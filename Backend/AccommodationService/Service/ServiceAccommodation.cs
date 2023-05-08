using AccommodationService.Model;
using AccommodationService.Repository;
using Grpc.Core;

namespace AccommodationService.Service
{
    public class ServiceAccommodation : IAccommodationService
    {
        private readonly IAccommodationRepository _accommodationRepository;

        public ServiceAccommodation(IAccommodationRepository repository)
        {
            _accommodationRepository = repository;
        }

        /*private readonly ProjectConfiguration _configuration;

        public AccommodationService(ProjectConfiguration projectConfiguration)
        {
            _configuration = projectConfiguration;

        }*/

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
