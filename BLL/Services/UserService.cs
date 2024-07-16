using AutoMapper;
using BLL.DTOs;
using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Security.Cryptography;
using System.Security.Claims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService : IUserService
    {

        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        private readonly IConfiguration _configuration;

        public UserService(IMapper mapper, IUserRepository userRepository, IConfiguration configuration)
        {
            _mapper = mapper;
            _userRepository = userRepository;
            _configuration = configuration;
        }

        public Task<UserDtoResponse> AddUser(UserRegisterDto userRegisterDto, int adminId)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserDtoResponse>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<(CookieOptions cookiesOption, object data)> Login(LoginRequest loginRequest)
        {
            var user = new User();

            if (!string.IsNullOrEmpty(loginRequest.Username))
            {
                user = await _userRepository.FindByUsername(loginRequest.Username);
            }
            else if (string.IsNullOrEmpty(loginRequest.Email))
            {
                user = await _userRepository.FindByEmail(loginRequest.Email);
            }


            if (user == null || user.PasswordHash == null)
            {
                throw new Exception("User object or password hash is null.");
            }
            if (!BCrypt.Net.BCrypt.Verify(loginRequest.Password, Encoding.UTF8.GetString(user.PasswordHash)))
            {
                throw new Exception("Wrong password.");
            }


            return (null,null);

        }

        public Task RemoveUser(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
