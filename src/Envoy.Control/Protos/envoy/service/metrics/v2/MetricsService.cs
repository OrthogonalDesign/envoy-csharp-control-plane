// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/service/metrics/v2/metrics_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Service.Metrics.V2 {

  /// <summary>Holder for reflection information generated from envoy/service/metrics/v2/metrics_service.proto</summary>
  public static partial class MetricsServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/service/metrics/v2/metrics_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MetricsServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5lbnZveS9zZXJ2aWNlL21ldHJpY3MvdjIvbWV0cmljc19zZXJ2aWNlLnBy",
            "b3RvEhhlbnZveS5zZXJ2aWNlLm1ldHJpY3MudjIaHGVudm95L2FwaS92Mi9j",
            "b3JlL2Jhc2UucHJvdG8aDW1ldHJpY3MucHJvdG8aF3ZhbGlkYXRlL3ZhbGlk",
            "YXRlLnByb3RvIhcKFVN0cmVhbU1ldHJpY3NSZXNwb25zZSLhAQoUU3RyZWFt",
            "TWV0cmljc01lc3NhZ2USTQoKaWRlbnRpZmllchgBIAEoCzI5LmVudm95LnNl",
            "cnZpY2UubWV0cmljcy52Mi5TdHJlYW1NZXRyaWNzTWVzc2FnZS5JZGVudGlm",
            "aWVyEjkKDWVudm95X21ldHJpY3MYAiADKAsyIi5pby5wcm9tZXRoZXVzLmNs",
            "aWVudC5NZXRyaWNGYW1pbHkaPwoKSWRlbnRpZmllchIxCgRub2RlGAEgASgL",
            "MhcuZW52b3kuYXBpLnYyLmNvcmUuTm9kZUIKuunAAwWKAQIQATKGAQoOTWV0",
            "cmljc1NlcnZpY2USdAoNU3RyZWFtTWV0cmljcxIuLmVudm95LnNlcnZpY2Uu",
            "bWV0cmljcy52Mi5TdHJlYW1NZXRyaWNzTWVzc2FnZRovLmVudm95LnNlcnZp",
            "Y2UubWV0cmljcy52Mi5TdHJlYW1NZXRyaWNzUmVzcG9uc2UiACgBQkIKJmlv",
            "LmVudm95cHJveHkuZW52b3kuc2VydmljZS5tZXRyaWNzLnYyQhNNZXRyaWNz",
            "U2VydmljZVByb3RvUAGIAQFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Api.V2.Core.BaseReflection.Descriptor, global::Io.Prometheus.Client.MetricsReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Service.Metrics.V2.StreamMetricsResponse), global::Envoy.Service.Metrics.V2.StreamMetricsResponse.Parser, null, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Service.Metrics.V2.StreamMetricsMessage), global::Envoy.Service.Metrics.V2.StreamMetricsMessage.Parser, new[]{ "Identifier", "EnvoyMetrics" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Service.Metrics.V2.StreamMetricsMessage.Types.Identifier), global::Envoy.Service.Metrics.V2.StreamMetricsMessage.Types.Identifier.Parser, new[]{ "Node" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class StreamMetricsResponse : pb::IMessage<StreamMetricsResponse> {
    private static readonly pb::MessageParser<StreamMetricsResponse> _parser = new pb::MessageParser<StreamMetricsResponse>(() => new StreamMetricsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StreamMetricsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Service.Metrics.V2.MetricsServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StreamMetricsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StreamMetricsResponse(StreamMetricsResponse other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StreamMetricsResponse Clone() {
      return new StreamMetricsResponse(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StreamMetricsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StreamMetricsResponse other) {
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
    public void MergeFrom(StreamMetricsResponse other) {
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

  public sealed partial class StreamMetricsMessage : pb::IMessage<StreamMetricsMessage> {
    private static readonly pb::MessageParser<StreamMetricsMessage> _parser = new pb::MessageParser<StreamMetricsMessage>(() => new StreamMetricsMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StreamMetricsMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Service.Metrics.V2.MetricsServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StreamMetricsMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StreamMetricsMessage(StreamMetricsMessage other) : this() {
      identifier_ = other.identifier_ != null ? other.identifier_.Clone() : null;
      envoyMetrics_ = other.envoyMetrics_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StreamMetricsMessage Clone() {
      return new StreamMetricsMessage(this);
    }

    /// <summary>Field number for the "identifier" field.</summary>
    public const int IdentifierFieldNumber = 1;
    private global::Envoy.Service.Metrics.V2.StreamMetricsMessage.Types.Identifier identifier_;
    /// <summary>
    /// Identifier data effectively is a structured metadata. As a performance optimization this will
    /// only be sent in the first message on the stream.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Envoy.Service.Metrics.V2.StreamMetricsMessage.Types.Identifier Identifier {
      get { return identifier_; }
      set {
        identifier_ = value;
      }
    }

    /// <summary>Field number for the "envoy_metrics" field.</summary>
    public const int EnvoyMetricsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Io.Prometheus.Client.MetricFamily> _repeated_envoyMetrics_codec
        = pb::FieldCodec.ForMessage(18, global::Io.Prometheus.Client.MetricFamily.Parser);
    private readonly pbc::RepeatedField<global::Io.Prometheus.Client.MetricFamily> envoyMetrics_ = new pbc::RepeatedField<global::Io.Prometheus.Client.MetricFamily>();
    /// <summary>
    /// A list of metric entries
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Io.Prometheus.Client.MetricFamily> EnvoyMetrics {
      get { return envoyMetrics_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StreamMetricsMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StreamMetricsMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Identifier, other.Identifier)) return false;
      if(!envoyMetrics_.Equals(other.envoyMetrics_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (identifier_ != null) hash ^= Identifier.GetHashCode();
      hash ^= envoyMetrics_.GetHashCode();
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
      if (identifier_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Identifier);
      }
      envoyMetrics_.WriteTo(output, _repeated_envoyMetrics_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (identifier_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Identifier);
      }
      size += envoyMetrics_.CalculateSize(_repeated_envoyMetrics_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StreamMetricsMessage other) {
      if (other == null) {
        return;
      }
      if (other.identifier_ != null) {
        if (identifier_ == null) {
          Identifier = new global::Envoy.Service.Metrics.V2.StreamMetricsMessage.Types.Identifier();
        }
        Identifier.MergeFrom(other.Identifier);
      }
      envoyMetrics_.Add(other.envoyMetrics_);
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
            if (identifier_ == null) {
              Identifier = new global::Envoy.Service.Metrics.V2.StreamMetricsMessage.Types.Identifier();
            }
            input.ReadMessage(Identifier);
            break;
          }
          case 18: {
            envoyMetrics_.AddEntriesFrom(input, _repeated_envoyMetrics_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the StreamMetricsMessage message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public sealed partial class Identifier : pb::IMessage<Identifier> {
        private static readonly pb::MessageParser<Identifier> _parser = new pb::MessageParser<Identifier>(() => new Identifier());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Identifier> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Envoy.Service.Metrics.V2.StreamMetricsMessage.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Identifier() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Identifier(Identifier other) : this() {
          node_ = other.node_ != null ? other.node_.Clone() : null;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Identifier Clone() {
          return new Identifier(this);
        }

        /// <summary>Field number for the "node" field.</summary>
        public const int NodeFieldNumber = 1;
        private global::Envoy.Api.V2.Core.Node node_;
        /// <summary>
        /// The node sending metrics over the stream.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Envoy.Api.V2.Core.Node Node {
          get { return node_; }
          set {
            node_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as Identifier);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(Identifier other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (!object.Equals(Node, other.Node)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (node_ != null) hash ^= Node.GetHashCode();
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
          if (node_ != null) {
            output.WriteRawTag(10);
            output.WriteMessage(Node);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (node_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(Node);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(Identifier other) {
          if (other == null) {
            return;
          }
          if (other.node_ != null) {
            if (node_ == null) {
              Node = new global::Envoy.Api.V2.Core.Node();
            }
            Node.MergeFrom(other.Node);
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
                if (node_ == null) {
                  Node = new global::Envoy.Api.V2.Core.Node();
                }
                input.ReadMessage(Node);
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
