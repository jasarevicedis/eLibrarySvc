using AutoMapper;
using BLL.DTOs;
using BLL.Interfaces;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class RoleService : IRoleService
    {
        private readonly IMapper _mapper;
        private readonly IRoleRepository _userRoleRepository;

        public RoleService(IMapper mapper, IRoleRepository userRoleRepository)
        {
            _mapper = mapper;
            _userRoleRepository = userRoleRepository;
        }

        public async Task<RoleDto> GetUserRoleById(int roleId)
        {
            var userRole = await _userRoleRepository.GetById(roleId);
            return _mapper.Map<RoleDto>(userRole);
        }
    }
}
