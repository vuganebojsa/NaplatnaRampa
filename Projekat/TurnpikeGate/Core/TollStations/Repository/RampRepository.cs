using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.TollStations.Model;

namespace TurnpikeGate.Core.TollStations.Repository
{
    public class RampRepository : IRampRepository
    {
        private IMongoCollection<Ramp> _collection;

        public RampRepository()
        {
            _collection = DatabaseConnection.Database.GetCollection<Ramp>("Ramps");
        }

        public void Delete(ObjectId id)
        {
            _collection.DeleteOne(item => item.ID == id);
        }

        public List<Ramp> GetAll()
        {
            return _collection.Find(item => true).ToList();
        }

        public Ramp GetById(ObjectId id)
        {
            return _collection.Find(item => item.ID == id).FirstOrDefault();
        }

        public void Insert(Ramp entity)
        {
            _collection.InsertOne(entity);
        }

        public void Update(Ramp entity)
        {
            _collection.ReplaceOne(item => item.ID == entity.ID, entity);
        }
    }
}
