namespace UserService.Service
{
    public interface IAccommodationService
    {
        public Task<AccommodationResponse> GetAccommodationById(string id);
    }
}
