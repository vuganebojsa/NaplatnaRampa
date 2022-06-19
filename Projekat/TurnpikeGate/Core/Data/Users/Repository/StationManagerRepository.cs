using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.Data.Users.Model;

namespace TurnpikeGate.Core.Data.Users.Repository
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
