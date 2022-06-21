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
using TurnpikeGate.Core;
using TurnpikeGate.Core.Locations.Repository;
using TurnpikeGate.Core.Locations.Service;
using TurnpikeGate.Core.TollStations;
using TurnpikeGate.View.AdministratorViews;

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
            TollStationForm tf = new TollStationForm();
            tf.ShowDialog();

        }
    }
}