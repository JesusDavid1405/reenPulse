using Entity.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models.Implements
{
    public class PlantCategory : GenericModel
    {
        public ICollection<PlantSpecies> plantSpecies { get; set; } = new List<PlantSpecies>();
    }
}
