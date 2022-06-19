using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.Data.TollStations.Model;

namespace TurnpikeGate.Core.Data.TollStations.Repository
{
    public class CameraRepository : ICameraRepository
    {
        private IMongoCollection<Camera> _collection;

        public CameraRepository()
        {
            _collection = DatabaseConnection.Database.GetCollection<Camera>("Cameras");
        }

        public void Delete(ObjectId id)
        {
            _collection.DeleteOne(item => item.ID == id);
        }

        public List<Camera> GetAll()
        {
            return _collection.Find(item => true).ToList();
        }

        public Camera GetById(ObjectId id)
        {
            return _collection.Find(item => item.ID == id).FirstOrDefault();
        }

        public void Insert(Camera entity)
        {
            _collection.InsertOne(entity);
        }

        public void Update(Camera entity)
        {
            _collection.ReplaceOne(item => item.ID == entity.ID, entity);
        }
    }
}
