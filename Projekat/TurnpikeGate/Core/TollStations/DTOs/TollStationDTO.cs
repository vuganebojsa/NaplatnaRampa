using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnpikeGate.Core.TollStations.DTOs
{
    public class CreateTollStationDTO
    {
        public string Address { get; set; }

        public string Name { get; set; }

        public ObjectId? StationManagerId { get; set; }

        public List<ObjectId>? ReferentIds { get; set; }

        public ObjectId LocationId { get; set; }

        public List<ObjectId>? TollBoothIds { get; set; }

    }

}
