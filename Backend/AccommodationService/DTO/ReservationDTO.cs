namespace AccommodationService.DTO
{
    public class ReservationDTO
    {
        public String Id { get; set; }
        public int Capacity { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Boolean Approved { get; set; }
        public Boolean PendingApproval { get; set; }
        public String AccomodationId { get; set; }

    }
}
