// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/service/accesslog/v3alpha/als.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Envoy.Service.Accesslog.V3Alpha {
  /// <summary>
  /// Service for streaming access logs from Envoy to an access log server.
  /// </summary>
  public static partial class AccessLogService
  {
    static readonly string __ServiceName = "envoy.service.accesslog.v3alpha.AccessLogService";

    static readonly grpc::Marshaller<global::Envoy.Service.Accesslog.V3Alpha.StreamAccessLogsMessage> __Marshaller_envoy_service_accesslog_v3alpha_StreamAccessLogsMessage = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Envoy.Service.Accesslog.V3Alpha.StreamAccessLogsMessage.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Envoy.Service.Accesslog.V3Alpha.StreamAccessLogsResponse> __Marshaller_envoy_service_accesslog_v3alpha_StreamAccessLogsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Envoy.Service.Accesslog.V3Alpha.StreamAccessLogsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Envoy.Service.Accesslog.V3Alpha.StreamAccessLogsMessage, global::Envoy.Service.Accesslog.V3Alpha.StreamAccessLogsResponse> __Method_StreamAccessLogs = new grpc::Method<global::Envoy.Service.Accesslog.V3Alpha.StreamAccessLogsMessage, global::Envoy.Service.Accesslog.V3Alpha.StreamAccessLogsResponse>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "StreamAccessLogs",
        __Marshaller_envoy_service_accesslog_v3alpha_StreamAccessLogsMessage,
        __Marshaller_envoy_service_accesslog_v3alpha_StreamAccessLogsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Envoy.Service.Accesslog.V3Alpha.AlsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of AccessLogService</summary>
    [grpc::BindServiceMethod(typeof(AccessLogService), "BindService")]
    public abstract partial class AccessLogServiceBase
    {
      /// <summary>
      /// Envoy will connect and send StreamAccessLogsMessage messages forever. It does not expect any
      /// response to be sent as nothing would be done in the case of failure. The server should
      /// disconnect if it expects Envoy to reconnect. In the future we may decide to add a different
      /// API for "critical" access logs in which Envoy will buffer access logs for some period of time
      /// until it gets an ACK so it could then retry. This API is designed for high throughput with the
      /// expectation that it might be lossy.
      /// </summary>
      /// <param name="requestStream">Used for reading requests from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Envoy.Service.Accesslog.V3Alpha.StreamAccessLogsResponse> StreamAccessLogs(grpc::IAsyncStreamReader<global::Envoy.Service.Accesslog.V3Alpha.StreamAccessLogsMessage> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for AccessLogService</summary>
    public partial class AccessLogServiceClient : grpc::ClientBase<AccessLogServiceClient>
    {
      /// <summary>Creates a new client for AccessLogService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public AccessLogServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AccessLogService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public AccessLogServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected AccessLogServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected AccessLogServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Envoy will connect and send StreamAccessLogsMessage messages forever. It does not expect any
      /// response to be sent as nothing would be done in the case of failure. The server should
      /// disconnect if it expects Envoy to reconnect. In the future we may decide to add a different
      /// API for "critical" access logs in which Envoy will buffer access logs for some period of time
      /// until it gets an ACK so it could then retry. This API is designed for high throughput with the
      /// expectation that it might be lossy.
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncClientStreamingCall<global::Envoy.Service.Accesslog.V3Alpha.StreamAccessLogsMessage, global::Envoy.Service.Accesslog.V3Alpha.StreamAccessLogsResponse> StreamAccessLogs(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return StreamAccessLogs(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Envoy will connect and send StreamAccessLogsMessage messages forever. It does not expect any
      /// response to be sent as nothing would be done in the case of failure. The server should
      /// disconnect if it expects Envoy to reconnect. In the future we may decide to add a different
      /// API for "critical" access logs in which Envoy will buffer access logs for some period of time
      /// until it gets an ACK so it could then retry. This API is designed for high throughput with the
      /// expectation that it might be lossy.
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncClientStreamingCall<global::Envoy.Service.Accesslog.V3Alpha.StreamAccessLogsMessage, global::Envoy.Service.Accesslog.V3Alpha.StreamAccessLogsResponse> StreamAccessLogs(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_StreamAccessLogs, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override AccessLogServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AccessLogServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(AccessLogServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_StreamAccessLogs, serviceImpl.StreamAccessLogs).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, AccessLogServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_StreamAccessLogs, serviceImpl == null ? null : new grpc::ClientStreamingServerMethod<global::Envoy.Service.Accesslog.V3Alpha.StreamAccessLogsMessage, global::Envoy.Service.Accesslog.V3Alpha.StreamAccessLogsResponse>(serviceImpl.StreamAccessLogs));
    }

  }
}
#endregion