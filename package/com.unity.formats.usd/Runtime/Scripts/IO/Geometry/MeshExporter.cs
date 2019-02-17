// Copyright 2018 Jeremy Cowles. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Collections.Generic;
using UnityEngine;
using USD.NET;
using USD.NET.Unity;

namespace Unity.Formats.USD {
  public static class MeshExporter {

    public static void ExportSkinnedMesh(ObjectContext objContext, ExportContext exportContext) {
      var smr = objContext.gameObject.GetComponent<SkinnedMeshRenderer>();

      UnityEngine.Profiling.Profiler.BeginSample("USD: Skinned Mesh");
      ExportMesh(objContext,
                 exportContext,
                 smr.sharedMesh,
                 smr.sharedMaterial,
                 smr.sharedMaterials,
                 exportMeshPose: exportContext.scene.Time == null);
      UnityEngine.Profiling.Profiler.EndSample();

      if (exportContext.scene.Time != null) {
        return;
      }

      // Note that the baked mesh no longer has the bone weights, so here we switch back to the
      // shared SkinnedMeshRenderer mesh.
      Transform rootBone = null;
      if (smr.rootBone != null && !exportContext.boneToRoot.TryGetValue(smr.rootBone, out rootBone)) {
        Debug.LogWarning("Root bone not found in export context for " +
            UnityTypeConverter.GetPath(smr.rootBone));
        return;
      }

      UnityEngine.Profiling.Profiler.BeginSample("USD: Skinning Weights");
      ExportSkelWeights(exportContext.scene,
                        objContext.path,
                        smr.sharedMesh,
                        rootBone,
                        smr.bones);
      UnityEngine.Profiling.Profiler.EndSample();

    }

    static void ExportSkelWeights(Scene scene,
                                  string path,
                                  Mesh unityMesh,
                                  Transform rootBone,
                                  Transform[] bones) {
      var sample = new SkelBindingSample();

      sample.geomBindTransform.value = Matrix4x4.identity;
      sample.joints = new string[bones.Length];

      int b = 0;
      var rootPath = UnityTypeConverter.GetPath(rootBone);
      foreach (Transform bone in bones) {
        var bonePath = UnityTypeConverter.GetPath(bone);
        if (bonePath == rootPath) {
          sample.joints[b++] = "/";
        } else {
          sample.joints[b++] = bonePath.Replace(rootPath + "/", "");
        }
      }

      int i = 0;
      int w = 0;
      b = 0;
#if UNITY_2019
      var bonesPerVertex = unityMesh.GetBonesPerVertex();
      var unityBoneWeights = unityMesh.GetAllBoneWeights();
      byte maxWeightCount = 0;
      foreach (var c in bonesPerVertex) {
        maxWeightCount = maxWeightCount > c ? maxWeightCount : c;
      }

      sample.jointIndices.value = new int[bonesPerVertex.Length * maxWeightCount];
      sample.jointIndices.elementSize = maxWeightCount;
      sample.jointIndices.interpolation = PrimvarInterpolation.Vertex;

      sample.jointWeights.value = new float[bonesPerVertex.Length * maxWeightCount];
      sample.jointWeights.elementSize = maxWeightCount;
      sample.jointWeights.interpolation = PrimvarInterpolation.Vertex;

      foreach (var weightCount in bonesPerVertex) {
        for (int j = 0; j < weightCount; j++) {
          var bw = unityBoneWeights[b++];
          sample.jointIndices.value[i++] = bw.boneIndex;
          sample.jointWeights.value[w++] = bw.weight;
        }

        // Unity allows a variable number of weights per bone, but we've made the array square,
        // which means we may need to skip a few indicies, if this vert doesn't use the max number
        // of weights.
        i += maxWeightCount - weightCount;
        w += maxWeightCount - weightCount;
      }
#else
      var unityBoneWeights = unityMesh.boneWeights;

      if (unityBoneWeights.Length == 0) {
        Debug.LogWarning("Found zero bone weights at: " + path);
        return;
      }

      sample.jointIndices.value = new int[unityBoneWeights.Length * 4];
      sample.jointIndices.elementSize = 4;
      sample.jointIndices.interpolation = PrimvarInterpolation.Vertex;

      sample.jointWeights.value = new float[unityBoneWeights.Length * 4];
      sample.jointWeights.elementSize = 4;
      sample.jointWeights.interpolation = PrimvarInterpolation.Vertex;

      foreach (var bone in unityBoneWeights) {
        sample.jointIndices.value[i++] = bone.boneIndex0;
        sample.jointIndices.value[i++] = bone.boneIndex1;
        sample.jointIndices.value[i++] = bone.boneIndex2;
        sample.jointIndices.value[i++] = bone.boneIndex3;
        sample.jointWeights.value[w++] = bone.weight0;
        sample.jointWeights.value[w++] = bone.weight1;
        sample.jointWeights.value[w++] = bone.weight2;
        sample.jointWeights.value[w++] = bone.weight3;
      }
#endif
      scene.Write(path, sample);
    }

    public static void ExportMesh(ObjectContext objContext, ExportContext exportContext) {
      MeshFilter mf = objContext.gameObject.GetComponent<MeshFilter>();
      MeshRenderer mr = objContext.gameObject.GetComponent<MeshRenderer>();

      UnityEngine.Profiling.Profiler.BeginSample("USD: Mesh");

      ExportMesh(objContext,
                 exportContext,
                 mf.sharedMesh,
                 mr.sharedMaterial,
                 mr.sharedMaterials);

      UnityEngine.Profiling.Profiler.EndSample();
    }

    static void ExportMesh(ObjectContext objContext,
                   ExportContext exportContext,
                   Mesh mesh,
                   Material sharedMaterial,
                   Material[] sharedMaterials,
                   bool exportMeshPose = true) {
      if (mesh.isReadable == false) {
        Debug.LogWarning("Mesh not readable: " + objContext.path);
        return;
      }
      string path = objContext.path;
      if (mesh == null) {
        Debug.LogWarning("Null mesh for: " + path);
        return;
      }
      var scene = exportContext.scene;
      bool unvarying = scene.Time == null;
      bool slowAndSafeConversion = exportContext.basisTransform == BasisTransformation.SlowAndSafe;
      var sample = (MeshSample)objContext.sample;
      var go = objContext.gameObject;

      if (mesh.bounds.center == Vector3.zero && mesh.bounds.extents == Vector3.zero) {
        mesh.RecalculateBounds();
      }
      sample.extent = mesh.bounds;

      if (slowAndSafeConversion) {
        // Unity uses a forward vector that matches DirectX, but USD matches OpenGL, so a change of
        // basis is required. There are shortcuts, but this is fully general.
        sample.ConvertTransform();

        sample.extent.center = UnityTypeConverter.ChangeBasis(sample.extent.center);
        sample.extent.extents = UnityTypeConverter.ChangeBasis(sample.extent.extents);
      }

      // Only export the mesh topology on the first frame.
      if (unvarying) {
        // TODO: Technically a mesh could be the root transform, which is not handled correctly here.
        // It should ahve the same logic for root prims as in ExportXform.
        sample.transform = XformExporter.GetLocalTransformMatrix(
            go.transform,
            scene.UpAxis == Scene.UpAxes.Z,
            new pxr.SdfPath(path).IsRootPrimPath(),
            exportContext.basisTransform);

        sample.normals = mesh.normals;
        sample.points = mesh.vertices;
        sample.tangents = mesh.tangents;

        sample.colors = mesh.colors;
        if (sample.colors != null && sample.colors.Length == 0) {
          sample.colors = null;
        }

        if ((sample.colors == null || sample.colors.Length == 0)
            && (sharedMaterial != null && sharedMaterial.HasProperty("_Color"))) {
          sample.colors = new Color[1];
          sample.colors[0] = sharedMaterial.color.linear;
        }

        // Gah. There is no way to inspect a meshes UVs.
        sample.st = mesh.uv;

        // Set face vertex counts and indices.
        var tris = mesh.triangles;

        if (slowAndSafeConversion) {
          // Unity uses a forward vector that matches DirectX, but USD matches OpenGL, so a change
          // of basis is required. There are shortcuts, but this is fully general.

          for (int i = 0; i < sample.points.Length; i++) {
            sample.points[i] = UnityTypeConverter.ChangeBasis(sample.points[i]);
            if (sample.normals != null && sample.normals.Length == sample.points.Length) {
              sample.normals[i] = UnityTypeConverter.ChangeBasis(sample.normals[i]);
            }
          }

          for (int i = 0; i < tris.Length; i += 3) {
            var t = tris[i];
            tris[i] = tris[i + 1];
            tris[i + 1] = t;
          }
        }

        sample.SetTriangles(tris);

        UnityEngine.Profiling.Profiler.BeginSample("USD: Mesh Write");
        scene.Write(path, sample);
        UnityEngine.Profiling.Profiler.EndSample();

        // TODO: this is a bit of a half-measure, we need real support for primvar interpolation.
        // Set interpolation based on color count.
        if (sample.colors != null && sample.colors.Length == 1) {
          pxr.UsdPrim usdPrim = scene.GetPrimAtPath(path);
          var colorPrimvar = new pxr.UsdGeomPrimvar(usdPrim.GetAttribute(pxr.UsdGeomTokens.primvarsDisplayColor));
          colorPrimvar.SetInterpolation(pxr.UsdGeomTokens.constant);
          var opacityPrimvar = new pxr.UsdGeomPrimvar(usdPrim.GetAttribute(pxr.UsdGeomTokens.primvarsDisplayOpacity));
          opacityPrimvar.SetInterpolation(pxr.UsdGeomTokens.constant);
        }

        string usdMaterialPath;
        if (exportContext.exportMaterials && sharedMaterial != null) {
          if (!exportContext.matMap.TryGetValue(sharedMaterial, out usdMaterialPath)) {
            Debug.LogError("Invalid material bound for: " + path);
          } else {
            MaterialSample.Bind(scene, path, usdMaterialPath);
          }
        }

        // In USD subMeshes are represented as UsdGeomSubsets.
        // When there are multiple subMeshes, convert them into UsdGeomSubsets.
        if (mesh.subMeshCount > 1) {
          // Build a table of face indices, used to convert the subMesh triangles to face indices.
          var faceTable = new Dictionary<Vector3, int>();
          for (int i = 0; i < tris.Length; i += 3) {
            if (!slowAndSafeConversion) {
              faceTable.Add(new Vector3(tris[i], tris[i + 1], tris[i + 2]), i / 3);
            } else {
              // Under slow and safe export, index 0 and 1 are swapped.
              // This swap will not be present in the subMesh indices, so must be undone here.
              faceTable.Add(new Vector3(tris[i + 1], tris[i], tris[i + 2]), i / 3);
            }
          }

          var usdPrim = scene.GetPrimAtPath(path);
          var usdGeomMesh = new pxr.UsdGeomMesh(usdPrim);
          // Process each subMesh and create a UsdGeomSubset of faces this subMesh targets.
          for (int si = 0; si < mesh.subMeshCount; si++) {
            int[] indices = mesh.GetTriangles(si);
            int[] faceIndices = new int[indices.Length / 3];

            for (int i = 0; i < indices.Length; i += 3) {
              faceIndices[i / 3] = faceTable[new Vector3(indices[i], indices[i + 1], indices[i + 2])];
            }

            var materialBindToken = new pxr.TfToken("materialBind");
            var vtIndices = UnityTypeConverter.ToVtArray(faceIndices);
            var subset = pxr.UsdGeomSubset.CreateUniqueGeomSubset(
                usdGeomMesh,            // The object of which this subset belongs.
                "subMeshes",            // An arbitrary name for the subset.
                pxr.UsdGeomTokens.face, // Indicator that these represent face indices
                vtIndices,              // The actual face indices.
                materialBindToken       // familyName = "materialBind"
                );

            if (exportContext.exportMaterials) {
              if (si >= sharedMaterials.Length || !exportContext.matMap.TryGetValue(sharedMaterials[si], out usdMaterialPath)) {
                Debug.LogError("Invalid material bound for: " + path);
              } else {
                MaterialSample.Bind(scene, subset.GetPath(), usdMaterialPath);
              }
            }
          }
        }
      } else {
        // Only write the transform when animating.
        var meshSample = new MeshSampleBase();
        meshSample.extent = sample.extent;
        meshSample.transform = XformExporter.GetLocalTransformMatrix(
            go.transform,
            scene.UpAxis == Scene.UpAxes.Z,
            new pxr.SdfPath(path).IsRootPrimPath(),
            exportContext.basisTransform);

        if (exportMeshPose) {
          meshSample.points = mesh.vertices;

          // Set face vertex counts and indices.
          var tris = mesh.triangles;

          if (slowAndSafeConversion) {
            // Unity uses a forward vector that matches DirectX, but USD matches OpenGL, so a change
            // of basis is required. There are shortcuts, but this is fully general.
            for (int i = 0; i < meshSample.points.Length; i++) {
              meshSample.points[i] = UnityTypeConverter.ChangeBasis(meshSample.points[i]);
            }

            for (int i = 0; i < tris.Length; i += 3) {
              var t = tris[i];
              tris[i] = tris[i + 1];
              tris[i + 1] = t;
            }
          }

          sample.SetTriangles(tris);
        }

        UnityEngine.Profiling.Profiler.BeginSample("USD: Mesh Write");
        scene.Write(path, meshSample);
        UnityEngine.Profiling.Profiler.EndSample();

      }
    }
  }
}
