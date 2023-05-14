using Grpc.Net.Client;
using ProtoService2;

namespace AccommodationService.Service
{
    public class ReservationService : IReservationService
    {
        public async Task<ReservationResponse> GetUserById(string id)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:4113");
            var client = new ReservationGrpc.ReservationGrpcClient(channel);
            var reply = await client.GetReservationInfoAsync(new ReservationRequest() { Id = id });
            return reply;
        }
    }
}