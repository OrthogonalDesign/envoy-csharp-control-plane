// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/api/v3alpha/eds.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Api.V3Alpha {

  /// <summary>Holder for reflection information generated from envoy/api/v3alpha/eds.proto</summary>
  public static partial class EdsReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/api/v3alpha/eds.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EdsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtlbnZveS9hcGkvdjNhbHBoYS9lZHMucHJvdG8SEWVudm95LmFwaS52M2Fs",
            "cGhhGiFlbnZveS9hcGkvdjNhbHBoYS9kaXNjb3ZlcnkucHJvdG8aKWVudm95",
            "L2FwaS92M2FscGhhL2VuZHBvaW50L2VuZHBvaW50LnByb3RvGhhlbnZveS90",
            "eXBlL3BlcmNlbnQucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJv",
            "dG8aF3ZhbGlkYXRlL3ZhbGlkYXRlLnByb3RvGh5nb29nbGUvcHJvdG9idWYv",
            "d3JhcHBlcnMucHJvdG8aHmdvb2dsZS9wcm90b2J1Zi9kdXJhdGlvbi5wcm90",
            "byLwBQoVQ2x1c3RlckxvYWRBc3NpZ25tZW50Eh8KDGNsdXN0ZXJfbmFtZRgB",
            "IAEoCUIJuunAAwRyAiABEkIKCWVuZHBvaW50cxgCIAMoCzIvLmVudm95LmFw",
            "aS52M2FscGhhLmVuZHBvaW50LkxvY2FsaXR5TGJFbmRwb2ludHMSVQoPbmFt",
            "ZWRfZW5kcG9pbnRzGAUgAygLMjwuZW52b3kuYXBpLnYzYWxwaGEuQ2x1c3Rl",
            "ckxvYWRBc3NpZ25tZW50Lk5hbWVkRW5kcG9pbnRzRW50cnkSPwoGcG9saWN5",
            "GAQgASgLMi8uZW52b3kuYXBpLnYzYWxwaGEuQ2x1c3RlckxvYWRBc3NpZ25t",
            "ZW50LlBvbGljeRpbChNOYW1lZEVuZHBvaW50c0VudHJ5EgsKA2tleRgBIAEo",
            "CRIzCgV2YWx1ZRgCIAEoCzIkLmVudm95LmFwaS52M2FscGhhLmVuZHBvaW50",
            "LkVuZHBvaW50OgI4ARr8AgoGUG9saWN5ElQKDmRyb3Bfb3ZlcmxvYWRzGAIg",
            "AygLMjwuZW52b3kuYXBpLnYzYWxwaGEuQ2x1c3RlckxvYWRBc3NpZ25tZW50",
            "LlBvbGljeS5Ecm9wT3ZlcmxvYWQSSAoXb3ZlcnByb3Zpc2lvbmluZ19mYWN0",
            "b3IYAyABKAsyHC5nb29nbGUucHJvdG9idWYuVUludDMyVmFsdWVCCbrpwAME",
            "KgIgABJFChRlbmRwb2ludF9zdGFsZV9hZnRlchgEIAEoCzIZLmdvb2dsZS5w",
            "cm90b2J1Zi5EdXJhdGlvbkIMuunAAweqAQQqAggAEiAKGGRpc2FibGVfb3Zl",
            "cnByb3Zpc2lvbmluZxgFIAEoCBpjCgxEcm9wT3ZlcmxvYWQSGwoIY2F0ZWdv",
            "cnkYASABKAlCCbrpwAMEcgIgARI2Cg9kcm9wX3BlcmNlbnRhZ2UYAiABKAsy",
            "HS5lbnZveS50eXBlLkZyYWN0aW9uYWxQZXJjZW50SgQIARACMvICChhFbmRw",
            "b2ludERpc2NvdmVyeVNlcnZpY2USYgoPU3RyZWFtRW5kcG9pbnRzEiMuZW52",
            "b3kuYXBpLnYzYWxwaGEuRGlzY292ZXJ5UmVxdWVzdBokLmVudm95LmFwaS52",
            "M2FscGhhLkRpc2NvdmVyeVJlc3BvbnNlIgAoATABEmsKDkRlbHRhRW5kcG9p",
            "bnRzEiguZW52b3kuYXBpLnYzYWxwaGEuRGVsdGFEaXNjb3ZlcnlSZXF1ZXN0",
            "GikuZW52b3kuYXBpLnYzYWxwaGEuRGVsdGFEaXNjb3ZlcnlSZXNwb25zZSIA",
            "KAEwARKEAQoORmV0Y2hFbmRwb2ludHMSIy5lbnZveS5hcGkudjNhbHBoYS5E",
            "aXNjb3ZlcnlSZXF1ZXN0GiQuZW52b3kuYXBpLnYzYWxwaGEuRGlzY292ZXJ5",
            "UmVzcG9uc2UiJ4LT5JMCISIcL3YzYWxwaGEvZGlzY292ZXJ5OmVuZHBvaW50",
            "czoBKkIwCh9pby5lbnZveXByb3h5LmVudm95LmFwaS52M2FscGhhQghFZHNQ",
            "cm90b1ABiAEBYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Api.V3Alpha.DiscoveryReflection.Descriptor, global::Envoy.Api.V3Alpha.Endpoint.EndpointReflection.Descriptor, global::Envoy.Type.PercentReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Api.V3Alpha.ClusterLoadAssignment), global::Envoy.Api.V3Alpha.ClusterLoadAssignment.Parser, new[]{ "ClusterName", "Endpoints", "NamedEndpoints", "Policy" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Api.V3Alpha.ClusterLoadAssignment.Types.Policy), global::Envoy.Api.V3Alpha.ClusterLoadAssignment.Types.Policy.Parser, new[]{ "DropOverloads", "OverprovisioningFactor", "EndpointStaleAfter", "DisableOverprovisioning" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Api.V3Alpha.ClusterLoadAssignment.Types.Policy.Types.DropOverload), global::Envoy.Api.V3Alpha.ClusterLoadAssignment.Types.Policy.Types.DropOverload.Parser, new[]{ "Category", "DropPercentage" }, null, null, null, null)})})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Each route from RDS will map to a single cluster or traffic split across
  /// clusters using weights expressed in the RDS WeightedCluster.
  ///
  /// With EDS, each cluster is treated independently from a LB perspective, with
  /// LB taking place between the Localities within a cluster and at a finer
  /// granularity between the hosts within a locality. The percentage of traffic
  /// for each endpoint is determined by both its load_balancing_weight, and the
  /// load_balancing_weight of its locality. First, a locality will be selected,
  /// then an endpoint within that locality will be chose based on its weight.
  /// </summary>
  public sealed partial class ClusterLoadAssignment : pb::IMessage<ClusterLoadAssignment> {
    private static readonly pb::MessageParser<ClusterLoadAssignment> _parser = new pb::MessageParser<ClusterLoadAssignment>(() => new ClusterLoadAssignment());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClusterLoadAssignment> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Api.V3Alpha.EdsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClusterLoadAssignment() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClusterLoadAssignment(ClusterLoadAssignment other) : this() {
      clusterName_ = other.clusterName_;
      endpoints_ = other.endpoints_.Clone();
      namedEndpoints_ = other.namedEndpoints_.Clone();
      policy_ = other.policy_ != null ? other.policy_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClusterLoadAssignment Clone() {
      return new ClusterLoadAssignment(this);
    }

    /// <summary>Field number for the "cluster_name" field.</summary>
    public const int ClusterNameFieldNumber = 1;
    private string clusterName_ = "";
    /// <summary>
    /// Name of the cluster. This will be the :ref:`service_name
    /// &lt;envoy_api_field_Cluster.EdsClusterConfig.service_name>` value if specified
    /// in the cluster :ref:`EdsClusterConfig
    /// &lt;envoy_api_msg_Cluster.EdsClusterConfig>`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ClusterName {
      get { return clusterName_; }
      set {
        clusterName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "endpoints" field.</summary>
    public const int EndpointsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Envoy.Api.V3Alpha.Endpoint.LocalityLbEndpoints> _repeated_endpoints_codec
        = pb::FieldCodec.ForMessage(18, global::Envoy.Api.V3Alpha.Endpoint.LocalityLbEndpoints.Parser);
    private readonly pbc::RepeatedField<global::Envoy.Api.V3Alpha.Endpoint.LocalityLbEndpoints> endpoints_ = new pbc::RepeatedField<global::Envoy.Api.V3Alpha.Endpoint.LocalityLbEndpoints>();
    /// <summary>
    /// List of endpoints to load balance to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Envoy.Api.V3Alpha.Endpoint.LocalityLbEndpoints> Endpoints {
      get { return endpoints_; }
    }

    /// <summary>Field number for the "named_endpoints" field.</summary>
    public const int NamedEndpointsFieldNumber = 5;
    private static readonly pbc::MapField<string, global::Envoy.Api.V3Alpha.Endpoint.Endpoint>.Codec _map_namedEndpoints_codec
        = new pbc::MapField<string, global::Envoy.Api.V3Alpha.Endpoint.Endpoint>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForMessage(18, global::Envoy.Api.V3Alpha.Endpoint.Endpoint.Parser), 42);
    private readonly pbc::MapField<string, global::Envoy.Api.V3Alpha.Endpoint.Endpoint> namedEndpoints_ = new pbc::MapField<string, global::Envoy.Api.V3Alpha.Endpoint.Endpoint>();
    /// <summary>
    /// Map of named endpoints that can be referenced in LocalityLbEndpoints.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::Envoy.Api.V3Alpha.Endpoint.Endpoint> NamedEndpoints {
      get { return namedEndpoints_; }
    }

    /// <summary>Field number for the "policy" field.</summary>
    public const int PolicyFieldNumber = 4;
    private global::Envoy.Api.V3Alpha.ClusterLoadAssignment.Types.Policy policy_;
    /// <summary>
    /// Load balancing policy settings.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Envoy.Api.V3Alpha.ClusterLoadAssignment.Types.Policy Policy {
      get { return policy_; }
      set {
        policy_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClusterLoadAssignment);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClusterLoadAssignment other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ClusterName != other.ClusterName) return false;
      if(!endpoints_.Equals(other.endpoints_)) return false;
      if (!NamedEndpoints.Equals(other.NamedEndpoints)) return false;
      if (!object.Equals(Policy, other.Policy)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ClusterName.Length != 0) hash ^= ClusterName.GetHashCode();
      hash ^= endpoints_.GetHashCode();
      hash ^= NamedEndpoints.GetHashCode();
      if (policy_ != null) hash ^= Policy.GetHashCode();
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
      if (ClusterName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ClusterName);
      }
      endpoints_.WriteTo(output, _repeated_endpoints_codec);
      if (policy_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Policy);
      }
      namedEndpoints_.WriteTo(output, _map_namedEndpoints_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ClusterName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClusterName);
      }
      size += endpoints_.CalculateSize(_repeated_endpoints_codec);
      size += namedEndpoints_.CalculateSize(_map_namedEndpoints_codec);
      if (policy_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Policy);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClusterLoadAssignment other) {
      if (other == null) {
        return;
      }
      if (other.ClusterName.Length != 0) {
        ClusterName = other.ClusterName;
      }
      endpoints_.Add(other.endpoints_);
      namedEndpoints_.Add(other.namedEndpoints_);
      if (other.policy_ != null) {
        if (policy_ == null) {
          Policy = new global::Envoy.Api.V3Alpha.ClusterLoadAssignment.Types.Policy();
        }
        Policy.MergeFrom(other.Policy);
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
            ClusterName = input.ReadString();
            break;
          }
          case 18: {
            endpoints_.AddEntriesFrom(input, _repeated_endpoints_codec);
            break;
          }
          case 34: {
            if (policy_ == null) {
              Policy = new global::Envoy.Api.V3Alpha.ClusterLoadAssignment.Types.Policy();
            }
            input.ReadMessage(Policy);
            break;
          }
          case 42: {
            namedEndpoints_.AddEntriesFrom(input, _map_namedEndpoints_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the ClusterLoadAssignment message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Load balancing policy settings.
      /// </summary>
      public sealed partial class Policy : pb::IMessage<Policy> {
        private static readonly pb::MessageParser<Policy> _parser = new pb::MessageParser<Policy>(() => new Policy());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Policy> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Envoy.Api.V3Alpha.ClusterLoadAssignment.Descriptor.NestedTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Policy() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Policy(Policy other) : this() {
          dropOverloads_ = other.dropOverloads_.Clone();
          OverprovisioningFactor = other.OverprovisioningFactor;
          endpointStaleAfter_ = other.endpointStaleAfter_ != null ? other.endpointStaleAfter_.Clone() : null;
          disableOverprovisioning_ = other.disableOverprovisioning_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Policy Clone() {
          return new Policy(this);
        }

        /// <summary>Field number for the "drop_overloads" field.</summary>
        public const int DropOverloadsFieldNumber = 2;
        private static readonly pb::FieldCodec<global::Envoy.Api.V3Alpha.ClusterLoadAssignment.Types.Policy.Types.DropOverload> _repeated_dropOverloads_codec
            = pb::FieldCodec.ForMessage(18, global::Envoy.Api.V3Alpha.ClusterLoadAssignment.Types.Policy.Types.DropOverload.Parser);
        private readonly pbc::RepeatedField<global::Envoy.Api.V3Alpha.ClusterLoadAssignment.Types.Policy.Types.DropOverload> dropOverloads_ = new pbc::RepeatedField<global::Envoy.Api.V3Alpha.ClusterLoadAssignment.Types.Policy.Types.DropOverload>();
        /// <summary>
        /// Action to trim the overall incoming traffic to protect the upstream
        /// hosts. This action allows protection in case the hosts are unable to
        /// recover from an outage, or unable to autoscale or unable to handle
        /// incoming traffic volume for any reason.
        ///
        /// At the client each category is applied one after the other to generate
        /// the 'actual' drop percentage on all outgoing traffic. For example:
        ///
        /// .. code-block:: json
        ///
        ///  { "drop_overloads": [
        ///      { "category": "throttle", "drop_percentage": 60 }
        ///      { "category": "lb", "drop_percentage": 50 }
        ///  ]}
        ///
        /// The actual drop percentages applied to the traffic at the clients will be
        ///    "throttle"_drop = 60%
        ///    "lb"_drop = 20%  // 50% of the remaining 'actual' load, which is 40%.
        ///    actual_outgoing_load = 20% // remaining after applying all categories.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<global::Envoy.Api.V3Alpha.ClusterLoadAssignment.Types.Policy.Types.DropOverload> DropOverloads {
          get { return dropOverloads_; }
        }

        /// <summary>Field number for the "overprovisioning_factor" field.</summary>
        public const int OverprovisioningFactorFieldNumber = 3;
        private static readonly pb::FieldCodec<uint?> _single_overprovisioningFactor_codec = pb::FieldCodec.ForStructWrapper<uint>(26);
        private uint? overprovisioningFactor_;
        /// <summary>
        /// Priority levels and localities are considered overprovisioned with this
        /// factor (in percentage). This means that we don't consider a priority
        /// level or locality unhealthy until the percentage of healthy hosts
        /// multiplied by the overprovisioning factor drops below 100.
        /// With the default value 140(1.4), Envoy doesn't consider a priority level
        /// or a locality unhealthy until their percentage of healthy hosts drops
        /// below 72%. For example:
        ///
        /// .. code-block:: json
        ///
        ///  { "overprovisioning_factor": 100 }
        ///
        /// Read more at :ref:`priority levels &lt;arch_overview_load_balancing_priority_levels>` and
        /// :ref:`localities &lt;arch_overview_load_balancing_locality_weighted_lb>`.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public uint? OverprovisioningFactor {
          get { return overprovisioningFactor_; }
          set {
            overprovisioningFactor_ = value;
          }
        }


        /// <summary>Field number for the "endpoint_stale_after" field.</summary>
        public const int EndpointStaleAfterFieldNumber = 4;
        private global::Google.Protobuf.WellKnownTypes.Duration endpointStaleAfter_;
        /// <summary>
        /// The max time until which the endpoints from this assignment can be used.
        /// If no new assignments are received before this time expires the endpoints
        /// are considered stale and should be marked unhealthy.
        /// Defaults to 0 which means endpoints never go stale.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Google.Protobuf.WellKnownTypes.Duration EndpointStaleAfter {
          get { return endpointStaleAfter_; }
          set {
            endpointStaleAfter_ = value;
          }
        }

        /// <summary>Field number for the "disable_overprovisioning" field.</summary>
        public const int DisableOverprovisioningFieldNumber = 5;
        private bool disableOverprovisioning_;
        /// <summary>
        /// The flag to disable overprovisioning. If it is set to true,
        /// :ref:`overprovisioning factor
        /// &lt;arch_overview_load_balancing_overprovisioning_factor>` will be ignored
        /// and Envoy will not perform graceful failover between priority levels or
        /// localities as endpoints become unhealthy. Otherwise Envoy will perform
        /// graceful failover as :ref:`overprovisioning factor
        /// &lt;arch_overview_load_balancing_overprovisioning_factor>` suggests.
        /// [#next-major-version: Unify with overprovisioning config as a single message.]
        /// [#not-implemented-hide:]
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool DisableOverprovisioning {
          get { return disableOverprovisioning_; }
          set {
            disableOverprovisioning_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as Policy);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(Policy other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if(!dropOverloads_.Equals(other.dropOverloads_)) return false;
          if (OverprovisioningFactor != other.OverprovisioningFactor) return false;
          if (!object.Equals(EndpointStaleAfter, other.EndpointStaleAfter)) return false;
          if (DisableOverprovisioning != other.DisableOverprovisioning) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          hash ^= dropOverloads_.GetHashCode();
          if (overprovisioningFactor_ != null) hash ^= OverprovisioningFactor.GetHashCode();
          if (endpointStaleAfter_ != null) hash ^= EndpointStaleAfter.GetHashCode();
          if (DisableOverprovisioning != false) hash ^= DisableOverprovisioning.GetHashCode();
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
          dropOverloads_.WriteTo(output, _repeated_dropOverloads_codec);
          if (overprovisioningFactor_ != null) {
            _single_overprovisioningFactor_codec.WriteTagAndValue(output, OverprovisioningFactor);
          }
          if (endpointStaleAfter_ != null) {
            output.WriteRawTag(34);
            output.WriteMessage(EndpointStaleAfter);
          }
          if (DisableOverprovisioning != false) {
            output.WriteRawTag(40);
            output.WriteBool(DisableOverprovisioning);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          size += dropOverloads_.CalculateSize(_repeated_dropOverloads_codec);
          if (overprovisioningFactor_ != null) {
            size += _single_overprovisioningFactor_codec.CalculateSizeWithTag(OverprovisioningFactor);
          }
          if (endpointStaleAfter_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(EndpointStaleAfter);
          }
          if (DisableOverprovisioning != false) {
            size += 1 + 1;
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(Policy other) {
          if (other == null) {
            return;
          }
          dropOverloads_.Add(other.dropOverloads_);
          if (other.overprovisioningFactor_ != null) {
            if (overprovisioningFactor_ == null || other.OverprovisioningFactor != 0) {
              OverprovisioningFactor = other.OverprovisioningFactor;
            }
          }
          if (other.endpointStaleAfter_ != null) {
            if (endpointStaleAfter_ == null) {
              EndpointStaleAfter = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            EndpointStaleAfter.MergeFrom(other.EndpointStaleAfter);
          }
          if (other.DisableOverprovisioning != false) {
            DisableOverprovisioning = other.DisableOverprovisioning;
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
                dropOverloads_.AddEntriesFrom(input, _repeated_dropOverloads_codec);
                break;
              }
              case 26: {
                uint? value = _single_overprovisioningFactor_codec.Read(input);
                if (overprovisioningFactor_ == null || value != 0) {
                  OverprovisioningFactor = value;
                }
                break;
              }
              case 34: {
                if (endpointStaleAfter_ == null) {
                  EndpointStaleAfter = new global::Google.Protobuf.WellKnownTypes.Duration();
                }
                input.ReadMessage(EndpointStaleAfter);
                break;
              }
              case 40: {
                DisableOverprovisioning = input.ReadBool();
                break;
              }
            }
          }
        }

        #region Nested types
        /// <summary>Container for nested types declared in the Policy message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static partial class Types {
          public sealed partial class DropOverload : pb::IMessage<DropOverload> {
            private static readonly pb::MessageParser<DropOverload> _parser = new pb::MessageParser<DropOverload>(() => new DropOverload());
            private pb::UnknownFieldSet _unknownFields;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public static pb::MessageParser<DropOverload> Parser { get { return _parser; } }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public static pbr::MessageDescriptor Descriptor {
              get { return global::Envoy.Api.V3Alpha.ClusterLoadAssignment.Types.Policy.Descriptor.NestedTypes[0]; }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            pbr::MessageDescriptor pb::IMessage.Descriptor {
              get { return Descriptor; }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public DropOverload() {
              OnConstruction();
            }

            partial void OnConstruction();

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public DropOverload(DropOverload other) : this() {
              category_ = other.category_;
              dropPercentage_ = other.dropPercentage_ != null ? other.dropPercentage_.Clone() : null;
              _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public DropOverload Clone() {
              return new DropOverload(this);
            }

            /// <summary>Field number for the "category" field.</summary>
            public const int CategoryFieldNumber = 1;
            private string category_ = "";
            /// <summary>
            /// Identifier for the policy specifying the drop.
            /// </summary>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public string Category {
              get { return category_; }
              set {
                category_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
              }
            }

            /// <summary>Field number for the "drop_percentage" field.</summary>
            public const int DropPercentageFieldNumber = 2;
            private global::Envoy.Type.FractionalPercent dropPercentage_;
            /// <summary>
            /// Percentage of traffic that should be dropped for the category.
            /// </summary>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public global::Envoy.Type.FractionalPercent DropPercentage {
              get { return dropPercentage_; }
              set {
                dropPercentage_ = value;
              }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public override bool Equals(object other) {
              return Equals(other as DropOverload);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public bool Equals(DropOverload other) {
              if (ReferenceEquals(other, null)) {
                return false;
              }
              if (ReferenceEquals(other, this)) {
                return true;
              }
              if (Category != other.Category) return false;
              if (!object.Equals(DropPercentage, other.DropPercentage)) return false;
              return Equals(_unknownFields, other._unknownFields);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public override int GetHashCode() {
              int hash = 1;
              if (Category.Length != 0) hash ^= Category.GetHashCode();
              if (dropPercentage_ != null) hash ^= DropPercentage.GetHashCode();
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
              if (Category.Length != 0) {
                output.WriteRawTag(10);
                output.WriteString(Category);
              }
              if (dropPercentage_ != null) {
                output.WriteRawTag(18);
                output.WriteMessage(DropPercentage);
              }
              if (_unknownFields != null) {
                _unknownFields.WriteTo(output);
              }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public int CalculateSize() {
              int size = 0;
              if (Category.Length != 0) {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Category);
              }
              if (dropPercentage_ != null) {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(DropPercentage);
              }
              if (_unknownFields != null) {
                size += _unknownFields.CalculateSize();
              }
              return size;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public void MergeFrom(DropOverload other) {
              if (other == null) {
                return;
              }
              if (other.Category.Length != 0) {
                Category = other.Category;
              }
              if (other.dropPercentage_ != null) {
                if (dropPercentage_ == null) {
                  DropPercentage = new global::Envoy.Type.FractionalPercent();
                }
                DropPercentage.MergeFrom(other.DropPercentage);
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
                    Category = input.ReadString();
                    break;
                  }
                  case 18: {
                    if (dropPercentage_ == null) {
                      DropPercentage = new global::Envoy.Type.FractionalPercent();
                    }
                    input.ReadMessage(DropPercentage);
                    break;
                  }
                }
              }
            }

          }

        }
        #endregion

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
