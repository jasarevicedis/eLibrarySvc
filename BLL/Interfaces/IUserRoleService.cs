using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IUserRoleService
    {
        Task<UserRoleDto> GetUserRoleById(int roleId);
    }
}
