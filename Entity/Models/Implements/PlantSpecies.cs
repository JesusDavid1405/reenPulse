using Entity.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models.Implements
{
    public class PlantSpecies : BaseModel
    {
        public int PlantCategoryId { get; set; }
        public PlantCategory PlantCategory { get; set; }

        public string ScientificName { get; set; }
        public string CommonName { get; set; }

        /// <summary>
        /// valores optimos de la humiedad del suelo en porcentaje
        /// </summary>
        public float OptSoliMoistureMin { get; set; }
        public float OptSoliMoistureMax { get; set; }

        /// <summary>
        /// Valores optimos del PH en una escala de 0 a 14
        /// </summary>
        public float OptPHMin { get; set; }
        public float OptPHMax { get; set; }

        /// <summary>
        /// Valores optimos de la temperatura del suelo en grados Celsius
        /// </summary>
        public float OptSolilTempMin { get; set; }
        public float OptSolilTempMax { get; set; }

        public ICollection<UserPlant> userPlants { get; set; } = new List<UserPlant>();

    }
}
