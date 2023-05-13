using AccommodationService.Model;

namespace AccommodationService.Repository
{
    public interface IReservationRepository
    {

        IEnumerable<Reservation> GetAll();
        void Create(Reservation reservation);
        void Update(Reservation reservation);
        public Reservation GetById(string id);
        void Delete(Reservation reservation);



        void DeleteById(string id);









    }
}
