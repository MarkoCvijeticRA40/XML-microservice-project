using AccommodationService.Model;

namespace AccommodationService.Repository
{
    public interface IReservationRepository
    {

        IEnumerable<Reservation> GetAll();
        void Create(Reservation reservation);

        void Update(Reservation reservation);


    }
}
