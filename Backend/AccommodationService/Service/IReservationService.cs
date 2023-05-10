using AccommodationService.Model;

namespace AccommodationService.Service
{
    public interface IReservationService
    {
        IEnumerable<Reservation> GetAll();
        void Create(Reservation reservation);
        void Update(Reservation reservation);

        public Reservation GetById(string id);


    }
}
