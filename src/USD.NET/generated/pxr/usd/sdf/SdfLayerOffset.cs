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

public class SdfLayerOffset : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SdfLayerOffset(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SdfLayerOffset obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SdfLayerOffset() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_SdfLayerOffset(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SdfLayerOffset(double offset, double scale) : this(UsdCsPINVOKE.new_SdfLayerOffset__SWIG_0(offset, scale), true) {
  }

  public SdfLayerOffset(double offset) : this(UsdCsPINVOKE.new_SdfLayerOffset__SWIG_1(offset), true) {
  }

  public SdfLayerOffset() : this(UsdCsPINVOKE.new_SdfLayerOffset__SWIG_2(), true) {
  }

  public double GetOffset() {
    double ret = UsdCsPINVOKE.SdfLayerOffset_GetOffset(swigCPtr);
    return ret;
  }

  public double GetScale() {
    double ret = UsdCsPINVOKE.SdfLayerOffset_GetScale(swigCPtr);
    return ret;
  }

  public void SetOffset(double newOffset) {
    UsdCsPINVOKE.SdfLayerOffset_SetOffset(swigCPtr, newOffset);
  }

  public void SetScale(double newScale) {
    UsdCsPINVOKE.SdfLayerOffset_SetScale(swigCPtr, newScale);
  }

  public bool IsIdentity() {
    bool ret = UsdCsPINVOKE.SdfLayerOffset_IsIdentity(swigCPtr);
    return ret;
  }

  public bool IsValid() {
    bool ret = UsdCsPINVOKE.SdfLayerOffset_IsValid(swigCPtr);
    return ret;
  }

  public SdfLayerOffset GetInverse() {
    SdfLayerOffset ret = new SdfLayerOffset(UsdCsPINVOKE.SdfLayerOffset_GetInverse(swigCPtr), true);
    return ret;
  }

  public uint GetHash() {
    uint ret = UsdCsPINVOKE.SdfLayerOffset_GetHash(swigCPtr);
    return ret;
  }

  public class Hash : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal Hash(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Hash obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~Hash() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            UsdCsPINVOKE.delete_SdfLayerOffset_Hash(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public Hash() : this(UsdCsPINVOKE.new_SdfLayerOffset_Hash(), true) {
    }
  
  }

}

}
