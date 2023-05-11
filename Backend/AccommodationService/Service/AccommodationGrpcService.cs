using AccommodationService.Model;
using AccommodationService.Repository;
using Grpc.Core;
using ProtoService;

namespace AccommodationService.Service
{
    public class AccommodationGrpcService : AccommodationGrpc.AccommodationGrpcBase
    {

        IAccommodationRepository accommodationRepository = new AccommodationRepository(); // replace with your implementation of IAccommodationRepository

        public AccommodationGrpcService()
        {
        
        }

        public AccommodationGrpcService(IAccommodationRepository repository)
        {
            accommodationRepository = repository;
        }

        public override Task<AccommodationResponse> GetAccommodationInfo(AccommodationRequest request, ServerCallContext context)
        {
            // Retrieve the accommodation from the database using the ID
            Accommodation accommodation = accommodationRepository.GetById(request.Id);

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
                Facilities = { accommodation.Facilities },
                Photos = accommodation.Photos,
                MinCapacity = accommodation.MinCapacity,
                MaxCapacity = accommodation.MaxCapacity,
                StartDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(accommodation.StartDate),
                EndDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(accommodation.EndDate),
                Price = accommodation.Price,
                Grade = accommodation.Grade
            };

            // Check if the Reservation property exists in the accommodation object
            var reservationProperty = accommodation.GetType().GetProperty("Reservation");
            if (reservationProperty != null && reservationProperty.PropertyType == typeof(ProtoService.Reservation))
            {
                // Get the Reservation value from the property
                var reservationValue = (ProtoService.Reservation)reservationProperty.GetValue(accommodation);
                response.ReservationType = reservationValue;
            }

            return Task.FromResult(response);
        }
    }
}
