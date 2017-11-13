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

public class TfTokenVector : global::System.IDisposable, global::System.Collections.IEnumerable
    , global::System.Collections.Generic.IEnumerable<TfToken>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TfTokenVector(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TfTokenVector obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TfTokenVector() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_TfTokenVector(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public TfTokenVector(global::System.Collections.ICollection c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (TfToken element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public TfToken this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(TfToken[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(TfToken[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, TfToken[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  global::System.Collections.Generic.IEnumerator<TfToken> global::System.Collections.Generic.IEnumerable<TfToken>.GetEnumerator() {
    return new TfTokenVectorEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new TfTokenVectorEnumerator(this);
  }

  public TfTokenVectorEnumerator GetEnumerator() {
    return new TfTokenVectorEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class TfTokenVectorEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<TfToken>
  {
    private TfTokenVector collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public TfTokenVectorEnumerator(TfTokenVector collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public TfToken Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (TfToken)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    UsdCsPINVOKE.TfTokenVector_Clear(swigCPtr);
  }

  public void Add(TfToken x) {
    UsdCsPINVOKE.TfTokenVector_Add(swigCPtr, TfToken.getCPtr(x));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = UsdCsPINVOKE.TfTokenVector_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = UsdCsPINVOKE.TfTokenVector_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    UsdCsPINVOKE.TfTokenVector_reserve(swigCPtr, n);
  }

  public TfTokenVector() : this(UsdCsPINVOKE.new_TfTokenVector__SWIG_0(), true) {
  }

  public TfTokenVector(TfTokenVector other) : this(UsdCsPINVOKE.new_TfTokenVector__SWIG_1(TfTokenVector.getCPtr(other)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public TfTokenVector(int capacity) : this(UsdCsPINVOKE.new_TfTokenVector__SWIG_2(capacity), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  private TfToken getitemcopy(int index) {
    TfToken ret = new TfToken(UsdCsPINVOKE.TfTokenVector_getitemcopy(swigCPtr, index), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private TfToken getitem(int index) {
    TfToken ret = new TfToken(UsdCsPINVOKE.TfTokenVector_getitem(swigCPtr, index), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, TfToken val) {
    UsdCsPINVOKE.TfTokenVector_setitem(swigCPtr, index, TfToken.getCPtr(val));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(TfTokenVector values) {
    UsdCsPINVOKE.TfTokenVector_AddRange(swigCPtr, TfTokenVector.getCPtr(values));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public TfTokenVector GetRange(int index, int count) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.TfTokenVector_GetRange(swigCPtr, index, count);
    TfTokenVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new TfTokenVector(cPtr, true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, TfToken x) {
    UsdCsPINVOKE.TfTokenVector_Insert(swigCPtr, index, TfToken.getCPtr(x));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, TfTokenVector values) {
    UsdCsPINVOKE.TfTokenVector_InsertRange(swigCPtr, index, TfTokenVector.getCPtr(values));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    UsdCsPINVOKE.TfTokenVector_RemoveAt(swigCPtr, index);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    UsdCsPINVOKE.TfTokenVector_RemoveRange(swigCPtr, index, count);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static TfTokenVector Repeat(TfToken value, int count) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.TfTokenVector_Repeat(TfToken.getCPtr(value), count);
    TfTokenVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new TfTokenVector(cPtr, true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    UsdCsPINVOKE.TfTokenVector_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    UsdCsPINVOKE.TfTokenVector_Reverse__SWIG_1(swigCPtr, index, count);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, TfTokenVector values) {
    UsdCsPINVOKE.TfTokenVector_SetRange(swigCPtr, index, TfTokenVector.getCPtr(values));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
