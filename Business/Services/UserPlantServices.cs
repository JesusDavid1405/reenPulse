using AutoMapper;
using Business.Interfaces.Implements;
using Business.Repository;
using Data.Interfaces.IDataBasic;
using Entity.DTOs.Implements.UserPlant;
using Entity.Models.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class UserPlantServices : BusinessGeneric<UserPlantSelectDto, UserPlantCreateDto, UserPlant>, IUserPlantServices
    {
        public UserPlantServices(IDataBasic<UserPlant> data, IMapper mapper)
            : base(data, mapper)
        { }
    }
}
