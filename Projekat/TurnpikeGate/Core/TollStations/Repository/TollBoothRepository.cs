using MongoDB.Bson;
using MongoDB.Driver;
using TurnpikeGate.Core.TollStations.Model;

namespace TurnpikeGate.Core.TollStations.Repository
{
    public class TollBoothRepository : ITollBoothRepository
    {
        private readonly IMongoCollection<TollBooth> _collection;

        public TollBoothRepository()
        {
            _collection = DatabaseConnection.Database.GetCollection<TollBooth>("TollBooths");
        }

        public void Delete(ObjectId id)
        {
            _collection.DeleteOne(item => item.ID == id);
        }

        public List<TollBooth> GetAll()
        {
            return _collection.Find(item => true).ToList();
        }

        public TollBooth GetById(ObjectId id)
        {
            return _collection.Find(item => item.ID == id).FirstOrDefault();
        }

        public void Insert(TollBooth entity)
        {
            _collection.InsertOne(entity);
        }

        public void Update(TollBooth entity)
        {
            _collection.ReplaceOne(item => item.ID == entity.ID, entity);
        }
    }
}
