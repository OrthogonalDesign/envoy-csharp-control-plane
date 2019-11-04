// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/service/tap/v2alpha/tapds.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Envoy.Service.Tap.V2Alpha {
  /// <summary>
  /// [#not-implemented-hide:] Tap discovery service.
  /// </summary>
  public static partial class TapDiscoveryService
  {
    static readonly string __ServiceName = "envoy.service.tap.v2alpha.TapDiscoveryService";

    static readonly grpc::Marshaller<global::Envoy.Api.V2.DiscoveryRequest> __Marshaller_envoy_api_v2_DiscoveryRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Envoy.Api.V2.DiscoveryRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Envoy.Api.V2.DiscoveryResponse> __Marshaller_envoy_api_v2_DiscoveryResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Envoy.Api.V2.DiscoveryResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Envoy.Api.V2.DeltaDiscoveryRequest> __Marshaller_envoy_api_v2_DeltaDiscoveryRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Envoy.Api.V2.DeltaDiscoveryRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Envoy.Api.V2.DeltaDiscoveryResponse> __Marshaller_envoy_api_v2_DeltaDiscoveryResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Envoy.Api.V2.DeltaDiscoveryResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Envoy.Api.V2.DiscoveryRequest, global::Envoy.Api.V2.DiscoveryResponse> __Method_StreamTapConfigs = new grpc::Method<global::Envoy.Api.V2.DiscoveryRequest, global::Envoy.Api.V2.DiscoveryResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "StreamTapConfigs",
        __Marshaller_envoy_api_v2_DiscoveryRequest,
        __Marshaller_envoy_api_v2_DiscoveryResponse);

    static readonly grpc::Method<global::Envoy.Api.V2.DeltaDiscoveryRequest, global::Envoy.Api.V2.DeltaDiscoveryResponse> __Method_DeltaTapConfigs = new grpc::Method<global::Envoy.Api.V2.DeltaDiscoveryRequest, global::Envoy.Api.V2.DeltaDiscoveryResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "DeltaTapConfigs",
        __Marshaller_envoy_api_v2_DeltaDiscoveryRequest,
        __Marshaller_envoy_api_v2_DeltaDiscoveryResponse);

    static readonly grpc::Method<global::Envoy.Api.V2.DiscoveryRequest, global::Envoy.Api.V2.DiscoveryResponse> __Method_FetchTapConfigs = new grpc::Method<global::Envoy.Api.V2.DiscoveryRequest, global::Envoy.Api.V2.DiscoveryResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "FetchTapConfigs",
        __Marshaller_envoy_api_v2_DiscoveryRequest,
        __Marshaller_envoy_api_v2_DiscoveryResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Envoy.Service.Tap.V2Alpha.TapdsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of TapDiscoveryService</summary>
    [grpc::BindServiceMethod(typeof(TapDiscoveryService), "BindService")]
    public abstract partial class TapDiscoveryServiceBase
    {
      public virtual global::System.Threading.Tasks.Task StreamTapConfigs(grpc::IAsyncStreamReader<global::Envoy.Api.V2.DiscoveryRequest> requestStream, grpc::IServerStreamWriter<global::Envoy.Api.V2.DiscoveryResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task DeltaTapConfigs(grpc::IAsyncStreamReader<global::Envoy.Api.V2.DeltaDiscoveryRequest> requestStream, grpc::IServerStreamWriter<global::Envoy.Api.V2.DeltaDiscoveryResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Envoy.Api.V2.DiscoveryResponse> FetchTapConfigs(global::Envoy.Api.V2.DiscoveryRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for TapDiscoveryService</summary>
    public partial class TapDiscoveryServiceClient : grpc::ClientBase<TapDiscoveryServiceClient>
    {
      /// <summary>Creates a new client for TapDiscoveryService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public TapDiscoveryServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for TapDiscoveryService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public TapDiscoveryServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected TapDiscoveryServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected TapDiscoveryServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncDuplexStreamingCall<global::Envoy.Api.V2.DiscoveryRequest, global::Envoy.Api.V2.DiscoveryResponse> StreamTapConfigs(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return StreamTapConfigs(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Envoy.Api.V2.DiscoveryRequest, global::Envoy.Api.V2.DiscoveryResponse> StreamTapConfigs(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_StreamTapConfigs, null, options);
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Envoy.Api.V2.DeltaDiscoveryRequest, global::Envoy.Api.V2.DeltaDiscoveryResponse> DeltaTapConfigs(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeltaTapConfigs(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Envoy.Api.V2.DeltaDiscoveryRequest, global::Envoy.Api.V2.DeltaDiscoveryResponse> DeltaTapConfigs(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_DeltaTapConfigs, null, options);
      }
      public virtual global::Envoy.Api.V2.DiscoveryResponse FetchTapConfigs(global::Envoy.Api.V2.DiscoveryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return FetchTapConfigs(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Envoy.Api.V2.DiscoveryResponse FetchTapConfigs(global::Envoy.Api.V2.DiscoveryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_FetchTapConfigs, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Envoy.Api.V2.DiscoveryResponse> FetchTapConfigsAsync(global::Envoy.Api.V2.DiscoveryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return FetchTapConfigsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Envoy.Api.V2.DiscoveryResponse> FetchTapConfigsAsync(global::Envoy.Api.V2.DiscoveryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_FetchTapConfigs, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override TapDiscoveryServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new TapDiscoveryServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(TapDiscoveryServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_StreamTapConfigs, serviceImpl.StreamTapConfigs)
          .AddMethod(__Method_DeltaTapConfigs, serviceImpl.DeltaTapConfigs)
          .AddMethod(__Method_FetchTapConfigs, serviceImpl.FetchTapConfigs).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, TapDiscoveryServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_StreamTapConfigs, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Envoy.Api.V2.DiscoveryRequest, global::Envoy.Api.V2.DiscoveryResponse>(serviceImpl.StreamTapConfigs));
      serviceBinder.AddMethod(__Method_DeltaTapConfigs, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Envoy.Api.V2.DeltaDiscoveryRequest, global::Envoy.Api.V2.DeltaDiscoveryResponse>(serviceImpl.DeltaTapConfigs));
      serviceBinder.AddMethod(__Method_FetchTapConfigs, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Envoy.Api.V2.DiscoveryRequest, global::Envoy.Api.V2.DiscoveryResponse>(serviceImpl.FetchTapConfigs));
    }

  }
}
#endregion
