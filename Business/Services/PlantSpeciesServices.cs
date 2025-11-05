using AutoMapper;
using Business.Interfaces.Implements;
using Business.Repository;
using Data.Interfaces.IDataBasic;
using Entity.DTOs.Implements.PlantSpecies;
using Entity.Models.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class PlantSpeciesServices : BusinessGeneric<PlantSpeciesSelectDto, PlantSpeciesCreateDto, PlantSpecies>, IPlantSpeciesServices
    {
        public PlantSpeciesServices(IDataBasic<PlantSpecies> data,IMapper mapper)
            : base(data, mapper)
        { }
    }
}
