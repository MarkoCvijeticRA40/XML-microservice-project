
using MongoDB.Driver;


namespace ReservationService.Repository
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly IMongoCollection<Model.Reservation> _reservations;



        public ReservationRepository() {
       
            
            var client = new MongoClient("mongodb://localhost:27017");
            var mongoDatabase = client.GetDatabase("mydatabase2");
            _reservations = mongoDatabase.GetCollection<Model.Reservation>("myreservations");


        }

        public void Create(Model.Reservation reservation)
        {
            _reservations.InsertOne(reservation);   
        }

        public void Delete(Model.Reservation reservation)
        {
            var filter = Builders<Model.Reservation>.Filter.Eq(u => u.Id, reservation.Id);
            _reservations.DeleteOne(filter);
        }

        public void DeleteById(string id)
        {
            var filter = Builders<Model.Reservation>.Filter.Eq(u => u.Id, id);
            _reservations.DeleteOne(filter);
        }

        
        public IEnumerable<Model.Reservation> GetAll()
        {
            return _reservations.Find(_ => true).ToList();
        }

        public Model.Reservation GetById(string id)
        {
            var filter = Builders<Model.Reservation>.Filter.Eq(a => a.Id, id);
            var reservation = _reservations.Find(filter).FirstOrDefault();


            if (reservation != null)
            {
                return reservation;
            }
            return null;
        }

        public void Update(Model.Reservation reservation)
        {
            var filter = Builders<Model.Reservation>.Filter.Eq(u => u.Id, reservation.Id);
            _reservations.ReplaceOne(filter, reservation);
        }

       


    }
}
