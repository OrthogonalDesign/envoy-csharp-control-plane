// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/type/range.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Type {

  /// <summary>Holder for reflection information generated from envoy/type/range.proto</summary>
  public static partial class RangeReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/type/range.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RangeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZlbnZveS90eXBlL3JhbmdlLnByb3RvEgplbnZveS50eXBlIigKCkludDY0",
            "UmFuZ2USDQoFc3RhcnQYASABKAMSCwoDZW5kGAIgASgDIikKC0RvdWJsZVJh",
            "bmdlEg0KBXN0YXJ0GAEgASgBEgsKA2VuZBgCIAEoAUIoChhpby5lbnZveXBy",
            "b3h5LmVudm95LnR5cGVCClJhbmdlUHJvdG9QAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Type.Int64Range), global::Envoy.Type.Int64Range.Parser, new[]{ "Start", "End" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Type.DoubleRange), global::Envoy.Type.DoubleRange.Parser, new[]{ "Start", "End" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Specifies the int64 start and end of the range using half-open interval semantics [start,
  /// end).
  /// </summary>
  public sealed partial class Int64Range : pb::IMessage<Int64Range> {
    private static readonly pb::MessageParser<Int64Range> _parser = new pb::MessageParser<Int64Range>(() => new Int64Range());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Int64Range> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Type.RangeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Int64Range() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Int64Range(Int64Range other) : this() {
      start_ = other.start_;
      end_ = other.end_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Int64Range Clone() {
      return new Int64Range(this);
    }

    /// <summary>Field number for the "start" field.</summary>
    public const int StartFieldNumber = 1;
    private long start_;
    /// <summary>
    /// start of the range (inclusive)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Start {
      get { return start_; }
      set {
        start_ = value;
      }
    }

    /// <summary>Field number for the "end" field.</summary>
    public const int EndFieldNumber = 2;
    private long end_;
    /// <summary>
    /// end of the range (exclusive)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long End {
      get { return end_; }
      set {
        end_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Int64Range);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Int64Range other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Start != other.Start) return false;
      if (End != other.End) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Start != 0L) hash ^= Start.GetHashCode();
      if (End != 0L) hash ^= End.GetHashCode();
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
      if (Start != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Start);
      }
      if (End != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(End);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Start != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Start);
      }
      if (End != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(End);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Int64Range other) {
      if (other == null) {
        return;
      }
      if (other.Start != 0L) {
        Start = other.Start;
      }
      if (other.End != 0L) {
        End = other.End;
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
            Start = input.ReadInt64();
            break;
          }
          case 16: {
            End = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Specifies the double start and end of the range using half-open interval semantics [start,
  /// end).
  /// </summary>
  public sealed partial class DoubleRange : pb::IMessage<DoubleRange> {
    private static readonly pb::MessageParser<DoubleRange> _parser = new pb::MessageParser<DoubleRange>(() => new DoubleRange());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DoubleRange> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Type.RangeReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DoubleRange() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DoubleRange(DoubleRange other) : this() {
      start_ = other.start_;
      end_ = other.end_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DoubleRange Clone() {
      return new DoubleRange(this);
    }

    /// <summary>Field number for the "start" field.</summary>
    public const int StartFieldNumber = 1;
    private double start_;
    /// <summary>
    /// start of the range (inclusive)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Start {
      get { return start_; }
      set {
        start_ = value;
      }
    }

    /// <summary>Field number for the "end" field.</summary>
    public const int EndFieldNumber = 2;
    private double end_;
    /// <summary>
    /// end of the range (exclusive)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double End {
      get { return end_; }
      set {
        end_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DoubleRange);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DoubleRange other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Start, other.Start)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(End, other.End)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Start != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Start);
      if (End != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(End);
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
      if (Start != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(Start);
      }
      if (End != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(End);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Start != 0D) {
        size += 1 + 8;
      }
      if (End != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DoubleRange other) {
      if (other == null) {
        return;
      }
      if (other.Start != 0D) {
        Start = other.Start;
      }
      if (other.End != 0D) {
        End = other.End;
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
          case 9: {
            Start = input.ReadDouble();
            break;
          }
          case 17: {
            End = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
