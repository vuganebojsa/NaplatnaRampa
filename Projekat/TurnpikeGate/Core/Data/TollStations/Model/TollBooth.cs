using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnpikeGate.Core.Data.TollStations.Model
{
    public enum TypeOfPayment
    {
        ELECTRONIC, PHYSICAL
    }
    public class TollBooth
    {
        [BsonElement("_id")]
        public ObjectId ID { get; set; }
        [BsonElement("type")]
        public TypeOfPayment Type { get; set; }

        // Foreign keys
        [BsonElement("toolStationId")]
        public ObjectId ToolStationId { get; set; }
        [BsonElement("rampId")]
        public ObjectId RampId { get; set; }
        [BsonElement("semaphoreId")]
        public ObjectId SemaphoreId { get; set; }
        [BsonElement("cameraId")]
        public ObjectId CameraId { get; set; }

        public TollBooth(TypeOfPayment type, ObjectId toolStationId, ObjectId rampId, ObjectId semaphoreId, ObjectId cameraId)
        {
            Type = type;
            ToolStationId = toolStationId;
            RampId = rampId;
            CameraId = cameraId;
            SemaphoreId = semaphoreId;
        }

    }
}
