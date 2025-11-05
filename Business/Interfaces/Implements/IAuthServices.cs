using Entity.DTOs.Implements.User;
using Entity.Models.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces.Implements
{
    public interface IAuthServices
    {
        Task<TokenDto?> Login(LoginDto login);
    }
}
