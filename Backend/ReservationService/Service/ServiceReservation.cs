using ReservationService.Model;
using ReservationService.Repository;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Linq;
using Grpc.Core;
using ProtoService;
using Reservation = ReservationService.Model.Reservation;
using ProtoService1;

namespace ReservationService.Service
{
    public class ServiceReservation : IReservationService
    {
        private readonly IReservationRepository _reservationRepository;
        //  private readonly IAccommodationRepository _accomondationRepository;

        /*
            Ovako se dobavlja smestaj
            string id = "123456789123456789123456";
            var channel = new Channel("localhost", 4111, ChannelCredentials.Insecure);
            var client = new AccommodationGrpc.AccommodationGrpcClient(channel);
            var accommodation = client.GetAccommodationInfo(new AccommodationRequest { Id = id });

            Ovako se dobavlja user
            string id1 = "645f76ba5b45418b5fddca8f";
            var channel1 = new Channel("localhost", 4112, ChannelCredentials.Insecure);
            var client1 = new UserGrpc.UserGrpcClient(channel1);
            var user = client1.GetUserInfo(new UserRequest { Id = id1 });
        */



        public ServiceReservation(IReservationRepository reservationRepository/*, IAccommodationRepository accomondationRepository*/)
        {
            _reservationRepository = reservationRepository;
          //  _accomondationRepository = accomondationRepository;

        }

        public IEnumerable<Reservation> GetAll()
        {
            return _reservationRepository.GetAll();
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

        public void Create(Reservation reservation)
        {
            
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
            _reservationRepository.Create(reservation);
        }




        public void DisapproveReservation(string id)
        {
            Reservation reservation = _reservationRepository.GetById(id);
            DeleteLogicaly(reservation);
            
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
