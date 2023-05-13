using ProtoService2;

namespace UserService.Service
{
    public interface IReservationService
    {
        public Task<ReservationResponse> GetReservationById(string id);


    }
}
