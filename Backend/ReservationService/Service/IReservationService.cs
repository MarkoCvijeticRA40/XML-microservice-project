using ReservationService.Model;

namespace ReservationService.Service
{
    public interface IReservationService
    {
        IEnumerable<Reservation> GetAll();

        public List<Reservation> getAllGuestReservations(string guestId);

        public List<Reservation> getAllUndealitedGuestReservedReservationsInFuture(string guestId);


        string Create(Reservation reservation);
        void Update(Reservation reservation);

        void DeleteLogicaly(Reservation reservation);


        void CancelReservation(string id);


        public Reservation ApproveReservation(string id);



        void DisapproveReservation(string id);


        public Reservation GetById(string id);




    }
}
