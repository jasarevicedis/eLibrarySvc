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

        public async Task<UserDtoResponse> AddUser(UserDtoRequest userRegisterDto)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(userRegisterDto.Password);

            User user = new User
            {
                FirstName = userRegisterDto.FirstName,
                LastName = userRegisterDto.LastName,
                Email = userRegisterDto.Email,
                Username = userRegisterDto.Username,
                PasswordHash = Encoding.UTF8.GetBytes(passwordHash),
                PasswordSalt = [],
                RoleId = userRegisterDto.RoleId,
            };
            _userRepository.Add(user);

            await _userRepository.SaveChangesAsync();

            var newUser = _mapper.Map<UserDtoResponse>(user);
            return newUser;
        }

        public Task DeleteUser(int userId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserDtoResponse>> GetAll()
        {
            var users = await _userRepository.GetAll();

            return _mapper.Map<List<UserDtoResponse>>(users);
        }

        public async Task<User> GetUserById(int id)
        {
            return await _userRepository.GetUserById(id);
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

        public async Task<UserDtoResponse> UpdateUser(UserDtoRequest userRequest, int userId)
        {
            var mappedUser = _mapper.Map<User>(userRequest);

            var user = await _userRepository.GetById(userId);

            mappedUser.PasswordHash = user!.PasswordHash;
            mappedUser.PasswordSalt = user.PasswordSalt;

            _userRepository.DetachEntity(user);
            //mappedUser.Role = null;
            mappedUser.Role = null;
            //user = mappedUser;
            _userRepository.Update(mappedUser);
            await _userRepository.SaveChangesAsync();

            var updatedUser = _mapper.Map<UserDtoResponse>(userRequest);
            return updatedUser;
        }
    }
}
