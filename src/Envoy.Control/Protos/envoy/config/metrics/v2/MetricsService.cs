// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/config/metrics/v2/metrics_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Config.Metrics.V2 {

  /// <summary>Holder for reflection information generated from envoy/config/metrics/v2/metrics_service.proto</summary>
  public static partial class MetricsServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/config/metrics/v2/metrics_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MetricsServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1lbnZveS9jb25maWcvbWV0cmljcy92Mi9tZXRyaWNzX3NlcnZpY2UucHJv",
            "dG8SF2Vudm95LmNvbmZpZy5tZXRyaWNzLnYyGiRlbnZveS9hcGkvdjIvY29y",
            "ZS9ncnBjX3NlcnZpY2UucHJvdG8aF3ZhbGlkYXRlL3ZhbGlkYXRlLnByb3Rv",
            "IlgKFE1ldHJpY3NTZXJ2aWNlQ29uZmlnEkAKDGdycGNfc2VydmljZRgBIAEo",
            "CzIeLmVudm95LmFwaS52Mi5jb3JlLkdycGNTZXJ2aWNlQgq66cADBYoBAhAB",
            "Qj4KJWlvLmVudm95cHJveHkuZW52b3kuY29uZmlnLm1ldHJpY3MudjJCE01l",
            "dHJpY3NTZXJ2aWNlUHJvdG9QAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Api.V2.Core.GrpcServiceReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Metrics.V2.MetricsServiceConfig), global::Envoy.Config.Metrics.V2.MetricsServiceConfig.Parser, new[]{ "GrpcService" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Metrics Service is configured as a built-in *envoy.metrics_service* :ref:`StatsSink
  /// &lt;envoy_api_msg_config.metrics.v2.StatsSink>`. This opaque configuration will be used to create
  /// Metrics Service.
  /// </summary>
  public sealed partial class MetricsServiceConfig : pb::IMessage<MetricsServiceConfig> {
    private static readonly pb::MessageParser<MetricsServiceConfig> _parser = new pb::MessageParser<MetricsServiceConfig>(() => new MetricsServiceConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MetricsServiceConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Metrics.V2.MetricsServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MetricsServiceConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MetricsServiceConfig(MetricsServiceConfig other) : this() {
      grpcService_ = other.grpcService_ != null ? other.grpcService_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MetricsServiceConfig Clone() {
      return new MetricsServiceConfig(this);
    }

    /// <summary>Field number for the "grpc_service" field.</summary>
    public const int GrpcServiceFieldNumber = 1;
    private global::Envoy.Api.V2.Core.GrpcService grpcService_;
    /// <summary>
    /// The upstream gRPC cluster that hosts the metrics service.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Envoy.Api.V2.Core.GrpcService GrpcService {
      get { return grpcService_; }
      set {
        grpcService_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MetricsServiceConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MetricsServiceConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(GrpcService, other.GrpcService)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (grpcService_ != null) hash ^= GrpcService.GetHashCode();
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
      if (grpcService_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(GrpcService);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (grpcService_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GrpcService);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MetricsServiceConfig other) {
      if (other == null) {
        return;
      }
      if (other.grpcService_ != null) {
        if (grpcService_ == null) {
          GrpcService = new global::Envoy.Api.V2.Core.GrpcService();
        }
        GrpcService.MergeFrom(other.GrpcService);
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
            if (grpcService_ == null) {
              GrpcService = new global::Envoy.Api.V2.Core.GrpcService();
            }
            input.ReadMessage(GrpcService);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
