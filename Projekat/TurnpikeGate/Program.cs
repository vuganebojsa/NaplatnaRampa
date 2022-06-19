using MongoDB.Bson;


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