using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.Prices.Model;

namespace TurnpikeGate.Core.Prices.Repository
{
    public class RoadSectionRepository : IRoadSectionRepository
    {
        private IMongoCollection<RoadSection> _collection;

        public RoadSectionRepository()
        {
            _collection = DatabaseConnection.Database.GetCollection<RoadSection>("RoadSections");
        }

        public void Delete(ObjectId id)
        {
            _collection.DeleteOne(item => item.ID == id);
        }

        public List<RoadSection> GetAll()
        {
            return _collection.Find(item => true).ToList();
        }

        public RoadSection GetById(ObjectId id)
        {
            return _collection.Find(item => item.ID == id).FirstOrDefault();
        }

        public RoadSection GetByLocations(ObjectId entranceStationId, ObjectId exitStationId)
        {
            return _collection.Find(item => item.DepartureStationId == entranceStationId && item.DestinationStationId == exitStationId).FirstOrDefault();
        }

        public void Insert(RoadSection entity)
        {
            _collection.InsertOne(entity);
        }

        public void Update(RoadSection entity)
        {
            _collection.ReplaceOne(item => item.ID == entity.ID, entity);
        }
    }
}
