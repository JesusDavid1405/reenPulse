using Entity.DTOs.Base;
using Entity.Models.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs.Implements.SensorReading
{
    public class SensorReadingSelectDto : BaseDto
    {
        public int SensorDeviceId { get; set; }

        /// <summary>
        /// Atributo adicional para mostrar el DeviceId del dispositivo del sensor
        /// </summary>
        public string SensorDeviceName { get; set; }

        public int UserPlantId { get; set; }
        public string UserPlantNickName { get; set; }

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
