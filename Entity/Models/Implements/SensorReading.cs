using Entity.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models.Implements
{
    public class SensorReading : BaseModel
    {
        public int SensorDeviceId { get; set; }
        public SensorDevice SensorDevice { get; set; }

        public int UserPlantId { get; set; }
        public UserPlant UserPlant { get; set; }

        /// <summary>
        /// Valores capturados por el sensor
        /// PH : en una escala de 0 a 14
        /// SoilMoisture : en porcentaje
        /// SoilTemperature : en grados Celsius
        /// </summary>
        public float SoilMoisture { get; set; }
        public float PH { get; set; }
        public float SoilTemperature { get; set; }
    }
}
