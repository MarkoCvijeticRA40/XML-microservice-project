using Grpc.Net.Client;

namespace UserService.Service
{
    public class AccommodationService : IAccommodationService
    {
        public async Task<AccommodationResponse> GetAccommodationById(string id)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:19178");
            var client = new AccommodationGrpc.AccommodationGrpcClient(channel);
            var reply = await client.GetAccommodationInfoAsync(new AccommodationRequest() { Id = id });
            return reply;
        }
    }
}
