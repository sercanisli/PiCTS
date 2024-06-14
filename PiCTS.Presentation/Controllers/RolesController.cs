using Microsoft.AspNetCore.Mvc;
using PiCTS.Entities.DataTransferObjects.RoleDTOs.RequestDTOs;
using PiCTS.Entities.Models;
using PiCTS.Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Presentation.Controllers
{
    [ApiController]
    [Route("api/roles")]
    public class RolesController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public RolesController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet("GetAllRolesAsync")]
        public async Task<IActionResult> GetAllRolesAsync()
        {
            var roles = await _manager.RoleService.GetAllRolesAsync();
            return Ok(roles);
        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetOneRoleByIdAsync([FromRoute(Name = "id")]Guid id)
        {
            var role = await _manager.RoleService.GetOneRoleById(id);
            return Ok(role);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOneRole([FromBody]RoleRegistrationDTO roleRegistrationDTO)
        {
            var result = await _manager.RoleService.CreateOneRoleAsync(roleRegistrationDTO);
            if (!result.Succeeded)
            {
                foreach (var err in result.Errors)
                {
                    ModelState.TryAddModelError(err.Code, err.Description);
                }
                return BadRequest(ModelState);
            }
            return StatusCode(201);
        }

        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> DeleteRole([FromRoute(Name = "id")] Guid id)
        {
            await _manager.RoleService.DeleteOneRoleAsync(id);
            return NoContent();
        }

        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> UpdateOneRole([FromRoute(Name = "id")] Guid id, [FromBody]RoleUpdateDTO roleUpdateDTO)
        {
            await _manager.RoleService.UpdateOneRoleAsync(id, roleUpdateDTO);
            return NoContent();
        }
    }
}
