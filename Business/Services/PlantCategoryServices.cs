using AutoMapper;
using Business.Interfaces.Implements;
using Business.Repository;
using Data.Interfaces.IDataBasic;
using Entity.DTOs.Implements.PlantCategory;
using Entity.Models.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class PlantCategoryServices : BusinessGeneric<PlantCategoryDto, PlantCategoryDto, PlantCategory>, IPlantCategoryServices
    {
        public PlantCategoryServices(IDataBasic<PlantCategory> data, IMapper mapper)
            : base(data, mapper)
        { }
    }
}
