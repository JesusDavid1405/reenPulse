using AutoMapper;
using Business.Interfaces.Implements;
using Business.Repository;
using Data.Interfaces.IDataBasic;
using Entity.DTOs.Implements.User;
using Entity.Models.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class UserServices : BusinessGeneric<UserDto, UserDto, User>, IUserServices
    {
        public UserServices(IDataBasic<User> data, IMapper mapper)
            : base(data, mapper)
        { }
    }
}
