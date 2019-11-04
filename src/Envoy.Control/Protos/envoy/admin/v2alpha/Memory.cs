// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/admin/v2alpha/memory.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Admin.V2Alpha {

  /// <summary>Holder for reflection information generated from envoy/admin/v2alpha/memory.proto</summary>
  public static partial class MemoryReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/admin/v2alpha/memory.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MemoryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBlbnZveS9hZG1pbi92MmFscGhhL21lbW9yeS5wcm90bxITZW52b3kuYWRt",
            "aW4udjJhbHBoYSJ8CgZNZW1vcnkSEQoJYWxsb2NhdGVkGAEgASgEEhEKCWhl",
            "YXBfc2l6ZRgCIAEoBBIZChFwYWdlaGVhcF91bm1hcHBlZBgDIAEoBBIVCg1w",
            "YWdlaGVhcF9mcmVlGAQgASgEEhoKEnRvdGFsX3RocmVhZF9jYWNoZRgFIAEo",
            "BEIyCiFpby5lbnZveXByb3h5LmVudm95LmFkbWluLnYyYWxwaGFCC01lbW9y",
            "eVByb3RvUAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Admin.V2Alpha.Memory), global::Envoy.Admin.V2Alpha.Memory.Parser, new[]{ "Allocated", "HeapSize", "PageheapUnmapped", "PageheapFree", "TotalThreadCache" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Proto representation of the internal memory consumption of an Envoy instance. These represent
  /// values extracted from an internal TCMalloc instance. For more information, see the section of the
  /// docs entitled ["Generic Tcmalloc Status"](https://gperftools.github.io/gperftools/tcmalloc.html).
  /// </summary>
  public sealed partial class Memory : pb::IMessage<Memory> {
    private static readonly pb::MessageParser<Memory> _parser = new pb::MessageParser<Memory>(() => new Memory());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Memory> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Admin.V2Alpha.MemoryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Memory() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Memory(Memory other) : this() {
      allocated_ = other.allocated_;
      heapSize_ = other.heapSize_;
      pageheapUnmapped_ = other.pageheapUnmapped_;
      pageheapFree_ = other.pageheapFree_;
      totalThreadCache_ = other.totalThreadCache_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Memory Clone() {
      return new Memory(this);
    }

    /// <summary>Field number for the "allocated" field.</summary>
    public const int AllocatedFieldNumber = 1;
    private ulong allocated_;
    /// <summary>
    /// The number of bytes allocated by the heap for Envoy. This is an alias for
    /// `generic.current_allocated_bytes`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Allocated {
      get { return allocated_; }
      set {
        allocated_ = value;
      }
    }

    /// <summary>Field number for the "heap_size" field.</summary>
    public const int HeapSizeFieldNumber = 2;
    private ulong heapSize_;
    /// <summary>
    /// The number of bytes reserved by the heap but not necessarily allocated. This is an alias for
    /// `generic.heap_size`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong HeapSize {
      get { return heapSize_; }
      set {
        heapSize_ = value;
      }
    }

    /// <summary>Field number for the "pageheap_unmapped" field.</summary>
    public const int PageheapUnmappedFieldNumber = 3;
    private ulong pageheapUnmapped_;
    /// <summary>
    /// The number of bytes in free, unmapped pages in the page heap. These bytes always count towards
    /// virtual memory usage, and depending on the OS, typically do not count towards physical memory
    /// usage. This is an alias for `tcmalloc.pageheap_unmapped_bytes`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong PageheapUnmapped {
      get { return pageheapUnmapped_; }
      set {
        pageheapUnmapped_ = value;
      }
    }

    /// <summary>Field number for the "pageheap_free" field.</summary>
    public const int PageheapFreeFieldNumber = 4;
    private ulong pageheapFree_;
    /// <summary>
    /// The number of bytes in free, mapped pages in the page heap. These bytes always count towards
    /// virtual memory usage, and unless the underlying memory is swapped out by the OS, they also
    /// count towards physical memory usage. This is an alias for `tcmalloc.pageheap_free_bytes`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong PageheapFree {
      get { return pageheapFree_; }
      set {
        pageheapFree_ = value;
      }
    }

    /// <summary>Field number for the "total_thread_cache" field.</summary>
    public const int TotalThreadCacheFieldNumber = 5;
    private ulong totalThreadCache_;
    /// <summary>
    /// The amount of memory used by the TCMalloc thread caches (for small objects). This is an alias
    /// for `tcmalloc.current_total_thread_cache_bytes`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong TotalThreadCache {
      get { return totalThreadCache_; }
      set {
        totalThreadCache_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Memory);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Memory other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Allocated != other.Allocated) return false;
      if (HeapSize != other.HeapSize) return false;
      if (PageheapUnmapped != other.PageheapUnmapped) return false;
      if (PageheapFree != other.PageheapFree) return false;
      if (TotalThreadCache != other.TotalThreadCache) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Allocated != 0UL) hash ^= Allocated.GetHashCode();
      if (HeapSize != 0UL) hash ^= HeapSize.GetHashCode();
      if (PageheapUnmapped != 0UL) hash ^= PageheapUnmapped.GetHashCode();
      if (PageheapFree != 0UL) hash ^= PageheapFree.GetHashCode();
      if (TotalThreadCache != 0UL) hash ^= TotalThreadCache.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Allocated != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(Allocated);
      }
      if (HeapSize != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(HeapSize);
      }
      if (PageheapUnmapped != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(PageheapUnmapped);
      }
      if (PageheapFree != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(PageheapFree);
      }
      if (TotalThreadCache != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(TotalThreadCache);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Allocated != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Allocated);
      }
      if (HeapSize != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(HeapSize);
      }
      if (PageheapUnmapped != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(PageheapUnmapped);
      }
      if (PageheapFree != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(PageheapFree);
      }
      if (TotalThreadCache != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TotalThreadCache);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Memory other) {
      if (other == null) {
        return;
      }
      if (other.Allocated != 0UL) {
        Allocated = other.Allocated;
      }
      if (other.HeapSize != 0UL) {
        HeapSize = other.HeapSize;
      }
      if (other.PageheapUnmapped != 0UL) {
        PageheapUnmapped = other.PageheapUnmapped;
      }
      if (other.PageheapFree != 0UL) {
        PageheapFree = other.PageheapFree;
      }
      if (other.TotalThreadCache != 0UL) {
        TotalThreadCache = other.TotalThreadCache;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Allocated = input.ReadUInt64();
            break;
          }
          case 16: {
            HeapSize = input.ReadUInt64();
            break;
          }
          case 24: {
            PageheapUnmapped = input.ReadUInt64();
            break;
          }
          case 32: {
            PageheapFree = input.ReadUInt64();
            break;
          }
          case 40: {
            TotalThreadCache = input.ReadUInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
