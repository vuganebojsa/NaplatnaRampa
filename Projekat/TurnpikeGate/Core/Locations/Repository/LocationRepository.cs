using MongoDB.Bson;
using MongoDB.Driver;

namespace TurnpikeGate.Core.Locations.Repository
{ 
    public class LocationRepository: ILocationRepository
    {
        private IMongoCollection<Location> _collection;

        public LocationRepository()
        {
            _collection = DatabaseConnection.Database.GetCollection<Location>("Locations");
        }

        public void Delete(ObjectId id)
        {
            _collection.DeleteOne(item => item.ID == id);
        }

        public List<Location> GetAll()
        {
            return _collection.Find(item => true).ToList();
        }

        public Location GetById(ObjectId id)
        {
            return _collection.Find(item => item.ID == id).FirstOrDefault();
        }

        public void Insert(Location entity)
        {
            _collection.InsertOne(entity);
        }

        public void Update(Location entity)
        {
            _collection.ReplaceOne(item => item.ID == entity.ID, entity);
        }
    }
}
