using AccommodationService.Model;

namespace AccommodationService.Repository
{
    public interface IAccommodationRepository
    {
        IEnumerable<Accommodation> GetAll();
        void Create(Accommodation user);
        public Accommodation GetById(string id);
        public Boolean IsAccommodationExist(String id);
    }
}

