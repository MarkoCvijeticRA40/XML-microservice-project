using AccommodationService.Model;

namespace AccommodationService.Service
{
    public interface IReservationService
    {
        IEnumerable<Reservation> GetAll();

        public List<Reservation> getAllGuestReservations(string guestId);



        void Create(Reservation reservation);
        void Update(Reservation reservation);

        void DeleteLogicaly(Reservation reservation);


        void CancelReservation(string id);


        public Reservation ApproveReservation(string id);



        void DisapproveReservation(string id);


        public Reservation GetById(string id);




    }
}
