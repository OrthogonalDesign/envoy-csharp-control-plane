// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/admin/v2alpha/certs.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Admin.V2Alpha {

  /// <summary>Holder for reflection information generated from envoy/admin/v2alpha/certs.proto</summary>
  public static partial class CertsReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/admin/v2alpha/certs.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CertsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9lbnZveS9hZG1pbi92MmFscGhhL2NlcnRzLnByb3RvEhNlbnZveS5hZG1p",
            "bi52MmFscGhhGh9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3RvIkYK",
            "DENlcnRpZmljYXRlcxI2CgxjZXJ0aWZpY2F0ZXMYASADKAsyIC5lbnZveS5h",
            "ZG1pbi52MmFscGhhLkNlcnRpZmljYXRlIoQBCgtDZXJ0aWZpY2F0ZRI4Cgdj",
            "YV9jZXJ0GAEgAygLMicuZW52b3kuYWRtaW4udjJhbHBoYS5DZXJ0aWZpY2F0",
            "ZURldGFpbHMSOwoKY2VydF9jaGFpbhgCIAMoCzInLmVudm95LmFkbWluLnYy",
            "YWxwaGEuQ2VydGlmaWNhdGVEZXRhaWxzIoMCChJDZXJ0aWZpY2F0ZURldGFp",
            "bHMSDAoEcGF0aBgBIAEoCRIVCg1zZXJpYWxfbnVtYmVyGAIgASgJEkQKEXN1",
            "YmplY3RfYWx0X25hbWVzGAMgAygLMikuZW52b3kuYWRtaW4udjJhbHBoYS5T",
            "dWJqZWN0QWx0ZXJuYXRlTmFtZRIdChVkYXlzX3VudGlsX2V4cGlyYXRpb24Y",
            "BCABKAQSLgoKdmFsaWRfZnJvbRgFIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5U",
            "aW1lc3RhbXASMwoPZXhwaXJhdGlvbl90aW1lGAYgASgLMhouZ29vZ2xlLnBy",
            "b3RvYnVmLlRpbWVzdGFtcCI8ChRTdWJqZWN0QWx0ZXJuYXRlTmFtZRINCgNk",
            "bnMYASABKAlIABINCgN1cmkYAiABKAlIAEIGCgRuYW1lQjEKIWlvLmVudm95",
            "cHJveHkuZW52b3kuYWRtaW4udjJhbHBoYUIKQ2VydHNQcm90b1ABYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Admin.V2Alpha.Certificates), global::Envoy.Admin.V2Alpha.Certificates.Parser, new[]{ "Certificates_" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Admin.V2Alpha.Certificate), global::Envoy.Admin.V2Alpha.Certificate.Parser, new[]{ "CaCert", "CertChain" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Admin.V2Alpha.CertificateDetails), global::Envoy.Admin.V2Alpha.CertificateDetails.Parser, new[]{ "Path", "SerialNumber", "SubjectAltNames", "DaysUntilExpiration", "ValidFrom", "ExpirationTime" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Admin.V2Alpha.SubjectAlternateName), global::Envoy.Admin.V2Alpha.SubjectAlternateName.Parser, new[]{ "Dns", "Uri" }, new[]{ "Name" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Proto representation of certificate details. Admin endpoint uses this wrapper for `/certs` to
  /// display certificate information. See :ref:`/certs &lt;operations_admin_interface_certs>` for more
  /// information.
  /// </summary>
  public sealed partial class Certificates : pb::IMessage<Certificates> {
    private static readonly pb::MessageParser<Certificates> _parser = new pb::MessageParser<Certificates>(() => new Certificates());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Certificates> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Admin.V2Alpha.CertsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Certificates() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Certificates(Certificates other) : this() {
      certificates_ = other.certificates_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Certificates Clone() {
      return new Certificates(this);
    }

    /// <summary>Field number for the "certificates" field.</summary>
    public const int Certificates_FieldNumber = 1;
    private static readonly pb::FieldCodec<global::Envoy.Admin.V2Alpha.Certificate> _repeated_certificates_codec
        = pb::FieldCodec.ForMessage(10, global::Envoy.Admin.V2Alpha.Certificate.Parser);
    private readonly pbc::RepeatedField<global::Envoy.Admin.V2Alpha.Certificate> certificates_ = new pbc::RepeatedField<global::Envoy.Admin.V2Alpha.Certificate>();
    /// <summary>
    /// List of certificates known to an Envoy.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Envoy.Admin.V2Alpha.Certificate> Certificates_ {
      get { return certificates_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Certificates);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Certificates other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!certificates_.Equals(other.certificates_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= certificates_.GetHashCode();
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
      certificates_.WriteTo(output, _repeated_certificates_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += certificates_.CalculateSize(_repeated_certificates_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Certificates other) {
      if (other == null) {
        return;
      }
      certificates_.Add(other.certificates_);
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
            certificates_.AddEntriesFrom(input, _repeated_certificates_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class Certificate : pb::IMessage<Certificate> {
    private static readonly pb::MessageParser<Certificate> _parser = new pb::MessageParser<Certificate>(() => new Certificate());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Certificate> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Admin.V2Alpha.CertsReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Certificate() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Certificate(Certificate other) : this() {
      caCert_ = other.caCert_.Clone();
      certChain_ = other.certChain_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Certificate Clone() {
      return new Certificate(this);
    }

    /// <summary>Field number for the "ca_cert" field.</summary>
    public const int CaCertFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Envoy.Admin.V2Alpha.CertificateDetails> _repeated_caCert_codec
        = pb::FieldCodec.ForMessage(10, global::Envoy.Admin.V2Alpha.CertificateDetails.Parser);
    private readonly pbc::RepeatedField<global::Envoy.Admin.V2Alpha.CertificateDetails> caCert_ = new pbc::RepeatedField<global::Envoy.Admin.V2Alpha.CertificateDetails>();
    /// <summary>
    /// Details of CA certificate.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Envoy.Admin.V2Alpha.CertificateDetails> CaCert {
      get { return caCert_; }
    }

    /// <summary>Field number for the "cert_chain" field.</summary>
    public const int CertChainFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Envoy.Admin.V2Alpha.CertificateDetails> _repeated_certChain_codec
        = pb::FieldCodec.ForMessage(18, global::Envoy.Admin.V2Alpha.CertificateDetails.Parser);
    private readonly pbc::RepeatedField<global::Envoy.Admin.V2Alpha.CertificateDetails> certChain_ = new pbc::RepeatedField<global::Envoy.Admin.V2Alpha.CertificateDetails>();
    /// <summary>
    /// Details of Certificate Chain
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Envoy.Admin.V2Alpha.CertificateDetails> CertChain {
      get { return certChain_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Certificate);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Certificate other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!caCert_.Equals(other.caCert_)) return false;
      if(!certChain_.Equals(other.certChain_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= caCert_.GetHashCode();
      hash ^= certChain_.GetHashCode();
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
      caCert_.WriteTo(output, _repeated_caCert_codec);
      certChain_.WriteTo(output, _repeated_certChain_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += caCert_.CalculateSize(_repeated_caCert_codec);
      size += certChain_.CalculateSize(_repeated_certChain_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Certificate other) {
      if (other == null) {
        return;
      }
      caCert_.Add(other.caCert_);
      certChain_.Add(other.certChain_);
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
            caCert_.AddEntriesFrom(input, _repeated_caCert_codec);
            break;
          }
          case 18: {
            certChain_.AddEntriesFrom(input, _repeated_certChain_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class CertificateDetails : pb::IMessage<CertificateDetails> {
    private static readonly pb::MessageParser<CertificateDetails> _parser = new pb::MessageParser<CertificateDetails>(() => new CertificateDetails());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CertificateDetails> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Admin.V2Alpha.CertsReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CertificateDetails() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CertificateDetails(CertificateDetails other) : this() {
      path_ = other.path_;
      serialNumber_ = other.serialNumber_;
      subjectAltNames_ = other.subjectAltNames_.Clone();
      daysUntilExpiration_ = other.daysUntilExpiration_;
      validFrom_ = other.validFrom_ != null ? other.validFrom_.Clone() : null;
      expirationTime_ = other.expirationTime_ != null ? other.expirationTime_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CertificateDetails Clone() {
      return new CertificateDetails(this);
    }

    /// <summary>Field number for the "path" field.</summary>
    public const int PathFieldNumber = 1;
    private string path_ = "";
    /// <summary>
    /// Path of the certificate.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Path {
      get { return path_; }
      set {
        path_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "serial_number" field.</summary>
    public const int SerialNumberFieldNumber = 2;
    private string serialNumber_ = "";
    /// <summary>
    /// Certificate Serial Number.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SerialNumber {
      get { return serialNumber_; }
      set {
        serialNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "subject_alt_names" field.</summary>
    public const int SubjectAltNamesFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Envoy.Admin.V2Alpha.SubjectAlternateName> _repeated_subjectAltNames_codec
        = pb::FieldCodec.ForMessage(26, global::Envoy.Admin.V2Alpha.SubjectAlternateName.Parser);
    private readonly pbc::RepeatedField<global::Envoy.Admin.V2Alpha.SubjectAlternateName> subjectAltNames_ = new pbc::RepeatedField<global::Envoy.Admin.V2Alpha.SubjectAlternateName>();
    /// <summary>
    /// List of Subject Alternate names.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Envoy.Admin.V2Alpha.SubjectAlternateName> SubjectAltNames {
      get { return subjectAltNames_; }
    }

    /// <summary>Field number for the "days_until_expiration" field.</summary>
    public const int DaysUntilExpirationFieldNumber = 4;
    private ulong daysUntilExpiration_;
    /// <summary>
    /// Minimum of days until expiration of certificate and it's chain.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong DaysUntilExpiration {
      get { return daysUntilExpiration_; }
      set {
        daysUntilExpiration_ = value;
      }
    }

    /// <summary>Field number for the "valid_from" field.</summary>
    public const int ValidFromFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Timestamp validFrom_;
    /// <summary>
    /// Indicates the time from which the certificate is valid.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp ValidFrom {
      get { return validFrom_; }
      set {
        validFrom_ = value;
      }
    }

    /// <summary>Field number for the "expiration_time" field.</summary>
    public const int ExpirationTimeFieldNumber = 6;
    private global::Google.Protobuf.WellKnownTypes.Timestamp expirationTime_;
    /// <summary>
    /// Indicates the time at which the certificate expires.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp ExpirationTime {
      get { return expirationTime_; }
      set {
        expirationTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CertificateDetails);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CertificateDetails other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Path != other.Path) return false;
      if (SerialNumber != other.SerialNumber) return false;
      if(!subjectAltNames_.Equals(other.subjectAltNames_)) return false;
      if (DaysUntilExpiration != other.DaysUntilExpiration) return false;
      if (!object.Equals(ValidFrom, other.ValidFrom)) return false;
      if (!object.Equals(ExpirationTime, other.ExpirationTime)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Path.Length != 0) hash ^= Path.GetHashCode();
      if (SerialNumber.Length != 0) hash ^= SerialNumber.GetHashCode();
      hash ^= subjectAltNames_.GetHashCode();
      if (DaysUntilExpiration != 0UL) hash ^= DaysUntilExpiration.GetHashCode();
      if (validFrom_ != null) hash ^= ValidFrom.GetHashCode();
      if (expirationTime_ != null) hash ^= ExpirationTime.GetHashCode();
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
      if (Path.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Path);
      }
      if (SerialNumber.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(SerialNumber);
      }
      subjectAltNames_.WriteTo(output, _repeated_subjectAltNames_codec);
      if (DaysUntilExpiration != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(DaysUntilExpiration);
      }
      if (validFrom_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(ValidFrom);
      }
      if (expirationTime_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(ExpirationTime);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Path.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Path);
      }
      if (SerialNumber.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SerialNumber);
      }
      size += subjectAltNames_.CalculateSize(_repeated_subjectAltNames_codec);
      if (DaysUntilExpiration != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(DaysUntilExpiration);
      }
      if (validFrom_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ValidFrom);
      }
      if (expirationTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ExpirationTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CertificateDetails other) {
      if (other == null) {
        return;
      }
      if (other.Path.Length != 0) {
        Path = other.Path;
      }
      if (other.SerialNumber.Length != 0) {
        SerialNumber = other.SerialNumber;
      }
      subjectAltNames_.Add(other.subjectAltNames_);
      if (other.DaysUntilExpiration != 0UL) {
        DaysUntilExpiration = other.DaysUntilExpiration;
      }
      if (other.validFrom_ != null) {
        if (validFrom_ == null) {
          ValidFrom = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        ValidFrom.MergeFrom(other.ValidFrom);
      }
      if (other.expirationTime_ != null) {
        if (expirationTime_ == null) {
          ExpirationTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        ExpirationTime.MergeFrom(other.ExpirationTime);
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
            Path = input.ReadString();
            break;
          }
          case 18: {
            SerialNumber = input.ReadString();
            break;
          }
          case 26: {
            subjectAltNames_.AddEntriesFrom(input, _repeated_subjectAltNames_codec);
            break;
          }
          case 32: {
            DaysUntilExpiration = input.ReadUInt64();
            break;
          }
          case 42: {
            if (validFrom_ == null) {
              ValidFrom = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ValidFrom);
            break;
          }
          case 50: {
            if (expirationTime_ == null) {
              ExpirationTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ExpirationTime);
            break;
          }
        }
      }
    }

  }

  public sealed partial class SubjectAlternateName : pb::IMessage<SubjectAlternateName> {
    private static readonly pb::MessageParser<SubjectAlternateName> _parser = new pb::MessageParser<SubjectAlternateName>(() => new SubjectAlternateName());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SubjectAlternateName> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Admin.V2Alpha.CertsReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SubjectAlternateName() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SubjectAlternateName(SubjectAlternateName other) : this() {
      switch (other.NameCase) {
        case NameOneofCase.Dns:
          Dns = other.Dns;
          break;
        case NameOneofCase.Uri:
          Uri = other.Uri;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SubjectAlternateName Clone() {
      return new SubjectAlternateName(this);
    }

    /// <summary>Field number for the "dns" field.</summary>
    public const int DnsFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Dns {
      get { return nameCase_ == NameOneofCase.Dns ? (string) name_ : ""; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        nameCase_ = NameOneofCase.Dns;
      }
    }

    /// <summary>Field number for the "uri" field.</summary>
    public const int UriFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Uri {
      get { return nameCase_ == NameOneofCase.Uri ? (string) name_ : ""; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        nameCase_ = NameOneofCase.Uri;
      }
    }

    private object name_;
    /// <summary>Enum of possible cases for the "name" oneof.</summary>
    public enum NameOneofCase {
      None = 0,
      Dns = 1,
      Uri = 2,
    }
    private NameOneofCase nameCase_ = NameOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NameOneofCase NameCase {
      get { return nameCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearName() {
      nameCase_ = NameOneofCase.None;
      name_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SubjectAlternateName);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SubjectAlternateName other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Dns != other.Dns) return false;
      if (Uri != other.Uri) return false;
      if (NameCase != other.NameCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (nameCase_ == NameOneofCase.Dns) hash ^= Dns.GetHashCode();
      if (nameCase_ == NameOneofCase.Uri) hash ^= Uri.GetHashCode();
      hash ^= (int) nameCase_;
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
      if (nameCase_ == NameOneofCase.Dns) {
        output.WriteRawTag(10);
        output.WriteString(Dns);
      }
      if (nameCase_ == NameOneofCase.Uri) {
        output.WriteRawTag(18);
        output.WriteString(Uri);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (nameCase_ == NameOneofCase.Dns) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Dns);
      }
      if (nameCase_ == NameOneofCase.Uri) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Uri);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SubjectAlternateName other) {
      if (other == null) {
        return;
      }
      switch (other.NameCase) {
        case NameOneofCase.Dns:
          Dns = other.Dns;
          break;
        case NameOneofCase.Uri:
          Uri = other.Uri;
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
            Dns = input.ReadString();
            break;
          }
          case 18: {
            Uri = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
