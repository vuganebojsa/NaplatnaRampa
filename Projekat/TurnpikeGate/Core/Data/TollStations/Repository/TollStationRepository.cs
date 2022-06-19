using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnpikeGate.Core.Data.TollStations.Repository
{
    public class TollStationRepository : ITollStationRepository
    {
        private IMongoCollection<TollStation> _collection;

        public TollStationRepository()
        {
            _collection = DatabaseConnection.Database.GetCollection<TollStation>("TollStations");
        }

        public void Delete(ObjectId id)
        {
            _collection.DeleteOne(item => item.ID == id);
        }

        public List<TollStation> GetAll()
        {
            return _collection.Find(item => true).ToList();
        }

        public TollStation GetById(ObjectId id)
        {
            return _collection.Find(item => item.ID == id).FirstOrDefault();
        }

        public void Insert(TollStation entity)
        {
            _collection.InsertOne(entity);
        }

        public void Update(TollStation entity)
        {
            _collection.ReplaceOne(item => item.ID == entity.ID, entity);
        }
    }
}
