using Entity.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models.Implements
{
    public class UserPlant : BaseModel
    {
        public string Nickname { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int PlantSpeciesId { get; set; }
        public PlantSpecies PlantSpecies { get; set; }

        public int SensorDeviceId { get; set; }
        public SensorDevice SensorDevice { get; set; }

        public ICollection<Notification> notifications { get; set; } = new List<Notification>();

    }
}
