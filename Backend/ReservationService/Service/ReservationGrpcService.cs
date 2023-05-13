using Grpc.Core;
using ProtoService2;
using ReservationService.Model;
using ReservationService.Repository;

namespace ReservationService.Service
{
    public class ReservationGrpcService : ReservationGrpc.ReservationGrpcBase
    {

        IReservationRepository reservationRepository = new ReservationRepository(); // replace with your implementation of IAccommodationRepository

        public ReservationGrpcService()
        {

        }

        public ReservationGrpcService(IReservationRepository repository)
        {
            reservationRepository = repository;
        }

        public override Task<ReservationResponse> GetReservationInfo(ReservationRequest request, ServerCallContext context)
        {
            // Retrieve the accommodation from the database using the ID
            Reservation reservation = reservationRepository.GetById(request.Id);

            // If the accommodation is not found, return an error
            if (reservation == null)
            {
                throw new RpcException(new Status(StatusCode.NotFound, $"Reservation with ID '{request.Id}' not found."));
            }

            // Map the Accommodation entity to AccommodationResponse proto
            ReservationResponse response = new ReservationResponse
            {
                Capacity = reservation.Capacity,
                StartDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(reservation.StartDate),
                EndDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(reservation.EndDate),
                Approved = reservation.Approved,
                Deleted = reservation.Deleted,
                AccomodationId= reservation.AccomodationId,
                GuestId= reservation.GuestId,
                NumberOfCancelation = reservation.NumberOfCancelation
            };
            return Task.FromResult(response);
        }
    }
}
