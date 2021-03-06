using MongoDB.Bson;
using MongoDB.Driver;
using TurnpikeGate.Core.TollStations.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnpikeGate.Core.TollStations.Repository
{
    public class TraficLightRepository : ITraficLightRepository
    {
        private IMongoCollection<TraficLight> _collection;

        public TraficLightRepository()
        {
            _collection = DatabaseConnection.Database.GetCollection<TraficLight>("TraficLights");
        }

        public void Delete(ObjectId id)
        {
            _collection.DeleteOne(item => item.ID == id);
        }

        public List<TraficLight> GetAll()
        {
            return _collection.Find(item => true).ToList();
        }

        public TraficLight GetById(ObjectId id)
        {
            return _collection.Find(item => item.ID == id).FirstOrDefault();
        }

        public TraficLight GetByTollBoothId(ObjectId tollBoothId)
        {
            return _collection.Find(item => item.ToolBoothId == tollBoothId).FirstOrDefault();
        }

        public void Insert(TraficLight entity)
        {
            _collection.InsertOne(entity);
        }

        public void Update(TraficLight entity)
        {
            _collection.ReplaceOne(item => item.ID == entity.ID, entity);
        }
    }
}
