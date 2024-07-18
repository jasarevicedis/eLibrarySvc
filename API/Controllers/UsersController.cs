using BLL.DTOs;
using BLL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using API.Util;
using BLL.Services;
using DAL.Models;

namespace API.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<ActionResult<UserDtoResponse>> AddUser(UserDtoRequest request)
        {
           

            var newUser = await _userService.AddUser(request);//, id

            return Ok(newUser);
        }

        [HttpGet]
        public async Task<ActionResult<List<UserDtoResponse>>> GetAll()
        {
            var users = await _userService.GetAll();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUserById(int id)
        {
            return await _userService.GetUserById(id);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<UserDtoResponse>> UpdateUser(int id, UserDtoRequest userRequest)
        {
            var updatedUser = await _userService.UpdateUser(userRequest, id);
            return updatedUser;
        }
    }
}
