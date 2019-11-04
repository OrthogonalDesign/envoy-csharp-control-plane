// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/config/filter/http/fault/v2/fault.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Config.Filter.Http.Fault.V2 {

  /// <summary>Holder for reflection information generated from envoy/config/filter/http/fault/v2/fault.proto</summary>
  public static partial class FaultReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/config/filter/http/fault/v2/fault.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FaultReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1lbnZveS9jb25maWcvZmlsdGVyL2h0dHAvZmF1bHQvdjIvZmF1bHQucHJv",
            "dG8SIWVudm95LmNvbmZpZy5maWx0ZXIuaHR0cC5mYXVsdC52MhoeZW52b3kv",
            "YXBpL3YyL3JvdXRlL3JvdXRlLnByb3RvGihlbnZveS9jb25maWcvZmlsdGVy",
            "L2ZhdWx0L3YyL2ZhdWx0LnByb3RvGhhlbnZveS90eXBlL3BlcmNlbnQucHJv",
            "dG8aHmdvb2dsZS9wcm90b2J1Zi93cmFwcGVycy5wcm90bxoXdmFsaWRhdGUv",
            "dmFsaWRhdGUucHJvdG8igAEKCkZhdWx0QWJvcnQSJAoLaHR0cF9zdGF0dXMY",
            "AiABKA1CDbrpwAMIKgYQ2AQoyAFIABIxCgpwZXJjZW50YWdlGAMgASgLMh0u",
            "ZW52b3kudHlwZS5GcmFjdGlvbmFsUGVyY2VudEITCgplcnJvcl90eXBlEgW4",
            "6cADAUoECAEQAiK/BAoJSFRUUEZhdWx0EjcKBWRlbGF5GAEgASgLMiguZW52",
            "b3kuY29uZmlnLmZpbHRlci5mYXVsdC52Mi5GYXVsdERlbGF5EjwKBWFib3J0",
            "GAIgASgLMi0uZW52b3kuY29uZmlnLmZpbHRlci5odHRwLmZhdWx0LnYyLkZh",
            "dWx0QWJvcnQSGAoQdXBzdHJlYW1fY2x1c3RlchgDIAEoCRIyCgdoZWFkZXJz",
            "GAQgAygLMiEuZW52b3kuYXBpLnYyLnJvdXRlLkhlYWRlck1hdGNoZXISGAoQ",
            "ZG93bnN0cmVhbV9ub2RlcxgFIAMoCRI3ChFtYXhfYWN0aXZlX2ZhdWx0cxgG",
            "IAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5VSW50MzJWYWx1ZRJJChNyZXNwb25z",
            "ZV9yYXRlX2xpbWl0GAcgASgLMiwuZW52b3kuY29uZmlnLmZpbHRlci5mYXVs",
            "dC52Mi5GYXVsdFJhdGVMaW1pdBIdChVkZWxheV9wZXJjZW50X3J1bnRpbWUY",
            "CCABKAkSHQoVYWJvcnRfcGVyY2VudF9ydW50aW1lGAkgASgJEh4KFmRlbGF5",
            "X2R1cmF0aW9uX3J1bnRpbWUYCiABKAkSIQoZYWJvcnRfaHR0cF9zdGF0dXNf",
            "cnVudGltZRgLIAEoCRIhChltYXhfYWN0aXZlX2ZhdWx0c19ydW50aW1lGAwg",
            "ASgJEisKI3Jlc3BvbnNlX3JhdGVfbGltaXRfcGVyY2VudF9ydW50aW1lGA0g",
            "ASgJQj8KL2lvLmVudm95cHJveHkuZW52b3kuY29uZmlnLmZpbHRlci5odHRw",
            "LmZhdWx0LnYyQgpGYXVsdFByb3RvUAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Api.V2.Route.RouteReflection.Descriptor, global::Envoy.Config.Filter.Fault.V2.FaultReflection.Descriptor, global::Envoy.Type.PercentReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Filter.Http.Fault.V2.FaultAbort), global::Envoy.Config.Filter.Http.Fault.V2.FaultAbort.Parser, new[]{ "HttpStatus", "Percentage" }, new[]{ "ErrorType" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Filter.Http.Fault.V2.HTTPFault), global::Envoy.Config.Filter.Http.Fault.V2.HTTPFault.Parser, new[]{ "Delay", "Abort", "UpstreamCluster", "Headers", "DownstreamNodes", "MaxActiveFaults", "ResponseRateLimit", "DelayPercentRuntime", "AbortPercentRuntime", "DelayDurationRuntime", "AbortHttpStatusRuntime", "MaxActiveFaultsRuntime", "ResponseRateLimitPercentRuntime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FaultAbort : pb::IMessage<FaultAbort> {
    private static readonly pb::MessageParser<FaultAbort> _parser = new pb::MessageParser<FaultAbort>(() => new FaultAbort());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FaultAbort> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Filter.Http.Fault.V2.FaultReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FaultAbort() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FaultAbort(FaultAbort other) : this() {
      percentage_ = other.percentage_ != null ? other.percentage_.Clone() : null;
      switch (other.ErrorTypeCase) {
        case ErrorTypeOneofCase.HttpStatus:
          HttpStatus = other.HttpStatus;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FaultAbort Clone() {
      return new FaultAbort(this);
    }

    /// <summary>Field number for the "http_status" field.</summary>
    public const int HttpStatusFieldNumber = 2;
    /// <summary>
    /// HTTP status code to use to abort the HTTP request.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint HttpStatus {
      get { return errorTypeCase_ == ErrorTypeOneofCase.HttpStatus ? (uint) errorType_ : 0; }
      set {
        errorType_ = value;
        errorTypeCase_ = ErrorTypeOneofCase.HttpStatus;
      }
    }

    /// <summary>Field number for the "percentage" field.</summary>
    public const int PercentageFieldNumber = 3;
    private global::Envoy.Type.FractionalPercent percentage_;
    /// <summary>
    /// The percentage of requests/operations/connections that will be aborted with the error code
    /// provided.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Envoy.Type.FractionalPercent Percentage {
      get { return percentage_; }
      set {
        percentage_ = value;
      }
    }

    private object errorType_;
    /// <summary>Enum of possible cases for the "error_type" oneof.</summary>
    public enum ErrorTypeOneofCase {
      None = 0,
      HttpStatus = 2,
    }
    private ErrorTypeOneofCase errorTypeCase_ = ErrorTypeOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ErrorTypeOneofCase ErrorTypeCase {
      get { return errorTypeCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearErrorType() {
      errorTypeCase_ = ErrorTypeOneofCase.None;
      errorType_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FaultAbort);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FaultAbort other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HttpStatus != other.HttpStatus) return false;
      if (!object.Equals(Percentage, other.Percentage)) return false;
      if (ErrorTypeCase != other.ErrorTypeCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (errorTypeCase_ == ErrorTypeOneofCase.HttpStatus) hash ^= HttpStatus.GetHashCode();
      if (percentage_ != null) hash ^= Percentage.GetHashCode();
      hash ^= (int) errorTypeCase_;
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
      if (errorTypeCase_ == ErrorTypeOneofCase.HttpStatus) {
        output.WriteRawTag(16);
        output.WriteUInt32(HttpStatus);
      }
      if (percentage_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Percentage);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (errorTypeCase_ == ErrorTypeOneofCase.HttpStatus) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HttpStatus);
      }
      if (percentage_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Percentage);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FaultAbort other) {
      if (other == null) {
        return;
      }
      if (other.percentage_ != null) {
        if (percentage_ == null) {
          Percentage = new global::Envoy.Type.FractionalPercent();
        }
        Percentage.MergeFrom(other.Percentage);
      }
      switch (other.ErrorTypeCase) {
        case ErrorTypeOneofCase.HttpStatus:
          HttpStatus = other.HttpStatus;
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
          case 16: {
            HttpStatus = input.ReadUInt32();
            break;
          }
          case 26: {
            if (percentage_ == null) {
              Percentage = new global::Envoy.Type.FractionalPercent();
            }
            input.ReadMessage(Percentage);
            break;
          }
        }
      }
    }

  }

  public sealed partial class HTTPFault : pb::IMessage<HTTPFault> {
    private static readonly pb::MessageParser<HTTPFault> _parser = new pb::MessageParser<HTTPFault>(() => new HTTPFault());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HTTPFault> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Filter.Http.Fault.V2.FaultReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HTTPFault() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HTTPFault(HTTPFault other) : this() {
      delay_ = other.delay_ != null ? other.delay_.Clone() : null;
      abort_ = other.abort_ != null ? other.abort_.Clone() : null;
      upstreamCluster_ = other.upstreamCluster_;
      headers_ = other.headers_.Clone();
      downstreamNodes_ = other.downstreamNodes_.Clone();
      MaxActiveFaults = other.MaxActiveFaults;
      responseRateLimit_ = other.responseRateLimit_ != null ? other.responseRateLimit_.Clone() : null;
      delayPercentRuntime_ = other.delayPercentRuntime_;
      abortPercentRuntime_ = other.abortPercentRuntime_;
      delayDurationRuntime_ = other.delayDurationRuntime_;
      abortHttpStatusRuntime_ = other.abortHttpStatusRuntime_;
      maxActiveFaultsRuntime_ = other.maxActiveFaultsRuntime_;
      responseRateLimitPercentRuntime_ = other.responseRateLimitPercentRuntime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HTTPFault Clone() {
      return new HTTPFault(this);
    }

    /// <summary>Field number for the "delay" field.</summary>
    public const int DelayFieldNumber = 1;
    private global::Envoy.Config.Filter.Fault.V2.FaultDelay delay_;
    /// <summary>
    /// If specified, the filter will inject delays based on the values in the
    /// object.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Envoy.Config.Filter.Fault.V2.FaultDelay Delay {
      get { return delay_; }
      set {
        delay_ = value;
      }
    }

    /// <summary>Field number for the "abort" field.</summary>
    public const int AbortFieldNumber = 2;
    private global::Envoy.Config.Filter.Http.Fault.V2.FaultAbort abort_;
    /// <summary>
    /// If specified, the filter will abort requests based on the values in
    /// the object. At least *abort* or *delay* must be specified.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Envoy.Config.Filter.Http.Fault.V2.FaultAbort Abort {
      get { return abort_; }
      set {
        abort_ = value;
      }
    }

    /// <summary>Field number for the "upstream_cluster" field.</summary>
    public const int UpstreamClusterFieldNumber = 3;
    private string upstreamCluster_ = "";
    /// <summary>
    /// Specifies the name of the (destination) upstream cluster that the
    /// filter should match on. Fault injection will be restricted to requests
    /// bound to the specific upstream cluster.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UpstreamCluster {
      get { return upstreamCluster_; }
      set {
        upstreamCluster_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "headers" field.</summary>
    public const int HeadersFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Envoy.Api.V2.Route.HeaderMatcher> _repeated_headers_codec
        = pb::FieldCodec.ForMessage(34, global::Envoy.Api.V2.Route.HeaderMatcher.Parser);
    private readonly pbc::RepeatedField<global::Envoy.Api.V2.Route.HeaderMatcher> headers_ = new pbc::RepeatedField<global::Envoy.Api.V2.Route.HeaderMatcher>();
    /// <summary>
    /// Specifies a set of headers that the filter should match on. The fault
    /// injection filter can be applied selectively to requests that match a set of
    /// headers specified in the fault filter config. The chances of actual fault
    /// injection further depend on the value of the :ref:`percentage
    /// &lt;envoy_api_field_config.filter.http.fault.v2.FaultAbort.percentage>` field.
    /// The filter will check the request's headers against all the specified
    /// headers in the filter config. A match will happen if all the headers in the
    /// config are present in the request with the same values (or based on
    /// presence if the *value* field is not in the config).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Envoy.Api.V2.Route.HeaderMatcher> Headers {
      get { return headers_; }
    }

    /// <summary>Field number for the "downstream_nodes" field.</summary>
    public const int DownstreamNodesFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _repeated_downstreamNodes_codec
        = pb::FieldCodec.ForString(42);
    private readonly pbc::RepeatedField<string> downstreamNodes_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Faults are injected for the specified list of downstream hosts. If this
    /// setting is not set, faults are injected for all downstream nodes.
    /// Downstream node name is taken from :ref:`the HTTP
    /// x-envoy-downstream-service-node
    /// &lt;config_http_conn_man_headers_downstream-service-node>` header and compared
    /// against downstream_nodes list.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> DownstreamNodes {
      get { return downstreamNodes_; }
    }

    /// <summary>Field number for the "max_active_faults" field.</summary>
    public const int MaxActiveFaultsFieldNumber = 6;
    private static readonly pb::FieldCodec<uint?> _single_maxActiveFaults_codec = pb::FieldCodec.ForStructWrapper<uint>(50);
    private uint? maxActiveFaults_;
    /// <summary>
    /// The maximum number of faults that can be active at a single time via the configured fault
    /// filter. Note that because this setting can be overridden at the route level, it's possible
    /// for the number of active faults to be greater than this value (if injected via a different
    /// route). If not specified, defaults to unlimited. This setting can be overridden via
    /// `runtime &lt;config_http_filters_fault_injection_runtime>` and any faults that are not injected
    /// due to overflow will be indicated via the `faults_overflow
    /// &lt;config_http_filters_fault_injection_stats>` stat.
    ///
    /// .. attention::
    ///   Like other :ref:`circuit breakers &lt;arch_overview_circuit_break>` in Envoy, this is a fuzzy
    ///   limit. It's possible for the number of active faults to rise slightly above the configured
    ///   amount due to the implementation details.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint? MaxActiveFaults {
      get { return maxActiveFaults_; }
      set {
        maxActiveFaults_ = value;
      }
    }


    /// <summary>Field number for the "response_rate_limit" field.</summary>
    public const int ResponseRateLimitFieldNumber = 7;
    private global::Envoy.Config.Filter.Fault.V2.FaultRateLimit responseRateLimit_;
    /// <summary>
    /// The response rate limit to be applied to the response body of the stream. When configured,
    /// the percentage can be overridden by the :ref:`fault.http.rate_limit.response_percent
    /// &lt;config_http_filters_fault_injection_runtime>` runtime key.
    ///
    /// .. attention::
    ///  This is a per-stream limit versus a connection level limit. This means that concurrent streams
    ///  will each get an independent limit.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Envoy.Config.Filter.Fault.V2.FaultRateLimit ResponseRateLimit {
      get { return responseRateLimit_; }
      set {
        responseRateLimit_ = value;
      }
    }

    /// <summary>Field number for the "delay_percent_runtime" field.</summary>
    public const int DelayPercentRuntimeFieldNumber = 8;
    private string delayPercentRuntime_ = "";
    /// <summary>
    /// The runtime key to override the :ref:`default &lt;config_http_filters_fault_injection_runtime>`
    /// runtime. The default is: fault.http.delay.fixed_delay_percent
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DelayPercentRuntime {
      get { return delayPercentRuntime_; }
      set {
        delayPercentRuntime_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "abort_percent_runtime" field.</summary>
    public const int AbortPercentRuntimeFieldNumber = 9;
    private string abortPercentRuntime_ = "";
    /// <summary>
    /// The runtime key to override the :ref:`default &lt;config_http_filters_fault_injection_runtime>`
    /// runtime. The default is: fault.http.abort.abort_percent
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AbortPercentRuntime {
      get { return abortPercentRuntime_; }
      set {
        abortPercentRuntime_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "delay_duration_runtime" field.</summary>
    public const int DelayDurationRuntimeFieldNumber = 10;
    private string delayDurationRuntime_ = "";
    /// <summary>
    /// The runtime key to override the :ref:`default &lt;config_http_filters_fault_injection_runtime>`
    /// runtime. The default is: fault.http.delay.fixed_duration_ms
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DelayDurationRuntime {
      get { return delayDurationRuntime_; }
      set {
        delayDurationRuntime_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "abort_http_status_runtime" field.</summary>
    public const int AbortHttpStatusRuntimeFieldNumber = 11;
    private string abortHttpStatusRuntime_ = "";
    /// <summary>
    /// The runtime key to override the :ref:`default &lt;config_http_filters_fault_injection_runtime>`
    /// runtime. The default is: fault.http.abort.http_status
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AbortHttpStatusRuntime {
      get { return abortHttpStatusRuntime_; }
      set {
        abortHttpStatusRuntime_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "max_active_faults_runtime" field.</summary>
    public const int MaxActiveFaultsRuntimeFieldNumber = 12;
    private string maxActiveFaultsRuntime_ = "";
    /// <summary>
    /// The runtime key to override the :ref:`default &lt;config_http_filters_fault_injection_runtime>`
    /// runtime. The default is: fault.http.max_active_faults
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MaxActiveFaultsRuntime {
      get { return maxActiveFaultsRuntime_; }
      set {
        maxActiveFaultsRuntime_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "response_rate_limit_percent_runtime" field.</summary>
    public const int ResponseRateLimitPercentRuntimeFieldNumber = 13;
    private string responseRateLimitPercentRuntime_ = "";
    /// <summary>
    /// The runtime key to override the :ref:`default &lt;config_http_filters_fault_injection_runtime>`
    /// runtime. The default is: fault.http.rate_limit.response_percent
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResponseRateLimitPercentRuntime {
      get { return responseRateLimitPercentRuntime_; }
      set {
        responseRateLimitPercentRuntime_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as HTTPFault);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HTTPFault other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Delay, other.Delay)) return false;
      if (!object.Equals(Abort, other.Abort)) return false;
      if (UpstreamCluster != other.UpstreamCluster) return false;
      if(!headers_.Equals(other.headers_)) return false;
      if(!downstreamNodes_.Equals(other.downstreamNodes_)) return false;
      if (MaxActiveFaults != other.MaxActiveFaults) return false;
      if (!object.Equals(ResponseRateLimit, other.ResponseRateLimit)) return false;
      if (DelayPercentRuntime != other.DelayPercentRuntime) return false;
      if (AbortPercentRuntime != other.AbortPercentRuntime) return false;
      if (DelayDurationRuntime != other.DelayDurationRuntime) return false;
      if (AbortHttpStatusRuntime != other.AbortHttpStatusRuntime) return false;
      if (MaxActiveFaultsRuntime != other.MaxActiveFaultsRuntime) return false;
      if (ResponseRateLimitPercentRuntime != other.ResponseRateLimitPercentRuntime) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (delay_ != null) hash ^= Delay.GetHashCode();
      if (abort_ != null) hash ^= Abort.GetHashCode();
      if (UpstreamCluster.Length != 0) hash ^= UpstreamCluster.GetHashCode();
      hash ^= headers_.GetHashCode();
      hash ^= downstreamNodes_.GetHashCode();
      if (maxActiveFaults_ != null) hash ^= MaxActiveFaults.GetHashCode();
      if (responseRateLimit_ != null) hash ^= ResponseRateLimit.GetHashCode();
      if (DelayPercentRuntime.Length != 0) hash ^= DelayPercentRuntime.GetHashCode();
      if (AbortPercentRuntime.Length != 0) hash ^= AbortPercentRuntime.GetHashCode();
      if (DelayDurationRuntime.Length != 0) hash ^= DelayDurationRuntime.GetHashCode();
      if (AbortHttpStatusRuntime.Length != 0) hash ^= AbortHttpStatusRuntime.GetHashCode();
      if (MaxActiveFaultsRuntime.Length != 0) hash ^= MaxActiveFaultsRuntime.GetHashCode();
      if (ResponseRateLimitPercentRuntime.Length != 0) hash ^= ResponseRateLimitPercentRuntime.GetHashCode();
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
      if (delay_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Delay);
      }
      if (abort_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Abort);
      }
      if (UpstreamCluster.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(UpstreamCluster);
      }
      headers_.WriteTo(output, _repeated_headers_codec);
      downstreamNodes_.WriteTo(output, _repeated_downstreamNodes_codec);
      if (maxActiveFaults_ != null) {
        _single_maxActiveFaults_codec.WriteTagAndValue(output, MaxActiveFaults);
      }
      if (responseRateLimit_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(ResponseRateLimit);
      }
      if (DelayPercentRuntime.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(DelayPercentRuntime);
      }
      if (AbortPercentRuntime.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(AbortPercentRuntime);
      }
      if (DelayDurationRuntime.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(DelayDurationRuntime);
      }
      if (AbortHttpStatusRuntime.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(AbortHttpStatusRuntime);
      }
      if (MaxActiveFaultsRuntime.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(MaxActiveFaultsRuntime);
      }
      if (ResponseRateLimitPercentRuntime.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(ResponseRateLimitPercentRuntime);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (delay_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Delay);
      }
      if (abort_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Abort);
      }
      if (UpstreamCluster.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UpstreamCluster);
      }
      size += headers_.CalculateSize(_repeated_headers_codec);
      size += downstreamNodes_.CalculateSize(_repeated_downstreamNodes_codec);
      if (maxActiveFaults_ != null) {
        size += _single_maxActiveFaults_codec.CalculateSizeWithTag(MaxActiveFaults);
      }
      if (responseRateLimit_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ResponseRateLimit);
      }
      if (DelayPercentRuntime.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DelayPercentRuntime);
      }
      if (AbortPercentRuntime.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AbortPercentRuntime);
      }
      if (DelayDurationRuntime.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DelayDurationRuntime);
      }
      if (AbortHttpStatusRuntime.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AbortHttpStatusRuntime);
      }
      if (MaxActiveFaultsRuntime.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MaxActiveFaultsRuntime);
      }
      if (ResponseRateLimitPercentRuntime.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResponseRateLimitPercentRuntime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(HTTPFault other) {
      if (other == null) {
        return;
      }
      if (other.delay_ != null) {
        if (delay_ == null) {
          Delay = new global::Envoy.Config.Filter.Fault.V2.FaultDelay();
        }
        Delay.MergeFrom(other.Delay);
      }
      if (other.abort_ != null) {
        if (abort_ == null) {
          Abort = new global::Envoy.Config.Filter.Http.Fault.V2.FaultAbort();
        }
        Abort.MergeFrom(other.Abort);
      }
      if (other.UpstreamCluster.Length != 0) {
        UpstreamCluster = other.UpstreamCluster;
      }
      headers_.Add(other.headers_);
      downstreamNodes_.Add(other.downstreamNodes_);
      if (other.maxActiveFaults_ != null) {
        if (maxActiveFaults_ == null || other.MaxActiveFaults != 0) {
          MaxActiveFaults = other.MaxActiveFaults;
        }
      }
      if (other.responseRateLimit_ != null) {
        if (responseRateLimit_ == null) {
          ResponseRateLimit = new global::Envoy.Config.Filter.Fault.V2.FaultRateLimit();
        }
        ResponseRateLimit.MergeFrom(other.ResponseRateLimit);
      }
      if (other.DelayPercentRuntime.Length != 0) {
        DelayPercentRuntime = other.DelayPercentRuntime;
      }
      if (other.AbortPercentRuntime.Length != 0) {
        AbortPercentRuntime = other.AbortPercentRuntime;
      }
      if (other.DelayDurationRuntime.Length != 0) {
        DelayDurationRuntime = other.DelayDurationRuntime;
      }
      if (other.AbortHttpStatusRuntime.Length != 0) {
        AbortHttpStatusRuntime = other.AbortHttpStatusRuntime;
      }
      if (other.MaxActiveFaultsRuntime.Length != 0) {
        MaxActiveFaultsRuntime = other.MaxActiveFaultsRuntime;
      }
      if (other.ResponseRateLimitPercentRuntime.Length != 0) {
        ResponseRateLimitPercentRuntime = other.ResponseRateLimitPercentRuntime;
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
            if (delay_ == null) {
              Delay = new global::Envoy.Config.Filter.Fault.V2.FaultDelay();
            }
            input.ReadMessage(Delay);
            break;
          }
          case 18: {
            if (abort_ == null) {
              Abort = new global::Envoy.Config.Filter.Http.Fault.V2.FaultAbort();
            }
            input.ReadMessage(Abort);
            break;
          }
          case 26: {
            UpstreamCluster = input.ReadString();
            break;
          }
          case 34: {
            headers_.AddEntriesFrom(input, _repeated_headers_codec);
            break;
          }
          case 42: {
            downstreamNodes_.AddEntriesFrom(input, _repeated_downstreamNodes_codec);
            break;
          }
          case 50: {
            uint? value = _single_maxActiveFaults_codec.Read(input);
            if (maxActiveFaults_ == null || value != 0) {
              MaxActiveFaults = value;
            }
            break;
          }
          case 58: {
            if (responseRateLimit_ == null) {
              ResponseRateLimit = new global::Envoy.Config.Filter.Fault.V2.FaultRateLimit();
            }
            input.ReadMessage(ResponseRateLimit);
            break;
          }
          case 66: {
            DelayPercentRuntime = input.ReadString();
            break;
          }
          case 74: {
            AbortPercentRuntime = input.ReadString();
            break;
          }
          case 82: {
            DelayDurationRuntime = input.ReadString();
            break;
          }
          case 90: {
            AbortHttpStatusRuntime = input.ReadString();
            break;
          }
          case 98: {
            MaxActiveFaultsRuntime = input.ReadString();
            break;
          }
          case 106: {
            ResponseRateLimitPercentRuntime = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
