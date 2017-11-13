//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pxr {

public class UsdGeomFaceSetAPI : UsdSchemaBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal UsdGeomFaceSetAPI(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.UsdGeomFaceSetAPI_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdGeomFaceSetAPI obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdGeomFaceSetAPI() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_UsdGeomFaceSetAPI(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public UsdGeomFaceSetAPI(UsdPrim prim, TfToken setName) : this(UsdCsPINVOKE.new_UsdGeomFaceSetAPI__SWIG_0(UsdPrim.getCPtr(prim), TfToken.getCPtr(setName)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdGeomFaceSetAPI(UsdPrim prim) : this(UsdCsPINVOKE.new_UsdGeomFaceSetAPI__SWIG_1(UsdPrim.getCPtr(prim)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdGeomFaceSetAPI() : this(UsdCsPINVOKE.new_UsdGeomFaceSetAPI__SWIG_2(), true) {
  }

  public UsdGeomFaceSetAPI(UsdSchemaBase schemaObj, TfToken setName) : this(UsdCsPINVOKE.new_UsdGeomFaceSetAPI__SWIG_3(UsdSchemaBase.getCPtr(schemaObj), TfToken.getCPtr(setName)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public TfToken GetFaceSetName() {
    TfToken ret = new TfToken(UsdCsPINVOKE.UsdGeomFaceSetAPI_GetFaceSetName(swigCPtr), true);
    return ret;
  }

  public bool SetIsPartition(bool isPartition) {
    bool ret = UsdCsPINVOKE.UsdGeomFaceSetAPI_SetIsPartition(swigCPtr, isPartition);
    return ret;
  }

  public bool GetIsPartition() {
    bool ret = UsdCsPINVOKE.UsdGeomFaceSetAPI_GetIsPartition(swigCPtr);
    return ret;
  }

  public bool SetFaceCounts(VtIntArray faceCounts, UsdTimeCode time) {
    bool ret = UsdCsPINVOKE.UsdGeomFaceSetAPI_SetFaceCounts__SWIG_0(swigCPtr, VtIntArray.getCPtr(faceCounts), UsdTimeCode.getCPtr(time));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetFaceCounts(VtIntArray faceCounts) {
    bool ret = UsdCsPINVOKE.UsdGeomFaceSetAPI_SetFaceCounts__SWIG_1(swigCPtr, VtIntArray.getCPtr(faceCounts));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetFaceCounts(VtIntArray faceCounts, UsdTimeCode time) {
    bool ret = UsdCsPINVOKE.UsdGeomFaceSetAPI_GetFaceCounts__SWIG_0(swigCPtr, VtIntArray.getCPtr(faceCounts), UsdTimeCode.getCPtr(time));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetFaceCounts(VtIntArray faceCounts) {
    bool ret = UsdCsPINVOKE.UsdGeomFaceSetAPI_GetFaceCounts__SWIG_1(swigCPtr, VtIntArray.getCPtr(faceCounts));
    return ret;
  }

  public bool SetFaceIndices(VtIntArray faceIndices, UsdTimeCode time) {
    bool ret = UsdCsPINVOKE.UsdGeomFaceSetAPI_SetFaceIndices__SWIG_0(swigCPtr, VtIntArray.getCPtr(faceIndices), UsdTimeCode.getCPtr(time));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetFaceIndices(VtIntArray faceIndices) {
    bool ret = UsdCsPINVOKE.UsdGeomFaceSetAPI_SetFaceIndices__SWIG_1(swigCPtr, VtIntArray.getCPtr(faceIndices));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetFaceIndices(VtIntArray faceIndices, UsdTimeCode time) {
    bool ret = UsdCsPINVOKE.UsdGeomFaceSetAPI_GetFaceIndices__SWIG_0(swigCPtr, VtIntArray.getCPtr(faceIndices), UsdTimeCode.getCPtr(time));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetFaceIndices(VtIntArray faceIndices) {
    bool ret = UsdCsPINVOKE.UsdGeomFaceSetAPI_GetFaceIndices__SWIG_1(swigCPtr, VtIntArray.getCPtr(faceIndices));
    return ret;
  }

  public bool SetBindingTargets(SdfPathVector bindings) {
    bool ret = UsdCsPINVOKE.UsdGeomFaceSetAPI_SetBindingTargets(swigCPtr, SdfPathVector.getCPtr(bindings));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetBindingTargets(SdfPathVector bindings) {
    bool ret = UsdCsPINVOKE.UsdGeomFaceSetAPI_GetBindingTargets(swigCPtr, SdfPathVector.getCPtr(bindings));
    return ret;
  }

  public bool AppendFaceGroup(VtIntArray faceIndices, SdfPath bindingTarget, UsdTimeCode time) {
    bool ret = UsdCsPINVOKE.UsdGeomFaceSetAPI_AppendFaceGroup__SWIG_0(swigCPtr, VtIntArray.getCPtr(faceIndices), SdfPath.getCPtr(bindingTarget), UsdTimeCode.getCPtr(time));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool AppendFaceGroup(VtIntArray faceIndices, SdfPath bindingTarget) {
    bool ret = UsdCsPINVOKE.UsdGeomFaceSetAPI_AppendFaceGroup__SWIG_1(swigCPtr, VtIntArray.getCPtr(faceIndices), SdfPath.getCPtr(bindingTarget));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool AppendFaceGroup(VtIntArray faceIndices) {
    bool ret = UsdCsPINVOKE.UsdGeomFaceSetAPI_AppendFaceGroup__SWIG_2(swigCPtr, VtIntArray.getCPtr(faceIndices));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute GetIsPartitionAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomFaceSetAPI_GetIsPartitionAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateIsPartitionAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomFaceSetAPI_CreateIsPartitionAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateIsPartitionAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomFaceSetAPI_CreateIsPartitionAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateIsPartitionAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomFaceSetAPI_CreateIsPartitionAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetFaceCountsAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomFaceSetAPI_GetFaceCountsAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateFaceCountsAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomFaceSetAPI_CreateFaceCountsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateFaceCountsAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomFaceSetAPI_CreateFaceCountsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateFaceCountsAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomFaceSetAPI_CreateFaceCountsAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetFaceIndicesAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomFaceSetAPI_GetFaceIndicesAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateFaceIndicesAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomFaceSetAPI_CreateFaceIndicesAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateFaceIndicesAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomFaceSetAPI_CreateFaceIndicesAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateFaceIndicesAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomFaceSetAPI_CreateFaceIndicesAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdRelationship GetBindingTargetsRel() {
    UsdRelationship ret = new UsdRelationship(UsdCsPINVOKE.UsdGeomFaceSetAPI_GetBindingTargetsRel(swigCPtr), true);
    return ret;
  }

  public UsdRelationship CreateBindingTargetsRel() {
    UsdRelationship ret = new UsdRelationship(UsdCsPINVOKE.UsdGeomFaceSetAPI_CreateBindingTargetsRel(swigCPtr), true);
    return ret;
  }

  public static UsdGeomFaceSetAPI Create(UsdPrim prim, TfToken setName, bool isPartition) {
    UsdGeomFaceSetAPI ret = new UsdGeomFaceSetAPI(UsdCsPINVOKE.UsdGeomFaceSetAPI_Create__SWIG_0(UsdPrim.getCPtr(prim), TfToken.getCPtr(setName), isPartition), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UsdGeomFaceSetAPI Create(UsdPrim prim, TfToken setName) {
    UsdGeomFaceSetAPI ret = new UsdGeomFaceSetAPI(UsdCsPINVOKE.UsdGeomFaceSetAPI_Create__SWIG_1(UsdPrim.getCPtr(prim), TfToken.getCPtr(setName)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UsdGeomFaceSetAPI Create(UsdSchemaBase schemaObj, TfToken setName, bool isPartition) {
    UsdGeomFaceSetAPI ret = new UsdGeomFaceSetAPI(UsdCsPINVOKE.UsdGeomFaceSetAPI_Create__SWIG_2(UsdSchemaBase.getCPtr(schemaObj), TfToken.getCPtr(setName), isPartition), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UsdGeomFaceSetAPI Create(UsdSchemaBase schemaObj, TfToken setName) {
    UsdGeomFaceSetAPI ret = new UsdGeomFaceSetAPI(UsdCsPINVOKE.UsdGeomFaceSetAPI_Create__SWIG_3(UsdSchemaBase.getCPtr(schemaObj), TfToken.getCPtr(setName)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UsdGeomFaceSetAPIVector GetFaceSets(UsdPrim prim) {
    UsdGeomFaceSetAPIVector ret = new UsdGeomFaceSetAPIVector(UsdCsPINVOKE.UsdGeomFaceSetAPI_GetFaceSets__SWIG_0(UsdPrim.getCPtr(prim)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UsdGeomFaceSetAPIVector GetFaceSets(UsdSchemaBase schemaObj) {
    UsdGeomFaceSetAPIVector ret = new UsdGeomFaceSetAPIVector(UsdCsPINVOKE.UsdGeomFaceSetAPI_GetFaceSets__SWIG_1(UsdSchemaBase.getCPtr(schemaObj)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Validate(/*cstype*/ out string reason) {
    bool ret = UsdCsPINVOKE.UsdGeomFaceSetAPI_Validate(swigCPtr, out reason);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
