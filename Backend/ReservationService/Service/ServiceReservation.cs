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

        public string Create(Reservation reservation)
        {
            List<Reservation> reservations = GetOverlapingReservations(reservation);
            if (reservations.Count != 0)
            {
                return "Accomodation is already defined at this time !";
            }

            var channel = new Channel("localhost", 4111, ChannelCredentials.Insecure);
            var client = new AccommodationGrpc.AccommodationGrpcClient(channel);
            var accommodation = client.GetAccommodationInfo(new AccommodationRequest { Id = reservation.AccomodationId });

       
            
            if(accommodation.MinCapacity > reservation.Capacity)
            {

                return "Minimum capacity of accommodation is not satisfied !";
            }else if (accommodation.MaxCapacity < reservation.Capacity)
            {

                return "Accomodation can not contain this much capacity !";
            }else if(accommodation.StartDate.ToDateTime().Date > reservation.StartDate.Date || accommodation.EndDate.ToDateTime().Date < reservation.EndDate.Date)
            {
                return "Accomodation is not avalible at this time !";
            }

            reservation.NumberOfCancelation = GetNumberOfCancelation(reservation.GuestId);

            if (accommodation.ReservationType == 0)
            {
                reservation.Approved = true;
                reservation.Deleted = false;
                _reservationRepository.Create(reservation);
                return "Your accommodation reservation is approved !";

            }

            
            reservation.Approved = false;
            reservation.Deleted = false;
            
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
                if ((r.AccomodationId ==reservation.AccomodationId)&&!r.Deleted && !r.Approved && (((r.StartDate < reservation.EndDate) && (r.StartDate > reservation.StartDate)) || ((r.EndDate < reservation.EndDate) && (r.EndDate > reservation.StartDate)) || ((reservation.StartDate < r.EndDate) && (reservation.StartDate > r.StartDate)) || ((reservation.EndDate < r.EndDate) && (reservation.EndDate > r.StartDate)) || ((r.EndDate.Date == reservation.EndDate.Date) && (r.EndDate.Date == reservation.StartDate.Date))))
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

        public List<Reservation> getAllUndeletedUnaprovedHostReservationsInFuture(string hostId)
        {
            List<Reservation> reservations = getAllUndeletedUnaprovedReservationsInFuture();
            List<Reservation> returnReservations = new List<Reservation> ();
            foreach(Reservation r in reservations)
            {
                var channel = new Channel("localhost", 4111, ChannelCredentials.Insecure);
                var client = new AccommodationGrpc.AccommodationGrpcClient(channel);
                var accommodation = client.GetAccommodationInfo(new AccommodationRequest { Id = r.AccomodationId });

                if(accommodation.HostId == hostId)
                {
                    returnReservations.Add(r);
                }
            }

            return returnReservations;


        }

        public List<Reservation> getAllUndeletedUnaprovedReservationsInFuture()
        {
            List<Reservation> reservations = (List<Reservation>)_reservationRepository.GetAll();
            return reservations
            .Where(r => !r.Deleted && !r.Approved && r.StartDate.Date >= DateTime.Today.Date)
            .ToList();
        }



    }
}
