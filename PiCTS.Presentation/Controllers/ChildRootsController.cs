using Microsoft.AspNetCore.Mvc;
using PiCTS.Entities.DataTransferObjects.ChildRootDTOs.RequestDTOs;
using PiCTS.Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Presentation.Controllers
{
    [ApiController]
    [Route("api/childroots")]
    public class ChildRootsController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public ChildRootsController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet("GetAllChildRootsAsync")]
        public async Task<IActionResult> GetAllChildRootsAsync()
        {
            var entities = await _manager.ChildRootService.GetAllChildRootsAsync(false);
            return Ok(entities);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOneChildRootByIdAsync([FromRoute(Name = "id")]int id)
        {
            var entity = await _manager.ChildRootService.GetOneChildRootByIdAsync(id, false);
            return Ok(entity);
        }

        [HttpPost]
        public async Task<IActionResult> CreateChildRootAsync([FromBody]ChildRootRegistrationDTO childRootRegistrationDTO)
        {
            await _manager.ChildRootService.CreateOneChildRootAsync(childRootRegistrationDTO);
            return StatusCode(201, childRootRegistrationDTO);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateChildRootAsync([FromRoute(Name = "id")]int id, [FromBody]ChildRootUpdateDTO childRootUpdateDTO)
        {
            await _manager.ChildRootService.UpdateOneChildRootAsync(id, childRootUpdateDTO, false);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteChildRootAsync([FromRoute(Name = "id")]int id)
        {
            await _manager.ChildRootService.DeleteOneChildRootAsync(id, false);
            return NoContent();
        }
    }
}
