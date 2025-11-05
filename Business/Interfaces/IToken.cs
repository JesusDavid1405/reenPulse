using Entity.DTOs.Implements.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IToken
    {
        Task<TokenDto> GenerateTokensAsync(AuthDto user);
    }   
}
