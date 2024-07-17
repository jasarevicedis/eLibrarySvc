using BLL.DTOs;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IUserService
    {
        Task<UserDtoResponse> AddUser(UserDtoRequest userRegisterDto, int adminId);
        Task<List<UserDtoResponse>> GetAll();
        Task DeleteUser(int userId);
        Task<User> GetUserById(int id);
        Task<(CookieOptions cookiesOption,object data)> Login(LoginDtoRequest loginRequest);
        Task<UserDtoResponse> RegisterUser(UserDtoRequest registerRequest);
    }
}
