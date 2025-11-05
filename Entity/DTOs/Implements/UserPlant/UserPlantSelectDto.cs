using Entity.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs.Implements.UserPlant
{
    public class UserPlantSelectDto : BaseDto
    {
        public string Nickname { get; set; }

        public int UserId { get; set; }
        public string UserName { get; set; }

        public int PlantSpeciesId { get; set; }
        public string PlantSpeciesCommonName { get; set; }

        public int SensorDeviceId { get; set; }
        /// <summary>
        /// Atributo adicional para mostrar el DeviceId del dispositivo del sensor
        /// </summary>
        public string SensorDeviceName { get; set; }
    }
}
