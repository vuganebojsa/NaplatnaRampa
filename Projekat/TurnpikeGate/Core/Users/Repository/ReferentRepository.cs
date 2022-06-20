using MongoDB.Bson;
using MongoDB.Driver;
using TurnpikeGate.Core.Users.Model;

namespace TurnpikeGate.Core.Users.Repository
{
    public class ReferentRepository: IReferentRepository
    {
        private IMongoCollection<Referent> _collection;

        public ReferentRepository()
        {
            _collection = DatabaseConnection.Database.GetCollection<Referent>("Referents");
        }

        public void Delete(ObjectId id)
        {
            _collection.DeleteOne(item => item.ID == id);
        }

        public List<Referent> GetAll()
        {
            return _collection.Find(item => true).ToList();
        }

        public Referent GetById(ObjectId id)
        {
            return _collection.Find(item => item.ID == id).FirstOrDefault();
        }

        public void Insert(Referent entity)
        {
            _collection.InsertOne(entity);
        }

        public void Update(Referent entity)
        {
            _collection.ReplaceOne(item => item.ID == entity.ID, entity);
        }
    }
}
