using Entity.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models.Implements
{
    public class SensorDevice : BaseModel
    {
        public string DeviceId { get; set; }
        public string Model { get; set; }
        public float BatteryLevel { get; set; }
        public DateTime LastSeenAt { get; set; }
        public string Status { get; set; }

        public ICollection<UserPlant> userPlants { get; set; } = new List<UserPlant>();
        public ICollection<SensorReading> sensorReadings { get; set; } = new List<SensorReading>();

    }
}
