// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/api/v3alpha/lds.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Envoy.Api.V3Alpha {
  /// <summary>
  /// The Envoy instance initiates an RPC at startup to discover a list of
  /// listeners. Updates are delivered via streaming from the LDS server and
  /// consist of a complete update of all listeners. Existing connections will be
  /// allowed to drain from listeners that are no longer present.
  /// </summary>
  public static partial class ListenerDiscoveryService
  {
    static readonly string __ServiceName = "envoy.api.v3alpha.ListenerDiscoveryService";

    static readonly grpc::Marshaller<global::Envoy.Api.V3Alpha.DeltaDiscoveryRequest> __Marshaller_envoy_api_v3alpha_DeltaDiscoveryRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Envoy.Api.V3Alpha.DeltaDiscoveryRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Envoy.Api.V3Alpha.DeltaDiscoveryResponse> __Marshaller_envoy_api_v3alpha_DeltaDiscoveryResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Envoy.Api.V3Alpha.DeltaDiscoveryResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Envoy.Api.V3Alpha.DiscoveryRequest> __Marshaller_envoy_api_v3alpha_DiscoveryRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Envoy.Api.V3Alpha.DiscoveryRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Envoy.Api.V3Alpha.DiscoveryResponse> __Marshaller_envoy_api_v3alpha_DiscoveryResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Envoy.Api.V3Alpha.DiscoveryResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Envoy.Api.V3Alpha.DeltaDiscoveryRequest, global::Envoy.Api.V3Alpha.DeltaDiscoveryResponse> __Method_DeltaListeners = new grpc::Method<global::Envoy.Api.V3Alpha.DeltaDiscoveryRequest, global::Envoy.Api.V3Alpha.DeltaDiscoveryResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "DeltaListeners",
        __Marshaller_envoy_api_v3alpha_DeltaDiscoveryRequest,
        __Marshaller_envoy_api_v3alpha_DeltaDiscoveryResponse);

    static readonly grpc::Method<global::Envoy.Api.V3Alpha.DiscoveryRequest, global::Envoy.Api.V3Alpha.DiscoveryResponse> __Method_StreamListeners = new grpc::Method<global::Envoy.Api.V3Alpha.DiscoveryRequest, global::Envoy.Api.V3Alpha.DiscoveryResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "StreamListeners",
        __Marshaller_envoy_api_v3alpha_DiscoveryRequest,
        __Marshaller_envoy_api_v3alpha_DiscoveryResponse);

    static readonly grpc::Method<global::Envoy.Api.V3Alpha.DiscoveryRequest, global::Envoy.Api.V3Alpha.DiscoveryResponse> __Method_FetchListeners = new grpc::Method<global::Envoy.Api.V3Alpha.DiscoveryRequest, global::Envoy.Api.V3Alpha.DiscoveryResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "FetchListeners",
        __Marshaller_envoy_api_v3alpha_DiscoveryRequest,
        __Marshaller_envoy_api_v3alpha_DiscoveryResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Envoy.Api.V3Alpha.LdsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ListenerDiscoveryService</summary>
    [grpc::BindServiceMethod(typeof(ListenerDiscoveryService), "BindService")]
    public abstract partial class ListenerDiscoveryServiceBase
    {
      public virtual global::System.Threading.Tasks.Task DeltaListeners(grpc::IAsyncStreamReader<global::Envoy.Api.V3Alpha.DeltaDiscoveryRequest> requestStream, grpc::IServerStreamWriter<global::Envoy.Api.V3Alpha.DeltaDiscoveryResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task StreamListeners(grpc::IAsyncStreamReader<global::Envoy.Api.V3Alpha.DiscoveryRequest> requestStream, grpc::IServerStreamWriter<global::Envoy.Api.V3Alpha.DiscoveryResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Envoy.Api.V3Alpha.DiscoveryResponse> FetchListeners(global::Envoy.Api.V3Alpha.DiscoveryRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ListenerDiscoveryService</summary>
    public partial class ListenerDiscoveryServiceClient : grpc::ClientBase<ListenerDiscoveryServiceClient>
    {
      /// <summary>Creates a new client for ListenerDiscoveryService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ListenerDiscoveryServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ListenerDiscoveryService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ListenerDiscoveryServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ListenerDiscoveryServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ListenerDiscoveryServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncDuplexStreamingCall<global::Envoy.Api.V3Alpha.DeltaDiscoveryRequest, global::Envoy.Api.V3Alpha.DeltaDiscoveryResponse> DeltaListeners(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeltaListeners(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Envoy.Api.V3Alpha.DeltaDiscoveryRequest, global::Envoy.Api.V3Alpha.DeltaDiscoveryResponse> DeltaListeners(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_DeltaListeners, null, options);
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Envoy.Api.V3Alpha.DiscoveryRequest, global::Envoy.Api.V3Alpha.DiscoveryResponse> StreamListeners(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return StreamListeners(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Envoy.Api.V3Alpha.DiscoveryRequest, global::Envoy.Api.V3Alpha.DiscoveryResponse> StreamListeners(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_StreamListeners, null, options);
      }
      public virtual global::Envoy.Api.V3Alpha.DiscoveryResponse FetchListeners(global::Envoy.Api.V3Alpha.DiscoveryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return FetchListeners(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Envoy.Api.V3Alpha.DiscoveryResponse FetchListeners(global::Envoy.Api.V3Alpha.DiscoveryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_FetchListeners, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Envoy.Api.V3Alpha.DiscoveryResponse> FetchListenersAsync(global::Envoy.Api.V3Alpha.DiscoveryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return FetchListenersAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Envoy.Api.V3Alpha.DiscoveryResponse> FetchListenersAsync(global::Envoy.Api.V3Alpha.DiscoveryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_FetchListeners, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ListenerDiscoveryServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ListenerDiscoveryServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ListenerDiscoveryServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_DeltaListeners, serviceImpl.DeltaListeners)
          .AddMethod(__Method_StreamListeners, serviceImpl.StreamListeners)
          .AddMethod(__Method_FetchListeners, serviceImpl.FetchListeners).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ListenerDiscoveryServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_DeltaListeners, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Envoy.Api.V3Alpha.DeltaDiscoveryRequest, global::Envoy.Api.V3Alpha.DeltaDiscoveryResponse>(serviceImpl.DeltaListeners));
      serviceBinder.AddMethod(__Method_StreamListeners, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Envoy.Api.V3Alpha.DiscoveryRequest, global::Envoy.Api.V3Alpha.DiscoveryResponse>(serviceImpl.StreamListeners));
      serviceBinder.AddMethod(__Method_FetchListeners, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Envoy.Api.V3Alpha.DiscoveryRequest, global::Envoy.Api.V3Alpha.DiscoveryResponse>(serviceImpl.FetchListeners));
    }

  }
}
#endregion
