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
    public class UserRepository : IUserRepository
    {
        private IMongoCollection<User> _collection;

        public UserRepository()
        { 
            _collection = DatabaseConnection.Database.GetCollection<User>("Users");
        }

        public void Delete(ObjectId id)
        {
            _collection.DeleteOne(item => item.ID == id);
        }

        public List<User> GetAll()
        {
            return _collection.Find(item => true).ToList();
        }

        public User GetById(ObjectId id)
        {
            return _collection.Find(item => item.ID == id).FirstOrDefault();
        }

        public void Insert(User entity)
        {
            _collection.InsertOne(entity);
        }

        public void Update(User entity)
        {
            _collection.ReplaceOne(item => item.ID == entity.ID, entity);
        }
    }
}
