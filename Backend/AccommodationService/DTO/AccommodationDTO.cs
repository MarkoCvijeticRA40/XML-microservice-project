using AccommodationService.Enums;

namespace AccommodationService.DTO
{
    public class AccommodationDTO
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public String Location { get; set; }
        public List<String> Facilities { get; set; }
        public String Photos { get; set; }
        public int MinCapacity { get; set; }
        public int MaxCapacity { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }
        public String ReservationType { get; set; }
        public double Grade { get; set; }
    }
}
