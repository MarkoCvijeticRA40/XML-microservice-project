// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/accommodation.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace UserService {
  public static partial class AccommodationGrpc
  {
    static readonly string __ServiceName = "UserService.AccommodationGrpc";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
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

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
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

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UserService.AccommodationRequest> __Marshaller_UserService_AccommodationRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserService.AccommodationRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::UserService.AccommodationResponse> __Marshaller_UserService_AccommodationResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::UserService.AccommodationResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::UserService.AccommodationRequest, global::UserService.AccommodationResponse> __Method_GetAccommodationInfo = new grpc::Method<global::UserService.AccommodationRequest, global::UserService.AccommodationResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAccommodationInfo",
        __Marshaller_UserService_AccommodationRequest,
        __Marshaller_UserService_AccommodationResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::UserService.AccommodationReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of AccommodationGrpc</summary>
    [grpc::BindServiceMethod(typeof(AccommodationGrpc), "BindService")]
    public abstract partial class AccommodationGrpcBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::UserService.AccommodationResponse> GetAccommodationInfo(global::UserService.AccommodationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(AccommodationGrpcBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAccommodationInfo, serviceImpl.GetAccommodationInfo).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, AccommodationGrpcBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetAccommodationInfo, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::UserService.AccommodationRequest, global::UserService.AccommodationResponse>(serviceImpl.GetAccommodationInfo));
    }

  }
}
#endregion
