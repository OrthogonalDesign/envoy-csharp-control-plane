// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/config/common/tap/v2alpha/common.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Config.Common.Tap.V2Alpha {

  /// <summary>Holder for reflection information generated from envoy/config/common/tap/v2alpha/common.proto</summary>
  public static partial class CommonReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/config/common/tap/v2alpha/common.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CommonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CixlbnZveS9jb25maWcvY29tbW9uL3RhcC92MmFscGhhL2NvbW1vbi5wcm90",
            "bxIfZW52b3kuY29uZmlnLmNvbW1vbi50YXAudjJhbHBoYRomZW52b3kvc2Vy",
            "dmljZS90YXAvdjJhbHBoYS9jb21tb24ucHJvdG8aJWVudm95L2FwaS92Mi9j",
            "b3JlL2NvbmZpZ19zb3VyY2UucHJvdG8aF3ZhbGlkYXRlL3ZhbGlkYXRlLnBy",
            "b3RvIvoCChVDb21tb25FeHRlbnNpb25Db25maWcSRAoMYWRtaW5fY29uZmln",
            "GAEgASgLMiwuZW52b3kuY29uZmlnLmNvbW1vbi50YXAudjJhbHBoYS5BZG1p",
            "bkNvbmZpZ0gAEj0KDXN0YXRpY19jb25maWcYAiABKAsyJC5lbnZveS5zZXJ2",
            "aWNlLnRhcC52MmFscGhhLlRhcENvbmZpZ0gAEloKDHRhcGRzX2NvbmZpZxgD",
            "IAEoCzJCLmVudm95LmNvbmZpZy5jb21tb24udGFwLnYyYWxwaGEuQ29tbW9u",
            "RXh0ZW5zaW9uQ29uZmlnLlRhcERTQ29uZmlnSAAaagoLVGFwRFNDb25maWcS",
            "QgoNY29uZmlnX3NvdXJjZRgBIAEoCzIfLmVudm95LmFwaS52Mi5jb3JlLkNv",
            "bmZpZ1NvdXJjZUIKuunAAwWKAQIQARIXCgRuYW1lGAIgASgJQgm66cADBHIC",
            "IAFCFAoLY29uZmlnX3R5cGUSBbjpwAMBIisKC0FkbWluQ29uZmlnEhwKCWNv",
            "bmZpZ19pZBgBIAEoCUIJuunAAwRyAiABQj4KLWlvLmVudm95cHJveHkuZW52",
            "b3kuY29uZmlnLmNvbW1vbi50YXAudjJhbHBoYUILQ29tbW9uUHJvdG9QAWIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Service.Tap.V2Alpha.CommonReflection.Descriptor, global::Envoy.Api.V2.Core.ConfigSourceReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Common.Tap.V2Alpha.CommonExtensionConfig), global::Envoy.Config.Common.Tap.V2Alpha.CommonExtensionConfig.Parser, new[]{ "AdminConfig", "StaticConfig", "TapdsConfig" }, new[]{ "ConfigType" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Common.Tap.V2Alpha.CommonExtensionConfig.Types.TapDSConfig), global::Envoy.Config.Common.Tap.V2Alpha.CommonExtensionConfig.Types.TapDSConfig.Parser, new[]{ "ConfigSource", "Name" }, null, null, null, null)}),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Common.Tap.V2Alpha.AdminConfig), global::Envoy.Config.Common.Tap.V2Alpha.AdminConfig.Parser, new[]{ "ConfigId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Common configuration for all tap extensions.
  /// </summary>
  public sealed partial class CommonExtensionConfig : pb::IMessage<CommonExtensionConfig> {
    private static readonly pb::MessageParser<CommonExtensionConfig> _parser = new pb::MessageParser<CommonExtensionConfig>(() => new CommonExtensionConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CommonExtensionConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Common.Tap.V2Alpha.CommonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommonExtensionConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommonExtensionConfig(CommonExtensionConfig other) : this() {
      switch (other.ConfigTypeCase) {
        case ConfigTypeOneofCase.AdminConfig:
          AdminConfig = other.AdminConfig.Clone();
          break;
        case ConfigTypeOneofCase.StaticConfig:
          StaticConfig = other.StaticConfig.Clone();
          break;
        case ConfigTypeOneofCase.TapdsConfig:
          TapdsConfig = other.TapdsConfig.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommonExtensionConfig Clone() {
      return new CommonExtensionConfig(this);
    }

    /// <summary>Field number for the "admin_config" field.</summary>
    public const int AdminConfigFieldNumber = 1;
    /// <summary>
    /// If specified, the tap filter will be configured via an admin handler.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Envoy.Config.Common.Tap.V2Alpha.AdminConfig AdminConfig {
      get { return configTypeCase_ == ConfigTypeOneofCase.AdminConfig ? (global::Envoy.Config.Common.Tap.V2Alpha.AdminConfig) configType_ : null; }
      set {
        configType_ = value;
        configTypeCase_ = value == null ? ConfigTypeOneofCase.None : ConfigTypeOneofCase.AdminConfig;
      }
    }

    /// <summary>Field number for the "static_config" field.</summary>
    public const int StaticConfigFieldNumber = 2;
    /// <summary>
    /// If specified, the tap filter will be configured via a static configuration that cannot be
    /// changed.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Envoy.Service.Tap.V2Alpha.TapConfig StaticConfig {
      get { return configTypeCase_ == ConfigTypeOneofCase.StaticConfig ? (global::Envoy.Service.Tap.V2Alpha.TapConfig) configType_ : null; }
      set {
        configType_ = value;
        configTypeCase_ = value == null ? ConfigTypeOneofCase.None : ConfigTypeOneofCase.StaticConfig;
      }
    }

    /// <summary>Field number for the "tapds_config" field.</summary>
    public const int TapdsConfigFieldNumber = 3;
    /// <summary>
    /// [#not-implemented-hide:] Configuration to use for TapDS updates for the filter.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Envoy.Config.Common.Tap.V2Alpha.CommonExtensionConfig.Types.TapDSConfig TapdsConfig {
      get { return configTypeCase_ == ConfigTypeOneofCase.TapdsConfig ? (global::Envoy.Config.Common.Tap.V2Alpha.CommonExtensionConfig.Types.TapDSConfig) configType_ : null; }
      set {
        configType_ = value;
        configTypeCase_ = value == null ? ConfigTypeOneofCase.None : ConfigTypeOneofCase.TapdsConfig;
      }
    }

    private object configType_;
    /// <summary>Enum of possible cases for the "config_type" oneof.</summary>
    public enum ConfigTypeOneofCase {
      None = 0,
      AdminConfig = 1,
      StaticConfig = 2,
      TapdsConfig = 3,
    }
    private ConfigTypeOneofCase configTypeCase_ = ConfigTypeOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConfigTypeOneofCase ConfigTypeCase {
      get { return configTypeCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearConfigType() {
      configTypeCase_ = ConfigTypeOneofCase.None;
      configType_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CommonExtensionConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CommonExtensionConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(AdminConfig, other.AdminConfig)) return false;
      if (!object.Equals(StaticConfig, other.StaticConfig)) return false;
      if (!object.Equals(TapdsConfig, other.TapdsConfig)) return false;
      if (ConfigTypeCase != other.ConfigTypeCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (configTypeCase_ == ConfigTypeOneofCase.AdminConfig) hash ^= AdminConfig.GetHashCode();
      if (configTypeCase_ == ConfigTypeOneofCase.StaticConfig) hash ^= StaticConfig.GetHashCode();
      if (configTypeCase_ == ConfigTypeOneofCase.TapdsConfig) hash ^= TapdsConfig.GetHashCode();
      hash ^= (int) configTypeCase_;
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
      if (configTypeCase_ == ConfigTypeOneofCase.AdminConfig) {
        output.WriteRawTag(10);
        output.WriteMessage(AdminConfig);
      }
      if (configTypeCase_ == ConfigTypeOneofCase.StaticConfig) {
        output.WriteRawTag(18);
        output.WriteMessage(StaticConfig);
      }
      if (configTypeCase_ == ConfigTypeOneofCase.TapdsConfig) {
        output.WriteRawTag(26);
        output.WriteMessage(TapdsConfig);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (configTypeCase_ == ConfigTypeOneofCase.AdminConfig) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AdminConfig);
      }
      if (configTypeCase_ == ConfigTypeOneofCase.StaticConfig) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StaticConfig);
      }
      if (configTypeCase_ == ConfigTypeOneofCase.TapdsConfig) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TapdsConfig);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CommonExtensionConfig other) {
      if (other == null) {
        return;
      }
      switch (other.ConfigTypeCase) {
        case ConfigTypeOneofCase.AdminConfig:
          if (AdminConfig == null) {
            AdminConfig = new global::Envoy.Config.Common.Tap.V2Alpha.AdminConfig();
          }
          AdminConfig.MergeFrom(other.AdminConfig);
          break;
        case ConfigTypeOneofCase.StaticConfig:
          if (StaticConfig == null) {
            StaticConfig = new global::Envoy.Service.Tap.V2Alpha.TapConfig();
          }
          StaticConfig.MergeFrom(other.StaticConfig);
          break;
        case ConfigTypeOneofCase.TapdsConfig:
          if (TapdsConfig == null) {
            TapdsConfig = new global::Envoy.Config.Common.Tap.V2Alpha.CommonExtensionConfig.Types.TapDSConfig();
          }
          TapdsConfig.MergeFrom(other.TapdsConfig);
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
            global::Envoy.Config.Common.Tap.V2Alpha.AdminConfig subBuilder = new global::Envoy.Config.Common.Tap.V2Alpha.AdminConfig();
            if (configTypeCase_ == ConfigTypeOneofCase.AdminConfig) {
              subBuilder.MergeFrom(AdminConfig);
            }
            input.ReadMessage(subBuilder);
            AdminConfig = subBuilder;
            break;
          }
          case 18: {
            global::Envoy.Service.Tap.V2Alpha.TapConfig subBuilder = new global::Envoy.Service.Tap.V2Alpha.TapConfig();
            if (configTypeCase_ == ConfigTypeOneofCase.StaticConfig) {
              subBuilder.MergeFrom(StaticConfig);
            }
            input.ReadMessage(subBuilder);
            StaticConfig = subBuilder;
            break;
          }
          case 26: {
            global::Envoy.Config.Common.Tap.V2Alpha.CommonExtensionConfig.Types.TapDSConfig subBuilder = new global::Envoy.Config.Common.Tap.V2Alpha.CommonExtensionConfig.Types.TapDSConfig();
            if (configTypeCase_ == ConfigTypeOneofCase.TapdsConfig) {
              subBuilder.MergeFrom(TapdsConfig);
            }
            input.ReadMessage(subBuilder);
            TapdsConfig = subBuilder;
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the CommonExtensionConfig message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// [#not-implemented-hide:]
      /// </summary>
      public sealed partial class TapDSConfig : pb::IMessage<TapDSConfig> {
        private static readonly pb::MessageParser<TapDSConfig> _parser = new pb::MessageParser<TapDSConfig>(() => new TapDSConfig());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<TapDSConfig> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Envoy.Config.Common.Tap.V2Alpha.CommonExtensionConfig.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public TapDSConfig() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public TapDSConfig(TapDSConfig other) : this() {
          configSource_ = other.configSource_ != null ? other.configSource_.Clone() : null;
          name_ = other.name_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public TapDSConfig Clone() {
          return new TapDSConfig(this);
        }

        /// <summary>Field number for the "config_source" field.</summary>
        public const int ConfigSourceFieldNumber = 1;
        private global::Envoy.Api.V2.Core.ConfigSource configSource_;
        /// <summary>
        /// Configuration for the source of TapDS updates for this Cluster.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Envoy.Api.V2.Core.ConfigSource ConfigSource {
          get { return configSource_; }
          set {
            configSource_ = value;
          }
        }

        /// <summary>Field number for the "name" field.</summary>
        public const int NameFieldNumber = 2;
        private string name_ = "";
        /// <summary>
        /// Tap config to request from XDS server.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Name {
          get { return name_; }
          set {
            name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as TapDSConfig);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(TapDSConfig other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (!object.Equals(ConfigSource, other.ConfigSource)) return false;
          if (Name != other.Name) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (configSource_ != null) hash ^= ConfigSource.GetHashCode();
          if (Name.Length != 0) hash ^= Name.GetHashCode();
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
          if (Name.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(Name);
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
          if (Name.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(TapDSConfig other) {
          if (other == null) {
            return;
          }
          if (other.configSource_ != null) {
            if (configSource_ == null) {
              ConfigSource = new global::Envoy.Api.V2.Core.ConfigSource();
            }
            ConfigSource.MergeFrom(other.ConfigSource);
          }
          if (other.Name.Length != 0) {
            Name = other.Name;
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
                  ConfigSource = new global::Envoy.Api.V2.Core.ConfigSource();
                }
                input.ReadMessage(ConfigSource);
                break;
              }
              case 18: {
                Name = input.ReadString();
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  /// <summary>
  /// Configuration for the admin handler. See :ref:`here &lt;config_http_filters_tap_admin_handler>` for
  /// more information.
  /// </summary>
  public sealed partial class AdminConfig : pb::IMessage<AdminConfig> {
    private static readonly pb::MessageParser<AdminConfig> _parser = new pb::MessageParser<AdminConfig>(() => new AdminConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AdminConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Common.Tap.V2Alpha.CommonReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdminConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdminConfig(AdminConfig other) : this() {
      configId_ = other.configId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdminConfig Clone() {
      return new AdminConfig(this);
    }

    /// <summary>Field number for the "config_id" field.</summary>
    public const int ConfigIdFieldNumber = 1;
    private string configId_ = "";
    /// <summary>
    /// Opaque configuration ID. When requests are made to the admin handler, the passed opaque ID is
    /// matched to the configured filter opaque ID to determine which filter to configure.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ConfigId {
      get { return configId_; }
      set {
        configId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AdminConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AdminConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ConfigId != other.ConfigId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ConfigId.Length != 0) hash ^= ConfigId.GetHashCode();
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
      if (ConfigId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ConfigId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ConfigId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ConfigId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AdminConfig other) {
      if (other == null) {
        return;
      }
      if (other.ConfigId.Length != 0) {
        ConfigId = other.ConfigId;
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
            ConfigId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
