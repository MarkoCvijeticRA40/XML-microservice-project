using AccommodationService.Model;
using AccommodationService.Repository;

namespace AccommodationService.Service
{
    public class ServiceReservation : IReservationService
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly IAccommodationRepository _accomondationRepository;


        public ServiceReservation(IReservationRepository reservationRepository, IAccommodationRepository accomondationRepository)
        {
            _reservationRepository = reservationRepository;
            _accomondationRepository = accomondationRepository;

        }

        public void Create(Reservation reservation)
        {
            

            if (_accomondationRepository.GetById(reservation.AccomodationId).ReservationType == Enums.ReservationType.Autoautomatically)
            {

                reservation.Approved = true;
                reservation.PendingApproval = false;
            }
            else
            {

                reservation.Approved = false;
                reservation.PendingApproval = true;
            }
            _reservationRepository.Create(reservation);
        }

        public IEnumerable<Reservation> GetAll()
        {
            return _reservationRepository.GetAll();
        }

        public Reservation GetById(string id)
        {
            return _reservationRepository.GetById(id);
        }

        public void Update(Reservation reservation)
        {
            _reservationRepository.Update(reservation);
        }
    }
}
