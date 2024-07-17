using BLL.DTOs;
using BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IConfiguration _configuration;

        public AuthController(IUserService userService, IConfiguration configuration)
        {
            _userService = userService;
            _configuration = configuration;
        }

        [HttpPost("login")]
        public async Task<ActionResult<object>> Login(LoginDtoRequest request)
        {
            if (request.Email.IsNullOrEmpty() && request.Username.IsNullOrEmpty())
                return BadRequest("Cannot login without at least an email or a phone number!");

            var (cookieOptions,data) = await _userService.Login(request);
            /*
            if (refresh != null)
            {
                Response.Cookies.Append("refreshToken", refresh, cookieOptions);
            }
            */
            return Ok(data);

        }

        [HttpPost("register")]
        public async Task<ActionResult<UserDtoResponse>> Register(UserDtoRequest userRegisterDto)

        {
            //Check if input contains at least an email or a phone number

            if (userRegisterDto.Email.IsNullOrEmpty() && userRegisterDto.Username.IsNullOrEmpty())
                return BadRequest("Cannot register without at least an email or a phone number!");
            var userDto = await _userService.RegisterUser(userRegisterDto);
            return Ok(userDto);
        }
    }
}
