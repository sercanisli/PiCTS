using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PiCTS.Entities.DataTransferObjects.RoleDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.RoleDTOs.ResponseDTOs;
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
    public class RoleManager : IRoleService
    {
        private readonly RoleManager<Role> _roleManager;
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public RoleManager(RoleManager<Role> roleManager, IRepositoryManager repositoryManager, IMapper mapper)
        {
            _roleManager = roleManager;
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<IdentityResult> CreateOneRoleAsync(RoleRegistrationDTO roleRegistrationDTO)
        {
            var role = _mapper.Map<Role>(roleRegistrationDTO);

            if(role == null)
            {
                throw new ArgumentNullException(nameof(role));
            }
            var result = await _roleManager.CreateAsync(role);
            await _repositoryManager.SaveChanges();
            var returnedRole = role;

            return result;
        }

        public async Task DeleteOneRoleAsync(Guid id)
        {
            var role = await _roleManager.Roles.FirstOrDefaultAsync(r => r.Id == Convert.ToString(id));
            if(role == null)
            {
                throw new RoleNotFoundException(id);
            }
            await _roleManager.DeleteAsync(role);
            await _repositoryManager.SaveChanges();
        }

        public async Task<IEnumerable<RoleResponseDTO>> GetAllRolesAsync()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            return _mapper.Map<IEnumerable<RoleResponseDTO>>(roles);
        }

        public async Task<RoleResponseDTO> GetOneRoleById(Guid id)
        {
            var role = await _roleManager.Roles.FirstOrDefaultAsync(r => r.Id == Convert.ToString(id));
            if(role == null)
            {
                throw new RoleNotFoundException(id);
            }
            return _mapper.Map<RoleResponseDTO>(role);
        }

        public async Task UpdateOneRoleAsync(Guid id, RoleUpdateDTO roleUpdateDTO)
        {
            var role = _mapper.Map<Role>(roleUpdateDTO);

            var returnedRole = await _roleManager.Roles.FirstOrDefaultAsync(r => r.Id == Convert.ToString(id));
            if (returnedRole == null)
            {
                throw new RoleNotFoundException(id);
            }
            returnedRole.Name = role.Name;
            returnedRole.ParentKey = role.ParentKey;
            await _roleManager.UpdateAsync(returnedRole);
            await _repositoryManager.SaveChanges();
        }
    }
}
