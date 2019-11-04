// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/api/v3alpha/core/http_uri.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Api.V3Alpha.Core {

  /// <summary>Holder for reflection information generated from envoy/api/v3alpha/core/http_uri.proto</summary>
  public static partial class HttpUriReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/api/v3alpha/core/http_uri.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HttpUriReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVlbnZveS9hcGkvdjNhbHBoYS9jb3JlL2h0dHBfdXJpLnByb3RvEhZlbnZv",
            "eS5hcGkudjNhbHBoYS5jb3JlGh5nb29nbGUvcHJvdG9idWYvZHVyYXRpb24u",
            "cHJvdG8aF3ZhbGlkYXRlL3ZhbGlkYXRlLnByb3RvIp4BCgdIdHRwVXJpEhYK",
            "A3VyaRgBIAEoCUIJuunAAwRyAiABEhwKB2NsdXN0ZXIYAiABKAlCCbrpwAME",
            "cgIgAUgAEkAKB3RpbWVvdXQYAyABKAsyGS5nb29nbGUucHJvdG9idWYuRHVy",
            "YXRpb25CFLrpwAMFqgECMgC66cADBaoBAggBQhsKEmh0dHBfdXBzdHJlYW1f",
            "dHlwZRIFuOnAAwFCNgokaW8uZW52b3lwcm94eS5lbnZveS5hcGkudjNhbHBo",
            "YS5jb3JlQgxIdHRwVXJpUHJvdG9QAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Api.V3Alpha.Core.HttpUri), global::Envoy.Api.V3Alpha.Core.HttpUri.Parser, new[]{ "Uri", "Cluster", "Timeout" }, new[]{ "HttpUpstreamType" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Envoy external URI descriptor
  /// </summary>
  public sealed partial class HttpUri : pb::IMessage<HttpUri> {
    private static readonly pb::MessageParser<HttpUri> _parser = new pb::MessageParser<HttpUri>(() => new HttpUri());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HttpUri> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Api.V3Alpha.Core.HttpUriReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HttpUri() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HttpUri(HttpUri other) : this() {
      uri_ = other.uri_;
      timeout_ = other.timeout_ != null ? other.timeout_.Clone() : null;
      switch (other.HttpUpstreamTypeCase) {
        case HttpUpstreamTypeOneofCase.Cluster:
          Cluster = other.Cluster;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HttpUri Clone() {
      return new HttpUri(this);
    }

    /// <summary>Field number for the "uri" field.</summary>
    public const int UriFieldNumber = 1;
    private string uri_ = "";
    /// <summary>
    /// The HTTP server URI. It should be a full FQDN with protocol, host and path.
    ///
    /// Example:
    ///
    /// .. code-block:: yaml
    ///
    ///    uri: https://www.googleapis.com/oauth2/v1/certs
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Uri {
      get { return uri_; }
      set {
        uri_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "cluster" field.</summary>
    public const int ClusterFieldNumber = 2;
    /// <summary>
    /// A cluster is created in the Envoy "cluster_manager" config
    /// section. This field specifies the cluster name.
    ///
    /// Example:
    ///
    /// .. code-block:: yaml
    ///
    ///    cluster: jwks_cluster
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Cluster {
      get { return httpUpstreamTypeCase_ == HttpUpstreamTypeOneofCase.Cluster ? (string) httpUpstreamType_ : ""; }
      set {
        httpUpstreamType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        httpUpstreamTypeCase_ = HttpUpstreamTypeOneofCase.Cluster;
      }
    }

    /// <summary>Field number for the "timeout" field.</summary>
    public const int TimeoutFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Duration timeout_;
    /// <summary>
    /// Sets the maximum duration in milliseconds that a response can take to arrive upon request.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Duration Timeout {
      get { return timeout_; }
      set {
        timeout_ = value;
      }
    }

    private object httpUpstreamType_;
    /// <summary>Enum of possible cases for the "http_upstream_type" oneof.</summary>
    public enum HttpUpstreamTypeOneofCase {
      None = 0,
      Cluster = 2,
    }
    private HttpUpstreamTypeOneofCase httpUpstreamTypeCase_ = HttpUpstreamTypeOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HttpUpstreamTypeOneofCase HttpUpstreamTypeCase {
      get { return httpUpstreamTypeCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearHttpUpstreamType() {
      httpUpstreamTypeCase_ = HttpUpstreamTypeOneofCase.None;
      httpUpstreamType_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as HttpUri);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HttpUri other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Uri != other.Uri) return false;
      if (Cluster != other.Cluster) return false;
      if (!object.Equals(Timeout, other.Timeout)) return false;
      if (HttpUpstreamTypeCase != other.HttpUpstreamTypeCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Uri.Length != 0) hash ^= Uri.GetHashCode();
      if (httpUpstreamTypeCase_ == HttpUpstreamTypeOneofCase.Cluster) hash ^= Cluster.GetHashCode();
      if (timeout_ != null) hash ^= Timeout.GetHashCode();
      hash ^= (int) httpUpstreamTypeCase_;
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
      if (Uri.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Uri);
      }
      if (httpUpstreamTypeCase_ == HttpUpstreamTypeOneofCase.Cluster) {
        output.WriteRawTag(18);
        output.WriteString(Cluster);
      }
      if (timeout_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Timeout);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Uri.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Uri);
      }
      if (httpUpstreamTypeCase_ == HttpUpstreamTypeOneofCase.Cluster) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Cluster);
      }
      if (timeout_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Timeout);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(HttpUri other) {
      if (other == null) {
        return;
      }
      if (other.Uri.Length != 0) {
        Uri = other.Uri;
      }
      if (other.timeout_ != null) {
        if (timeout_ == null) {
          Timeout = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        Timeout.MergeFrom(other.Timeout);
      }
      switch (other.HttpUpstreamTypeCase) {
        case HttpUpstreamTypeOneofCase.Cluster:
          Cluster = other.Cluster;
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
          case 10: {
            Uri = input.ReadString();
            break;
          }
          case 18: {
            Cluster = input.ReadString();
            break;
          }
          case 26: {
            if (timeout_ == null) {
              Timeout = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(Timeout);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
