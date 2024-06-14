using Microsoft.AspNetCore.Mvc;
using PiCTS.Entities.DataTransferObjects.BranchMainRootDTOs.RequestDTOs;
using PiCTS.Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Presentation.Controllers
{
    [ApiController]
    [Route("api/branchmainroots")]
    public class BranchMainRootsController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public BranchMainRootsController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet("GetAllBranchMainRootsAsync")]
        public async Task<IActionResult> GetAllBranchMainRootsAsync()
        {
            var entities = await _manager.BranchMainRootService.GetAllBranchMainRootAsync(false);
            return Ok(entities);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOneBranchMainRootAsync([FromRoute(Name = "id")]int id)
        {
            var entity = await _manager.BranchMainRootService.GetOneBranchMainRootByIdAsync(id, false);
            return Ok(entity);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOneBranchMainRootAsync([FromBody]BranchMainRootRegistrationDTO branchMainRootRegistrationDTO)
        {
            await _manager.BranchMainRootService.CreateOneBranchMainRootAsync(branchMainRootRegistrationDTO);
            return StatusCode(201, branchMainRootRegistrationDTO);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateOneBranchMainRootAsync([FromRoute(Name = "id")]int id, [FromBody]BranchMainRootUpdateDTO branchMainRootUpdateDTO)
        {
            await _manager.BranchMainRootService.UpdateOneBranchMainRootAsync(id, branchMainRootUpdateDTO, false);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteOneBranchMainRootAsync([FromRoute(Name = "id")]int id)
        {
            await _manager.BranchMainRootService.DeleteOneBranchMainRootAsync(id, false);
            return NoContent();
        }
    }
}
