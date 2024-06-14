using PiCTS.Entities.DataTransferObjects;
using PiCTS.Entities.DataTransferObjects.RoleDTOs.ResponseDTOs;
using PiCTS.Entities.DataTransferObjects.UserDTOs.RequestDTOs;
using PiCTS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Services.Contract
{
    public interface IUserRolesService
    {
        Task<IList<RoleResponseDTO>> GetAllUserRolesAsync(Guid id);
        Task UpdateOneUserRolesAsync(UserForUserRolesDTO userForUserRolesDTO);
    }
}
