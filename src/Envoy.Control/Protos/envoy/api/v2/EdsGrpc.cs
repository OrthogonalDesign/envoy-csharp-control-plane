// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/api/v2/eds.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Envoy.Api.V2 {
  public static partial class EndpointDiscoveryService
  {
    static readonly string __ServiceName = "envoy.api.v2.EndpointDiscoveryService";

    static readonly grpc::Marshaller<global::Envoy.Api.V2.DiscoveryRequest> __Marshaller_envoy_api_v2_DiscoveryRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Envoy.Api.V2.DiscoveryRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Envoy.Api.V2.DiscoveryResponse> __Marshaller_envoy_api_v2_DiscoveryResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Envoy.Api.V2.DiscoveryResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Envoy.Api.V2.DeltaDiscoveryRequest> __Marshaller_envoy_api_v2_DeltaDiscoveryRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Envoy.Api.V2.DeltaDiscoveryRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Envoy.Api.V2.DeltaDiscoveryResponse> __Marshaller_envoy_api_v2_DeltaDiscoveryResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Envoy.Api.V2.DeltaDiscoveryResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Envoy.Api.V2.DiscoveryRequest, global::Envoy.Api.V2.DiscoveryResponse> __Method_StreamEndpoints = new grpc::Method<global::Envoy.Api.V2.DiscoveryRequest, global::Envoy.Api.V2.DiscoveryResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "StreamEndpoints",
        __Marshaller_envoy_api_v2_DiscoveryRequest,
        __Marshaller_envoy_api_v2_DiscoveryResponse);

    static readonly grpc::Method<global::Envoy.Api.V2.DeltaDiscoveryRequest, global::Envoy.Api.V2.DeltaDiscoveryResponse> __Method_DeltaEndpoints = new grpc::Method<global::Envoy.Api.V2.DeltaDiscoveryRequest, global::Envoy.Api.V2.DeltaDiscoveryResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "DeltaEndpoints",
        __Marshaller_envoy_api_v2_DeltaDiscoveryRequest,
        __Marshaller_envoy_api_v2_DeltaDiscoveryResponse);

    static readonly grpc::Method<global::Envoy.Api.V2.DiscoveryRequest, global::Envoy.Api.V2.DiscoveryResponse> __Method_FetchEndpoints = new grpc::Method<global::Envoy.Api.V2.DiscoveryRequest, global::Envoy.Api.V2.DiscoveryResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "FetchEndpoints",
        __Marshaller_envoy_api_v2_DiscoveryRequest,
        __Marshaller_envoy_api_v2_DiscoveryResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Envoy.Api.V2.EdsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of EndpointDiscoveryService</summary>
    [grpc::BindServiceMethod(typeof(EndpointDiscoveryService), "BindService")]
    public abstract partial class EndpointDiscoveryServiceBase
    {
      /// <summary>
      /// The resource_names field in DiscoveryRequest specifies a list of clusters
      /// to subscribe to updates for.
      /// </summary>
      /// <param name="requestStream">Used for reading requests from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      public virtual global::System.Threading.Tasks.Task StreamEndpoints(grpc::IAsyncStreamReader<global::Envoy.Api.V2.DiscoveryRequest> requestStream, grpc::IServerStreamWriter<global::Envoy.Api.V2.DiscoveryResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task DeltaEndpoints(grpc::IAsyncStreamReader<global::Envoy.Api.V2.DeltaDiscoveryRequest> requestStream, grpc::IServerStreamWriter<global::Envoy.Api.V2.DeltaDiscoveryResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Envoy.Api.V2.DiscoveryResponse> FetchEndpoints(global::Envoy.Api.V2.DiscoveryRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for EndpointDiscoveryService</summary>
    public partial class EndpointDiscoveryServiceClient : grpc::ClientBase<EndpointDiscoveryServiceClient>
    {
      /// <summary>Creates a new client for EndpointDiscoveryService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public EndpointDiscoveryServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for EndpointDiscoveryService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public EndpointDiscoveryServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected EndpointDiscoveryServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected EndpointDiscoveryServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// The resource_names field in DiscoveryRequest specifies a list of clusters
      /// to subscribe to updates for.
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncDuplexStreamingCall<global::Envoy.Api.V2.DiscoveryRequest, global::Envoy.Api.V2.DiscoveryResponse> StreamEndpoints(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return StreamEndpoints(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// The resource_names field in DiscoveryRequest specifies a list of clusters
      /// to subscribe to updates for.
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncDuplexStreamingCall<global::Envoy.Api.V2.DiscoveryRequest, global::Envoy.Api.V2.DiscoveryResponse> StreamEndpoints(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_StreamEndpoints, null, options);
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Envoy.Api.V2.DeltaDiscoveryRequest, global::Envoy.Api.V2.DeltaDiscoveryResponse> DeltaEndpoints(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeltaEndpoints(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Envoy.Api.V2.DeltaDiscoveryRequest, global::Envoy.Api.V2.DeltaDiscoveryResponse> DeltaEndpoints(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_DeltaEndpoints, null, options);
      }
      public virtual global::Envoy.Api.V2.DiscoveryResponse FetchEndpoints(global::Envoy.Api.V2.DiscoveryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return FetchEndpoints(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Envoy.Api.V2.DiscoveryResponse FetchEndpoints(global::Envoy.Api.V2.DiscoveryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_FetchEndpoints, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Envoy.Api.V2.DiscoveryResponse> FetchEndpointsAsync(global::Envoy.Api.V2.DiscoveryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return FetchEndpointsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Envoy.Api.V2.DiscoveryResponse> FetchEndpointsAsync(global::Envoy.Api.V2.DiscoveryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_FetchEndpoints, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override EndpointDiscoveryServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new EndpointDiscoveryServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(EndpointDiscoveryServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_StreamEndpoints, serviceImpl.StreamEndpoints)
          .AddMethod(__Method_DeltaEndpoints, serviceImpl.DeltaEndpoints)
          .AddMethod(__Method_FetchEndpoints, serviceImpl.FetchEndpoints).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, EndpointDiscoveryServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_StreamEndpoints, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Envoy.Api.V2.DiscoveryRequest, global::Envoy.Api.V2.DiscoveryResponse>(serviceImpl.StreamEndpoints));
      serviceBinder.AddMethod(__Method_DeltaEndpoints, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Envoy.Api.V2.DeltaDiscoveryRequest, global::Envoy.Api.V2.DeltaDiscoveryResponse>(serviceImpl.DeltaEndpoints));
      serviceBinder.AddMethod(__Method_FetchEndpoints, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Envoy.Api.V2.DiscoveryRequest, global::Envoy.Api.V2.DiscoveryResponse>(serviceImpl.FetchEndpoints));
    }

  }
}
#endregion
