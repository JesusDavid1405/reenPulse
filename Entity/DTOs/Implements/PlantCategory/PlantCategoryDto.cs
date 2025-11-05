using Entity.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs.Implements.PlantCategory
{
    public class PlantCategoryDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
