using ProtoService;

namespace ReservationService.Service
{
    public interface IAccommodationService
    {
        public Task<AccommodationResponse> GetAccommodationById(string id);

    }
}
