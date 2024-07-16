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
        Task<UserDtoResponse> AddUser(UserRegisterDto userRegisterDto, int adminId);
        Task<List<UserDtoResponse>> GetAll();
        Task RemoveUser(int userId);
        Task<User> GetUserById(int id);
        Task<(CookieOptions cookiesOption,object data)> Login(LoginRequest loginRequest);
    }
}
