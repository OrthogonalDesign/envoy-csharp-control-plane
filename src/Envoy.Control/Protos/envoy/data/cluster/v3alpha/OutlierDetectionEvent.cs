// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/data/cluster/v3alpha/outlier_detection_event.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Data.Cluster.V3Alpha {

  /// <summary>Holder for reflection information generated from envoy/data/cluster/v3alpha/outlier_detection_event.proto</summary>
  public static partial class OutlierDetectionEventReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/data/cluster/v3alpha/outlier_detection_event.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OutlierDetectionEventReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjhlbnZveS9kYXRhL2NsdXN0ZXIvdjNhbHBoYS9vdXRsaWVyX2RldGVjdGlv",
            "bl9ldmVudC5wcm90bxIaZW52b3kuZGF0YS5jbHVzdGVyLnYzYWxwaGEaH2dv",
            "b2dsZS9wcm90b2J1Zi90aW1lc3RhbXAucHJvdG8aHmdvb2dsZS9wcm90b2J1",
            "Zi93cmFwcGVycy5wcm90bxoXdmFsaWRhdGUvdmFsaWRhdGUucHJvdG8iuwQK",
            "FU91dGxpZXJEZXRlY3Rpb25FdmVudBJJCgR0eXBlGAEgASgOMi8uZW52b3ku",
            "ZGF0YS5jbHVzdGVyLnYzYWxwaGEuT3V0bGllckVqZWN0aW9uVHlwZUIKuunA",
            "AwWCAQIQARItCgl0aW1lc3RhbXAYAiABKAsyGi5nb29nbGUucHJvdG9idWYu",
            "VGltZXN0YW1wEjwKFnNlY3Nfc2luY2VfbGFzdF9hY3Rpb24YAyABKAsyHC5n",
            "b29nbGUucHJvdG9idWYuVUludDY0VmFsdWUSHwoMY2x1c3Rlcl9uYW1lGAQg",
            "ASgJQgm66cADBHICIAESHwoMdXBzdHJlYW1fdXJsGAUgASgJQgm66cADBHIC",
            "IAESPgoGYWN0aW9uGAYgASgOMiIuZW52b3kuZGF0YS5jbHVzdGVyLnYzYWxw",
            "aGEuQWN0aW9uQgq66cADBYIBAhABEhUKDW51bV9lamVjdGlvbnMYByABKA0S",
            "EAoIZW5mb3JjZWQYCCABKAgSVwoYZWplY3Rfc3VjY2Vzc19yYXRlX2V2ZW50",
            "GAkgASgLMjMuZW52b3kuZGF0YS5jbHVzdGVyLnYzYWxwaGEuT3V0bGllckVq",
            "ZWN0U3VjY2Vzc1JhdGVIABJWChdlamVjdF9jb25zZWN1dGl2ZV9ldmVudBgK",
            "IAEoCzIzLmVudm95LmRhdGEuY2x1c3Rlci52M2FscGhhLk91dGxpZXJFamVj",
            "dENvbnNlY3V0aXZlSABCDgoFZXZlbnQSBbjpwAMBIqwBChdPdXRsaWVyRWpl",
            "Y3RTdWNjZXNzUmF0ZRIkChFob3N0X3N1Y2Nlc3NfcmF0ZRgBIAEoDUIJuunA",
            "AwQqAhhkEi8KHGNsdXN0ZXJfYXZlcmFnZV9zdWNjZXNzX3JhdGUYAiABKA1C",
            "CbrpwAMEKgIYZBI6CidjbHVzdGVyX3N1Y2Nlc3NfcmF0ZV9lamVjdGlvbl90",
            "aHJlc2hvbGQYAyABKA1CCbrpwAMEKgIYZCIZChdPdXRsaWVyRWplY3RDb25z",
            "ZWN1dGl2ZSqiAQoTT3V0bGllckVqZWN0aW9uVHlwZRITCg9DT05TRUNVVElW",
            "RV81WFgQABIfChtDT05TRUNVVElWRV9HQVRFV0FZX0ZBSUxVUkUQARIQCgxT",
            "VUNDRVNTX1JBVEUQAhIkCiBDT05TRUNVVElWRV9MT0NBTF9PUklHSU5fRkFJ",
            "TFVSRRADEh0KGVNVQ0NFU1NfUkFURV9MT0NBTF9PUklHSU4QBCogCgZBY3Rp",
            "b24SCQoFRUpFQ1QQABILCgdVTkVKRUNUEAFCSAooaW8uZW52b3lwcm94eS5l",
            "bnZveS5kYXRhLmNsdXN0ZXIudjNhbHBoYUIaT3V0bGllckRldGVjdGlvbkV2",
            "ZW50UHJvdG9QAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Envoy.Data.Cluster.V3Alpha.OutlierEjectionType), typeof(global::Envoy.Data.Cluster.V3Alpha.Action), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Data.Cluster.V3Alpha.OutlierDetectionEvent), global::Envoy.Data.Cluster.V3Alpha.OutlierDetectionEvent.Parser, new[]{ "Type", "Timestamp", "SecsSinceLastAction", "ClusterName", "UpstreamUrl", "Action", "NumEjections", "Enforced", "EjectSuccessRateEvent", "EjectConsecutiveEvent" }, new[]{ "Event" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Data.Cluster.V3Alpha.OutlierEjectSuccessRate), global::Envoy.Data.Cluster.V3Alpha.OutlierEjectSuccessRate.Parser, new[]{ "HostSuccessRate", "ClusterAverageSuccessRate", "ClusterSuccessRateEjectionThreshold" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Data.Cluster.V3Alpha.OutlierEjectConsecutive), global::Envoy.Data.Cluster.V3Alpha.OutlierEjectConsecutive.Parser, null, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// Type of ejection that took place
  /// </summary>
  public enum OutlierEjectionType {
    /// <summary>
    /// In case upstream host returns certain number of consecutive 5xx.
    /// If
    /// :ref:`outlier_detection.split_external_local_origin_errors&lt;envoy_api_field_cluster.OutlierDetection.split_external_local_origin_errors>`
    /// is *false*, all type of errors are treated as HTTP 5xx errors.
    /// See :ref:`Cluster outlier detection &lt;arch_overview_outlier_detection>` documentation for
    /// details.
    /// </summary>
    [pbr::OriginalName("CONSECUTIVE_5XX")] Consecutive5Xx = 0,
    /// <summary>
    /// In case upstream host returns certain number of consecutive gateway errors
    /// </summary>
    [pbr::OriginalName("CONSECUTIVE_GATEWAY_FAILURE")] ConsecutiveGatewayFailure = 1,
    /// <summary>
    /// Runs over aggregated success rate statistics from every host in cluster
    /// and selects hosts for which ratio of successful replies deviates from other hosts
    /// in the cluster.
    /// If
    /// :ref:`outlier_detection.split_external_local_origin_errors&lt;envoy_api_field_cluster.OutlierDetection.split_external_local_origin_errors>`
    /// is *false*, all errors (externally and locally generated) are used to calculate success rate
    /// statistics. See :ref:`Cluster outlier detection &lt;arch_overview_outlier_detection>`
    /// documentation for details.
    /// </summary>
    [pbr::OriginalName("SUCCESS_RATE")] SuccessRate = 2,
    /// <summary>
    /// Consecutive local origin failures: Connection failures, resets, timeouts, etc
    /// This type of ejection happens only when
    /// :ref:`outlier_detection.split_external_local_origin_errors&lt;envoy_api_field_cluster.OutlierDetection.split_external_local_origin_errors>`
    /// is set to *true*.
    /// See :ref:`Cluster outlier detection &lt;arch_overview_outlier_detection>` documentation for
    /// </summary>
    [pbr::OriginalName("CONSECUTIVE_LOCAL_ORIGIN_FAILURE")] ConsecutiveLocalOriginFailure = 3,
    /// <summary>
    /// Runs over aggregated success rate statistics for local origin failures
    /// for all hosts in the cluster and selects hosts for which success rate deviates from other
    /// hosts in the cluster. This type of ejection happens only when
    /// :ref:`outlier_detection.split_external_local_origin_errors&lt;envoy_api_field_cluster.OutlierDetection.split_external_local_origin_errors>`
    /// is set to *true*.
    /// See :ref:`Cluster outlier detection &lt;arch_overview_outlier_detection>` documentation for
    /// </summary>
    [pbr::OriginalName("SUCCESS_RATE_LOCAL_ORIGIN")] SuccessRateLocalOrigin = 4,
  }

  /// <summary>
  /// Represents possible action applied to upstream host
  /// </summary>
  public enum Action {
    /// <summary>
    /// In case host was excluded from service
    /// </summary>
    [pbr::OriginalName("EJECT")] Eject = 0,
    /// <summary>
    /// In case host was brought back into service
    /// </summary>
    [pbr::OriginalName("UNEJECT")] Uneject = 1,
  }

  #endregion

  #region Messages
  public sealed partial class OutlierDetectionEvent : pb::IMessage<OutlierDetectionEvent> {
    private static readonly pb::MessageParser<OutlierDetectionEvent> _parser = new pb::MessageParser<OutlierDetectionEvent>(() => new OutlierDetectionEvent());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OutlierDetectionEvent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Data.Cluster.V3Alpha.OutlierDetectionEventReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OutlierDetectionEvent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OutlierDetectionEvent(OutlierDetectionEvent other) : this() {
      type_ = other.type_;
      timestamp_ = other.timestamp_ != null ? other.timestamp_.Clone() : null;
      SecsSinceLastAction = other.SecsSinceLastAction;
      clusterName_ = other.clusterName_;
      upstreamUrl_ = other.upstreamUrl_;
      action_ = other.action_;
      numEjections_ = other.numEjections_;
      enforced_ = other.enforced_;
      switch (other.EventCase) {
        case EventOneofCase.EjectSuccessRateEvent:
          EjectSuccessRateEvent = other.EjectSuccessRateEvent.Clone();
          break;
        case EventOneofCase.EjectConsecutiveEvent:
          EjectConsecutiveEvent = other.EjectConsecutiveEvent.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OutlierDetectionEvent Clone() {
      return new OutlierDetectionEvent(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private global::Envoy.Data.Cluster.V3Alpha.OutlierEjectionType type_ = global::Envoy.Data.Cluster.V3Alpha.OutlierEjectionType.Consecutive5Xx;
    /// <summary>
    /// In case of eject represents type of ejection that took place.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Envoy.Data.Cluster.V3Alpha.OutlierEjectionType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "timestamp" field.</summary>
    public const int TimestampFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp timestamp_;
    /// <summary>
    /// Timestamp for event.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp Timestamp {
      get { return timestamp_; }
      set {
        timestamp_ = value;
      }
    }

    /// <summary>Field number for the "secs_since_last_action" field.</summary>
    public const int SecsSinceLastActionFieldNumber = 3;
    private static readonly pb::FieldCodec<ulong?> _single_secsSinceLastAction_codec = pb::FieldCodec.ForStructWrapper<ulong>(26);
    private ulong? secsSinceLastAction_;
    /// <summary>
    /// The time in seconds since the last action (either an ejection or unejection) took place.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong? SecsSinceLastAction {
      get { return secsSinceLastAction_; }
      set {
        secsSinceLastAction_ = value;
      }
    }


    /// <summary>Field number for the "cluster_name" field.</summary>
    public const int ClusterNameFieldNumber = 4;
    private string clusterName_ = "";
    /// <summary>
    /// The :ref:`cluster &lt;envoy_api_msg_Cluster>` that owns the ejected host.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ClusterName {
      get { return clusterName_; }
      set {
        clusterName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "upstream_url" field.</summary>
    public const int UpstreamUrlFieldNumber = 5;
    private string upstreamUrl_ = "";
    /// <summary>
    /// The URL of the ejected host. E.g., ``tcp://1.2.3.4:80``.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UpstreamUrl {
      get { return upstreamUrl_; }
      set {
        upstreamUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "action" field.</summary>
    public const int ActionFieldNumber = 6;
    private global::Envoy.Data.Cluster.V3Alpha.Action action_ = global::Envoy.Data.Cluster.V3Alpha.Action.Eject;
    /// <summary>
    /// The action that took place.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Envoy.Data.Cluster.V3Alpha.Action Action {
      get { return action_; }
      set {
        action_ = value;
      }
    }

    /// <summary>Field number for the "num_ejections" field.</summary>
    public const int NumEjectionsFieldNumber = 7;
    private uint numEjections_;
    /// <summary>
    /// If ``action`` is ``eject``, specifies the number of times the host has been ejected (local to
    /// that Envoy and gets reset if the host gets removed from the upstream cluster for any reason and
    /// then re-added).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint NumEjections {
      get { return numEjections_; }
      set {
        numEjections_ = value;
      }
    }

    /// <summary>Field number for the "enforced" field.</summary>
    public const int EnforcedFieldNumber = 8;
    private bool enforced_;
    /// <summary>
    /// If ``action`` is ``eject``, specifies if the ejection was enforced. ``true`` means the host was
    /// ejected. ``false`` means the event was logged but the host was not actually ejected.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Enforced {
      get { return enforced_; }
      set {
        enforced_ = value;
      }
    }

    /// <summary>Field number for the "eject_success_rate_event" field.</summary>
    public const int EjectSuccessRateEventFieldNumber = 9;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Envoy.Data.Cluster.V3Alpha.OutlierEjectSuccessRate EjectSuccessRateEvent {
      get { return eventCase_ == EventOneofCase.EjectSuccessRateEvent ? (global::Envoy.Data.Cluster.V3Alpha.OutlierEjectSuccessRate) event_ : null; }
      set {
        event_ = value;
        eventCase_ = value == null ? EventOneofCase.None : EventOneofCase.EjectSuccessRateEvent;
      }
    }

    /// <summary>Field number for the "eject_consecutive_event" field.</summary>
    public const int EjectConsecutiveEventFieldNumber = 10;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Envoy.Data.Cluster.V3Alpha.OutlierEjectConsecutive EjectConsecutiveEvent {
      get { return eventCase_ == EventOneofCase.EjectConsecutiveEvent ? (global::Envoy.Data.Cluster.V3Alpha.OutlierEjectConsecutive) event_ : null; }
      set {
        event_ = value;
        eventCase_ = value == null ? EventOneofCase.None : EventOneofCase.EjectConsecutiveEvent;
      }
    }

    private object event_;
    /// <summary>Enum of possible cases for the "event" oneof.</summary>
    public enum EventOneofCase {
      None = 0,
      EjectSuccessRateEvent = 9,
      EjectConsecutiveEvent = 10,
    }
    private EventOneofCase eventCase_ = EventOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EventOneofCase EventCase {
      get { return eventCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearEvent() {
      eventCase_ = EventOneofCase.None;
      event_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as OutlierDetectionEvent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(OutlierDetectionEvent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (!object.Equals(Timestamp, other.Timestamp)) return false;
      if (SecsSinceLastAction != other.SecsSinceLastAction) return false;
      if (ClusterName != other.ClusterName) return false;
      if (UpstreamUrl != other.UpstreamUrl) return false;
      if (Action != other.Action) return false;
      if (NumEjections != other.NumEjections) return false;
      if (Enforced != other.Enforced) return false;
      if (!object.Equals(EjectSuccessRateEvent, other.EjectSuccessRateEvent)) return false;
      if (!object.Equals(EjectConsecutiveEvent, other.EjectConsecutiveEvent)) return false;
      if (EventCase != other.EventCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Type != global::Envoy.Data.Cluster.V3Alpha.OutlierEjectionType.Consecutive5Xx) hash ^= Type.GetHashCode();
      if (timestamp_ != null) hash ^= Timestamp.GetHashCode();
      if (secsSinceLastAction_ != null) hash ^= SecsSinceLastAction.GetHashCode();
      if (ClusterName.Length != 0) hash ^= ClusterName.GetHashCode();
      if (UpstreamUrl.Length != 0) hash ^= UpstreamUrl.GetHashCode();
      if (Action != global::Envoy.Data.Cluster.V3Alpha.Action.Eject) hash ^= Action.GetHashCode();
      if (NumEjections != 0) hash ^= NumEjections.GetHashCode();
      if (Enforced != false) hash ^= Enforced.GetHashCode();
      if (eventCase_ == EventOneofCase.EjectSuccessRateEvent) hash ^= EjectSuccessRateEvent.GetHashCode();
      if (eventCase_ == EventOneofCase.EjectConsecutiveEvent) hash ^= EjectConsecutiveEvent.GetHashCode();
      hash ^= (int) eventCase_;
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
      if (Type != global::Envoy.Data.Cluster.V3Alpha.OutlierEjectionType.Consecutive5Xx) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (timestamp_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Timestamp);
      }
      if (secsSinceLastAction_ != null) {
        _single_secsSinceLastAction_codec.WriteTagAndValue(output, SecsSinceLastAction);
      }
      if (ClusterName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ClusterName);
      }
      if (UpstreamUrl.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(UpstreamUrl);
      }
      if (Action != global::Envoy.Data.Cluster.V3Alpha.Action.Eject) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Action);
      }
      if (NumEjections != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(NumEjections);
      }
      if (Enforced != false) {
        output.WriteRawTag(64);
        output.WriteBool(Enforced);
      }
      if (eventCase_ == EventOneofCase.EjectSuccessRateEvent) {
        output.WriteRawTag(74);
        output.WriteMessage(EjectSuccessRateEvent);
      }
      if (eventCase_ == EventOneofCase.EjectConsecutiveEvent) {
        output.WriteRawTag(82);
        output.WriteMessage(EjectConsecutiveEvent);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Type != global::Envoy.Data.Cluster.V3Alpha.OutlierEjectionType.Consecutive5Xx) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (timestamp_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Timestamp);
      }
      if (secsSinceLastAction_ != null) {
        size += _single_secsSinceLastAction_codec.CalculateSizeWithTag(SecsSinceLastAction);
      }
      if (ClusterName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClusterName);
      }
      if (UpstreamUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UpstreamUrl);
      }
      if (Action != global::Envoy.Data.Cluster.V3Alpha.Action.Eject) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Action);
      }
      if (NumEjections != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NumEjections);
      }
      if (Enforced != false) {
        size += 1 + 1;
      }
      if (eventCase_ == EventOneofCase.EjectSuccessRateEvent) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EjectSuccessRateEvent);
      }
      if (eventCase_ == EventOneofCase.EjectConsecutiveEvent) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EjectConsecutiveEvent);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(OutlierDetectionEvent other) {
      if (other == null) {
        return;
      }
      if (other.Type != global::Envoy.Data.Cluster.V3Alpha.OutlierEjectionType.Consecutive5Xx) {
        Type = other.Type;
      }
      if (other.timestamp_ != null) {
        if (timestamp_ == null) {
          Timestamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        Timestamp.MergeFrom(other.Timestamp);
      }
      if (other.secsSinceLastAction_ != null) {
        if (secsSinceLastAction_ == null || other.SecsSinceLastAction != 0UL) {
          SecsSinceLastAction = other.SecsSinceLastAction;
        }
      }
      if (other.ClusterName.Length != 0) {
        ClusterName = other.ClusterName;
      }
      if (other.UpstreamUrl.Length != 0) {
        UpstreamUrl = other.UpstreamUrl;
      }
      if (other.Action != global::Envoy.Data.Cluster.V3Alpha.Action.Eject) {
        Action = other.Action;
      }
      if (other.NumEjections != 0) {
        NumEjections = other.NumEjections;
      }
      if (other.Enforced != false) {
        Enforced = other.Enforced;
      }
      switch (other.EventCase) {
        case EventOneofCase.EjectSuccessRateEvent:
          if (EjectSuccessRateEvent == null) {
            EjectSuccessRateEvent = new global::Envoy.Data.Cluster.V3Alpha.OutlierEjectSuccessRate();
          }
          EjectSuccessRateEvent.MergeFrom(other.EjectSuccessRateEvent);
          break;
        case EventOneofCase.EjectConsecutiveEvent:
          if (EjectConsecutiveEvent == null) {
            EjectConsecutiveEvent = new global::Envoy.Data.Cluster.V3Alpha.OutlierEjectConsecutive();
          }
          EjectConsecutiveEvent.MergeFrom(other.EjectConsecutiveEvent);
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
            Type = (global::Envoy.Data.Cluster.V3Alpha.OutlierEjectionType) input.ReadEnum();
            break;
          }
          case 18: {
            if (timestamp_ == null) {
              Timestamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(Timestamp);
            break;
          }
          case 26: {
            ulong? value = _single_secsSinceLastAction_codec.Read(input);
            if (secsSinceLastAction_ == null || value != 0UL) {
              SecsSinceLastAction = value;
            }
            break;
          }
          case 34: {
            ClusterName = input.ReadString();
            break;
          }
          case 42: {
            UpstreamUrl = input.ReadString();
            break;
          }
          case 48: {
            Action = (global::Envoy.Data.Cluster.V3Alpha.Action) input.ReadEnum();
            break;
          }
          case 56: {
            NumEjections = input.ReadUInt32();
            break;
          }
          case 64: {
            Enforced = input.ReadBool();
            break;
          }
          case 74: {
            global::Envoy.Data.Cluster.V3Alpha.OutlierEjectSuccessRate subBuilder = new global::Envoy.Data.Cluster.V3Alpha.OutlierEjectSuccessRate();
            if (eventCase_ == EventOneofCase.EjectSuccessRateEvent) {
              subBuilder.MergeFrom(EjectSuccessRateEvent);
            }
            input.ReadMessage(subBuilder);
            EjectSuccessRateEvent = subBuilder;
            break;
          }
          case 82: {
            global::Envoy.Data.Cluster.V3Alpha.OutlierEjectConsecutive subBuilder = new global::Envoy.Data.Cluster.V3Alpha.OutlierEjectConsecutive();
            if (eventCase_ == EventOneofCase.EjectConsecutiveEvent) {
              subBuilder.MergeFrom(EjectConsecutiveEvent);
            }
            input.ReadMessage(subBuilder);
            EjectConsecutiveEvent = subBuilder;
            break;
          }
        }
      }
    }

  }

  public sealed partial class OutlierEjectSuccessRate : pb::IMessage<OutlierEjectSuccessRate> {
    private static readonly pb::MessageParser<OutlierEjectSuccessRate> _parser = new pb::MessageParser<OutlierEjectSuccessRate>(() => new OutlierEjectSuccessRate());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OutlierEjectSuccessRate> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Data.Cluster.V3Alpha.OutlierDetectionEventReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OutlierEjectSuccessRate() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OutlierEjectSuccessRate(OutlierEjectSuccessRate other) : this() {
      hostSuccessRate_ = other.hostSuccessRate_;
      clusterAverageSuccessRate_ = other.clusterAverageSuccessRate_;
      clusterSuccessRateEjectionThreshold_ = other.clusterSuccessRateEjectionThreshold_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OutlierEjectSuccessRate Clone() {
      return new OutlierEjectSuccessRate(this);
    }

    /// <summary>Field number for the "host_success_rate" field.</summary>
    public const int HostSuccessRateFieldNumber = 1;
    private uint hostSuccessRate_;
    /// <summary>
    /// Host’s success rate at the time of the ejection event on a 0-100 range.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint HostSuccessRate {
      get { return hostSuccessRate_; }
      set {
        hostSuccessRate_ = value;
      }
    }

    /// <summary>Field number for the "cluster_average_success_rate" field.</summary>
    public const int ClusterAverageSuccessRateFieldNumber = 2;
    private uint clusterAverageSuccessRate_;
    /// <summary>
    /// Average success rate of the hosts in the cluster at the time of the ejection event on a 0-100
    /// range.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint ClusterAverageSuccessRate {
      get { return clusterAverageSuccessRate_; }
      set {
        clusterAverageSuccessRate_ = value;
      }
    }

    /// <summary>Field number for the "cluster_success_rate_ejection_threshold" field.</summary>
    public const int ClusterSuccessRateEjectionThresholdFieldNumber = 3;
    private uint clusterSuccessRateEjectionThreshold_;
    /// <summary>
    /// Success rate ejection threshold at the time of the ejection event.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint ClusterSuccessRateEjectionThreshold {
      get { return clusterSuccessRateEjectionThreshold_; }
      set {
        clusterSuccessRateEjectionThreshold_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as OutlierEjectSuccessRate);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(OutlierEjectSuccessRate other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HostSuccessRate != other.HostSuccessRate) return false;
      if (ClusterAverageSuccessRate != other.ClusterAverageSuccessRate) return false;
      if (ClusterSuccessRateEjectionThreshold != other.ClusterSuccessRateEjectionThreshold) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (HostSuccessRate != 0) hash ^= HostSuccessRate.GetHashCode();
      if (ClusterAverageSuccessRate != 0) hash ^= ClusterAverageSuccessRate.GetHashCode();
      if (ClusterSuccessRateEjectionThreshold != 0) hash ^= ClusterSuccessRateEjectionThreshold.GetHashCode();
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
      if (HostSuccessRate != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(HostSuccessRate);
      }
      if (ClusterAverageSuccessRate != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ClusterAverageSuccessRate);
      }
      if (ClusterSuccessRateEjectionThreshold != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ClusterSuccessRateEjectionThreshold);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (HostSuccessRate != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HostSuccessRate);
      }
      if (ClusterAverageSuccessRate != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ClusterAverageSuccessRate);
      }
      if (ClusterSuccessRateEjectionThreshold != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ClusterSuccessRateEjectionThreshold);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(OutlierEjectSuccessRate other) {
      if (other == null) {
        return;
      }
      if (other.HostSuccessRate != 0) {
        HostSuccessRate = other.HostSuccessRate;
      }
      if (other.ClusterAverageSuccessRate != 0) {
        ClusterAverageSuccessRate = other.ClusterAverageSuccessRate;
      }
      if (other.ClusterSuccessRateEjectionThreshold != 0) {
        ClusterSuccessRateEjectionThreshold = other.ClusterSuccessRateEjectionThreshold;
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
            HostSuccessRate = input.ReadUInt32();
            break;
          }
          case 16: {
            ClusterAverageSuccessRate = input.ReadUInt32();
            break;
          }
          case 24: {
            ClusterSuccessRateEjectionThreshold = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class OutlierEjectConsecutive : pb::IMessage<OutlierEjectConsecutive> {
    private static readonly pb::MessageParser<OutlierEjectConsecutive> _parser = new pb::MessageParser<OutlierEjectConsecutive>(() => new OutlierEjectConsecutive());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OutlierEjectConsecutive> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Data.Cluster.V3Alpha.OutlierDetectionEventReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OutlierEjectConsecutive() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OutlierEjectConsecutive(OutlierEjectConsecutive other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OutlierEjectConsecutive Clone() {
      return new OutlierEjectConsecutive(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as OutlierEjectConsecutive);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(OutlierEjectConsecutive other) {
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
    public void MergeFrom(OutlierEjectConsecutive other) {
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
