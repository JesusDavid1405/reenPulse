using Data.Interfaces.IDataBasic;
using Entity.Models.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces.IDataImplement
{
    public interface IUserRepository : IDataBasic<User>
    {
        Task<User?> Login(string emailOrUsername, string password);
        Task<User?> GetByUsernameOrEmailAsync(string emailOrUsername);
    }
}
