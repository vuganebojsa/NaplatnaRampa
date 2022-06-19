using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnpikeGate
{
   
    public static class DatabaseConnection
    {
        public static IMongoDatabase Database;

        public static void Init()
        {
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://tim7:tim7idemo@cluster0.4zhwvea.mongodb.net/?retryWrites=true&w=majority");
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            Database = client.GetDatabase("TurnpikeGate");
        }
    }

    
}
