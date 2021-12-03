// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Pais.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace TCC.Application.GRPC.Protos {
  public static partial class PaisProtoService
  {
    static readonly string __ServiceName = "PaisProtoService";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::TCC.Application.GRPC.Protos.GetPaisNomeRequest> __Marshaller_GetPaisNomeRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TCC.Application.GRPC.Protos.GetPaisNomeRequest.Parser));
    static readonly grpc::Marshaller<global::TCC.Application.GRPC.Protos.PaisModel> __Marshaller_PaisModel = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TCC.Application.GRPC.Protos.PaisModel.Parser));

    static readonly grpc::Method<global::TCC.Application.GRPC.Protos.GetPaisNomeRequest, global::TCC.Application.GRPC.Protos.PaisModel> __Method_GetPais = new grpc::Method<global::TCC.Application.GRPC.Protos.GetPaisNomeRequest, global::TCC.Application.GRPC.Protos.PaisModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPais",
        __Marshaller_GetPaisNomeRequest,
        __Marshaller_PaisModel);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::TCC.Application.GRPC.Protos.PaisReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for PaisProtoService</summary>
    public partial class PaisProtoServiceClient : grpc::ClientBase<PaisProtoServiceClient>
    {
      /// <summary>Creates a new client for PaisProtoService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public PaisProtoServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for PaisProtoService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public PaisProtoServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected PaisProtoServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected PaisProtoServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::TCC.Application.GRPC.Protos.PaisModel GetPais(global::TCC.Application.GRPC.Protos.GetPaisNomeRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPais(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::TCC.Application.GRPC.Protos.PaisModel GetPais(global::TCC.Application.GRPC.Protos.GetPaisNomeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetPais, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::TCC.Application.GRPC.Protos.PaisModel> GetPaisAsync(global::TCC.Application.GRPC.Protos.GetPaisNomeRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPaisAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::TCC.Application.GRPC.Protos.PaisModel> GetPaisAsync(global::TCC.Application.GRPC.Protos.GetPaisNomeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetPais, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override PaisProtoServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new PaisProtoServiceClient(configuration);
      }
    }

  }
}
#endregion
