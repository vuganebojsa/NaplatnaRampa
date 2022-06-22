using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.Tags.Model;

namespace TurnpikeGate.Core.Tags.Repository
{
    public class ElectronicTagRepository : IElectronicTagRepository
    {
        private IMongoCollection<ElectronicTag> _collection;

        public ElectronicTagRepository()
        {
            _collection = DatabaseConnection.Database.GetCollection<ElectronicTag>("Tags");
        }

        public void Delete(ObjectId id)
        {
            _collection.DeleteOne(item => item.ID == id);
        }

        public List<ElectronicTag> GetAll()
        {
            return _collection.Find(item => true).ToList();
        }

        public ElectronicTag GetById(ObjectId id)
        {
            return _collection.Find(item => item.ID == id).FirstOrDefault();
        }

        public void Insert(ElectronicTag entity)
        {
            _collection.InsertOne(entity);
        }

        public void Update(ElectronicTag entity)
        {
            _collection.ReplaceOne(item => item.ID == entity.ID, entity);
        }
    }
}
