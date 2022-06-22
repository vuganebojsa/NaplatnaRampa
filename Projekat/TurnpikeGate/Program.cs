using MongoDB.Bson;
using TurnpikeGate.Core.TollStations.Model;
using TurnpikeGate.Core.TollStations.Repository;
using TurnpikeGate.Core.Turnpike.Model;
using TurnpikeGate.Core.Turnpike.Repository;
using TurnpikeGate.Core.Prices.Model;
using TurnpikeGate.Core.Prices.Repository;
using TurnpikeGate.Core.Users;
using TurnpikeGate.Core.Users.Model;
using TurnpikeGate.Core.Users.Repository;
using TurnpikeGate.Core.TollStations.Service;
using Autofac;
using TurnpikeGate.View.AdministratorViews;
using TurnpikeGate.View;
using TurnpikeGate.Core.Users.Service;

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
            Globals.Load();

            LoginForm lf = new LoginForm();
            lf.ShowDialog();
        }
    }
}