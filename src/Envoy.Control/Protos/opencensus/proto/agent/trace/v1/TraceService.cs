// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: opencensus/proto/agent/trace/v1/trace_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Opencensus.Proto.Agent.Trace.V1 {

  /// <summary>Holder for reflection information generated from opencensus/proto/agent/trace/v1/trace_service.proto</summary>
  public static partial class TraceServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for opencensus/proto/agent/trace/v1/trace_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TraceServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNvcGVuY2Vuc3VzL3Byb3RvL2FnZW50L3RyYWNlL3YxL3RyYWNlX3NlcnZp",
            "Y2UucHJvdG8SH29wZW5jZW5zdXMucHJvdG8uYWdlbnQudHJhY2UudjEaLW9w",
            "ZW5jZW5zdXMvcHJvdG8vYWdlbnQvY29tbW9uL3YxL2NvbW1vbi5wcm90bxor",
            "b3BlbmNlbnN1cy9wcm90by9yZXNvdXJjZS92MS9yZXNvdXJjZS5wcm90bxol",
            "b3BlbmNlbnN1cy9wcm90by90cmFjZS92MS90cmFjZS5wcm90bxosb3BlbmNl",
            "bnN1cy9wcm90by90cmFjZS92MS90cmFjZV9jb25maWcucHJvdG8ihAEKFEN1",
            "cnJlbnRMaWJyYXJ5Q29uZmlnEjQKBG5vZGUYASABKAsyJi5vcGVuY2Vuc3Vz",
            "LnByb3RvLmFnZW50LmNvbW1vbi52MS5Ob2RlEjYKBmNvbmZpZxgCIAEoCzIm",
            "Lm9wZW5jZW5zdXMucHJvdG8udHJhY2UudjEuVHJhY2VDb25maWcihAEKFFVw",
            "ZGF0ZWRMaWJyYXJ5Q29uZmlnEjQKBG5vZGUYASABKAsyJi5vcGVuY2Vuc3Vz",
            "LnByb3RvLmFnZW50LmNvbW1vbi52MS5Ob2RlEjYKBmNvbmZpZxgCIAEoCzIm",
            "Lm9wZW5jZW5zdXMucHJvdG8udHJhY2UudjEuVHJhY2VDb25maWciuwEKGUV4",
            "cG9ydFRyYWNlU2VydmljZVJlcXVlc3QSNAoEbm9kZRgBIAEoCzImLm9wZW5j",
            "ZW5zdXMucHJvdG8uYWdlbnQuY29tbW9uLnYxLk5vZGUSLgoFc3BhbnMYAiAD",
            "KAsyHy5vcGVuY2Vuc3VzLnByb3RvLnRyYWNlLnYxLlNwYW4SOAoIcmVzb3Vy",
            "Y2UYAyABKAsyJi5vcGVuY2Vuc3VzLnByb3RvLnJlc291cmNlLnYxLlJlc291",
            "cmNlIhwKGkV4cG9ydFRyYWNlU2VydmljZVJlc3BvbnNlMpYCCgxUcmFjZVNl",
            "cnZpY2USfAoGQ29uZmlnEjUub3BlbmNlbnN1cy5wcm90by5hZ2VudC50cmFj",
            "ZS52MS5DdXJyZW50TGlicmFyeUNvbmZpZxo1Lm9wZW5jZW5zdXMucHJvdG8u",
            "YWdlbnQudHJhY2UudjEuVXBkYXRlZExpYnJhcnlDb25maWciACgBMAEShwEK",
            "BkV4cG9ydBI6Lm9wZW5jZW5zdXMucHJvdG8uYWdlbnQudHJhY2UudjEuRXhw",
            "b3J0VHJhY2VTZXJ2aWNlUmVxdWVzdBo7Lm9wZW5jZW5zdXMucHJvdG8uYWdl",
            "bnQudHJhY2UudjEuRXhwb3J0VHJhY2VTZXJ2aWNlUmVzcG9uc2UiACgBMAFC",
            "gwEKImlvLm9wZW5jZW5zdXMucHJvdG8uYWdlbnQudHJhY2UudjFCEVRyYWNl",
            "U2VydmljZVByb3RvUAFaSGdpdGh1Yi5jb20vY2Vuc3VzLWluc3RydW1lbnRh",
            "dGlvbi9vcGVuY2Vuc3VzLXByb3RvL2dlbi1nby9hZ2VudC90cmFjZS92MWIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Opencensus.Proto.Agent.Common.V1.CommonReflection.Descriptor, global::Opencensus.Proto.Resource.V1.ResourceReflection.Descriptor, global::Opencensus.Proto.Trace.V1.TraceReflection.Descriptor, global::Opencensus.Proto.Trace.V1.TraceConfigReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Opencensus.Proto.Agent.Trace.V1.CurrentLibraryConfig), global::Opencensus.Proto.Agent.Trace.V1.CurrentLibraryConfig.Parser, new[]{ "Node", "Config" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Opencensus.Proto.Agent.Trace.V1.UpdatedLibraryConfig), global::Opencensus.Proto.Agent.Trace.V1.UpdatedLibraryConfig.Parser, new[]{ "Node", "Config" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Opencensus.Proto.Agent.Trace.V1.ExportTraceServiceRequest), global::Opencensus.Proto.Agent.Trace.V1.ExportTraceServiceRequest.Parser, new[]{ "Node", "Spans", "Resource" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Opencensus.Proto.Agent.Trace.V1.ExportTraceServiceResponse), global::Opencensus.Proto.Agent.Trace.V1.ExportTraceServiceResponse.Parser, null, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CurrentLibraryConfig : pb::IMessage<CurrentLibraryConfig> {
    private static readonly pb::MessageParser<CurrentLibraryConfig> _parser = new pb::MessageParser<CurrentLibraryConfig>(() => new CurrentLibraryConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CurrentLibraryConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Opencensus.Proto.Agent.Trace.V1.TraceServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CurrentLibraryConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CurrentLibraryConfig(CurrentLibraryConfig other) : this() {
      node_ = other.node_ != null ? other.node_.Clone() : null;
      config_ = other.config_ != null ? other.config_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CurrentLibraryConfig Clone() {
      return new CurrentLibraryConfig(this);
    }

    /// <summary>Field number for the "node" field.</summary>
    public const int NodeFieldNumber = 1;
    private global::Opencensus.Proto.Agent.Common.V1.Node node_;
    /// <summary>
    /// This is required only in the first message on the stream or if the
    /// previous sent CurrentLibraryConfig message has a different Node (e.g.
    /// when the same RPC is used to configure multiple Applications).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Opencensus.Proto.Agent.Common.V1.Node Node {
      get { return node_; }
      set {
        node_ = value;
      }
    }

    /// <summary>Field number for the "config" field.</summary>
    public const int ConfigFieldNumber = 2;
    private global::Opencensus.Proto.Trace.V1.TraceConfig config_;
    /// <summary>
    /// Current configuration.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Opencensus.Proto.Trace.V1.TraceConfig Config {
      get { return config_; }
      set {
        config_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CurrentLibraryConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CurrentLibraryConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Node, other.Node)) return false;
      if (!object.Equals(Config, other.Config)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (node_ != null) hash ^= Node.GetHashCode();
      if (config_ != null) hash ^= Config.GetHashCode();
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
      if (config_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Config);
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
      if (config_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Config);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CurrentLibraryConfig other) {
      if (other == null) {
        return;
      }
      if (other.node_ != null) {
        if (node_ == null) {
          Node = new global::Opencensus.Proto.Agent.Common.V1.Node();
        }
        Node.MergeFrom(other.Node);
      }
      if (other.config_ != null) {
        if (config_ == null) {
          Config = new global::Opencensus.Proto.Trace.V1.TraceConfig();
        }
        Config.MergeFrom(other.Config);
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
              Node = new global::Opencensus.Proto.Agent.Common.V1.Node();
            }
            input.ReadMessage(Node);
            break;
          }
          case 18: {
            if (config_ == null) {
              Config = new global::Opencensus.Proto.Trace.V1.TraceConfig();
            }
            input.ReadMessage(Config);
            break;
          }
        }
      }
    }

  }

  public sealed partial class UpdatedLibraryConfig : pb::IMessage<UpdatedLibraryConfig> {
    private static readonly pb::MessageParser<UpdatedLibraryConfig> _parser = new pb::MessageParser<UpdatedLibraryConfig>(() => new UpdatedLibraryConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UpdatedLibraryConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Opencensus.Proto.Agent.Trace.V1.TraceServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UpdatedLibraryConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UpdatedLibraryConfig(UpdatedLibraryConfig other) : this() {
      node_ = other.node_ != null ? other.node_.Clone() : null;
      config_ = other.config_ != null ? other.config_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UpdatedLibraryConfig Clone() {
      return new UpdatedLibraryConfig(this);
    }

    /// <summary>Field number for the "node" field.</summary>
    public const int NodeFieldNumber = 1;
    private global::Opencensus.Proto.Agent.Common.V1.Node node_;
    /// <summary>
    /// This field is ignored when the RPC is used to configure only one Application.
    /// This is required only in the first message on the stream or if the
    /// previous sent UpdatedLibraryConfig message has a different Node.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Opencensus.Proto.Agent.Common.V1.Node Node {
      get { return node_; }
      set {
        node_ = value;
      }
    }

    /// <summary>Field number for the "config" field.</summary>
    public const int ConfigFieldNumber = 2;
    private global::Opencensus.Proto.Trace.V1.TraceConfig config_;
    /// <summary>
    /// Requested updated configuration.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Opencensus.Proto.Trace.V1.TraceConfig Config {
      get { return config_; }
      set {
        config_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UpdatedLibraryConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UpdatedLibraryConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Node, other.Node)) return false;
      if (!object.Equals(Config, other.Config)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (node_ != null) hash ^= Node.GetHashCode();
      if (config_ != null) hash ^= Config.GetHashCode();
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
      if (config_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Config);
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
      if (config_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Config);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UpdatedLibraryConfig other) {
      if (other == null) {
        return;
      }
      if (other.node_ != null) {
        if (node_ == null) {
          Node = new global::Opencensus.Proto.Agent.Common.V1.Node();
        }
        Node.MergeFrom(other.Node);
      }
      if (other.config_ != null) {
        if (config_ == null) {
          Config = new global::Opencensus.Proto.Trace.V1.TraceConfig();
        }
        Config.MergeFrom(other.Config);
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
              Node = new global::Opencensus.Proto.Agent.Common.V1.Node();
            }
            input.ReadMessage(Node);
            break;
          }
          case 18: {
            if (config_ == null) {
              Config = new global::Opencensus.Proto.Trace.V1.TraceConfig();
            }
            input.ReadMessage(Config);
            break;
          }
        }
      }
    }

  }

  public sealed partial class ExportTraceServiceRequest : pb::IMessage<ExportTraceServiceRequest> {
    private static readonly pb::MessageParser<ExportTraceServiceRequest> _parser = new pb::MessageParser<ExportTraceServiceRequest>(() => new ExportTraceServiceRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ExportTraceServiceRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Opencensus.Proto.Agent.Trace.V1.TraceServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExportTraceServiceRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExportTraceServiceRequest(ExportTraceServiceRequest other) : this() {
      node_ = other.node_ != null ? other.node_.Clone() : null;
      spans_ = other.spans_.Clone();
      resource_ = other.resource_ != null ? other.resource_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExportTraceServiceRequest Clone() {
      return new ExportTraceServiceRequest(this);
    }

    /// <summary>Field number for the "node" field.</summary>
    public const int NodeFieldNumber = 1;
    private global::Opencensus.Proto.Agent.Common.V1.Node node_;
    /// <summary>
    /// This is required only in the first message on the stream or if the
    /// previous sent ExportTraceServiceRequest message has a different Node (e.g.
    /// when the same RPC is used to send Spans from multiple Applications).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Opencensus.Proto.Agent.Common.V1.Node Node {
      get { return node_; }
      set {
        node_ = value;
      }
    }

    /// <summary>Field number for the "spans" field.</summary>
    public const int SpansFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Opencensus.Proto.Trace.V1.Span> _repeated_spans_codec
        = pb::FieldCodec.ForMessage(18, global::Opencensus.Proto.Trace.V1.Span.Parser);
    private readonly pbc::RepeatedField<global::Opencensus.Proto.Trace.V1.Span> spans_ = new pbc::RepeatedField<global::Opencensus.Proto.Trace.V1.Span>();
    /// <summary>
    /// A list of Spans that belong to the last received Node.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Opencensus.Proto.Trace.V1.Span> Spans {
      get { return spans_; }
    }

    /// <summary>Field number for the "resource" field.</summary>
    public const int ResourceFieldNumber = 3;
    private global::Opencensus.Proto.Resource.V1.Resource resource_;
    /// <summary>
    /// The resource for the spans in this message that do not have an explicit
    /// resource set.
    /// If unset, the most recently set resource in the RPC stream applies. It is
    /// valid to never be set within a stream, e.g. when no resource info is known.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Opencensus.Proto.Resource.V1.Resource Resource {
      get { return resource_; }
      set {
        resource_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ExportTraceServiceRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ExportTraceServiceRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Node, other.Node)) return false;
      if(!spans_.Equals(other.spans_)) return false;
      if (!object.Equals(Resource, other.Resource)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (node_ != null) hash ^= Node.GetHashCode();
      hash ^= spans_.GetHashCode();
      if (resource_ != null) hash ^= Resource.GetHashCode();
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
      spans_.WriteTo(output, _repeated_spans_codec);
      if (resource_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Resource);
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
      size += spans_.CalculateSize(_repeated_spans_codec);
      if (resource_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Resource);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ExportTraceServiceRequest other) {
      if (other == null) {
        return;
      }
      if (other.node_ != null) {
        if (node_ == null) {
          Node = new global::Opencensus.Proto.Agent.Common.V1.Node();
        }
        Node.MergeFrom(other.Node);
      }
      spans_.Add(other.spans_);
      if (other.resource_ != null) {
        if (resource_ == null) {
          Resource = new global::Opencensus.Proto.Resource.V1.Resource();
        }
        Resource.MergeFrom(other.Resource);
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
              Node = new global::Opencensus.Proto.Agent.Common.V1.Node();
            }
            input.ReadMessage(Node);
            break;
          }
          case 18: {
            spans_.AddEntriesFrom(input, _repeated_spans_codec);
            break;
          }
          case 26: {
            if (resource_ == null) {
              Resource = new global::Opencensus.Proto.Resource.V1.Resource();
            }
            input.ReadMessage(Resource);
            break;
          }
        }
      }
    }

  }

  public sealed partial class ExportTraceServiceResponse : pb::IMessage<ExportTraceServiceResponse> {
    private static readonly pb::MessageParser<ExportTraceServiceResponse> _parser = new pb::MessageParser<ExportTraceServiceResponse>(() => new ExportTraceServiceResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ExportTraceServiceResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Opencensus.Proto.Agent.Trace.V1.TraceServiceReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExportTraceServiceResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExportTraceServiceResponse(ExportTraceServiceResponse other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExportTraceServiceResponse Clone() {
      return new ExportTraceServiceResponse(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ExportTraceServiceResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ExportTraceServiceResponse other) {
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
    public void MergeFrom(ExportTraceServiceResponse other) {
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

  #endregion

}

#endregion Designer generated code
