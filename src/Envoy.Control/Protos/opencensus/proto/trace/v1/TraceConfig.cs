// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: opencensus/proto/trace/v1/trace_config.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Opencensus.Proto.Trace.V1 {

  /// <summary>Holder for reflection information generated from opencensus/proto/trace/v1/trace_config.proto</summary>
  public static partial class TraceConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for opencensus/proto/trace/v1/trace_config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TraceConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CixvcGVuY2Vuc3VzL3Byb3RvL3RyYWNlL3YxL3RyYWNlX2NvbmZpZy5wcm90",
            "bxIZb3BlbmNlbnN1cy5wcm90by50cmFjZS52MSKHAwoLVHJhY2VDb25maWcS",
            "TAoTcHJvYmFiaWxpdHlfc2FtcGxlchgBIAEoCzItLm9wZW5jZW5zdXMucHJv",
            "dG8udHJhY2UudjEuUHJvYmFiaWxpdHlTYW1wbGVySAASRgoQY29uc3RhbnRf",
            "c2FtcGxlchgCIAEoCzIqLm9wZW5jZW5zdXMucHJvdG8udHJhY2UudjEuQ29u",
            "c3RhbnRTYW1wbGVySAASTwoVcmF0ZV9saW1pdGluZ19zYW1wbGVyGAMgASgL",
            "Mi4ub3BlbmNlbnN1cy5wcm90by50cmFjZS52MS5SYXRlTGltaXRpbmdTYW1w",
            "bGVySAASIAoYbWF4X251bWJlcl9vZl9hdHRyaWJ1dGVzGAQgASgDEiEKGW1h",
            "eF9udW1iZXJfb2ZfYW5ub3RhdGlvbnMYBSABKAMSJAocbWF4X251bWJlcl9v",
            "Zl9tZXNzYWdlX2V2ZW50cxgGIAEoAxIbChNtYXhfbnVtYmVyX29mX2xpbmtz",
            "GAcgASgDQgkKB3NhbXBsZXIiMQoSUHJvYmFiaWxpdHlTYW1wbGVyEhsKE3Nh",
            "bXBsaW5nUHJvYmFiaWxpdHkYASABKAEipgEKD0NvbnN0YW50U2FtcGxlchJN",
            "CghkZWNpc2lvbhgBIAEoDjI7Lm9wZW5jZW5zdXMucHJvdG8udHJhY2UudjEu",
            "Q29uc3RhbnRTYW1wbGVyLkNvbnN0YW50RGVjaXNpb24iRAoQQ29uc3RhbnRE",
            "ZWNpc2lvbhIOCgpBTFdBWVNfT0ZGEAASDQoJQUxXQVlTX09OEAESEQoNQUxX",
            "QVlTX1BBUkVOVBACIiIKE1JhdGVMaW1pdGluZ1NhbXBsZXISCwoDcXBzGAEg",
            "ASgDQnYKHGlvLm9wZW5jZW5zdXMucHJvdG8udHJhY2UudjFCEFRyYWNlQ29u",
            "ZmlnUHJvdG9QAVpCZ2l0aHViLmNvbS9jZW5zdXMtaW5zdHJ1bWVudGF0aW9u",
            "L29wZW5jZW5zdXMtcHJvdG8vZ2VuLWdvL3RyYWNlL3YxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Opencensus.Proto.Trace.V1.TraceConfig), global::Opencensus.Proto.Trace.V1.TraceConfig.Parser, new[]{ "ProbabilitySampler", "ConstantSampler", "RateLimitingSampler", "MaxNumberOfAttributes", "MaxNumberOfAnnotations", "MaxNumberOfMessageEvents", "MaxNumberOfLinks" }, new[]{ "Sampler" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Opencensus.Proto.Trace.V1.ProbabilitySampler), global::Opencensus.Proto.Trace.V1.ProbabilitySampler.Parser, new[]{ "SamplingProbability" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Opencensus.Proto.Trace.V1.ConstantSampler), global::Opencensus.Proto.Trace.V1.ConstantSampler.Parser, new[]{ "Decision" }, null, new[]{ typeof(global::Opencensus.Proto.Trace.V1.ConstantSampler.Types.ConstantDecision) }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Opencensus.Proto.Trace.V1.RateLimitingSampler), global::Opencensus.Proto.Trace.V1.RateLimitingSampler.Parser, new[]{ "Qps" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Global configuration of the trace service. All fields must be specified, or
  /// the default (zero) values will be used for each type.
  /// </summary>
  public sealed partial class TraceConfig : pb::IMessage<TraceConfig> {
    private static readonly pb::MessageParser<TraceConfig> _parser = new pb::MessageParser<TraceConfig>(() => new TraceConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TraceConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Opencensus.Proto.Trace.V1.TraceConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TraceConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TraceConfig(TraceConfig other) : this() {
      maxNumberOfAttributes_ = other.maxNumberOfAttributes_;
      maxNumberOfAnnotations_ = other.maxNumberOfAnnotations_;
      maxNumberOfMessageEvents_ = other.maxNumberOfMessageEvents_;
      maxNumberOfLinks_ = other.maxNumberOfLinks_;
      switch (other.SamplerCase) {
        case SamplerOneofCase.ProbabilitySampler:
          ProbabilitySampler = other.ProbabilitySampler.Clone();
          break;
        case SamplerOneofCase.ConstantSampler:
          ConstantSampler = other.ConstantSampler.Clone();
          break;
        case SamplerOneofCase.RateLimitingSampler:
          RateLimitingSampler = other.RateLimitingSampler.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TraceConfig Clone() {
      return new TraceConfig(this);
    }

    /// <summary>Field number for the "probability_sampler" field.</summary>
    public const int ProbabilitySamplerFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Opencensus.Proto.Trace.V1.ProbabilitySampler ProbabilitySampler {
      get { return samplerCase_ == SamplerOneofCase.ProbabilitySampler ? (global::Opencensus.Proto.Trace.V1.ProbabilitySampler) sampler_ : null; }
      set {
        sampler_ = value;
        samplerCase_ = value == null ? SamplerOneofCase.None : SamplerOneofCase.ProbabilitySampler;
      }
    }

    /// <summary>Field number for the "constant_sampler" field.</summary>
    public const int ConstantSamplerFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Opencensus.Proto.Trace.V1.ConstantSampler ConstantSampler {
      get { return samplerCase_ == SamplerOneofCase.ConstantSampler ? (global::Opencensus.Proto.Trace.V1.ConstantSampler) sampler_ : null; }
      set {
        sampler_ = value;
        samplerCase_ = value == null ? SamplerOneofCase.None : SamplerOneofCase.ConstantSampler;
      }
    }

    /// <summary>Field number for the "rate_limiting_sampler" field.</summary>
    public const int RateLimitingSamplerFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Opencensus.Proto.Trace.V1.RateLimitingSampler RateLimitingSampler {
      get { return samplerCase_ == SamplerOneofCase.RateLimitingSampler ? (global::Opencensus.Proto.Trace.V1.RateLimitingSampler) sampler_ : null; }
      set {
        sampler_ = value;
        samplerCase_ = value == null ? SamplerOneofCase.None : SamplerOneofCase.RateLimitingSampler;
      }
    }

    /// <summary>Field number for the "max_number_of_attributes" field.</summary>
    public const int MaxNumberOfAttributesFieldNumber = 4;
    private long maxNumberOfAttributes_;
    /// <summary>
    /// The global default max number of attributes per span.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long MaxNumberOfAttributes {
      get { return maxNumberOfAttributes_; }
      set {
        maxNumberOfAttributes_ = value;
      }
    }

    /// <summary>Field number for the "max_number_of_annotations" field.</summary>
    public const int MaxNumberOfAnnotationsFieldNumber = 5;
    private long maxNumberOfAnnotations_;
    /// <summary>
    /// The global default max number of annotation events per span.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long MaxNumberOfAnnotations {
      get { return maxNumberOfAnnotations_; }
      set {
        maxNumberOfAnnotations_ = value;
      }
    }

    /// <summary>Field number for the "max_number_of_message_events" field.</summary>
    public const int MaxNumberOfMessageEventsFieldNumber = 6;
    private long maxNumberOfMessageEvents_;
    /// <summary>
    /// The global default max number of message events per span.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long MaxNumberOfMessageEvents {
      get { return maxNumberOfMessageEvents_; }
      set {
        maxNumberOfMessageEvents_ = value;
      }
    }

    /// <summary>Field number for the "max_number_of_links" field.</summary>
    public const int MaxNumberOfLinksFieldNumber = 7;
    private long maxNumberOfLinks_;
    /// <summary>
    /// The global default max number of link entries per span.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long MaxNumberOfLinks {
      get { return maxNumberOfLinks_; }
      set {
        maxNumberOfLinks_ = value;
      }
    }

    private object sampler_;
    /// <summary>Enum of possible cases for the "sampler" oneof.</summary>
    public enum SamplerOneofCase {
      None = 0,
      ProbabilitySampler = 1,
      ConstantSampler = 2,
      RateLimitingSampler = 3,
    }
    private SamplerOneofCase samplerCase_ = SamplerOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SamplerOneofCase SamplerCase {
      get { return samplerCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearSampler() {
      samplerCase_ = SamplerOneofCase.None;
      sampler_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TraceConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TraceConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ProbabilitySampler, other.ProbabilitySampler)) return false;
      if (!object.Equals(ConstantSampler, other.ConstantSampler)) return false;
      if (!object.Equals(RateLimitingSampler, other.RateLimitingSampler)) return false;
      if (MaxNumberOfAttributes != other.MaxNumberOfAttributes) return false;
      if (MaxNumberOfAnnotations != other.MaxNumberOfAnnotations) return false;
      if (MaxNumberOfMessageEvents != other.MaxNumberOfMessageEvents) return false;
      if (MaxNumberOfLinks != other.MaxNumberOfLinks) return false;
      if (SamplerCase != other.SamplerCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (samplerCase_ == SamplerOneofCase.ProbabilitySampler) hash ^= ProbabilitySampler.GetHashCode();
      if (samplerCase_ == SamplerOneofCase.ConstantSampler) hash ^= ConstantSampler.GetHashCode();
      if (samplerCase_ == SamplerOneofCase.RateLimitingSampler) hash ^= RateLimitingSampler.GetHashCode();
      if (MaxNumberOfAttributes != 0L) hash ^= MaxNumberOfAttributes.GetHashCode();
      if (MaxNumberOfAnnotations != 0L) hash ^= MaxNumberOfAnnotations.GetHashCode();
      if (MaxNumberOfMessageEvents != 0L) hash ^= MaxNumberOfMessageEvents.GetHashCode();
      if (MaxNumberOfLinks != 0L) hash ^= MaxNumberOfLinks.GetHashCode();
      hash ^= (int) samplerCase_;
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
      if (samplerCase_ == SamplerOneofCase.ProbabilitySampler) {
        output.WriteRawTag(10);
        output.WriteMessage(ProbabilitySampler);
      }
      if (samplerCase_ == SamplerOneofCase.ConstantSampler) {
        output.WriteRawTag(18);
        output.WriteMessage(ConstantSampler);
      }
      if (samplerCase_ == SamplerOneofCase.RateLimitingSampler) {
        output.WriteRawTag(26);
        output.WriteMessage(RateLimitingSampler);
      }
      if (MaxNumberOfAttributes != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(MaxNumberOfAttributes);
      }
      if (MaxNumberOfAnnotations != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(MaxNumberOfAnnotations);
      }
      if (MaxNumberOfMessageEvents != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(MaxNumberOfMessageEvents);
      }
      if (MaxNumberOfLinks != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(MaxNumberOfLinks);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (samplerCase_ == SamplerOneofCase.ProbabilitySampler) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ProbabilitySampler);
      }
      if (samplerCase_ == SamplerOneofCase.ConstantSampler) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ConstantSampler);
      }
      if (samplerCase_ == SamplerOneofCase.RateLimitingSampler) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RateLimitingSampler);
      }
      if (MaxNumberOfAttributes != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(MaxNumberOfAttributes);
      }
      if (MaxNumberOfAnnotations != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(MaxNumberOfAnnotations);
      }
      if (MaxNumberOfMessageEvents != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(MaxNumberOfMessageEvents);
      }
      if (MaxNumberOfLinks != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(MaxNumberOfLinks);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TraceConfig other) {
      if (other == null) {
        return;
      }
      if (other.MaxNumberOfAttributes != 0L) {
        MaxNumberOfAttributes = other.MaxNumberOfAttributes;
      }
      if (other.MaxNumberOfAnnotations != 0L) {
        MaxNumberOfAnnotations = other.MaxNumberOfAnnotations;
      }
      if (other.MaxNumberOfMessageEvents != 0L) {
        MaxNumberOfMessageEvents = other.MaxNumberOfMessageEvents;
      }
      if (other.MaxNumberOfLinks != 0L) {
        MaxNumberOfLinks = other.MaxNumberOfLinks;
      }
      switch (other.SamplerCase) {
        case SamplerOneofCase.ProbabilitySampler:
          if (ProbabilitySampler == null) {
            ProbabilitySampler = new global::Opencensus.Proto.Trace.V1.ProbabilitySampler();
          }
          ProbabilitySampler.MergeFrom(other.ProbabilitySampler);
          break;
        case SamplerOneofCase.ConstantSampler:
          if (ConstantSampler == null) {
            ConstantSampler = new global::Opencensus.Proto.Trace.V1.ConstantSampler();
          }
          ConstantSampler.MergeFrom(other.ConstantSampler);
          break;
        case SamplerOneofCase.RateLimitingSampler:
          if (RateLimitingSampler == null) {
            RateLimitingSampler = new global::Opencensus.Proto.Trace.V1.RateLimitingSampler();
          }
          RateLimitingSampler.MergeFrom(other.RateLimitingSampler);
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
            global::Opencensus.Proto.Trace.V1.ProbabilitySampler subBuilder = new global::Opencensus.Proto.Trace.V1.ProbabilitySampler();
            if (samplerCase_ == SamplerOneofCase.ProbabilitySampler) {
              subBuilder.MergeFrom(ProbabilitySampler);
            }
            input.ReadMessage(subBuilder);
            ProbabilitySampler = subBuilder;
            break;
          }
          case 18: {
            global::Opencensus.Proto.Trace.V1.ConstantSampler subBuilder = new global::Opencensus.Proto.Trace.V1.ConstantSampler();
            if (samplerCase_ == SamplerOneofCase.ConstantSampler) {
              subBuilder.MergeFrom(ConstantSampler);
            }
            input.ReadMessage(subBuilder);
            ConstantSampler = subBuilder;
            break;
          }
          case 26: {
            global::Opencensus.Proto.Trace.V1.RateLimitingSampler subBuilder = new global::Opencensus.Proto.Trace.V1.RateLimitingSampler();
            if (samplerCase_ == SamplerOneofCase.RateLimitingSampler) {
              subBuilder.MergeFrom(RateLimitingSampler);
            }
            input.ReadMessage(subBuilder);
            RateLimitingSampler = subBuilder;
            break;
          }
          case 32: {
            MaxNumberOfAttributes = input.ReadInt64();
            break;
          }
          case 40: {
            MaxNumberOfAnnotations = input.ReadInt64();
            break;
          }
          case 48: {
            MaxNumberOfMessageEvents = input.ReadInt64();
            break;
          }
          case 56: {
            MaxNumberOfLinks = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Sampler that tries to uniformly sample traces with a given probability.
  /// The probability of sampling a trace is equal to that of the specified probability.
  /// </summary>
  public sealed partial class ProbabilitySampler : pb::IMessage<ProbabilitySampler> {
    private static readonly pb::MessageParser<ProbabilitySampler> _parser = new pb::MessageParser<ProbabilitySampler>(() => new ProbabilitySampler());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ProbabilitySampler> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Opencensus.Proto.Trace.V1.TraceConfigReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProbabilitySampler() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProbabilitySampler(ProbabilitySampler other) : this() {
      samplingProbability_ = other.samplingProbability_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProbabilitySampler Clone() {
      return new ProbabilitySampler(this);
    }

    /// <summary>Field number for the "samplingProbability" field.</summary>
    public const int SamplingProbabilityFieldNumber = 1;
    private double samplingProbability_;
    /// <summary>
    /// The desired probability of sampling. Must be within [0.0, 1.0].
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double SamplingProbability {
      get { return samplingProbability_; }
      set {
        samplingProbability_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ProbabilitySampler);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ProbabilitySampler other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(SamplingProbability, other.SamplingProbability)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SamplingProbability != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(SamplingProbability);
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
      if (SamplingProbability != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(SamplingProbability);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SamplingProbability != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ProbabilitySampler other) {
      if (other == null) {
        return;
      }
      if (other.SamplingProbability != 0D) {
        SamplingProbability = other.SamplingProbability;
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
          case 9: {
            SamplingProbability = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Sampler that always makes a constant decision on span sampling.
  /// </summary>
  public sealed partial class ConstantSampler : pb::IMessage<ConstantSampler> {
    private static readonly pb::MessageParser<ConstantSampler> _parser = new pb::MessageParser<ConstantSampler>(() => new ConstantSampler());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ConstantSampler> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Opencensus.Proto.Trace.V1.TraceConfigReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConstantSampler() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConstantSampler(ConstantSampler other) : this() {
      decision_ = other.decision_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConstantSampler Clone() {
      return new ConstantSampler(this);
    }

    /// <summary>Field number for the "decision" field.</summary>
    public const int DecisionFieldNumber = 1;
    private global::Opencensus.Proto.Trace.V1.ConstantSampler.Types.ConstantDecision decision_ = global::Opencensus.Proto.Trace.V1.ConstantSampler.Types.ConstantDecision.AlwaysOff;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Opencensus.Proto.Trace.V1.ConstantSampler.Types.ConstantDecision Decision {
      get { return decision_; }
      set {
        decision_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ConstantSampler);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ConstantSampler other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Decision != other.Decision) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Decision != global::Opencensus.Proto.Trace.V1.ConstantSampler.Types.ConstantDecision.AlwaysOff) hash ^= Decision.GetHashCode();
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
      if (Decision != global::Opencensus.Proto.Trace.V1.ConstantSampler.Types.ConstantDecision.AlwaysOff) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Decision);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Decision != global::Opencensus.Proto.Trace.V1.ConstantSampler.Types.ConstantDecision.AlwaysOff) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Decision);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ConstantSampler other) {
      if (other == null) {
        return;
      }
      if (other.Decision != global::Opencensus.Proto.Trace.V1.ConstantSampler.Types.ConstantDecision.AlwaysOff) {
        Decision = other.Decision;
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
            Decision = (global::Opencensus.Proto.Trace.V1.ConstantSampler.Types.ConstantDecision) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the ConstantSampler message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// How spans should be sampled:
      /// - Always off
      /// - Always on
      /// - Always follow the parent Span's decision (off if no parent).
      /// </summary>
      public enum ConstantDecision {
        [pbr::OriginalName("ALWAYS_OFF")] AlwaysOff = 0,
        [pbr::OriginalName("ALWAYS_ON")] AlwaysOn = 1,
        [pbr::OriginalName("ALWAYS_PARENT")] AlwaysParent = 2,
      }

    }
    #endregion

  }

  /// <summary>
  /// Sampler that tries to sample with a rate per time window.
  /// </summary>
  public sealed partial class RateLimitingSampler : pb::IMessage<RateLimitingSampler> {
    private static readonly pb::MessageParser<RateLimitingSampler> _parser = new pb::MessageParser<RateLimitingSampler>(() => new RateLimitingSampler());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RateLimitingSampler> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Opencensus.Proto.Trace.V1.TraceConfigReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RateLimitingSampler() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RateLimitingSampler(RateLimitingSampler other) : this() {
      qps_ = other.qps_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RateLimitingSampler Clone() {
      return new RateLimitingSampler(this);
    }

    /// <summary>Field number for the "qps" field.</summary>
    public const int QpsFieldNumber = 1;
    private long qps_;
    /// <summary>
    /// Rate per second.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Qps {
      get { return qps_; }
      set {
        qps_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RateLimitingSampler);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RateLimitingSampler other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Qps != other.Qps) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Qps != 0L) hash ^= Qps.GetHashCode();
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
      if (Qps != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Qps);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Qps != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Qps);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RateLimitingSampler other) {
      if (other == null) {
        return;
      }
      if (other.Qps != 0L) {
        Qps = other.Qps;
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
            Qps = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
