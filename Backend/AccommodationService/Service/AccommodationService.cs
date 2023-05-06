using AccommodationService.Model;
using AccommodationService.Repository;

namespace AccommodationService.Service
{
    public class AccommodationService : IAccommodationService
    {
        private readonly IAccommodationRepository _accommodationRepository;

        public AccommodationService(IAccommodationRepository repository)
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
