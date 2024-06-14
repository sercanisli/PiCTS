using Microsoft.AspNetCore.Mvc;
using PiCTS.Entities.DataTransferObjects.UserDTOs.RequestDTOs;
using PiCTS.Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Presentation.Controllers
{
    [ApiController]
    [Route("api/userroles")]
    public class UserRolesController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public UserRolesController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetAllUserRolesAsync([FromRoute] Guid id)
        {
            var roles = await _manager.UserRolesService.GetAllUserRolesAsync(id);
            return Ok(roles);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUserRoles([FromBody] UserForUserRolesDTO userForUserRolesDTO)
        {
            await _manager.UserRolesService.UpdateOneUserRolesAsync(userForUserRolesDTO);
            return NoContent();
        }
    }
}
