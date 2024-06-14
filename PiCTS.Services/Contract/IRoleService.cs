using Microsoft.AspNetCore.Identity;
using PiCTS.Entities.DataTransferObjects.RoleDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.RoleDTOs.ResponseDTOs;
using PiCTS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Services.Contract
{
    public interface IRoleService
    {
        Task<IEnumerable<RoleResponseDTO>> GetAllRolesAsync();
        Task<RoleResponseDTO> GetOneRoleById(Guid id);
        Task<IdentityResult> CreateOneRoleAsync(RoleRegistrationDTO roleRegistrationDTO);
        Task UpdateOneRoleAsync(Guid id, RoleUpdateDTO roleUpdateDTO);
        Task DeleteOneRoleAsync(Guid id);
    }
}
