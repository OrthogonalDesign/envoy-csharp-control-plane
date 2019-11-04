// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/service/discovery/v2/ads.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Envoy.Service.Discovery.V2 {
  /// <summary>
  /// See https://github.com/lyft/envoy-api#apis for a description of the role of
  /// ADS and how it is intended to be used by a management server. ADS requests
  /// have the same structure as their singleton xDS counterparts, but can
  /// multiplex many resource types on a single stream. The type_url in the
  /// DiscoveryRequest/DiscoveryResponse provides sufficient information to recover
  /// the multiplexed singleton APIs at the Envoy instance and management server.
  /// </summary>
  public static partial class AggregatedDiscoveryService
  {
    static readonly string __ServiceName = "envoy.service.discovery.v2.AggregatedDiscoveryService";

    static readonly grpc::Marshaller<global::Envoy.Api.V2.DiscoveryRequest> __Marshaller_envoy_api_v2_DiscoveryRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Envoy.Api.V2.DiscoveryRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Envoy.Api.V2.DiscoveryResponse> __Marshaller_envoy_api_v2_DiscoveryResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Envoy.Api.V2.DiscoveryResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Envoy.Api.V2.DeltaDiscoveryRequest> __Marshaller_envoy_api_v2_DeltaDiscoveryRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Envoy.Api.V2.DeltaDiscoveryRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Envoy.Api.V2.DeltaDiscoveryResponse> __Marshaller_envoy_api_v2_DeltaDiscoveryResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Envoy.Api.V2.DeltaDiscoveryResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Envoy.Api.V2.DiscoveryRequest, global::Envoy.Api.V2.DiscoveryResponse> __Method_StreamAggregatedResources = new grpc::Method<global::Envoy.Api.V2.DiscoveryRequest, global::Envoy.Api.V2.DiscoveryResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "StreamAggregatedResources",
        __Marshaller_envoy_api_v2_DiscoveryRequest,
        __Marshaller_envoy_api_v2_DiscoveryResponse);

    static readonly grpc::Method<global::Envoy.Api.V2.DeltaDiscoveryRequest, global::Envoy.Api.V2.DeltaDiscoveryResponse> __Method_DeltaAggregatedResources = new grpc::Method<global::Envoy.Api.V2.DeltaDiscoveryRequest, global::Envoy.Api.V2.DeltaDiscoveryResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "DeltaAggregatedResources",
        __Marshaller_envoy_api_v2_DeltaDiscoveryRequest,
        __Marshaller_envoy_api_v2_DeltaDiscoveryResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Envoy.Service.Discovery.V2.AdsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of AggregatedDiscoveryService</summary>
    [grpc::BindServiceMethod(typeof(AggregatedDiscoveryService), "BindService")]
    public abstract partial class AggregatedDiscoveryServiceBase
    {
      /// <summary>
      /// This is a gRPC-only API.
      /// </summary>
      /// <param name="requestStream">Used for reading requests from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      public virtual global::System.Threading.Tasks.Task StreamAggregatedResources(grpc::IAsyncStreamReader<global::Envoy.Api.V2.DiscoveryRequest> requestStream, grpc::IServerStreamWriter<global::Envoy.Api.V2.DiscoveryResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task DeltaAggregatedResources(grpc::IAsyncStreamReader<global::Envoy.Api.V2.DeltaDiscoveryRequest> requestStream, grpc::IServerStreamWriter<global::Envoy.Api.V2.DeltaDiscoveryResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for AggregatedDiscoveryService</summary>
    public partial class AggregatedDiscoveryServiceClient : grpc::ClientBase<AggregatedDiscoveryServiceClient>
    {
      /// <summary>Creates a new client for AggregatedDiscoveryService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public AggregatedDiscoveryServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AggregatedDiscoveryService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public AggregatedDiscoveryServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected AggregatedDiscoveryServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected AggregatedDiscoveryServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// This is a gRPC-only API.
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncDuplexStreamingCall<global::Envoy.Api.V2.DiscoveryRequest, global::Envoy.Api.V2.DiscoveryResponse> StreamAggregatedResources(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return StreamAggregatedResources(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// This is a gRPC-only API.
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncDuplexStreamingCall<global::Envoy.Api.V2.DiscoveryRequest, global::Envoy.Api.V2.DiscoveryResponse> StreamAggregatedResources(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_StreamAggregatedResources, null, options);
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Envoy.Api.V2.DeltaDiscoveryRequest, global::Envoy.Api.V2.DeltaDiscoveryResponse> DeltaAggregatedResources(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeltaAggregatedResources(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Envoy.Api.V2.DeltaDiscoveryRequest, global::Envoy.Api.V2.DeltaDiscoveryResponse> DeltaAggregatedResources(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_DeltaAggregatedResources, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override AggregatedDiscoveryServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AggregatedDiscoveryServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(AggregatedDiscoveryServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_StreamAggregatedResources, serviceImpl.StreamAggregatedResources)
          .AddMethod(__Method_DeltaAggregatedResources, serviceImpl.DeltaAggregatedResources).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, AggregatedDiscoveryServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_StreamAggregatedResources, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Envoy.Api.V2.DiscoveryRequest, global::Envoy.Api.V2.DiscoveryResponse>(serviceImpl.StreamAggregatedResources));
      serviceBinder.AddMethod(__Method_DeltaAggregatedResources, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Envoy.Api.V2.DeltaDiscoveryRequest, global::Envoy.Api.V2.DeltaDiscoveryResponse>(serviceImpl.DeltaAggregatedResources));
    }

  }
}
#endregion
