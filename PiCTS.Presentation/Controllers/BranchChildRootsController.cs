using Microsoft.AspNetCore.Mvc;
using PiCTS.Entities.DataTransferObjects.BranchChildRootDTOs.RequestDTOs;
using PiCTS.Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Presentation.Controllers
{
    [ApiController]
    [Route("api/")]
    public class BranchChildRootsController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public BranchChildRootsController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet("GetAllBranchChildRootAsync")]
        public async Task<IActionResult> GetAllBranchChildRootAsync()
        {
            var entities = await _manager.BranchChildRootService.GetAllBranchChildRootAsync(false);
            return Ok(entities);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOneBranchChildRootByIdAsync([FromRoute(Name ="id")]int id)
        {
            var entity = await _manager.BranchChildRootService.GetOneBranchChildRootByIdAsync(id, false);
            return Ok(entity);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOneBranchChildRootAsync([FromBody]BranchChildRootRegistrationDTO branchChildRootRegistrationDTO)
        {
            await _manager.BranchChildRootService.CreateOneBranchChildRootAsync(branchChildRootRegistrationDTO);
            return StatusCode(201, branchChildRootRegistrationDTO);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateOneBranchChildRootAsync([FromRoute(Name = "id")]int id, [FromBody]BranchChildRootUpdateDTO branchChildRootUpdateDTO)
        {
            await _manager.BranchChildRootService.UpdateOneBranchChildRootAsync(id, branchChildRootUpdateDTO, false);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteBranchChildRootAsync([FromRoute(Name = "id")]int id)
        {
            await _manager.BranchChildRootService.DeleteOneBranchChildRootAsync(id, false);
            return NoContent();
        }
    }
}
