using Entity.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs.Implements.SensorDevice
{
    public class SensorDeviceDto : BaseDto
    {
        public string DeviceId { get; set; }
        public string Model { get; set; }
        public float BatteryLevel { get; set; }
        public DateTime LastSeenAt { get; set; }
        public string Status { get; set; }
    }
}
