// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/config/filter/http/transcoder/v3alpha/transcoder.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Config.Filter.Http.Transcoder.V3Alpha {

  /// <summary>Holder for reflection information generated from envoy/config/filter/http/transcoder/v3alpha/transcoder.proto</summary>
  public static partial class TranscoderReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/config/filter/http/transcoder/v3alpha/transcoder.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TranscoderReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjxlbnZveS9jb25maWcvZmlsdGVyL2h0dHAvdHJhbnNjb2Rlci92M2FscGhh",
            "L3RyYW5zY29kZXIucHJvdG8SK2Vudm95LmNvbmZpZy5maWx0ZXIuaHR0cC50",
            "cmFuc2NvZGVyLnYzYWxwaGEaF3ZhbGlkYXRlL3ZhbGlkYXRlLnByb3RvIosE",
            "ChJHcnBjSnNvblRyYW5zY29kZXISGgoQcHJvdG9fZGVzY3JpcHRvchgBIAEo",
            "CUgAEh4KFHByb3RvX2Rlc2NyaXB0b3JfYmluGAQgASgMSAASHAoIc2Vydmlj",
            "ZXMYAiADKAlCCrrpwAMFkgECCAESYwoNcHJpbnRfb3B0aW9ucxgDIAEoCzJM",
            "LmVudm95LmNvbmZpZy5maWx0ZXIuaHR0cC50cmFuc2NvZGVyLnYzYWxwaGEu",
            "R3JwY0pzb25UcmFuc2NvZGVyLlByaW50T3B0aW9ucxIkChxtYXRjaF9pbmNv",
            "bWluZ19yZXF1ZXN0X3JvdXRlGAUgASgIEiAKGGlnbm9yZWRfcXVlcnlfcGFy",
            "YW1ldGVycxgGIAMoCRIUCgxhdXRvX21hcHBpbmcYByABKAgSJwofaWdub3Jl",
            "X3Vua25vd25fcXVlcnlfcGFyYW1ldGVycxgIIAEoCBqVAQoMUHJpbnRPcHRp",
            "b25zEhYKDmFkZF93aGl0ZXNwYWNlGAEgASgIEiUKHWFsd2F5c19wcmludF9w",
            "cmltaXRpdmVfZmllbGRzGAIgASgIEiIKGmFsd2F5c19wcmludF9lbnVtc19h",
            "c19pbnRzGAMgASgIEiIKGnByZXNlcnZlX3Byb3RvX2ZpZWxkX25hbWVzGAQg",
            "ASgIQhcKDmRlc2NyaXB0b3Jfc2V0EgW46cADAUJOCjlpby5lbnZveXByb3h5",
            "LmVudm95LmNvbmZpZy5maWx0ZXIuaHR0cC50cmFuc2NvZGVyLnYzYWxwaGFC",
            "D1RyYW5zY29kZXJQcm90b1ABYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Filter.Http.Transcoder.V3Alpha.GrpcJsonTranscoder), global::Envoy.Config.Filter.Http.Transcoder.V3Alpha.GrpcJsonTranscoder.Parser, new[]{ "ProtoDescriptor", "ProtoDescriptorBin", "Services", "PrintOptions", "MatchIncomingRequestRoute", "IgnoredQueryParameters", "AutoMapping", "IgnoreUnknownQueryParameters" }, new[]{ "DescriptorSet" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Filter.Http.Transcoder.V3Alpha.GrpcJsonTranscoder.Types.PrintOptions), global::Envoy.Config.Filter.Http.Transcoder.V3Alpha.GrpcJsonTranscoder.Types.PrintOptions.Parser, new[]{ "AddWhitespace", "AlwaysPrintPrimitiveFields", "AlwaysPrintEnumsAsInts", "PreserveProtoFieldNames" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GrpcJsonTranscoder : pb::IMessage<GrpcJsonTranscoder> {
    private static readonly pb::MessageParser<GrpcJsonTranscoder> _parser = new pb::MessageParser<GrpcJsonTranscoder>(() => new GrpcJsonTranscoder());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GrpcJsonTranscoder> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Filter.Http.Transcoder.V3Alpha.TranscoderReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GrpcJsonTranscoder() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GrpcJsonTranscoder(GrpcJsonTranscoder other) : this() {
      services_ = other.services_.Clone();
      printOptions_ = other.printOptions_ != null ? other.printOptions_.Clone() : null;
      matchIncomingRequestRoute_ = other.matchIncomingRequestRoute_;
      ignoredQueryParameters_ = other.ignoredQueryParameters_.Clone();
      autoMapping_ = other.autoMapping_;
      ignoreUnknownQueryParameters_ = other.ignoreUnknownQueryParameters_;
      switch (other.DescriptorSetCase) {
        case DescriptorSetOneofCase.ProtoDescriptor:
          ProtoDescriptor = other.ProtoDescriptor;
          break;
        case DescriptorSetOneofCase.ProtoDescriptorBin:
          ProtoDescriptorBin = other.ProtoDescriptorBin;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GrpcJsonTranscoder Clone() {
      return new GrpcJsonTranscoder(this);
    }

    /// <summary>Field number for the "proto_descriptor" field.</summary>
    public const int ProtoDescriptorFieldNumber = 1;
    /// <summary>
    /// Supplies the filename of
    /// :ref:`the proto descriptor set &lt;config_grpc_json_generate_proto_descriptor_set>` for the gRPC
    /// services.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ProtoDescriptor {
      get { return descriptorSetCase_ == DescriptorSetOneofCase.ProtoDescriptor ? (string) descriptorSet_ : ""; }
      set {
        descriptorSet_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        descriptorSetCase_ = DescriptorSetOneofCase.ProtoDescriptor;
      }
    }

    /// <summary>Field number for the "proto_descriptor_bin" field.</summary>
    public const int ProtoDescriptorBinFieldNumber = 4;
    /// <summary>
    /// Supplies the binary content of
    /// :ref:`the proto descriptor set &lt;config_grpc_json_generate_proto_descriptor_set>` for the gRPC
    /// services.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString ProtoDescriptorBin {
      get { return descriptorSetCase_ == DescriptorSetOneofCase.ProtoDescriptorBin ? (pb::ByteString) descriptorSet_ : pb::ByteString.Empty; }
      set {
        descriptorSet_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        descriptorSetCase_ = DescriptorSetOneofCase.ProtoDescriptorBin;
      }
    }

    /// <summary>Field number for the "services" field.</summary>
    public const int ServicesFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _repeated_services_codec
        = pb::FieldCodec.ForString(18);
    private readonly pbc::RepeatedField<string> services_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// A list of strings that
    /// supplies the fully qualified service names (i.e. "package_name.service_name") that
    /// the transcoder will translate. If the service name doesn't exist in ``proto_descriptor``,
    /// Envoy will fail at startup. The ``proto_descriptor`` may contain more services than
    /// the service names specified here, but they won't be translated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Services {
      get { return services_; }
    }

    /// <summary>Field number for the "print_options" field.</summary>
    public const int PrintOptionsFieldNumber = 3;
    private global::Envoy.Config.Filter.Http.Transcoder.V3Alpha.GrpcJsonTranscoder.Types.PrintOptions printOptions_;
    /// <summary>
    /// Control options for response JSON. These options are passed directly to
    /// `JsonPrintOptions &lt;https://developers.google.com/protocol-buffers/docs/reference/cpp/
    /// google.protobuf.util.json_util#JsonPrintOptions>`_.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Envoy.Config.Filter.Http.Transcoder.V3Alpha.GrpcJsonTranscoder.Types.PrintOptions PrintOptions {
      get { return printOptions_; }
      set {
        printOptions_ = value;
      }
    }

    /// <summary>Field number for the "match_incoming_request_route" field.</summary>
    public const int MatchIncomingRequestRouteFieldNumber = 5;
    private bool matchIncomingRequestRoute_;
    /// <summary>
    /// Whether to keep the incoming request route after the outgoing headers have been transformed to
    /// the match the upstream gRPC service. Note: This means that routes for gRPC services that are
    /// not transcoded cannot be used in combination with *match_incoming_request_route*.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool MatchIncomingRequestRoute {
      get { return matchIncomingRequestRoute_; }
      set {
        matchIncomingRequestRoute_ = value;
      }
    }

    /// <summary>Field number for the "ignored_query_parameters" field.</summary>
    public const int IgnoredQueryParametersFieldNumber = 6;
    private static readonly pb::FieldCodec<string> _repeated_ignoredQueryParameters_codec
        = pb::FieldCodec.ForString(50);
    private readonly pbc::RepeatedField<string> ignoredQueryParameters_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// A list of query parameters to be ignored for transcoding method mapping.
    /// By default, the transcoder filter will not transcode a request if there are any
    /// unknown/invalid query parameters.
    ///
    /// Example :
    ///
    /// .. code-block:: proto
    ///
    ///     service Bookstore {
    ///       rpc GetShelf(GetShelfRequest) returns (Shelf) {
    ///         option (google.api.http) = {
    ///           get: "/shelves/{shelf}"
    ///         };
    ///       }
    ///     }
    ///
    ///     message GetShelfRequest {
    ///       int64 shelf = 1;
    ///     }
    ///
    ///     message Shelf {}
    ///
    /// The request ``/shelves/100?foo=bar`` will not be mapped to ``GetShelf``` because variable
    /// binding for ``foo`` is not defined. Adding ``foo`` to ``ignored_query_parameters`` will allow
    /// the same request to be mapped to ``GetShelf``.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> IgnoredQueryParameters {
      get { return ignoredQueryParameters_; }
    }

    /// <summary>Field number for the "auto_mapping" field.</summary>
    public const int AutoMappingFieldNumber = 7;
    private bool autoMapping_;
    /// <summary>
    /// Whether to route methods without the ``google.api.http`` option.
    ///
    /// Example :
    ///
    /// .. code-block:: proto
    ///
    ///     package bookstore;
    ///
    ///     service Bookstore {
    ///       rpc GetShelf(GetShelfRequest) returns (Shelf) {}
    ///     }
    ///
    ///     message GetShelfRequest {
    ///       int64 shelf = 1;
    ///     }
    ///
    ///     message Shelf {}
    ///
    /// The client could ``post`` a json body ``{"shelf": 1234}`` with the path of
    /// ``/bookstore.Bookstore/GetShelfRequest`` to call ``GetShelfRequest``.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool AutoMapping {
      get { return autoMapping_; }
      set {
        autoMapping_ = value;
      }
    }

    /// <summary>Field number for the "ignore_unknown_query_parameters" field.</summary>
    public const int IgnoreUnknownQueryParametersFieldNumber = 8;
    private bool ignoreUnknownQueryParameters_;
    /// <summary>
    /// Whether to ignore query parameters that cannot be mapped to a corresponding
    /// protobuf field. Use this if you cannot control the query parameters and do
    /// not know them beforehand. Otherwise use ``ignored_query_parameters``.
    /// Defaults to false.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IgnoreUnknownQueryParameters {
      get { return ignoreUnknownQueryParameters_; }
      set {
        ignoreUnknownQueryParameters_ = value;
      }
    }

    private object descriptorSet_;
    /// <summary>Enum of possible cases for the "descriptor_set" oneof.</summary>
    public enum DescriptorSetOneofCase {
      None = 0,
      ProtoDescriptor = 1,
      ProtoDescriptorBin = 4,
    }
    private DescriptorSetOneofCase descriptorSetCase_ = DescriptorSetOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DescriptorSetOneofCase DescriptorSetCase {
      get { return descriptorSetCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearDescriptorSet() {
      descriptorSetCase_ = DescriptorSetOneofCase.None;
      descriptorSet_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GrpcJsonTranscoder);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GrpcJsonTranscoder other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ProtoDescriptor != other.ProtoDescriptor) return false;
      if (ProtoDescriptorBin != other.ProtoDescriptorBin) return false;
      if(!services_.Equals(other.services_)) return false;
      if (!object.Equals(PrintOptions, other.PrintOptions)) return false;
      if (MatchIncomingRequestRoute != other.MatchIncomingRequestRoute) return false;
      if(!ignoredQueryParameters_.Equals(other.ignoredQueryParameters_)) return false;
      if (AutoMapping != other.AutoMapping) return false;
      if (IgnoreUnknownQueryParameters != other.IgnoreUnknownQueryParameters) return false;
      if (DescriptorSetCase != other.DescriptorSetCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (descriptorSetCase_ == DescriptorSetOneofCase.ProtoDescriptor) hash ^= ProtoDescriptor.GetHashCode();
      if (descriptorSetCase_ == DescriptorSetOneofCase.ProtoDescriptorBin) hash ^= ProtoDescriptorBin.GetHashCode();
      hash ^= services_.GetHashCode();
      if (printOptions_ != null) hash ^= PrintOptions.GetHashCode();
      if (MatchIncomingRequestRoute != false) hash ^= MatchIncomingRequestRoute.GetHashCode();
      hash ^= ignoredQueryParameters_.GetHashCode();
      if (AutoMapping != false) hash ^= AutoMapping.GetHashCode();
      if (IgnoreUnknownQueryParameters != false) hash ^= IgnoreUnknownQueryParameters.GetHashCode();
      hash ^= (int) descriptorSetCase_;
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
      if (descriptorSetCase_ == DescriptorSetOneofCase.ProtoDescriptor) {
        output.WriteRawTag(10);
        output.WriteString(ProtoDescriptor);
      }
      services_.WriteTo(output, _repeated_services_codec);
      if (printOptions_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(PrintOptions);
      }
      if (descriptorSetCase_ == DescriptorSetOneofCase.ProtoDescriptorBin) {
        output.WriteRawTag(34);
        output.WriteBytes(ProtoDescriptorBin);
      }
      if (MatchIncomingRequestRoute != false) {
        output.WriteRawTag(40);
        output.WriteBool(MatchIncomingRequestRoute);
      }
      ignoredQueryParameters_.WriteTo(output, _repeated_ignoredQueryParameters_codec);
      if (AutoMapping != false) {
        output.WriteRawTag(56);
        output.WriteBool(AutoMapping);
      }
      if (IgnoreUnknownQueryParameters != false) {
        output.WriteRawTag(64);
        output.WriteBool(IgnoreUnknownQueryParameters);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (descriptorSetCase_ == DescriptorSetOneofCase.ProtoDescriptor) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProtoDescriptor);
      }
      if (descriptorSetCase_ == DescriptorSetOneofCase.ProtoDescriptorBin) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(ProtoDescriptorBin);
      }
      size += services_.CalculateSize(_repeated_services_codec);
      if (printOptions_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PrintOptions);
      }
      if (MatchIncomingRequestRoute != false) {
        size += 1 + 1;
      }
      size += ignoredQueryParameters_.CalculateSize(_repeated_ignoredQueryParameters_codec);
      if (AutoMapping != false) {
        size += 1 + 1;
      }
      if (IgnoreUnknownQueryParameters != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GrpcJsonTranscoder other) {
      if (other == null) {
        return;
      }
      services_.Add(other.services_);
      if (other.printOptions_ != null) {
        if (printOptions_ == null) {
          PrintOptions = new global::Envoy.Config.Filter.Http.Transcoder.V3Alpha.GrpcJsonTranscoder.Types.PrintOptions();
        }
        PrintOptions.MergeFrom(other.PrintOptions);
      }
      if (other.MatchIncomingRequestRoute != false) {
        MatchIncomingRequestRoute = other.MatchIncomingRequestRoute;
      }
      ignoredQueryParameters_.Add(other.ignoredQueryParameters_);
      if (other.AutoMapping != false) {
        AutoMapping = other.AutoMapping;
      }
      if (other.IgnoreUnknownQueryParameters != false) {
        IgnoreUnknownQueryParameters = other.IgnoreUnknownQueryParameters;
      }
      switch (other.DescriptorSetCase) {
        case DescriptorSetOneofCase.ProtoDescriptor:
          ProtoDescriptor = other.ProtoDescriptor;
          break;
        case DescriptorSetOneofCase.ProtoDescriptorBin:
          ProtoDescriptorBin = other.ProtoDescriptorBin;
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
            ProtoDescriptor = input.ReadString();
            break;
          }
          case 18: {
            services_.AddEntriesFrom(input, _repeated_services_codec);
            break;
          }
          case 26: {
            if (printOptions_ == null) {
              PrintOptions = new global::Envoy.Config.Filter.Http.Transcoder.V3Alpha.GrpcJsonTranscoder.Types.PrintOptions();
            }
            input.ReadMessage(PrintOptions);
            break;
          }
          case 34: {
            ProtoDescriptorBin = input.ReadBytes();
            break;
          }
          case 40: {
            MatchIncomingRequestRoute = input.ReadBool();
            break;
          }
          case 50: {
            ignoredQueryParameters_.AddEntriesFrom(input, _repeated_ignoredQueryParameters_codec);
            break;
          }
          case 56: {
            AutoMapping = input.ReadBool();
            break;
          }
          case 64: {
            IgnoreUnknownQueryParameters = input.ReadBool();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the GrpcJsonTranscoder message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public sealed partial class PrintOptions : pb::IMessage<PrintOptions> {
        private static readonly pb::MessageParser<PrintOptions> _parser = new pb::MessageParser<PrintOptions>(() => new PrintOptions());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<PrintOptions> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Envoy.Config.Filter.Http.Transcoder.V3Alpha.GrpcJsonTranscoder.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public PrintOptions() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public PrintOptions(PrintOptions other) : this() {
          addWhitespace_ = other.addWhitespace_;
          alwaysPrintPrimitiveFields_ = other.alwaysPrintPrimitiveFields_;
          alwaysPrintEnumsAsInts_ = other.alwaysPrintEnumsAsInts_;
          preserveProtoFieldNames_ = other.preserveProtoFieldNames_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public PrintOptions Clone() {
          return new PrintOptions(this);
        }

        /// <summary>Field number for the "add_whitespace" field.</summary>
        public const int AddWhitespaceFieldNumber = 1;
        private bool addWhitespace_;
        /// <summary>
        /// Whether to add spaces, line breaks and indentation to make the JSON
        /// output easy to read. Defaults to false.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool AddWhitespace {
          get { return addWhitespace_; }
          set {
            addWhitespace_ = value;
          }
        }

        /// <summary>Field number for the "always_print_primitive_fields" field.</summary>
        public const int AlwaysPrintPrimitiveFieldsFieldNumber = 2;
        private bool alwaysPrintPrimitiveFields_;
        /// <summary>
        /// Whether to always print primitive fields. By default primitive
        /// fields with default values will be omitted in JSON output. For
        /// example, an int32 field set to 0 will be omitted. Setting this flag to
        /// true will override the default behavior and print primitive fields
        /// regardless of their values. Defaults to false.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool AlwaysPrintPrimitiveFields {
          get { return alwaysPrintPrimitiveFields_; }
          set {
            alwaysPrintPrimitiveFields_ = value;
          }
        }

        /// <summary>Field number for the "always_print_enums_as_ints" field.</summary>
        public const int AlwaysPrintEnumsAsIntsFieldNumber = 3;
        private bool alwaysPrintEnumsAsInts_;
        /// <summary>
        /// Whether to always print enums as ints. By default they are rendered
        /// as strings. Defaults to false.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool AlwaysPrintEnumsAsInts {
          get { return alwaysPrintEnumsAsInts_; }
          set {
            alwaysPrintEnumsAsInts_ = value;
          }
        }

        /// <summary>Field number for the "preserve_proto_field_names" field.</summary>
        public const int PreserveProtoFieldNamesFieldNumber = 4;
        private bool preserveProtoFieldNames_;
        /// <summary>
        /// Whether to preserve proto field names. By default protobuf will
        /// generate JSON field names using the ``json_name`` option, or lower camel case,
        /// in that order. Setting this flag will preserve the original field names. Defaults to false.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool PreserveProtoFieldNames {
          get { return preserveProtoFieldNames_; }
          set {
            preserveProtoFieldNames_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as PrintOptions);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(PrintOptions other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (AddWhitespace != other.AddWhitespace) return false;
          if (AlwaysPrintPrimitiveFields != other.AlwaysPrintPrimitiveFields) return false;
          if (AlwaysPrintEnumsAsInts != other.AlwaysPrintEnumsAsInts) return false;
          if (PreserveProtoFieldNames != other.PreserveProtoFieldNames) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (AddWhitespace != false) hash ^= AddWhitespace.GetHashCode();
          if (AlwaysPrintPrimitiveFields != false) hash ^= AlwaysPrintPrimitiveFields.GetHashCode();
          if (AlwaysPrintEnumsAsInts != false) hash ^= AlwaysPrintEnumsAsInts.GetHashCode();
          if (PreserveProtoFieldNames != false) hash ^= PreserveProtoFieldNames.GetHashCode();
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
          if (AddWhitespace != false) {
            output.WriteRawTag(8);
            output.WriteBool(AddWhitespace);
          }
          if (AlwaysPrintPrimitiveFields != false) {
            output.WriteRawTag(16);
            output.WriteBool(AlwaysPrintPrimitiveFields);
          }
          if (AlwaysPrintEnumsAsInts != false) {
            output.WriteRawTag(24);
            output.WriteBool(AlwaysPrintEnumsAsInts);
          }
          if (PreserveProtoFieldNames != false) {
            output.WriteRawTag(32);
            output.WriteBool(PreserveProtoFieldNames);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (AddWhitespace != false) {
            size += 1 + 1;
          }
          if (AlwaysPrintPrimitiveFields != false) {
            size += 1 + 1;
          }
          if (AlwaysPrintEnumsAsInts != false) {
            size += 1 + 1;
          }
          if (PreserveProtoFieldNames != false) {
            size += 1 + 1;
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(PrintOptions other) {
          if (other == null) {
            return;
          }
          if (other.AddWhitespace != false) {
            AddWhitespace = other.AddWhitespace;
          }
          if (other.AlwaysPrintPrimitiveFields != false) {
            AlwaysPrintPrimitiveFields = other.AlwaysPrintPrimitiveFields;
          }
          if (other.AlwaysPrintEnumsAsInts != false) {
            AlwaysPrintEnumsAsInts = other.AlwaysPrintEnumsAsInts;
          }
          if (other.PreserveProtoFieldNames != false) {
            PreserveProtoFieldNames = other.PreserveProtoFieldNames;
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
                AddWhitespace = input.ReadBool();
                break;
              }
              case 16: {
                AlwaysPrintPrimitiveFields = input.ReadBool();
                break;
              }
              case 24: {
                AlwaysPrintEnumsAsInts = input.ReadBool();
                break;
              }
              case 32: {
                PreserveProtoFieldNames = input.ReadBool();
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
