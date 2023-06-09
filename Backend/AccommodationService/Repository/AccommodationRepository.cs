﻿using AccommodationService.Model;
using MongoDB.Driver;

namespace AccommodationService.Repository
{
    public class AccommodationRepository : IAccommodationRepository
    {

        private readonly IMongoCollection<Accommodation> _accommodation;

        public AccommodationRepository()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var mongoDatabase = client.GetDatabase("mydatabase1");
            _accommodation = mongoDatabase.GetCollection<Accommodation>("myaccommodations"); 
        }

        public void Update(Accommodation accommodation)
        {
            var filter = Builders<Accommodation>.Filter.Eq(u => u.Id, accommodation.Id);
            _accommodation.ReplaceOne(filter, accommodation);
        }


        public void Create(Accommodation accommodation)
        {
            _accommodation.InsertOne(accommodation);

        }

        public void Delete(string id)
        {
            var filter = Builders<Accommodation>.Filter.Eq(u => u.Id, id);
            _accommodation.DeleteOne(filter);
        }

        public void Delete(Accommodation accommodation)
        {
            var filter = Builders<Accommodation>.Filter.Eq(u => u.Id, accommodation.Id);
            _accommodation.DeleteOne(filter);
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
