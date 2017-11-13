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

public class GfVec2h : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GfVec2h(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GfVec2h obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~GfVec2h() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_GfVec2h(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public GfVec2h() : this(UsdCsPINVOKE.new_GfVec2h__SWIG_0(), true) {
  }

  public GfVec2h(GfVec2h other) : this(UsdCsPINVOKE.new_GfVec2h__SWIG_1(GfVec2h.getCPtr(other)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfVec2h(GfHalf value) : this(UsdCsPINVOKE.new_GfVec2h__SWIG_2(GfHalf.getCPtr(value)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfVec2h(GfHalf s0, GfHalf s1) : this(UsdCsPINVOKE.new_GfVec2h__SWIG_3(GfHalf.getCPtr(s0), GfHalf.getCPtr(s1)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfVec2h(GfVec2d other) : this(UsdCsPINVOKE.new_GfVec2h__SWIG_5(GfVec2d.getCPtr(other)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfVec2h(GfVec2f other) : this(UsdCsPINVOKE.new_GfVec2h__SWIG_6(GfVec2f.getCPtr(other)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfVec2h(GfVec2i other) : this(UsdCsPINVOKE.new_GfVec2h__SWIG_7(GfVec2i.getCPtr(other)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static GfVec2h XAxis() {
    GfVec2h ret = new GfVec2h(UsdCsPINVOKE.GfVec2h_XAxis(), true);
    return ret;
  }

  public static GfVec2h YAxis() {
    GfVec2h ret = new GfVec2h(UsdCsPINVOKE.GfVec2h_YAxis(), true);
    return ret;
  }

  public static GfVec2h Axis(uint i) {
    GfVec2h ret = new GfVec2h(UsdCsPINVOKE.GfVec2h_Axis(i), true);
    return ret;
  }

  public GfVec2h Set(GfHalf s0, GfHalf s1) {
    GfVec2h ret = new GfVec2h(UsdCsPINVOKE.GfVec2h_Set__SWIG_0(swigCPtr, GfHalf.getCPtr(s0), GfHalf.getCPtr(s1)), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfVec2h Set(GfHalf a) {
    GfVec2h ret = new GfVec2h(UsdCsPINVOKE.GfVec2h_Set__SWIG_1(swigCPtr, GfHalf.getCPtr(a)), false);
    return ret;
  }

  public GfVec2h GetProjection(GfVec2h v) {
    GfVec2h ret = new GfVec2h(UsdCsPINVOKE.GfVec2h_GetProjection(swigCPtr, GfVec2h.getCPtr(v)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfVec2h GetComplement(GfVec2h b) {
    GfVec2h ret = new GfVec2h(UsdCsPINVOKE.GfVec2h_GetComplement(swigCPtr, GfVec2h.getCPtr(b)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfHalf GetLengthSq() {
    GfHalf ret = new GfHalf(UsdCsPINVOKE.GfVec2h_GetLengthSq(swigCPtr), true);
    return ret;
  }

  public GfHalf GetLength() {
    GfHalf ret = new GfHalf(UsdCsPINVOKE.GfVec2h_GetLength(swigCPtr), true);
    return ret;
  }

  public GfHalf Normalize(GfHalf eps) {
    GfHalf ret = new GfHalf(UsdCsPINVOKE.GfVec2h_Normalize__SWIG_0(swigCPtr, GfHalf.getCPtr(eps)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfHalf Normalize() {
    GfHalf ret = new GfHalf(UsdCsPINVOKE.GfVec2h_Normalize__SWIG_1(swigCPtr), true);
    return ret;
  }

  public GfVec2h GetNormalized(GfHalf eps) {
    GfVec2h ret = new GfVec2h(UsdCsPINVOKE.GfVec2h_GetNormalized__SWIG_0(swigCPtr, GfHalf.getCPtr(eps)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfVec2h GetNormalized() {
    GfVec2h ret = new GfVec2h(UsdCsPINVOKE.GfVec2h_GetNormalized__SWIG_1(swigCPtr), true);
    return ret;
  }

  public static bool Equals(GfVec2h lhs, GfVec2h rhs) {
    bool ret = UsdCsPINVOKE.GfVec2h_Equals(GfVec2h.getCPtr(lhs), GfVec2h.getCPtr(rhs));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  override public int GetHashCode() {
    int ret = UsdCsPINVOKE.GfVec2h_GetHashCode(swigCPtr);
    return ret;
  }

    public static bool operator==(GfVec2h lhs, GfVec2h rhs){
	    // The Swig binding glew will re-enter this operator comparing to null, so 
	    // that case must be handled explicitly to avoid an infinite loop. This is still
	    // not great, since it crosses the C#/C++ barrier twice. A better approache might
	    // be to return a simple value from C++ that can be compared in C#.
      bool lnull = lhs as object == null;
      bool rnull = rhs as object == null;
      return (lnull == rnull) && ((lnull && rnull) || GfVec2h.Equals(lhs, rhs));
    }

    public static bool operator !=(GfVec2h lhs, GfVec2h rhs) {
        return !(lhs == rhs);
    }

	  override public bool Equals(object rhs) {
		  return GfVec2h.Equals(this, rhs as GfVec2h);
	  }
  
  protected float GetValue(int index) {
    float ret = UsdCsPINVOKE.GfVec2h_GetValue(swigCPtr, index);
    return ret;
  }

  protected void SetValue(int index, float value) {
    UsdCsPINVOKE.GfVec2h_SetValue(swigCPtr, index, value);
  }

  public float this[int index] {
    get { return GetValue(index); }
    set { SetValue(index, value); }
  }
  
  public static readonly uint dimension = UsdCsPINVOKE.GfVec2h_dimension_get();
}

}
