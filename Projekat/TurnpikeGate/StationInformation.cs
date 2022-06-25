using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using TurnpikeGate.Core.TollStations;

namespace TurnpikeGate
{
    class StationInformation
    {
        public static ObjectId EntryStationId { get; set; }
        public static ObjectId ExitStationId { get; set; }
        public static ObjectId TollBoothId { get; set; }


        public static void LoadFile()
        {
            using (var file = new StreamReader("../../../data/stationInfo.txt"))
            {
                string line = file.ReadLine();
                string[] splitLine = line.Split(':');

                EntryStationId = ObjectId.Parse(splitLine[1]);

                line = file.ReadLine();
                splitLine = line.Split(':');
                ExitStationId = ObjectId.Parse(splitLine[1]);

                line = file.ReadLine();
                splitLine = line.Split(':');
                TollBoothId = ObjectId.Parse(splitLine[1]);

            }

        }

    }
}
