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

        public Task<UserDtoResponse> AddUser(UserDtoRequest userRegisterDto, int adminId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUser(int userId)
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

        public async Task<(CookieOptions cookiesOption, object data)> Login(LoginDtoRequest loginRequest)
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

        public async Task<UserDtoResponse> RegisterUser(UserDtoRequest registerRequest)
        {
            
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(registerRequest.Password);

            User user = new User
            {
                FirstName = registerRequest.FirstName,
                LastName = registerRequest.LastName,
                Email = registerRequest.Email,
                Username = registerRequest.Username,
                PasswordHash = Encoding.UTF8.GetBytes(passwordHash),
                PasswordSalt = [],
                RoleId = registerRequest.RoleId,
            };
            _userRepository.Add(user);

            await _userRepository.SaveChangesAsync();

            var userDto = _mapper.Map<UserDtoResponse>(user);

            return userDto;
        }

        public Task RemoveUser(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
