using MongoDB.Bson;
using TurnpikeGate.Core.Data.TollStations.Model;
using TurnpikeGate.Core.Data.TollStations.Repository;
using TurnpikeGate.Core.Data.Turnpike.Model;
using TurnpikeGate.Core.Data.Turnpike.Repository;
using TurnpikeGate.Core.Data.Users;
using TurnpikeGate.Core.Data.Users.Model;
using TurnpikeGate.Core.Data.Users.Repository;
namespace TurnpikeGate
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseConnection.Init();   
        }
    }
}