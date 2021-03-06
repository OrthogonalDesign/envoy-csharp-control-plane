// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/service/discovery/v3alpha/rtds.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Service.Discovery.V3Alpha {

  /// <summary>Holder for reflection information generated from envoy/service/discovery/v3alpha/rtds.proto</summary>
  public static partial class RtdsReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/service/discovery/v3alpha/rtds.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RtdsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiplbnZveS9zZXJ2aWNlL2Rpc2NvdmVyeS92M2FscGhhL3J0ZHMucHJvdG8S",
            "H2Vudm95LnNlcnZpY2UuZGlzY292ZXJ5LnYzYWxwaGEaIWVudm95L2FwaS92",
            "M2FscGhhL2Rpc2NvdmVyeS5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9u",
            "cy5wcm90bxocZ29vZ2xlL3Byb3RvYnVmL3N0cnVjdC5wcm90bxoXdmFsaWRh",
            "dGUvdmFsaWRhdGUucHJvdG8iCwoJUnRkc0R1bW15IkoKB1J1bnRpbWUSFwoE",
            "bmFtZRgBIAEoCUIJuunAAwRyAiABEiYKBWxheWVyGAIgASgLMhcuZ29vZ2xl",
            "LnByb3RvYnVmLlN0cnVjdDLpAgoXUnVudGltZURpc2NvdmVyeVNlcnZpY2US",
            "YAoNU3RyZWFtUnVudGltZRIjLmVudm95LmFwaS52M2FscGhhLkRpc2NvdmVy",
            "eVJlcXVlc3QaJC5lbnZveS5hcGkudjNhbHBoYS5EaXNjb3ZlcnlSZXNwb25z",
            "ZSIAKAEwARJpCgxEZWx0YVJ1bnRpbWUSKC5lbnZveS5hcGkudjNhbHBoYS5E",
            "ZWx0YURpc2NvdmVyeVJlcXVlc3QaKS5lbnZveS5hcGkudjNhbHBoYS5EZWx0",
            "YURpc2NvdmVyeVJlc3BvbnNlIgAoATABEoABCgxGZXRjaFJ1bnRpbWUSIy5l",
            "bnZveS5hcGkudjNhbHBoYS5EaXNjb3ZlcnlSZXF1ZXN0GiQuZW52b3kuYXBp",
            "LnYzYWxwaGEuRGlzY292ZXJ5UmVzcG9uc2UiJYLT5JMCHyIaL3YzYWxwaGEv",
            "ZGlzY292ZXJ5OnJ1bnRpbWU6ASpCPwotaW8uZW52b3lwcm94eS5lbnZveS5z",
            "ZXJ2aWNlLmRpc2NvdmVyeS52M2FscGhhQglSdGRzUHJvdG9QAYgBAWIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Api.V3Alpha.DiscoveryReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.StructReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Service.Discovery.V3Alpha.RtdsDummy), global::Envoy.Service.Discovery.V3Alpha.RtdsDummy.Parser, null, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Service.Discovery.V3Alpha.Runtime), global::Envoy.Service.Discovery.V3Alpha.Runtime.Parser, new[]{ "Name", "Layer" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// [#not-implemented-hide:] Not configuration. Workaround c++ protobuf issue with importing
  /// services: https://github.com/google/protobuf/issues/4221
  /// </summary>
  public sealed partial class RtdsDummy : pb::IMessage<RtdsDummy> {
    private static readonly pb::MessageParser<RtdsDummy> _parser = new pb::MessageParser<RtdsDummy>(() => new RtdsDummy());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RtdsDummy> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Service.Discovery.V3Alpha.RtdsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RtdsDummy() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RtdsDummy(RtdsDummy other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RtdsDummy Clone() {
      return new RtdsDummy(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RtdsDummy);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RtdsDummy other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RtdsDummy other) {
      if (other == null) {
        return;
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
        }
      }
    }

  }

  /// <summary>
  /// RTDS resource type. This describes a layer in the runtime virtual filesystem.
  /// </summary>
  public sealed partial class Runtime : pb::IMessage<Runtime> {
    private static readonly pb::MessageParser<Runtime> _parser = new pb::MessageParser<Runtime>(() => new Runtime());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Runtime> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Service.Discovery.V3Alpha.RtdsReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Runtime() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Runtime(Runtime other) : this() {
      name_ = other.name_;
      layer_ = other.layer_ != null ? other.layer_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Runtime Clone() {
      return new Runtime(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Runtime resource name. This makes the Runtime a self-describing xDS
    /// resource.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "layer" field.</summary>
    public const int LayerFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Struct layer_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Struct Layer {
      get { return layer_; }
      set {
        layer_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Runtime);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Runtime other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!object.Equals(Layer, other.Layer)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (layer_ != null) hash ^= Layer.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (layer_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Layer);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (layer_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Layer);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Runtime other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.layer_ != null) {
        if (layer_ == null) {
          Layer = new global::Google.Protobuf.WellKnownTypes.Struct();
        }
        Layer.MergeFrom(other.Layer);
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            if (layer_ == null) {
              Layer = new global::Google.Protobuf.WellKnownTypes.Struct();
            }
            input.ReadMessage(Layer);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
