using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace AccommodationService.Model
{
    public class Reservation
    {


        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String? Id { get; set; }
        public int Capacity { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Boolean Approved { get; set; }
        public String AccomodationId { get; set; }






    }
}
