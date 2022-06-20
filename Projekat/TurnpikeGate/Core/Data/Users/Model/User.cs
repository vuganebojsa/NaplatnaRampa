using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TurnpikeGate.Core.Data.Users.Model
{
    
    public class User
    {
        [BsonElement("_id")]
        public ObjectId ID { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("lastName")]
        public string LastName { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("phoneNumber")]
        public string PhoneNumber { get; set; }

        [BsonElement("JMBG")]
        public string JMBG { get; set; }

        [BsonElement("salary")]
        public double Salary { get; set; }

        [BsonElement("active")]
        public bool IsActive { get; set; }


        public User(string name, string lastName, string email, string phoneNumber, string jmbg, double salary)
        {
            ID = ObjectId.GenerateNewId();
            Name = name;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            JMBG = jmbg;
            Salary = salary;
            IsActive = false;
        }
    }


}