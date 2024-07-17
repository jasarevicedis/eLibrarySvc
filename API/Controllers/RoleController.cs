using BLL.DTOs;
using BLL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _userRoleService;

        public RoleController(IRoleService userRoleService)
        {
            _userRoleService = userRoleService;
        }

        [HttpGet]
        //[Authorize()]
        public async Task<ActionResult<RoleDto>> GetUserRoleById(int roleId)
        {
            return await _userRoleService.GetUserRoleById(roleId);
        }
    }
}
