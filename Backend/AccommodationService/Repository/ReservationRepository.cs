using AccommodationService.Enums;
using AccommodationService.Model;
using MongoDB.Driver;

namespace AccommodationService.Repository
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly IMongoCollection<Model.Reservation> _reservations;



        public ReservationRepository() {
       
            
            var client = new MongoClient("mongodb://localhost:27017");
            var mongoDatabase = client.GetDatabase("mydatabase1");
            _reservations = mongoDatabase.GetCollection<Model.Reservation>("myreservations");


        }

        public void Create(Model.Reservation reservation)
        {
            _reservations.InsertOne(reservation);   
        }

        public IEnumerable<Model.Reservation> GetAll()
        {
            return _reservations.Find(_ => true).ToList();
        }

        public Reservation GetById(string id)
        {
            var filter = Builders<Reservation>.Filter.Eq(a => a.Id, id);
            var reservation = _reservations.Find(filter).FirstOrDefault();


            if (reservation != null)
            {
                return reservation;
            }
            return null;
        }

        public void Update(Model.Reservation reservation)
        {
            var filter = Builders<Reservation>.Filter.Eq(u => u.Id, reservation.Id);
            _reservations.ReplaceOne(filter, reservation);
        }
    }
}
