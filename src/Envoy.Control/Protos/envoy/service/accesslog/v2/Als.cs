// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/service/accesslog/v2/als.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Service.Accesslog.V2 {

  /// <summary>Holder for reflection information generated from envoy/service/accesslog/v2/als.proto</summary>
  public static partial class AlsReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/service/accesslog/v2/als.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AlsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRlbnZveS9zZXJ2aWNlL2FjY2Vzc2xvZy92Mi9hbHMucHJvdG8SGmVudm95",
            "LnNlcnZpY2UuYWNjZXNzbG9nLnYyGhxlbnZveS9hcGkvdjIvY29yZS9iYXNl",
            "LnByb3RvGidlbnZveS9kYXRhL2FjY2Vzc2xvZy92Mi9hY2Nlc3Nsb2cucHJv",
            "dG8aF3ZhbGlkYXRlL3ZhbGlkYXRlLnByb3RvIhoKGFN0cmVhbUFjY2Vzc0xv",
            "Z3NSZXNwb25zZSLjBAoXU3RyZWFtQWNjZXNzTG9nc01lc3NhZ2USUgoKaWRl",
            "bnRpZmllchgBIAEoCzI+LmVudm95LnNlcnZpY2UuYWNjZXNzbG9nLnYyLlN0",
            "cmVhbUFjY2Vzc0xvZ3NNZXNzYWdlLklkZW50aWZpZXISXQoJaHR0cF9sb2dz",
            "GAIgASgLMkguZW52b3kuc2VydmljZS5hY2Nlc3Nsb2cudjIuU3RyZWFtQWNj",
            "ZXNzTG9nc01lc3NhZ2UuSFRUUEFjY2Vzc0xvZ0VudHJpZXNIABJbCgh0Y3Bf",
            "bG9ncxgDIAEoCzJHLmVudm95LnNlcnZpY2UuYWNjZXNzbG9nLnYyLlN0cmVh",
            "bUFjY2Vzc0xvZ3NNZXNzYWdlLlRDUEFjY2Vzc0xvZ0VudHJpZXNIABpcCgpJ",
            "ZGVudGlmaWVyEjEKBG5vZGUYASABKAsyFy5lbnZveS5hcGkudjIuY29yZS5O",
            "b2RlQgq66cADBYoBAhABEhsKCGxvZ19uYW1lGAIgASgJQgm66cADBHICIAEa",
            "YgoUSFRUUEFjY2Vzc0xvZ0VudHJpZXMSSgoJbG9nX2VudHJ5GAEgAygLMisu",
            "ZW52b3kuZGF0YS5hY2Nlc3Nsb2cudjIuSFRUUEFjY2Vzc0xvZ0VudHJ5Qgq6",
            "6cADBZIBAggBGmAKE1RDUEFjY2Vzc0xvZ0VudHJpZXMSSQoJbG9nX2VudHJ5",
            "GAEgAygLMiouZW52b3kuZGF0YS5hY2Nlc3Nsb2cudjIuVENQQWNjZXNzTG9n",
            "RW50cnlCCrrpwAMFkgECCAFCFAoLbG9nX2VudHJpZXMSBbjpwAMBMpYBChBB",
            "Y2Nlc3NMb2dTZXJ2aWNlEoEBChBTdHJlYW1BY2Nlc3NMb2dzEjMuZW52b3ku",
            "c2VydmljZS5hY2Nlc3Nsb2cudjIuU3RyZWFtQWNjZXNzTG9nc01lc3NhZ2Ua",
            "NC5lbnZveS5zZXJ2aWNlLmFjY2Vzc2xvZy52Mi5TdHJlYW1BY2Nlc3NMb2dz",
            "UmVzcG9uc2UiACgBQjkKKGlvLmVudm95cHJveHkuZW52b3kuc2VydmljZS5h",
            "Y2Nlc3Nsb2cudjJCCEFsc1Byb3RvUAGIAQFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Api.V2.Core.BaseReflection.Descriptor, global::Envoy.Data.Accesslog.V2.AccesslogReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Service.Accesslog.V2.StreamAccessLogsResponse), global::Envoy.Service.Accesslog.V2.StreamAccessLogsResponse.Parser, null, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Service.Accesslog.V2.StreamAccessLogsMessage), global::Envoy.Service.Accesslog.V2.StreamAccessLogsMessage.Parser, new[]{ "Identifier", "HttpLogs", "TcpLogs" }, new[]{ "LogEntries" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Service.Accesslog.V2.StreamAccessLogsMessage.Types.Identifier), global::Envoy.Service.Accesslog.V2.StreamAccessLogsMessage.Types.Identifier.Parser, new[]{ "Node", "LogName" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Service.Accesslog.V2.StreamAccessLogsMessage.Types.HTTPAccessLogEntries), global::Envoy.Service.Accesslog.V2.StreamAccessLogsMessage.Types.HTTPAccessLogEntries.Parser, new[]{ "LogEntry" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Service.Accesslog.V2.StreamAccessLogsMessage.Types.TCPAccessLogEntries), global::Envoy.Service.Accesslog.V2.StreamAccessLogsMessage.Types.TCPAccessLogEntries.Parser, new[]{ "LogEntry" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Empty response for the StreamAccessLogs API. Will never be sent. See below.
  /// </summary>
  public sealed partial class StreamAccessLogsResponse : pb::IMessage<StreamAccessLogsResponse> {
    private static readonly pb::MessageParser<StreamAccessLogsResponse> _parser = new pb::MessageParser<StreamAccessLogsResponse>(() => new StreamAccessLogsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StreamAccessLogsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Service.Accesslog.V2.AlsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StreamAccessLogsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StreamAccessLogsResponse(StreamAccessLogsResponse other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StreamAccessLogsResponse Clone() {
      return new StreamAccessLogsResponse(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StreamAccessLogsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StreamAccessLogsResponse other) {
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
    public void MergeFrom(StreamAccessLogsResponse other) {
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

  /// <summary>
  /// Stream message for the StreamAccessLogs API. Envoy will open a stream to the server and stream
  /// access logs without ever expecting a response.
  /// </summary>
  public sealed partial class StreamAccessLogsMessage : pb::IMessage<StreamAccessLogsMessage> {
    private static readonly pb::MessageParser<StreamAccessLogsMessage> _parser = new pb::MessageParser<StreamAccessLogsMessage>(() => new StreamAccessLogsMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StreamAccessLogsMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Service.Accesslog.V2.AlsReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StreamAccessLogsMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StreamAccessLogsMessage(StreamAccessLogsMessage other) : this() {
      identifier_ = other.identifier_ != null ? other.identifier_.Clone() : null;
      switch (other.LogEntriesCase) {
        case LogEntriesOneofCase.HttpLogs:
          HttpLogs = other.HttpLogs.Clone();
          break;
        case LogEntriesOneofCase.TcpLogs:
          TcpLogs = other.TcpLogs.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StreamAccessLogsMessage Clone() {
      return new StreamAccessLogsMessage(this);
    }

    /// <summary>Field number for the "identifier" field.</summary>
    public const int IdentifierFieldNumber = 1;
    private global::Envoy.Service.Accesslog.V2.StreamAccessLogsMessage.Types.Identifier identifier_;
    /// <summary>
    /// Identifier data that will only be sent in the first message on the stream. This is effectively
    /// structured metadata and is a performance optimization.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Envoy.Service.Accesslog.V2.StreamAccessLogsMessage.Types.Identifier Identifier {
      get { return identifier_; }
      set {
        identifier_ = value;
      }
    }

    /// <summary>Field number for the "http_logs" field.</summary>
    public const int HttpLogsFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Envoy.Service.Accesslog.V2.StreamAccessLogsMessage.Types.HTTPAccessLogEntries HttpLogs {
      get { return logEntriesCase_ == LogEntriesOneofCase.HttpLogs ? (global::Envoy.Service.Accesslog.V2.StreamAccessLogsMessage.Types.HTTPAccessLogEntries) logEntries_ : null; }
      set {
        logEntries_ = value;
        logEntriesCase_ = value == null ? LogEntriesOneofCase.None : LogEntriesOneofCase.HttpLogs;
      }
    }

    /// <summary>Field number for the "tcp_logs" field.</summary>
    public const int TcpLogsFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Envoy.Service.Accesslog.V2.StreamAccessLogsMessage.Types.TCPAccessLogEntries TcpLogs {
      get { return logEntriesCase_ == LogEntriesOneofCase.TcpLogs ? (global::Envoy.Service.Accesslog.V2.StreamAccessLogsMessage.Types.TCPAccessLogEntries) logEntries_ : null; }
      set {
        logEntries_ = value;
        logEntriesCase_ = value == null ? LogEntriesOneofCase.None : LogEntriesOneofCase.TcpLogs;
      }
    }

    private object logEntries_;
    /// <summary>Enum of possible cases for the "log_entries" oneof.</summary>
    public enum LogEntriesOneofCase {
      None = 0,
      HttpLogs = 2,
      TcpLogs = 3,
    }
    private LogEntriesOneofCase logEntriesCase_ = LogEntriesOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LogEntriesOneofCase LogEntriesCase {
      get { return logEntriesCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearLogEntries() {
      logEntriesCase_ = LogEntriesOneofCase.None;
      logEntries_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StreamAccessLogsMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StreamAccessLogsMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Identifier, other.Identifier)) return false;
      if (!object.Equals(HttpLogs, other.HttpLogs)) return false;
      if (!object.Equals(TcpLogs, other.TcpLogs)) return false;
      if (LogEntriesCase != other.LogEntriesCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (identifier_ != null) hash ^= Identifier.GetHashCode();
      if (logEntriesCase_ == LogEntriesOneofCase.HttpLogs) hash ^= HttpLogs.GetHashCode();
      if (logEntriesCase_ == LogEntriesOneofCase.TcpLogs) hash ^= TcpLogs.GetHashCode();
      hash ^= (int) logEntriesCase_;
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
      if (logEntriesCase_ == LogEntriesOneofCase.HttpLogs) {
        output.WriteRawTag(18);
        output.WriteMessage(HttpLogs);
      }
      if (logEntriesCase_ == LogEntriesOneofCase.TcpLogs) {
        output.WriteRawTag(26);
        output.WriteMessage(TcpLogs);
      }
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
      if (logEntriesCase_ == LogEntriesOneofCase.HttpLogs) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(HttpLogs);
      }
      if (logEntriesCase_ == LogEntriesOneofCase.TcpLogs) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TcpLogs);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StreamAccessLogsMessage other) {
      if (other == null) {
        return;
      }
      if (other.identifier_ != null) {
        if (identifier_ == null) {
          Identifier = new global::Envoy.Service.Accesslog.V2.StreamAccessLogsMessage.Types.Identifier();
        }
        Identifier.MergeFrom(other.Identifier);
      }
      switch (other.LogEntriesCase) {
        case LogEntriesOneofCase.HttpLogs:
          if (HttpLogs == null) {
            HttpLogs = new global::Envoy.Service.Accesslog.V2.StreamAccessLogsMessage.Types.HTTPAccessLogEntries();
          }
          HttpLogs.MergeFrom(other.HttpLogs);
          break;
        case LogEntriesOneofCase.TcpLogs:
          if (TcpLogs == null) {
            TcpLogs = new global::Envoy.Service.Accesslog.V2.StreamAccessLogsMessage.Types.TCPAccessLogEntries();
          }
          TcpLogs.MergeFrom(other.TcpLogs);
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
            if (identifier_ == null) {
              Identifier = new global::Envoy.Service.Accesslog.V2.StreamAccessLogsMessage.Types.Identifier();
            }
            input.ReadMessage(Identifier);
            break;
          }
          case 18: {
            global::Envoy.Service.Accesslog.V2.StreamAccessLogsMessage.Types.HTTPAccessLogEntries subBuilder = new global::Envoy.Service.Accesslog.V2.StreamAccessLogsMessage.Types.HTTPAccessLogEntries();
            if (logEntriesCase_ == LogEntriesOneofCase.HttpLogs) {
              subBuilder.MergeFrom(HttpLogs);
            }
            input.ReadMessage(subBuilder);
            HttpLogs = subBuilder;
            break;
          }
          case 26: {
            global::Envoy.Service.Accesslog.V2.StreamAccessLogsMessage.Types.TCPAccessLogEntries subBuilder = new global::Envoy.Service.Accesslog.V2.StreamAccessLogsMessage.Types.TCPAccessLogEntries();
            if (logEntriesCase_ == LogEntriesOneofCase.TcpLogs) {
              subBuilder.MergeFrom(TcpLogs);
            }
            input.ReadMessage(subBuilder);
            TcpLogs = subBuilder;
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the StreamAccessLogsMessage message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public sealed partial class Identifier : pb::IMessage<Identifier> {
        private static readonly pb::MessageParser<Identifier> _parser = new pb::MessageParser<Identifier>(() => new Identifier());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Identifier> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Envoy.Service.Accesslog.V2.StreamAccessLogsMessage.Descriptor.NestedTypes[0]; }
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
          logName_ = other.logName_;
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
        /// The node sending the access log messages over the stream.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Envoy.Api.V2.Core.Node Node {
          get { return node_; }
          set {
            node_ = value;
          }
        }

        /// <summary>Field number for the "log_name" field.</summary>
        public const int LogNameFieldNumber = 2;
        private string logName_ = "";
        /// <summary>
        /// The friendly name of the log configured in :ref:`CommonGrpcAccessLogConfig
        /// &lt;envoy_api_msg_config.accesslog.v2.CommonGrpcAccessLogConfig>`.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string LogName {
          get { return logName_; }
          set {
            logName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
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
          if (LogName != other.LogName) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (node_ != null) hash ^= Node.GetHashCode();
          if (LogName.Length != 0) hash ^= LogName.GetHashCode();
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
          if (LogName.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(LogName);
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
          if (LogName.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(LogName);
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
          if (other.LogName.Length != 0) {
            LogName = other.LogName;
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
              case 18: {
                LogName = input.ReadString();
                break;
              }
            }
          }
        }

      }

      /// <summary>
      /// Wrapper for batches of HTTP access log entries.
      /// </summary>
      public sealed partial class HTTPAccessLogEntries : pb::IMessage<HTTPAccessLogEntries> {
        private static readonly pb::MessageParser<HTTPAccessLogEntries> _parser = new pb::MessageParser<HTTPAccessLogEntries>(() => new HTTPAccessLogEntries());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<HTTPAccessLogEntries> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Envoy.Service.Accesslog.V2.StreamAccessLogsMessage.Descriptor.NestedTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public HTTPAccessLogEntries() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public HTTPAccessLogEntries(HTTPAccessLogEntries other) : this() {
          logEntry_ = other.logEntry_.Clone();
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public HTTPAccessLogEntries Clone() {
          return new HTTPAccessLogEntries(this);
        }

        /// <summary>Field number for the "log_entry" field.</summary>
        public const int LogEntryFieldNumber = 1;
        private static readonly pb::FieldCodec<global::Envoy.Data.Accesslog.V2.HTTPAccessLogEntry> _repeated_logEntry_codec
            = pb::FieldCodec.ForMessage(10, global::Envoy.Data.Accesslog.V2.HTTPAccessLogEntry.Parser);
        private readonly pbc::RepeatedField<global::Envoy.Data.Accesslog.V2.HTTPAccessLogEntry> logEntry_ = new pbc::RepeatedField<global::Envoy.Data.Accesslog.V2.HTTPAccessLogEntry>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<global::Envoy.Data.Accesslog.V2.HTTPAccessLogEntry> LogEntry {
          get { return logEntry_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as HTTPAccessLogEntries);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(HTTPAccessLogEntries other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if(!logEntry_.Equals(other.logEntry_)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          hash ^= logEntry_.GetHashCode();
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
          logEntry_.WriteTo(output, _repeated_logEntry_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          size += logEntry_.CalculateSize(_repeated_logEntry_codec);
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(HTTPAccessLogEntries other) {
          if (other == null) {
            return;
          }
          logEntry_.Add(other.logEntry_);
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
                logEntry_.AddEntriesFrom(input, _repeated_logEntry_codec);
                break;
              }
            }
          }
        }

      }

      /// <summary>
      /// Wrapper for batches of TCP access log entries.
      /// </summary>
      public sealed partial class TCPAccessLogEntries : pb::IMessage<TCPAccessLogEntries> {
        private static readonly pb::MessageParser<TCPAccessLogEntries> _parser = new pb::MessageParser<TCPAccessLogEntries>(() => new TCPAccessLogEntries());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<TCPAccessLogEntries> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Envoy.Service.Accesslog.V2.StreamAccessLogsMessage.Descriptor.NestedTypes[2]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public TCPAccessLogEntries() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public TCPAccessLogEntries(TCPAccessLogEntries other) : this() {
          logEntry_ = other.logEntry_.Clone();
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public TCPAccessLogEntries Clone() {
          return new TCPAccessLogEntries(this);
        }

        /// <summary>Field number for the "log_entry" field.</summary>
        public const int LogEntryFieldNumber = 1;
        private static readonly pb::FieldCodec<global::Envoy.Data.Accesslog.V2.TCPAccessLogEntry> _repeated_logEntry_codec
            = pb::FieldCodec.ForMessage(10, global::Envoy.Data.Accesslog.V2.TCPAccessLogEntry.Parser);
        private readonly pbc::RepeatedField<global::Envoy.Data.Accesslog.V2.TCPAccessLogEntry> logEntry_ = new pbc::RepeatedField<global::Envoy.Data.Accesslog.V2.TCPAccessLogEntry>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<global::Envoy.Data.Accesslog.V2.TCPAccessLogEntry> LogEntry {
          get { return logEntry_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as TCPAccessLogEntries);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(TCPAccessLogEntries other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if(!logEntry_.Equals(other.logEntry_)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          hash ^= logEntry_.GetHashCode();
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
          logEntry_.WriteTo(output, _repeated_logEntry_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          size += logEntry_.CalculateSize(_repeated_logEntry_codec);
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(TCPAccessLogEntries other) {
          if (other == null) {
            return;
          }
          logEntry_.Add(other.logEntry_);
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
                logEntry_.AddEntriesFrom(input, _repeated_logEntry_codec);
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
