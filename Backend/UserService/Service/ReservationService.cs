using Grpc.Net.Client;
using ProtoService2;

namespace UserService.Service
{
    public class ReservationService : IReservationService
    {
        public async Task<ReservationResponse> GetReservationById(string id)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:4111");
            var client = new ReservationGrpc.ReservationGrpcClient(channel);
            var reply = await client.GetReservationInfoAsync(new ReservationRequest() { Id = id });
            return reply;
        }
    }
}
