// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/config/filter/http/rbac/v2/rbac.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Config.Filter.Http.Rbac.V2 {

  /// <summary>Holder for reflection information generated from envoy/config/filter/http/rbac/v2/rbac.proto</summary>
  public static partial class RbacReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/config/filter/http/rbac/v2/rbac.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RbacReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CitlbnZveS9jb25maWcvZmlsdGVyL2h0dHAvcmJhYy92Mi9yYmFjLnByb3Rv",
            "EiBlbnZveS5jb25maWcuZmlsdGVyLmh0dHAucmJhYy52MhofZW52b3kvY29u",
            "ZmlnL3JiYWMvdjIvcmJhYy5wcm90bxoXdmFsaWRhdGUvdmFsaWRhdGUucHJv",
            "dG8iYwoEUkJBQxIpCgVydWxlcxgBIAEoCzIaLmVudm95LmNvbmZpZy5yYmFj",
            "LnYyLlJCQUMSMAoMc2hhZG93X3J1bGVzGAIgASgLMhouZW52b3kuY29uZmln",
            "LnJiYWMudjIuUkJBQyJUCgxSQkFDUGVyUm91dGUSNAoEcmJhYxgCIAEoCzIm",
            "LmVudm95LmNvbmZpZy5maWx0ZXIuaHR0cC5yYmFjLnYyLlJCQUNKBAgBEAJS",
            "CGRpc2FibGVkQj0KLmlvLmVudm95cHJveHkuZW52b3kuY29uZmlnLmZpbHRl",
            "ci5odHRwLnJiYWMudjJCCVJiYWNQcm90b1ABYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Config.Rbac.V2.RbacReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Filter.Http.Rbac.V2.RBAC), global::Envoy.Config.Filter.Http.Rbac.V2.RBAC.Parser, new[]{ "Rules", "ShadowRules" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Filter.Http.Rbac.V2.RBACPerRoute), global::Envoy.Config.Filter.Http.Rbac.V2.RBACPerRoute.Parser, new[]{ "Rbac" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// RBAC filter config.
  /// </summary>
  public sealed partial class RBAC : pb::IMessage<RBAC> {
    private static readonly pb::MessageParser<RBAC> _parser = new pb::MessageParser<RBAC>(() => new RBAC());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RBAC> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Filter.Http.Rbac.V2.RbacReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RBAC() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RBAC(RBAC other) : this() {
      rules_ = other.rules_ != null ? other.rules_.Clone() : null;
      shadowRules_ = other.shadowRules_ != null ? other.shadowRules_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RBAC Clone() {
      return new RBAC(this);
    }

    /// <summary>Field number for the "rules" field.</summary>
    public const int RulesFieldNumber = 1;
    private global::Envoy.Config.Rbac.V2.RBAC rules_;
    /// <summary>
    /// Specify the RBAC rules to be applied globally.
    /// If absent, no enforcing RBAC policy will be applied.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Envoy.Config.Rbac.V2.RBAC Rules {
      get { return rules_; }
      set {
        rules_ = value;
      }
    }

    /// <summary>Field number for the "shadow_rules" field.</summary>
    public const int ShadowRulesFieldNumber = 2;
    private global::Envoy.Config.Rbac.V2.RBAC shadowRules_;
    /// <summary>
    /// Shadow rules are not enforced by the filter (i.e., returning a 403)
    /// but will emit stats and logs and can be used for rule testing.
    /// If absent, no shadow RBAC policy will be applied.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Envoy.Config.Rbac.V2.RBAC ShadowRules {
      get { return shadowRules_; }
      set {
        shadowRules_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RBAC);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RBAC other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Rules, other.Rules)) return false;
      if (!object.Equals(ShadowRules, other.ShadowRules)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (rules_ != null) hash ^= Rules.GetHashCode();
      if (shadowRules_ != null) hash ^= ShadowRules.GetHashCode();
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
      if (rules_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Rules);
      }
      if (shadowRules_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ShadowRules);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (rules_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Rules);
      }
      if (shadowRules_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ShadowRules);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RBAC other) {
      if (other == null) {
        return;
      }
      if (other.rules_ != null) {
        if (rules_ == null) {
          Rules = new global::Envoy.Config.Rbac.V2.RBAC();
        }
        Rules.MergeFrom(other.Rules);
      }
      if (other.shadowRules_ != null) {
        if (shadowRules_ == null) {
          ShadowRules = new global::Envoy.Config.Rbac.V2.RBAC();
        }
        ShadowRules.MergeFrom(other.ShadowRules);
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
            if (rules_ == null) {
              Rules = new global::Envoy.Config.Rbac.V2.RBAC();
            }
            input.ReadMessage(Rules);
            break;
          }
          case 18: {
            if (shadowRules_ == null) {
              ShadowRules = new global::Envoy.Config.Rbac.V2.RBAC();
            }
            input.ReadMessage(ShadowRules);
            break;
          }
        }
      }
    }

  }

  public sealed partial class RBACPerRoute : pb::IMessage<RBACPerRoute> {
    private static readonly pb::MessageParser<RBACPerRoute> _parser = new pb::MessageParser<RBACPerRoute>(() => new RBACPerRoute());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RBACPerRoute> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Filter.Http.Rbac.V2.RbacReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RBACPerRoute() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RBACPerRoute(RBACPerRoute other) : this() {
      rbac_ = other.rbac_ != null ? other.rbac_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RBACPerRoute Clone() {
      return new RBACPerRoute(this);
    }

    /// <summary>Field number for the "rbac" field.</summary>
    public const int RbacFieldNumber = 2;
    private global::Envoy.Config.Filter.Http.Rbac.V2.RBAC rbac_;
    /// <summary>
    /// Override the global configuration of the filter with this new config.
    /// If absent, the global RBAC policy will be disabled for this route.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Envoy.Config.Filter.Http.Rbac.V2.RBAC Rbac {
      get { return rbac_; }
      set {
        rbac_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RBACPerRoute);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RBACPerRoute other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Rbac, other.Rbac)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (rbac_ != null) hash ^= Rbac.GetHashCode();
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
      if (rbac_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Rbac);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (rbac_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Rbac);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RBACPerRoute other) {
      if (other == null) {
        return;
      }
      if (other.rbac_ != null) {
        if (rbac_ == null) {
          Rbac = new global::Envoy.Config.Filter.Http.Rbac.V2.RBAC();
        }
        Rbac.MergeFrom(other.Rbac);
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
          case 18: {
            if (rbac_ == null) {
              Rbac = new global::Envoy.Config.Filter.Http.Rbac.V2.RBAC();
            }
            input.ReadMessage(Rbac);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
