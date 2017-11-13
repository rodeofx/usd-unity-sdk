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

public class UsdGeomPrimvar : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UsdGeomPrimvar(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdGeomPrimvar obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdGeomPrimvar() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_UsdGeomPrimvar(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public UsdGeomPrimvar() : this(UsdCsPINVOKE.new_UsdGeomPrimvar__SWIG_0(), true) {
  }

  public UsdGeomPrimvar(UsdAttribute attr) : this(UsdCsPINVOKE.new_UsdGeomPrimvar__SWIG_1(UsdAttribute.getCPtr(attr)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public TfToken GetInterpolation() {
    TfToken ret = new TfToken(UsdCsPINVOKE.UsdGeomPrimvar_GetInterpolation(swigCPtr), true);
    return ret;
  }

  public bool SetInterpolation(TfToken interpolation) {
    bool ret = UsdCsPINVOKE.UsdGeomPrimvar_SetInterpolation(swigCPtr, TfToken.getCPtr(interpolation));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool HasAuthoredInterpolation() {
    bool ret = UsdCsPINVOKE.UsdGeomPrimvar_HasAuthoredInterpolation(swigCPtr);
    return ret;
  }

  public int GetElementSize() {
    int ret = UsdCsPINVOKE.UsdGeomPrimvar_GetElementSize(swigCPtr);
    return ret;
  }

  public bool SetElementSize(int eltSize) {
    bool ret = UsdCsPINVOKE.UsdGeomPrimvar_SetElementSize(swigCPtr, eltSize);
    return ret;
  }

  public bool HasAuthoredElementSize() {
    bool ret = UsdCsPINVOKE.UsdGeomPrimvar_HasAuthoredElementSize(swigCPtr);
    return ret;
  }

  public static bool IsPrimvar(UsdAttribute attr) {
    bool ret = UsdCsPINVOKE.UsdGeomPrimvar_IsPrimvar(UsdAttribute.getCPtr(attr));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool IsValidInterpolation(TfToken interpolation) {
    bool ret = UsdCsPINVOKE.UsdGeomPrimvar_IsValidInterpolation(TfToken.getCPtr(interpolation));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void GetDeclarationInfo(/*cstype*/ out TfToken name, /*cstype*/ out SdfValueTypeName typeName, /*cstype*/ out TfToken interpolation, out int elementSize) {
    TfToken tempname = new TfToken();
    SdfValueTypeName temptypeName = new SdfValueTypeName();
    TfToken tempinterpolation = new TfToken();
    try {
      UsdCsPINVOKE.UsdGeomPrimvar_GetDeclarationInfo(swigCPtr, TfToken.getCPtr(tempname), SdfValueTypeName.getCPtr(temptypeName), TfToken.getCPtr(tempinterpolation), out elementSize);
    } finally {
    name = tempname;
    typeName = temptypeName;
    interpolation = tempinterpolation;
    }
  }

  public UsdAttribute GetAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomPrimvar_GetAttr(swigCPtr), false);
    return ret;
  }

  public bool IsDefined() {
    bool ret = UsdCsPINVOKE.UsdGeomPrimvar_IsDefined(swigCPtr);
    return ret;
  }

  public TfToken GetName() {
    TfToken ret = new TfToken(UsdCsPINVOKE.UsdGeomPrimvar_GetName(swigCPtr), false);
    return ret;
  }

  public TfToken GetPrimvarName() {
    TfToken ret = new TfToken(UsdCsPINVOKE.UsdGeomPrimvar_GetPrimvarName(swigCPtr), true);
    return ret;
  }

  public bool NameContainsNamespaces() {
    bool ret = UsdCsPINVOKE.UsdGeomPrimvar_NameContainsNamespaces(swigCPtr);
    return ret;
  }

  public TfToken GetBaseName() {
    TfToken ret = new TfToken(UsdCsPINVOKE.UsdGeomPrimvar_GetBaseName(swigCPtr), true);
    return ret;
  }

  public TfToken GetNamespace() {
    TfToken ret = new TfToken(UsdCsPINVOKE.UsdGeomPrimvar_GetNamespace(swigCPtr), true);
    return ret;
  }

  public StdStringVector SplitName() {
    StdStringVector ret = new StdStringVector(UsdCsPINVOKE.UsdGeomPrimvar_SplitName(swigCPtr), true);
    return ret;
  }

  public SdfValueTypeName GetTypeName() {
    SdfValueTypeName ret = new SdfValueTypeName(UsdCsPINVOKE.UsdGeomPrimvar_GetTypeName(swigCPtr), true);
    return ret;
  }

  public bool GetTimeSamples(StdDoubleVector times) {
    bool ret = UsdCsPINVOKE.UsdGeomPrimvar_GetTimeSamples(swigCPtr, StdDoubleVector.getCPtr(times));
    return ret;
  }

  public bool ValueMightBeTimeVarying() {
    bool ret = UsdCsPINVOKE.UsdGeomPrimvar_ValueMightBeTimeVarying(swigCPtr);
    return ret;
  }

  public bool SetIndices(VtIntArray indices, UsdTimeCode time) {
    bool ret = UsdCsPINVOKE.UsdGeomPrimvar_SetIndices__SWIG_0(swigCPtr, VtIntArray.getCPtr(indices), UsdTimeCode.getCPtr(time));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetIndices(VtIntArray indices) {
    bool ret = UsdCsPINVOKE.UsdGeomPrimvar_SetIndices__SWIG_1(swigCPtr, VtIntArray.getCPtr(indices));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetIndices(out VtIntArray indices, UsdTimeCode time) {
    VtIntArray tempindices = new VtIntArray();
    try {
      bool ret = UsdCsPINVOKE.UsdGeomPrimvar_GetIndices__SWIG_0(swigCPtr, VtIntArray.getCPtr(tempindices), UsdTimeCode.getCPtr(time));
      if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } finally {
    indices = tempindices;
    }
  }

  public bool GetIndices(out VtIntArray indices) {
    VtIntArray tempindices = new VtIntArray();
    try {
      bool ret = UsdCsPINVOKE.UsdGeomPrimvar_GetIndices__SWIG_1(swigCPtr, VtIntArray.getCPtr(tempindices));
      return ret;
    } finally {
    indices = tempindices;
    }
  }

  public void BlockIndices() {
    UsdCsPINVOKE.UsdGeomPrimvar_BlockIndices(swigCPtr);
  }

  public bool IsIndexed() {
    bool ret = UsdCsPINVOKE.UsdGeomPrimvar_IsIndexed(swigCPtr);
    return ret;
  }

  public bool SetUnauthoredValuesIndex(int unauthoredValuesIndex) {
    bool ret = UsdCsPINVOKE.UsdGeomPrimvar_SetUnauthoredValuesIndex(swigCPtr, unauthoredValuesIndex);
    return ret;
  }

  public int GetUnauthoredValuesIndex() {
    int ret = UsdCsPINVOKE.UsdGeomPrimvar_GetUnauthoredValuesIndex(swigCPtr);
    return ret;
  }

  public bool ComputeFlattened(VtValue value, UsdTimeCode time) {
    bool ret = UsdCsPINVOKE.UsdGeomPrimvar_ComputeFlattened__SWIG_2(swigCPtr, VtValue.getCPtr(value), UsdTimeCode.getCPtr(time));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ComputeFlattened(VtValue value) {
    bool ret = UsdCsPINVOKE.UsdGeomPrimvar_ComputeFlattened__SWIG_3(swigCPtr, VtValue.getCPtr(value));
    return ret;
  }

  public bool IsIdTarget() {
    bool ret = UsdCsPINVOKE.UsdGeomPrimvar_IsIdTarget(swigCPtr);
    return ret;
  }

  public bool SetIdTarget(SdfPath path) {
    bool ret = UsdCsPINVOKE.UsdGeomPrimvar_SetIdTarget(swigCPtr, SdfPath.getCPtr(path));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
