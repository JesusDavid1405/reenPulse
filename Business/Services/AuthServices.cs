using AutoMapper;
using Business.Interfaces;
using Business.Interfaces.Implements;
using Data.Interfaces.IDataImplement;
using Entity.DTOs.Implements.User;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class AuthServices : IAuthServices
    {
        private readonly IUserRepository _userRepository;
        private readonly IToken _tokenService;
        private readonly ILogger<AuthServices> _logger;
        private readonly IMapper _mapper;

        public AuthServices(IUserRepository userRepository, IToken tokenService, ILogger<AuthServices> logger, IMapper mapper)
        {
            _userRepository = userRepository;
            _tokenService = tokenService;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<TokenDto?> Login(LoginDto login)
        {
            var user = await _userRepository.Login(login.EmailOrUsername, login.Password);
            if (user == null)
            {
                _logger.LogWarning("Authentication failed for user: {EmailOrUsername}", login.EmailOrUsername);
                throw new UnauthorizedAccessException("Invalid credentials.");
            }
            var authDto = _mapper.Map<AuthDto>(user);
            return await _tokenService.GenerateTokensAsync(authDto);
        }
    }
}
