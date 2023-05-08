using AccommodationService.Model;
using AccommodationService.Repository;
using Grpc.Net.Client;

namespace AccommodationService.Service
{
    public class ServiceAccommodation : IAccommodationService
    {
        private readonly IAccommodationRepository _accommodationRepository;

        public ServiceAccommodation(IAccommodationRepository repository)
        {
            _accommodationRepository = repository;
        }
        public void Create(Accommodation accommodation)
        {
            _accommodationRepository.Create(accommodation);
        }

        public IEnumerable<Accommodation> GetAll()
        {
            return _accommodationRepository.GetAll();
        }

        public Accommodation GetById(string id)
        {
            return _accommodationRepository.GetById(id);
        }
    }
}
