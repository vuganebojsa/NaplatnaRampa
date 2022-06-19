using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnpikeGate.Core.Data.Users.Model
{
    public enum UserType 
    {
        ADMINISTRATOR,
        MAIN_MANAGER,
        STATION_MANAGER,
        REFERENT,
        TAG_SELLER
    }
    public class Credentials
    {
        [BsonElement("_id")]
        public ObjectId ID { get; set; }

        [BsonElement("username")]
        public string Username { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }

        [BsonElement("userType")]
        public UserType Type { get; set; }

        // Foreign keys
        [BsonElement("userId")]
        public ObjectId UserId { get; set; }
        

        public Credentials(string username, string password, UserType type, ObjectId userId)
        { 
            ID = ObjectId.GenerateNewId();
            Username = username;
            Password = password;
            Type = type;
            UserId = userId;
        }

    }
}
