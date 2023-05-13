using ReservationService.DTO;
using ReservationService.Mappers;
using ReservationService.Model;

namespace ReservationService.Mappers
{
    public class ReservationMapper : IGenericMapper<Reservation, ReservationDTO>
    {
        public ReservationDTO ToDTO(Reservation reservation)
        {
            ReservationDTO reservationDTO = new ReservationDTO();

            reservationDTO.Id = reservation.Id;
            reservationDTO.Capacity = reservation.Capacity;
            reservationDTO.StartDate = reservation.StartDate;
            reservationDTO.EndDate = reservation.EndDate;
            reservationDTO.Approved = reservation.Approved;
            reservationDTO.Deleted = reservation.Deleted;
            reservationDTO.AccomodationId = reservation.AccomodationId;
            reservationDTO.GuestId = reservation.GuestId;
            reservationDTO.NumberOfCancelation = reservation.NumberOfCancelation;



            return reservationDTO;


        }

        public List<ReservationDTO> ToDTO(List<Reservation> reservations)
        {
            List<ReservationDTO> reservationDTOs = new List<ReservationDTO>();

            foreach(Reservation reservation in reservations)
            {
                ReservationDTO reservationDTO = new ReservationDTO();

                reservationDTO.Id = reservation.Id;
                reservationDTO.Capacity = reservation.Capacity;
                reservationDTO.StartDate = reservation.StartDate;
                reservationDTO.EndDate = reservation.EndDate;
                reservationDTO.Approved = reservation.Approved;
                reservationDTO.Deleted = reservation.Deleted;
                reservationDTO.AccomodationId = reservation.AccomodationId;
                reservationDTO.GuestId = reservation.GuestId;
                reservationDTO.NumberOfCancelation = reservation.NumberOfCancelation;


                reservationDTOs.Add(reservationDTO);    

            }

            return reservationDTOs;

        }

        public Reservation ToModel(ReservationDTO reservationDTO)
        {
            Reservation reservation = new Reservation();

            reservation.Id = reservationDTO.Id;
            reservation.Capacity = reservationDTO.Capacity;
            reservation.StartDate = reservationDTO.StartDate;
            reservation.EndDate = reservationDTO.EndDate;
            reservation.Approved = reservationDTO.Approved;
            reservation.Deleted = reservationDTO.Deleted;
            reservation.AccomodationId = reservationDTO.AccomodationId;
            reservation.GuestId = reservationDTO.GuestId;
            reservation.NumberOfCancelation = reservationDTO.NumberOfCancelation;

            return reservation;
        }

        public List<Reservation> ToModel(List<ReservationDTO> reservationDTOs)
        {

            List<Reservation> reservations = new List<Reservation>();

            foreach (ReservationDTO reservationDTO in reservationDTOs)
            {
                Reservation reservation = new Reservation();

                reservation.Id = reservationDTO.Id;
                reservation.Capacity = reservationDTO.Capacity;
                reservation.StartDate = reservationDTO.StartDate;
                reservation.EndDate = reservationDTO.EndDate;
                reservation.Approved = reservationDTO.Approved;
                reservation.Deleted = reservationDTO.Deleted;
                reservation.AccomodationId = reservationDTO.AccomodationId;
                reservation.GuestId = reservationDTO.GuestId;
                reservation.NumberOfCancelation = reservationDTO.NumberOfCancelation;


                reservations.Add(reservation);

            }

            return reservations;
        }
    }
}
