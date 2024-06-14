using AutoMapper;
using Microsoft.AspNetCore.Identity;
using PiCTS.Entities.DataTransferObjects;
using PiCTS.Entities.DataTransferObjects.RoleDTOs.ResponseDTOs;
using PiCTS.Entities.DataTransferObjects.UserDTOs.RequestDTOs;
using PiCTS.Entities.Exceptions;
using PiCTS.Entities.Models;
using PiCTS.Repositories.Contract;
using PiCTS.Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Services.Concrete
{
    public class UserRolesManager : IUserRolesService
    {
        private readonly UserManager<User> _userManager;
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;
        private readonly RoleManager<Role> _roleManager;

        public UserRolesManager(UserManager<User> userManager, IRepositoryManager manager, IMapper mapper, RoleManager<Role> roleManager)
        {
            _userManager = userManager;
            _manager = manager;
            _mapper = mapper;
            _roleManager = roleManager;
        }

        public async Task<IList<RoleResponseDTO>> GetAllUserRolesAsync(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                throw new UserNotFoundException(id);
            }

            var roles = await _userManager.GetRolesAsync(user);
            var roleDTOs = new List<RoleResponseDTO>();

            foreach (var roleName in roles)
            {
                var role = await _roleManager.FindByNameAsync(roleName);
                if (role != null)
                {
                    var roleDTO = _mapper.Map<RoleResponseDTO>(role);
                    roleDTOs.Add(roleDTO);
                }
            }

            return roleDTOs;
        }

        public async Task UpdateOneUserRolesAsync(UserForUserRolesDTO userForUserRolesDTO)
        {
            var user = await _userManager.FindByIdAsync(userForUserRolesDTO.Id.ToString());
            if (user == null)
            {
                throw new UserNotFoundException(userForUserRolesDTO.Id);
            }

            var existingRoles = await _userManager.GetRolesAsync(user);

            foreach (var role in existingRoles)
            {
                var result = await _userManager.RemoveFromRoleAsync(user, role);

                if (!result.Succeeded)
                {
                    throw new Exception($"An error occurred while removing the role '{role}' from the user.");
                }
            }

            foreach (var role in userForUserRolesDTO.Roles)
            {
                var result = await _userManager.AddToRoleAsync(user, role);

                if (!result.Succeeded)
                {
                    throw new Exception($"An error occurred while adding the role '{role}' to the user.");
                }
            }
        }
    }
}
