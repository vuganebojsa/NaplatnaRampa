using MongoDB.Bson;
using MongoDB.Driver;
using TurnpikeGate.Core.Users.Model;

namespace TurnpikeGate.Core.Users.Repository
{
    public class StationManagerRepository: IStationManagerRepository
    {
        private IMongoCollection<StationManager> _collection;

        public StationManagerRepository()
        {
            _collection = DatabaseConnection.Database.GetCollection<StationManager>("StationManagers");
        }

        public void Delete(ObjectId id)
        {
            _collection.DeleteOne(item => item.ID == id);
        }

        public List<StationManager> GetAll()
        {
            return _collection.Find(item => true).ToList();
        }

        public StationManager GetById(ObjectId id)
        {
            return _collection.Find(item => item.ID == id).FirstOrDefault();
        }

        public void Insert(StationManager entity)
        {
            _collection.InsertOne(entity);
        }

        public void Update(StationManager entity)
        {
            _collection.ReplaceOne(item => item.ID == entity.ID, entity);
        }
    }
}
