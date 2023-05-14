using ReservationService.Model;
using ReservationService.Repository;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Linq;

namespace ReservationService.Service
{
    public class ServiceReservation : IReservationService
    {
        private readonly IReservationRepository _reservationRepository;
      //  private readonly IAccommodationRepository _accomondationRepository;


        public ServiceReservation(IReservationRepository reservationRepository/*, IAccommodationRepository accomondationRepository*/)
        {
            _reservationRepository = reservationRepository;
          //  _accomondationRepository = accomondationRepository;

        }

        public void CancelReservation(string id)
        {
            Reservation reservation = _reservationRepository.GetById(id);
            DeleteLogicaly(reservation);
            List<Reservation> guestReservations = getAllGuestReservations(reservation.GuestId);
            foreach (Reservation guestReservation in guestReservations)
            {
                guestReservation.NumberOfCancelation += 1;
                _reservationRepository.Update(guestReservation);
            }

        }




        public List<Reservation> getAllGuestReservations(string guestId) {
            List<Reservation> reservations = (List<Reservation>)_reservationRepository.GetAll();
            return reservations
            .Where(r => r.GuestId == guestId)
            .ToList();
        }

        public string Create(Reservation reservation)
        {
            List<Reservation> reservations = GetOverlapingReservations(reservation);
            if (reservations.Count != 0)
            {
                return "Accomodation is already defined at this time !";
            }

            //check count
            //check time of Accomodation
            

            /*
            if (_accomondationRepository.GetById(reservation.AccomodationId).ReservationType == Enums.ReservationType.Autoautomatically)
            {

                reservation.Approved = true;
                reservation.Deleted = false;
            }
            else
            {

                reservation.Approved = false;
                reservation.Deleted = false;
            }
            */
            reservation.NumberOfCancelation = GetNumberOfCancelation(reservation.GuestId);
            _reservationRepository.Create(reservation);
            return "Your accommodation reservation is waitnig to be approved !";
        }


        public List<Reservation> GetOverlapingReservations(Reservation reservation)
        {
            return _reservationRepository.GetAll().Where(r => (r.AccomodationId == reservation.AccomodationId) && !r.Deleted && r.Approved && (((r.StartDate < reservation.EndDate) && (r.StartDate > reservation.StartDate)) || ((r.EndDate < reservation.EndDate) && (r.EndDate > reservation.StartDate)) || ((reservation.StartDate < r.EndDate) && (reservation.StartDate > r.StartDate)) || ((reservation.EndDate < r.EndDate) && (reservation.EndDate > r.StartDate)) || ((r.EndDate.Date == reservation.EndDate.Date) && (r.EndDate.Date == reservation.StartDate.Date)))).ToList();

        }

        public int GetNumberOfCancelation(string guestId)
        {
            List<Reservation> reservations = getAllGuestReservations(guestId);
            if( reservations.Count == 0 ) { return 0; }
            return reservations[0].NumberOfCancelation;
        } 


        public void DisapproveReservation(string id)
        {
            Reservation reservation = _reservationRepository.GetById(id);
            DeleteLogicaly(reservation);
            
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

        public void DeleteLogicaly(Reservation reservation)
        {
            reservation.Deleted = true;
            _reservationRepository.Update(reservation);
        }

        public Reservation ApproveReservation(string id)
        {
            Reservation reservation = GetById(id);
            reservation.Approved = true;
            Update(reservation);
            DisaproveAllInDateRange(reservation);
            return reservation;

        }

        public void DisaproveAllInDateRange(Reservation reservation)
        {
            List<Reservation> reservations = (List<Reservation>)_reservationRepository.GetAll();

            foreach(Reservation r in reservations)
            {
                if ((r.AccomodationId ==reservation.AccomodationId)&&!r.Deleted && !r.Approved &&(((r.StartDate > reservation.StartDate) && (r.StartDate < reservation.EndDate)) || ((r.EndDate > reservation.StartDate) && (r.EndDate < reservation.EndDate))))
                {
                    DeleteLogicaly(r);
                }
            }
        }

        public List<Reservation> getAllUndealitedGuestReservedReservationsInFuture(string guestId)
        {
            List<Reservation> reservations = (List<Reservation>)_reservationRepository.GetAll();
            return reservations
            .Where(r => r.GuestId == guestId && !r.Deleted && r.Approved  && r.StartDate.Date > DateTime.Today.Date)
            .ToList();
        }
    }
}
