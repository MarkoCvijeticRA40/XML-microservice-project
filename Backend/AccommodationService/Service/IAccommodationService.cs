using AccommodationService.Model;
using Grpc.Core;

namespace AccommodationService.Service
{
    public interface IAccommodationService
    {
        IEnumerable<Accommodation> GetAll();
        public void Create(Accommodation accommodation);
        public Accommodation GetById(string id);

        List<Accommodation> GetAllAccommodationsBySearch(string location, int guests, DateTime startDate, DateTime endDate);

        public void Update(Accommodation accommodation);


    }
}
