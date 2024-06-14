using Microsoft.AspNetCore.Mvc;
using PiCTS.Entities.DataTransferObjects.MainRootDTOs.RequestDTOs;
using PiCTS.Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Presentation.Controllers
{
    [ApiController]
    [Route("api/mainroots")]
    public class MainRootsController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public MainRootsController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet("GetAllMainRootsAsync")]
        public async Task<IActionResult> GetAllMainRootsAsync()
        {
            var entities = await _manager.MainRootService.GetAllMainRootsAsync(false);
            return Ok(entities);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOneMainRootAsync([FromRoute(Name = "id")]int id)
        {
            var entity = await _manager.MainRootService.GetOneMainRootByIdAsync(id, false);
            return Ok(entity);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMainRootAsync([FromBody]MainRootRegistrationDTO mainRootRegistrationDTO)
        {
            await _manager.MainRootService.CreateOneMainRootAsync(mainRootRegistrationDTO);
            return StatusCode(201, mainRootRegistrationDTO);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateMainRootAsync([FromRoute(Name = "id")]int id, [FromBody]MainRootUpdateDTO mainRootUpdateDTO)
        {
            await _manager.MainRootService.UpdateOneMainRootAsync(id, mainRootUpdateDTO, false);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteMainRootAsync([FromRoute(Name = "id")]int id)
        {
            await _manager.MainRootService.DeleteOneMainRootAsync(id, false);
            return NoContent();
        }
    }
}
