using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using AccommodationService.Enums;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AccommodationService.Model
{
    public class Accommodation
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public String Name { get; set; }
        public String Location { get; set; }
        public List<String> Facilities { get; set; }
        public List<String> Photos { get; set; }
        public int MinCapacity { get; set; }
        public int MaxCapacity { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }
        public ReservationType ReservationType { get; set; }
        public double Grade { get; set; }
        public string HostId { get; set; }

        


    }
}
