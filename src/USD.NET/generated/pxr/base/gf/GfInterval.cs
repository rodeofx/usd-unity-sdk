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

public class GfInterval : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GfInterval(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GfInterval obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~GfInterval() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_GfInterval(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public GfInterval() : this(UsdCsPINVOKE.new_GfInterval__SWIG_0(), true) {
  }

  public GfInterval(double val) : this(UsdCsPINVOKE.new_GfInterval__SWIG_1(val), true) {
  }

  public GfInterval(double min, double max, bool minClosed, bool maxClosed) : this(UsdCsPINVOKE.new_GfInterval__SWIG_2(min, max, minClosed, maxClosed), true) {
  }

  public GfInterval(double min, double max, bool minClosed) : this(UsdCsPINVOKE.new_GfInterval__SWIG_3(min, max, minClosed), true) {
  }

  public GfInterval(double min, double max) : this(UsdCsPINVOKE.new_GfInterval__SWIG_4(min, max), true) {
  }

  public uint Hash() {
    uint ret = UsdCsPINVOKE.GfInterval_Hash(swigCPtr);
    return ret;
  }

  public double GetMin() {
    double ret = UsdCsPINVOKE.GfInterval_GetMin(swigCPtr);
    return ret;
  }

  public double GetMax() {
    double ret = UsdCsPINVOKE.GfInterval_GetMax(swigCPtr);
    return ret;
  }

  public void SetMin(double v) {
    UsdCsPINVOKE.GfInterval_SetMin__SWIG_0(swigCPtr, v);
  }

  public void SetMin(double v, bool minClosed) {
    UsdCsPINVOKE.GfInterval_SetMin__SWIG_1(swigCPtr, v, minClosed);
  }

  public void SetMax(double v) {
    UsdCsPINVOKE.GfInterval_SetMax__SWIG_0(swigCPtr, v);
  }

  public void SetMax(double v, bool maxClosed) {
    UsdCsPINVOKE.GfInterval_SetMax__SWIG_1(swigCPtr, v, maxClosed);
  }

  public bool IsMinClosed() {
    bool ret = UsdCsPINVOKE.GfInterval_IsMinClosed(swigCPtr);
    return ret;
  }

  public bool IsMaxClosed() {
    bool ret = UsdCsPINVOKE.GfInterval_IsMaxClosed(swigCPtr);
    return ret;
  }

  public bool IsMinOpen() {
    bool ret = UsdCsPINVOKE.GfInterval_IsMinOpen(swigCPtr);
    return ret;
  }

  public bool IsMaxOpen() {
    bool ret = UsdCsPINVOKE.GfInterval_IsMaxOpen(swigCPtr);
    return ret;
  }

  public bool IsMaxFinite() {
    bool ret = UsdCsPINVOKE.GfInterval_IsMaxFinite(swigCPtr);
    return ret;
  }

  public bool IsMinFinite() {
    bool ret = UsdCsPINVOKE.GfInterval_IsMinFinite(swigCPtr);
    return ret;
  }

  public bool IsFinite() {
    bool ret = UsdCsPINVOKE.GfInterval_IsFinite(swigCPtr);
    return ret;
  }

  public bool IsEmpty() {
    bool ret = UsdCsPINVOKE.GfInterval_IsEmpty(swigCPtr);
    return ret;
  }

  public double GetSize() {
    double ret = UsdCsPINVOKE.GfInterval_GetSize(swigCPtr);
    return ret;
  }

  public double Size() {
    double ret = UsdCsPINVOKE.GfInterval_Size(swigCPtr);
    return ret;
  }

  public bool Contains(double d) {
    bool ret = UsdCsPINVOKE.GfInterval_Contains__SWIG_0(swigCPtr, d);
    return ret;
  }

  public bool In(double d) {
    bool ret = UsdCsPINVOKE.GfInterval_In(swigCPtr, d);
    return ret;
  }

  public bool Contains(GfInterval i) {
    bool ret = UsdCsPINVOKE.GfInterval_Contains__SWIG_1(swigCPtr, GfInterval.getCPtr(i));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Intersects(GfInterval i) {
    bool ret = UsdCsPINVOKE.GfInterval_Intersects(swigCPtr, GfInterval.getCPtr(i));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static GfInterval GetFullInterval() {
    GfInterval ret = new GfInterval(UsdCsPINVOKE.GfInterval_GetFullInterval(), true);
    return ret;
  }

  public static bool Equals(GfInterval lhs, GfInterval rhs) {
    bool ret = UsdCsPINVOKE.GfInterval_Equals(GfInterval.getCPtr(lhs), GfInterval.getCPtr(rhs));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  override public int GetHashCode() {
    int ret = UsdCsPINVOKE.GfInterval_GetHashCode(swigCPtr);
    return ret;
  }

    public static bool operator==(GfInterval lhs, GfInterval rhs){
	    // The Swig binding glew will re-enter this operator comparing to null, so 
	    // that case must be handled explicitly to avoid an infinite loop. This is still
	    // not great, since it crosses the C#/C++ barrier twice. A better approache might
	    // be to return a simple value from C++ that can be compared in C#.
      bool lnull = lhs as object == null;
      bool rnull = rhs as object == null;
      return (lnull == rnull) && ((lnull && rnull) || GfInterval.Equals(lhs, rhs));
    }

    public static bool operator !=(GfInterval lhs, GfInterval rhs) {
        return !(lhs == rhs);
    }

	  override public bool Equals(object rhs) {
		  return GfInterval.Equals(this, rhs as GfInterval);
	  }
  
}

}
