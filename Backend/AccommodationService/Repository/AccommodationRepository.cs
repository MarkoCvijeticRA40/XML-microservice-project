using AccommodationService.Model;
using MongoDB.Driver;

namespace AccommodationService.Repository
{
    public class AccommodationRepository : IAccommodationRepository
    {

        private readonly IMongoCollection<Accommodation> _accommodation;

        public AccommodationRepository()
        {
            /* Konekcija koju cemo posle koristiti kada dokerizujemo
            var client = new MongoClient("mongodb://root:password@mongo:27017");
            var mongoDatabase = client.GetDatabase("mydatabase");
            _accommodation = mongoDatabase.GetCollection<Accommodation>("myaccommodations");*/

            var client = new MongoClient("mongodb://localhost:27017");
            var mongoDatabase = client.GetDatabase("mydatabase1");
            _accommodation = mongoDatabase.GetCollection<Accommodation>("myaccommodations"); 
        }



        public void Create(Accommodation accommodation)
        {
            _accommodation.InsertOne(accommodation);

        }

        public IEnumerable<Accommodation> GetAll()
        {
            return _accommodation.Find(_ => true).ToList();
        }

        public Boolean IsAccommodationExist(String id)
        {
            var filter = Builders<Accommodation>.Filter.Eq(a => a.Id, id);
            var user = _accommodation.Find(filter).FirstOrDefault();
            if (user != null)
            {
                return true;
            }
            return false;
        }

        public Accommodation GetById(string id)
        {
            var filter = Builders<Accommodation>.Filter.Eq(a => a.Id, id);
            var accommodation = _accommodation.Find(filter).FirstOrDefault();


            if (accommodation != null)
            {
                return accommodation;
            }
            return null;
        }
    }
}
