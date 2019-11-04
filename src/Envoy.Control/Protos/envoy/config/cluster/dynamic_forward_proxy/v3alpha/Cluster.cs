// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/config/cluster/dynamic_forward_proxy/v3alpha/cluster.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Config.Cluster.DynamicForwardProxy.V3Alpha {

  /// <summary>Holder for reflection information generated from envoy/config/cluster/dynamic_forward_proxy/v3alpha/cluster.proto</summary>
  public static partial class ClusterReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/config/cluster/dynamic_forward_proxy/v3alpha/cluster.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClusterReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBlbnZveS9jb25maWcvY2x1c3Rlci9keW5hbWljX2ZvcndhcmRfcHJveHkv",
            "djNhbHBoYS9jbHVzdGVyLnByb3RvEjJlbnZveS5jb25maWcuY2x1c3Rlci5k",
            "eW5hbWljX2ZvcndhcmRfcHJveHkudjNhbHBoYRpBZW52b3kvY29uZmlnL2Nv",
            "bW1vbi9keW5hbWljX2ZvcndhcmRfcHJveHkvdjNhbHBoYS9kbnNfY2FjaGUu",
            "cHJvdG8aF3ZhbGlkYXRlL3ZhbGlkYXRlLnByb3RvIngKDUNsdXN0ZXJDb25m",
            "aWcSZwoQZG5zX2NhY2hlX2NvbmZpZxgBIAEoCzJBLmVudm95LmNvbmZpZy5j",
            "b21tb24uZHluYW1pY19mb3J3YXJkX3Byb3h5LnYzYWxwaGEuRG5zQ2FjaGVD",
            "b25maWdCCrrpwAMFigECEAFCZQpAaW8uZW52b3lwcm94eS5lbnZveS5jb25m",
            "aWcuY2x1c3Rlci5keW5hbWljX2ZvcndhcmRfcHJveHkudjNhbHBoYUIfRHlu",
            "YW1pY0ZvcndhcmRQcm94eUNsdXN0ZXJQcm90b1ABYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Config.Common.DynamicForwardProxy.V3Alpha.DnsCacheReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Cluster.DynamicForwardProxy.V3Alpha.ClusterConfig), global::Envoy.Config.Cluster.DynamicForwardProxy.V3Alpha.ClusterConfig.Parser, new[]{ "DnsCacheConfig" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Configuration for the dynamic forward proxy cluster. See the :ref:`architecture overview
  /// &lt;arch_overview_http_dynamic_forward_proxy>` for more information.
  /// </summary>
  public sealed partial class ClusterConfig : pb::IMessage<ClusterConfig> {
    private static readonly pb::MessageParser<ClusterConfig> _parser = new pb::MessageParser<ClusterConfig>(() => new ClusterConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClusterConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Cluster.DynamicForwardProxy.V3Alpha.ClusterReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClusterConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClusterConfig(ClusterConfig other) : this() {
      dnsCacheConfig_ = other.dnsCacheConfig_ != null ? other.dnsCacheConfig_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClusterConfig Clone() {
      return new ClusterConfig(this);
    }

    /// <summary>Field number for the "dns_cache_config" field.</summary>
    public const int DnsCacheConfigFieldNumber = 1;
    private global::Envoy.Config.Common.DynamicForwardProxy.V3Alpha.DnsCacheConfig dnsCacheConfig_;
    /// <summary>
    /// The DNS cache configuration that the cluster will attach to. Note this configuration must
    /// match that of associated :ref:`dynamic forward proxy HTTP filter configuration
    /// &lt;envoy_api_field_config.filter.http.dynamic_forward_proxy.v3alpha.FilterConfig.dns_cache_config>`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Envoy.Config.Common.DynamicForwardProxy.V3Alpha.DnsCacheConfig DnsCacheConfig {
      get { return dnsCacheConfig_; }
      set {
        dnsCacheConfig_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClusterConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClusterConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(DnsCacheConfig, other.DnsCacheConfig)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (dnsCacheConfig_ != null) hash ^= DnsCacheConfig.GetHashCode();
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
      if (dnsCacheConfig_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(DnsCacheConfig);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (dnsCacheConfig_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DnsCacheConfig);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClusterConfig other) {
      if (other == null) {
        return;
      }
      if (other.dnsCacheConfig_ != null) {
        if (dnsCacheConfig_ == null) {
          DnsCacheConfig = new global::Envoy.Config.Common.DynamicForwardProxy.V3Alpha.DnsCacheConfig();
        }
        DnsCacheConfig.MergeFrom(other.DnsCacheConfig);
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
            if (dnsCacheConfig_ == null) {
              DnsCacheConfig = new global::Envoy.Config.Common.DynamicForwardProxy.V3Alpha.DnsCacheConfig();
            }
            input.ReadMessage(DnsCacheConfig);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code