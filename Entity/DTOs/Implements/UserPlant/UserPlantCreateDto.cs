using Entity.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs.Implements.UserPlant
{
    public class UserPlantCreateDto : BaseDto
    {
        public string Nickname { get; set; }

        public int UserId { get; set; }

        public int PlantSpeciesId { get; set; }

        public int SensorDeviceId { get; set; }
    }
}
