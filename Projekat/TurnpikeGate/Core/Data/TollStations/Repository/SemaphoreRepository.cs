using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnpikeGate.Core.Data.TollStations.Repository
{
    public class SemaphoreRepository : ISemaphoreRepository
    {
        private IMongoCollection<Semaphore> _collection;

        public SemaphoreRepository()
        {
            _collection = DatabaseConnection.Database.GetCollection<Semaphore>("Semaphores");
        }

        public void Delete(ObjectId id)
        {
            _collection.DeleteOne(item => item.ID == id);
        }

        public List<Semaphore> GetAll()
        {
            return _collection.Find(item => true).ToList();
        }

        public Semaphore GetById(ObjectId id)
        {
            return _collection.Find(item => item.ID == id).FirstOrDefault();
        }

        public void Insert(Semaphore entity)
        {
            _collection.InsertOne(entity);
        }

        public void Update(Semaphore entity)
        {
            _collection.ReplaceOne(item => item.ID == entity.ID, entity);
        }
    }
}
