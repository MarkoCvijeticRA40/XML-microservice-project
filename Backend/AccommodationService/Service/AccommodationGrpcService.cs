using AccommodationService.Core;
using AccommodationService.Model;
using AccommodationService.Repository;
using Grpc.Core;
using Grpc.Net.Client;

namespace AccommodationService.Service
{
    public class AccommodationGrpcService : AccommodationGrpc.AccommodationGrpcBase
    {

        private readonly IAccommodationRepository _accommodationRepository;

        public AccommodationGrpcService()
        {
        
        }

        public AccommodationGrpcService(IAccommodationRepository repository)
        {
            _accommodationRepository = repository;
        }

        public override Task<AccommodationResponse> GetAccommodationInfo(AccommodationRequest request, ServerCallContext context)
        {
            // Retrieve the accommodation from the database using the ID
            Accommodation accommodation = _accommodationRepository.GetById(request.Id);

            // If the accommodation is not found, return an error
            if (accommodation == null)
            {
                throw new RpcException(new Status(StatusCode.NotFound, $"Accommodation with ID '{request.Id}' not found."));
            }

            // Map the Accommodation entity to AccommodationResponse proto
            AccommodationResponse response = new AccommodationResponse
            {
                Name = accommodation.Name,
                Location = accommodation.Location,
                //Facilities = { accommodation.Facilities.Split(',', StringSplitOptions.RemoveEmptyEntries) },
                //Photos = accommodation.Photos,
                MinCapacity = accommodation.MinCapacity,
                MaxCapacity = accommodation.MaxCapacity,
                Price = accommodation.Price,
                //Reservation = accommodation.Reservation,
                Grade = accommodation.Grade
            };

            return Task.FromResult(response);
        }

    }
}
