using AccommodationService.Model;
using Grpc.Core;

namespace AccommodationService.Service
{
    public interface IAccommodationService
    {
        IEnumerable<Accommodation> GetAll();
        public void Create(Accommodation accommodation);
        public Accommodation GetById(string id);

    }
}
