namespace ReservationService.DTO
{
    public class ReservationDTO
    {
        public String Id { get; set; }
        public int Capacity { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Boolean Approved { get; set; }
        public Boolean Deleted { get; set; }
        public String AccomodationId { get; set; }

        public String GuestId { get; set; }

        public int NumberOfCancelation { get; set; }


    }
}
