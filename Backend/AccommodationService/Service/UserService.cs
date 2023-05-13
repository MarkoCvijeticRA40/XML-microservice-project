using Grpc.Net.Client;
using ProtoService1;

namespace AccommodationService.Service
{
    public class UserService : IUserService
    {
        public async Task<UserResponse> GetUserById(string id)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:4112");
            var client = new UserGrpc.UserGrpcClient(channel);
            var reply = await client.GetUserInfoAsync(new UserRequest() { Id = id });
            return reply;
        }
    }
}