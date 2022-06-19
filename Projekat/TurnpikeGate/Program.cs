
using MongoDB.Bson;
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
            Credentials user = new Credentials("ognjencar34","123",UserType.ADMINISTRATOR,new ObjectId("62af712c3a5c19aa24753f93"));
            ICredentialsRepository rep = new CredentialsRepository();
            rep.Insert(user);

        }
    }
}