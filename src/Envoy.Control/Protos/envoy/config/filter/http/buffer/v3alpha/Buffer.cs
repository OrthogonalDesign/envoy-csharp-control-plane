// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/config/filter/http/buffer/v3alpha/buffer.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Config.Filter.Http.Buffer.V3Alpha {

  /// <summary>Holder for reflection information generated from envoy/config/filter/http/buffer/v3alpha/buffer.proto</summary>
  public static partial class BufferReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/config/filter/http/buffer/v3alpha/buffer.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BufferReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRlbnZveS9jb25maWcvZmlsdGVyL2h0dHAvYnVmZmVyL3YzYWxwaGEvYnVm",
            "ZmVyLnByb3RvEidlbnZveS5jb25maWcuZmlsdGVyLmh0dHAuYnVmZmVyLnYz",
            "YWxwaGEaHmdvb2dsZS9wcm90b2J1Zi93cmFwcGVycy5wcm90bxoXdmFsaWRh",
            "dGUvdmFsaWRhdGUucHJvdG8iUgoGQnVmZmVyEkIKEW1heF9yZXF1ZXN0X2J5",
            "dGVzGAEgASgLMhwuZ29vZ2xlLnByb3RvYnVmLlVJbnQzMlZhbHVlQgm66cAD",
            "BCoCIABKBAgCEAMikQEKDkJ1ZmZlclBlclJvdXRlEh0KCGRpc2FibGVkGAEg",
            "ASgIQgm66cADBGoCCAFIABJNCgZidWZmZXIYAiABKAsyLy5lbnZveS5jb25m",
            "aWcuZmlsdGVyLmh0dHAuYnVmZmVyLnYzYWxwaGEuQnVmZmVyQgq66cADBYoB",
            "AhABSABCEQoIb3ZlcnJpZGUSBbjpwAMBQkYKNWlvLmVudm95cHJveHkuZW52",
            "b3kuY29uZmlnLmZpbHRlci5odHRwLmJ1ZmZlci52M2FscGhhQgtCdWZmZXJQ",
            "cm90b1ABYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Filter.Http.Buffer.V3Alpha.Buffer), global::Envoy.Config.Filter.Http.Buffer.V3Alpha.Buffer.Parser, new[]{ "MaxRequestBytes" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Filter.Http.Buffer.V3Alpha.BufferPerRoute), global::Envoy.Config.Filter.Http.Buffer.V3Alpha.BufferPerRoute.Parser, new[]{ "Disabled", "Buffer" }, new[]{ "Override" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Buffer : pb::IMessage<Buffer> {
    private static readonly pb::MessageParser<Buffer> _parser = new pb::MessageParser<Buffer>(() => new Buffer());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Buffer> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Filter.Http.Buffer.V3Alpha.BufferReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Buffer() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Buffer(Buffer other) : this() {
      MaxRequestBytes = other.MaxRequestBytes;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Buffer Clone() {
      return new Buffer(this);
    }

    /// <summary>Field number for the "max_request_bytes" field.</summary>
    public const int MaxRequestBytesFieldNumber = 1;
    private static readonly pb::FieldCodec<uint?> _single_maxRequestBytes_codec = pb::FieldCodec.ForStructWrapper<uint>(10);
    private uint? maxRequestBytes_;
    /// <summary>
    /// The maximum request size that the filter will buffer before the connection
    /// manager will stop buffering and return a 413 response.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint? MaxRequestBytes {
      get { return maxRequestBytes_; }
      set {
        maxRequestBytes_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Buffer);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Buffer other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MaxRequestBytes != other.MaxRequestBytes) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (maxRequestBytes_ != null) hash ^= MaxRequestBytes.GetHashCode();
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
      if (maxRequestBytes_ != null) {
        _single_maxRequestBytes_codec.WriteTagAndValue(output, MaxRequestBytes);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (maxRequestBytes_ != null) {
        size += _single_maxRequestBytes_codec.CalculateSizeWithTag(MaxRequestBytes);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Buffer other) {
      if (other == null) {
        return;
      }
      if (other.maxRequestBytes_ != null) {
        if (maxRequestBytes_ == null || other.MaxRequestBytes != 0) {
          MaxRequestBytes = other.MaxRequestBytes;
        }
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
          case 10: {
            uint? value = _single_maxRequestBytes_codec.Read(input);
            if (maxRequestBytes_ == null || value != 0) {
              MaxRequestBytes = value;
            }
            break;
          }
        }
      }
    }

  }

  public sealed partial class BufferPerRoute : pb::IMessage<BufferPerRoute> {
    private static readonly pb::MessageParser<BufferPerRoute> _parser = new pb::MessageParser<BufferPerRoute>(() => new BufferPerRoute());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BufferPerRoute> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Filter.Http.Buffer.V3Alpha.BufferReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BufferPerRoute() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BufferPerRoute(BufferPerRoute other) : this() {
      switch (other.OverrideCase) {
        case OverrideOneofCase.Disabled:
          Disabled = other.Disabled;
          break;
        case OverrideOneofCase.Buffer:
          Buffer = other.Buffer.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BufferPerRoute Clone() {
      return new BufferPerRoute(this);
    }

    /// <summary>Field number for the "disabled" field.</summary>
    public const int DisabledFieldNumber = 1;
    /// <summary>
    /// Disable the buffer filter for this particular vhost or route.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Disabled {
      get { return overrideCase_ == OverrideOneofCase.Disabled ? (bool) override_ : false; }
      set {
        override_ = value;
        overrideCase_ = OverrideOneofCase.Disabled;
      }
    }

    /// <summary>Field number for the "buffer" field.</summary>
    public const int BufferFieldNumber = 2;
    /// <summary>
    /// Override the global configuration of the filter with this new config.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Envoy.Config.Filter.Http.Buffer.V3Alpha.Buffer Buffer {
      get { return overrideCase_ == OverrideOneofCase.Buffer ? (global::Envoy.Config.Filter.Http.Buffer.V3Alpha.Buffer) override_ : null; }
      set {
        override_ = value;
        overrideCase_ = value == null ? OverrideOneofCase.None : OverrideOneofCase.Buffer;
      }
    }

    private object override_;
    /// <summary>Enum of possible cases for the "override" oneof.</summary>
    public enum OverrideOneofCase {
      None = 0,
      Disabled = 1,
      Buffer = 2,
    }
    private OverrideOneofCase overrideCase_ = OverrideOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OverrideOneofCase OverrideCase {
      get { return overrideCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearOverride() {
      overrideCase_ = OverrideOneofCase.None;
      override_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BufferPerRoute);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BufferPerRoute other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Disabled != other.Disabled) return false;
      if (!object.Equals(Buffer, other.Buffer)) return false;
      if (OverrideCase != other.OverrideCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (overrideCase_ == OverrideOneofCase.Disabled) hash ^= Disabled.GetHashCode();
      if (overrideCase_ == OverrideOneofCase.Buffer) hash ^= Buffer.GetHashCode();
      hash ^= (int) overrideCase_;
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
      if (overrideCase_ == OverrideOneofCase.Disabled) {
        output.WriteRawTag(8);
        output.WriteBool(Disabled);
      }
      if (overrideCase_ == OverrideOneofCase.Buffer) {
        output.WriteRawTag(18);
        output.WriteMessage(Buffer);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (overrideCase_ == OverrideOneofCase.Disabled) {
        size += 1 + 1;
      }
      if (overrideCase_ == OverrideOneofCase.Buffer) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Buffer);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BufferPerRoute other) {
      if (other == null) {
        return;
      }
      switch (other.OverrideCase) {
        case OverrideOneofCase.Disabled:
          Disabled = other.Disabled;
          break;
        case OverrideOneofCase.Buffer:
          if (Buffer == null) {
            Buffer = new global::Envoy.Config.Filter.Http.Buffer.V3Alpha.Buffer();
          }
          Buffer.MergeFrom(other.Buffer);
          break;
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
            Disabled = input.ReadBool();
            break;
          }
          case 18: {
            global::Envoy.Config.Filter.Http.Buffer.V3Alpha.Buffer subBuilder = new global::Envoy.Config.Filter.Http.Buffer.V3Alpha.Buffer();
            if (overrideCase_ == OverrideOneofCase.Buffer) {
              subBuilder.MergeFrom(Buffer);
            }
            input.ReadMessage(subBuilder);
            Buffer = subBuilder;
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
