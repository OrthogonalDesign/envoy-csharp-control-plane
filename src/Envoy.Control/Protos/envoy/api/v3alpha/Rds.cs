// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/api/v3alpha/rds.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Api.V3Alpha {

  /// <summary>Holder for reflection information generated from envoy/api/v3alpha/rds.proto</summary>
  public static partial class RdsReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/api/v3alpha/rds.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RdsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtlbnZveS9hcGkvdjNhbHBoYS9yZHMucHJvdG8SEWVudm95LmFwaS52M2Fs",
            "cGhhGiFlbnZveS9hcGkvdjNhbHBoYS9jb3JlL2Jhc2UucHJvdG8aKmVudm95",
            "L2FwaS92M2FscGhhL2NvcmUvY29uZmlnX3NvdXJjZS5wcm90bxohZW52b3kv",
            "YXBpL3YzYWxwaGEvZGlzY292ZXJ5LnByb3RvGiNlbnZveS9hcGkvdjNhbHBo",
            "YS9yb3V0ZS9yb3V0ZS5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5w",
            "cm90bxoeZ29vZ2xlL3Byb3RvYnVmL3dyYXBwZXJzLnByb3RvGhd2YWxpZGF0",
            "ZS92YWxpZGF0ZS5wcm90byLUAwoSUm91dGVDb25maWd1cmF0aW9uEgwKBG5h",
            "bWUYASABKAkSOwoNdmlydHVhbF9ob3N0cxgCIAMoCzIkLmVudm95LmFwaS52",
            "M2FscGhhLnJvdXRlLlZpcnR1YWxIb3N0EiUKBHZoZHMYCSABKAsyFy5lbnZv",
            "eS5hcGkudjNhbHBoYS5WaGRzEh0KFWludGVybmFsX29ubHlfaGVhZGVycxgD",
            "IAMoCRJXChdyZXNwb25zZV9oZWFkZXJzX3RvX2FkZBgEIAMoCzIpLmVudm95",
            "LmFwaS52M2FscGhhLmNvcmUuSGVhZGVyVmFsdWVPcHRpb25CC7rpwAMGkgED",
            "EOgHEiIKGnJlc3BvbnNlX2hlYWRlcnNfdG9fcmVtb3ZlGAUgAygJElYKFnJl",
            "cXVlc3RfaGVhZGVyc190b19hZGQYBiADKAsyKS5lbnZveS5hcGkudjNhbHBo",
            "YS5jb3JlLkhlYWRlclZhbHVlT3B0aW9uQgu66cADBpIBAxDoBxIhChlyZXF1",
            "ZXN0X2hlYWRlcnNfdG9fcmVtb3ZlGAggAygJEjUKEXZhbGlkYXRlX2NsdXN0",
            "ZXJzGAcgASgLMhouZ29vZ2xlLnByb3RvYnVmLkJvb2xWYWx1ZSJPCgRWaGRz",
            "EkcKDWNvbmZpZ19zb3VyY2UYASABKAsyJC5lbnZveS5hcGkudjNhbHBoYS5j",
            "b3JlLkNvbmZpZ1NvdXJjZUIKuunAAwWKAQIQATLiAgoVUm91dGVEaXNjb3Zl",
            "cnlTZXJ2aWNlEl8KDFN0cmVhbVJvdXRlcxIjLmVudm95LmFwaS52M2FscGhh",
            "LkRpc2NvdmVyeVJlcXVlc3QaJC5lbnZveS5hcGkudjNhbHBoYS5EaXNjb3Zl",
            "cnlSZXNwb25zZSIAKAEwARJoCgtEZWx0YVJvdXRlcxIoLmVudm95LmFwaS52",
            "M2FscGhhLkRlbHRhRGlzY292ZXJ5UmVxdWVzdBopLmVudm95LmFwaS52M2Fs",
            "cGhhLkRlbHRhRGlzY292ZXJ5UmVzcG9uc2UiACgBMAESfgoLRmV0Y2hSb3V0",
            "ZXMSIy5lbnZveS5hcGkudjNhbHBoYS5EaXNjb3ZlcnlSZXF1ZXN0GiQuZW52",
            "b3kuYXBpLnYzYWxwaGEuRGlzY292ZXJ5UmVzcG9uc2UiJILT5JMCHiIZL3Yz",
            "YWxwaGEvZGlzY292ZXJ5OnJvdXRlczoBKjKNAQobVmlydHVhbEhvc3REaXNj",
            "b3ZlcnlTZXJ2aWNlEm4KEURlbHRhVmlydHVhbEhvc3RzEiguZW52b3kuYXBp",
            "LnYzYWxwaGEuRGVsdGFEaXNjb3ZlcnlSZXF1ZXN0GikuZW52b3kuYXBpLnYz",
            "YWxwaGEuRGVsdGFEaXNjb3ZlcnlSZXNwb25zZSIAKAEwAUIwCh9pby5lbnZv",
            "eXByb3h5LmVudm95LmFwaS52M2FscGhhQghSZHNQcm90b1ABiAEBYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Api.V3Alpha.Core.BaseReflection.Descriptor, global::Envoy.Api.V3Alpha.Core.ConfigSourceReflection.Descriptor, global::Envoy.Api.V3Alpha.DiscoveryReflection.Descriptor, global::Envoy.Api.V3Alpha.Route.RouteReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Api.V3Alpha.RouteConfiguration), global::Envoy.Api.V3Alpha.RouteConfiguration.Parser, new[]{ "Name", "VirtualHosts", "Vhds", "InternalOnlyHeaders", "ResponseHeadersToAdd", "ResponseHeadersToRemove", "RequestHeadersToAdd", "RequestHeadersToRemove", "ValidateClusters" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Api.V3Alpha.Vhds), global::Envoy.Api.V3Alpha.Vhds.Parser, new[]{ "ConfigSource" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// [#comment:next free field: 10]
  /// </summary>
  public sealed partial class RouteConfiguration : pb::IMessage<RouteConfiguration> {
    private static readonly pb::MessageParser<RouteConfiguration> _parser = new pb::MessageParser<RouteConfiguration>(() => new RouteConfiguration());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RouteConfiguration> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Api.V3Alpha.RdsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RouteConfiguration() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RouteConfiguration(RouteConfiguration other) : this() {
      name_ = other.name_;
      virtualHosts_ = other.virtualHosts_.Clone();
      vhds_ = other.vhds_ != null ? other.vhds_.Clone() : null;
      internalOnlyHeaders_ = other.internalOnlyHeaders_.Clone();
      responseHeadersToAdd_ = other.responseHeadersToAdd_.Clone();
      responseHeadersToRemove_ = other.responseHeadersToRemove_.Clone();
      requestHeadersToAdd_ = other.requestHeadersToAdd_.Clone();
      requestHeadersToRemove_ = other.requestHeadersToRemove_.Clone();
      ValidateClusters = other.ValidateClusters;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RouteConfiguration Clone() {
      return new RouteConfiguration(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// The name of the route configuration. For example, it might match
    /// :ref:`route_config_name
    /// &lt;envoy_api_field_config.filter.network.http_connection_manager.v3alpha.Rds.route_config_name>`
    /// in :ref:`envoy_api_msg_config.filter.network.http_connection_manager.v3alpha.Rds`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "virtual_hosts" field.</summary>
    public const int VirtualHostsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Envoy.Api.V3Alpha.Route.VirtualHost> _repeated_virtualHosts_codec
        = pb::FieldCodec.ForMessage(18, global::Envoy.Api.V3Alpha.Route.VirtualHost.Parser);
    private readonly pbc::RepeatedField<global::Envoy.Api.V3Alpha.Route.VirtualHost> virtualHosts_ = new pbc::RepeatedField<global::Envoy.Api.V3Alpha.Route.VirtualHost>();
    /// <summary>
    /// An array of virtual hosts that make up the route table.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Envoy.Api.V3Alpha.Route.VirtualHost> VirtualHosts {
      get { return virtualHosts_; }
    }

    /// <summary>Field number for the "vhds" field.</summary>
    public const int VhdsFieldNumber = 9;
    private global::Envoy.Api.V3Alpha.Vhds vhds_;
    /// <summary>
    /// An array of virtual hosts will be dynamically loaded via the VHDS API.
    /// Both *virtual_hosts* and *vhds* fields will be used when present. *virtual_hosts* can be used
    /// for a base routing table or for infrequently changing virtual hosts. *vhds* is used for
    /// on-demand discovery of virtual hosts. The contents of these two fields will be merged to
    /// generate a routing table for a given RouteConfiguration, with *vhds* derived configuration
    /// taking precedence.
    /// [#not-implemented-hide:]
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Envoy.Api.V3Alpha.Vhds Vhds {
      get { return vhds_; }
      set {
        vhds_ = value;
      }
    }

    /// <summary>Field number for the "internal_only_headers" field.</summary>
    public const int InternalOnlyHeadersFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_internalOnlyHeaders_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> internalOnlyHeaders_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Optionally specifies a list of HTTP headers that the connection manager
    /// will consider to be internal only. If they are found on external requests they will be cleaned
    /// prior to filter invocation. See :ref:`config_http_conn_man_headers_x-envoy-internal` for more
    /// information.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> InternalOnlyHeaders {
      get { return internalOnlyHeaders_; }
    }

    /// <summary>Field number for the "response_headers_to_add" field.</summary>
    public const int ResponseHeadersToAddFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Envoy.Api.V3Alpha.Core.HeaderValueOption> _repeated_responseHeadersToAdd_codec
        = pb::FieldCodec.ForMessage(34, global::Envoy.Api.V3Alpha.Core.HeaderValueOption.Parser);
    private readonly pbc::RepeatedField<global::Envoy.Api.V3Alpha.Core.HeaderValueOption> responseHeadersToAdd_ = new pbc::RepeatedField<global::Envoy.Api.V3Alpha.Core.HeaderValueOption>();
    /// <summary>
    /// Specifies a list of HTTP headers that should be added to each response that
    /// the connection manager encodes. Headers specified at this level are applied
    /// after headers from any enclosed :ref:`envoy_api_msg_route.VirtualHost` or
    /// :ref:`envoy_api_msg_route.RouteAction`. For more information, including details on
    /// header value syntax, see the documentation on :ref:`custom request headers
    /// &lt;config_http_conn_man_headers_custom_request_headers>`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Envoy.Api.V3Alpha.Core.HeaderValueOption> ResponseHeadersToAdd {
      get { return responseHeadersToAdd_; }
    }

    /// <summary>Field number for the "response_headers_to_remove" field.</summary>
    public const int ResponseHeadersToRemoveFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _repeated_responseHeadersToRemove_codec
        = pb::FieldCodec.ForString(42);
    private readonly pbc::RepeatedField<string> responseHeadersToRemove_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Specifies a list of HTTP headers that should be removed from each response
    /// that the connection manager encodes.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> ResponseHeadersToRemove {
      get { return responseHeadersToRemove_; }
    }

    /// <summary>Field number for the "request_headers_to_add" field.</summary>
    public const int RequestHeadersToAddFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Envoy.Api.V3Alpha.Core.HeaderValueOption> _repeated_requestHeadersToAdd_codec
        = pb::FieldCodec.ForMessage(50, global::Envoy.Api.V3Alpha.Core.HeaderValueOption.Parser);
    private readonly pbc::RepeatedField<global::Envoy.Api.V3Alpha.Core.HeaderValueOption> requestHeadersToAdd_ = new pbc::RepeatedField<global::Envoy.Api.V3Alpha.Core.HeaderValueOption>();
    /// <summary>
    /// Specifies a list of HTTP headers that should be added to each request
    /// routed by the HTTP connection manager. Headers specified at this level are
    /// applied after headers from any enclosed :ref:`envoy_api_msg_route.VirtualHost` or
    /// :ref:`envoy_api_msg_route.RouteAction`. For more information, including details on
    /// header value syntax, see the documentation on :ref:`custom request headers
    /// &lt;config_http_conn_man_headers_custom_request_headers>`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Envoy.Api.V3Alpha.Core.HeaderValueOption> RequestHeadersToAdd {
      get { return requestHeadersToAdd_; }
    }

    /// <summary>Field number for the "request_headers_to_remove" field.</summary>
    public const int RequestHeadersToRemoveFieldNumber = 8;
    private static readonly pb::FieldCodec<string> _repeated_requestHeadersToRemove_codec
        = pb::FieldCodec.ForString(66);
    private readonly pbc::RepeatedField<string> requestHeadersToRemove_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Specifies a list of HTTP headers that should be removed from each request
    /// routed by the HTTP connection manager.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> RequestHeadersToRemove {
      get { return requestHeadersToRemove_; }
    }

    /// <summary>Field number for the "validate_clusters" field.</summary>
    public const int ValidateClustersFieldNumber = 7;
    private static readonly pb::FieldCodec<bool?> _single_validateClusters_codec = pb::FieldCodec.ForStructWrapper<bool>(58);
    private bool? validateClusters_;
    /// <summary>
    /// An optional boolean that specifies whether the clusters that the route
    /// table refers to will be validated by the cluster manager. If set to true
    /// and a route refers to a non-existent cluster, the route table will not
    /// load. If set to false and a route refers to a non-existent cluster, the
    /// route table will load and the router filter will return a 404 if the route
    /// is selected at runtime. This setting defaults to true if the route table
    /// is statically defined via the :ref:`route_config
    /// &lt;envoy_api_field_config.filter.network.http_connection_manager.v3alpha.HttpConnectionManager.route_config>`
    /// option. This setting default to false if the route table is loaded dynamically via the
    /// :ref:`rds
    /// &lt;envoy_api_field_config.filter.network.http_connection_manager.v3alpha.HttpConnectionManager.rds>`
    /// option. Users may wish to override the default behavior in certain cases (for example when
    /// using CDS with a static route table).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool? ValidateClusters {
      get { return validateClusters_; }
      set {
        validateClusters_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RouteConfiguration);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RouteConfiguration other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if(!virtualHosts_.Equals(other.virtualHosts_)) return false;
      if (!object.Equals(Vhds, other.Vhds)) return false;
      if(!internalOnlyHeaders_.Equals(other.internalOnlyHeaders_)) return false;
      if(!responseHeadersToAdd_.Equals(other.responseHeadersToAdd_)) return false;
      if(!responseHeadersToRemove_.Equals(other.responseHeadersToRemove_)) return false;
      if(!requestHeadersToAdd_.Equals(other.requestHeadersToAdd_)) return false;
      if(!requestHeadersToRemove_.Equals(other.requestHeadersToRemove_)) return false;
      if (ValidateClusters != other.ValidateClusters) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      hash ^= virtualHosts_.GetHashCode();
      if (vhds_ != null) hash ^= Vhds.GetHashCode();
      hash ^= internalOnlyHeaders_.GetHashCode();
      hash ^= responseHeadersToAdd_.GetHashCode();
      hash ^= responseHeadersToRemove_.GetHashCode();
      hash ^= requestHeadersToAdd_.GetHashCode();
      hash ^= requestHeadersToRemove_.GetHashCode();
      if (validateClusters_ != null) hash ^= ValidateClusters.GetHashCode();
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
      virtualHosts_.WriteTo(output, _repeated_virtualHosts_codec);
      internalOnlyHeaders_.WriteTo(output, _repeated_internalOnlyHeaders_codec);
      responseHeadersToAdd_.WriteTo(output, _repeated_responseHeadersToAdd_codec);
      responseHeadersToRemove_.WriteTo(output, _repeated_responseHeadersToRemove_codec);
      requestHeadersToAdd_.WriteTo(output, _repeated_requestHeadersToAdd_codec);
      if (validateClusters_ != null) {
        _single_validateClusters_codec.WriteTagAndValue(output, ValidateClusters);
      }
      requestHeadersToRemove_.WriteTo(output, _repeated_requestHeadersToRemove_codec);
      if (vhds_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(Vhds);
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
      size += virtualHosts_.CalculateSize(_repeated_virtualHosts_codec);
      if (vhds_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Vhds);
      }
      size += internalOnlyHeaders_.CalculateSize(_repeated_internalOnlyHeaders_codec);
      size += responseHeadersToAdd_.CalculateSize(_repeated_responseHeadersToAdd_codec);
      size += responseHeadersToRemove_.CalculateSize(_repeated_responseHeadersToRemove_codec);
      size += requestHeadersToAdd_.CalculateSize(_repeated_requestHeadersToAdd_codec);
      size += requestHeadersToRemove_.CalculateSize(_repeated_requestHeadersToRemove_codec);
      if (validateClusters_ != null) {
        size += _single_validateClusters_codec.CalculateSizeWithTag(ValidateClusters);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RouteConfiguration other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      virtualHosts_.Add(other.virtualHosts_);
      if (other.vhds_ != null) {
        if (vhds_ == null) {
          Vhds = new global::Envoy.Api.V3Alpha.Vhds();
        }
        Vhds.MergeFrom(other.Vhds);
      }
      internalOnlyHeaders_.Add(other.internalOnlyHeaders_);
      responseHeadersToAdd_.Add(other.responseHeadersToAdd_);
      responseHeadersToRemove_.Add(other.responseHeadersToRemove_);
      requestHeadersToAdd_.Add(other.requestHeadersToAdd_);
      requestHeadersToRemove_.Add(other.requestHeadersToRemove_);
      if (other.validateClusters_ != null) {
        if (validateClusters_ == null || other.ValidateClusters != false) {
          ValidateClusters = other.ValidateClusters;
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            virtualHosts_.AddEntriesFrom(input, _repeated_virtualHosts_codec);
            break;
          }
          case 26: {
            internalOnlyHeaders_.AddEntriesFrom(input, _repeated_internalOnlyHeaders_codec);
            break;
          }
          case 34: {
            responseHeadersToAdd_.AddEntriesFrom(input, _repeated_responseHeadersToAdd_codec);
            break;
          }
          case 42: {
            responseHeadersToRemove_.AddEntriesFrom(input, _repeated_responseHeadersToRemove_codec);
            break;
          }
          case 50: {
            requestHeadersToAdd_.AddEntriesFrom(input, _repeated_requestHeadersToAdd_codec);
            break;
          }
          case 58: {
            bool? value = _single_validateClusters_codec.Read(input);
            if (validateClusters_ == null || value != false) {
              ValidateClusters = value;
            }
            break;
          }
          case 66: {
            requestHeadersToRemove_.AddEntriesFrom(input, _repeated_requestHeadersToRemove_codec);
            break;
          }
          case 74: {
            if (vhds_ == null) {
              Vhds = new global::Envoy.Api.V3Alpha.Vhds();
            }
            input.ReadMessage(Vhds);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// [#not-implemented-hide:]
  /// </summary>
  public sealed partial class Vhds : pb::IMessage<Vhds> {
    private static readonly pb::MessageParser<Vhds> _parser = new pb::MessageParser<Vhds>(() => new Vhds());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Vhds> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Api.V3Alpha.RdsReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Vhds() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Vhds(Vhds other) : this() {
      configSource_ = other.configSource_ != null ? other.configSource_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Vhds Clone() {
      return new Vhds(this);
    }

    /// <summary>Field number for the "config_source" field.</summary>
    public const int ConfigSourceFieldNumber = 1;
    private global::Envoy.Api.V3Alpha.Core.ConfigSource configSource_;
    /// <summary>
    /// Configuration source specifier for VHDS.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Envoy.Api.V3Alpha.Core.ConfigSource ConfigSource {
      get { return configSource_; }
      set {
        configSource_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Vhds);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Vhds other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ConfigSource, other.ConfigSource)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (configSource_ != null) hash ^= ConfigSource.GetHashCode();
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
      if (configSource_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ConfigSource);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (configSource_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ConfigSource);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Vhds other) {
      if (other == null) {
        return;
      }
      if (other.configSource_ != null) {
        if (configSource_ == null) {
          ConfigSource = new global::Envoy.Api.V3Alpha.Core.ConfigSource();
        }
        ConfigSource.MergeFrom(other.ConfigSource);
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
            if (configSource_ == null) {
              ConfigSource = new global::Envoy.Api.V3Alpha.Core.ConfigSource();
            }
            input.ReadMessage(ConfigSource);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
