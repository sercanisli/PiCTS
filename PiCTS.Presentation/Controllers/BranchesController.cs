using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PiCTS.Entities.DataTransferObjects.BranchDTOs.RequestDTOs;
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
    [Route("api/branches")]
    public class BranchesController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public BranchesController(IServiceManager manager)
        {
            _manager = manager;
        }

        [Authorize(Roles = "Şubeleri Gorme")]
        [HttpGet("GetAllBranchesAsync")]
        public async Task<IActionResult> GetAllBranchesAsync()
        {
            var userName = HttpContext.User?.Identity?.Name;
            var entities = await _manager.BranchService.GetAllBranchesAsync(userName, false);
            return Ok(entities);
        }

        [HttpGet("GetAllLimitedBranchesAsync")]
        public async Task<IActionResult> GetAllLimitedBranchesAsync()
        {
            var entities = await _manager.BranchService.GetAllLimitedBranchesAsync(false);
            return Ok(entities);
        }

        [Authorize(Roles = "Şubeleri Gorme")]
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOneBranchAsync([FromRoute(Name ="id")]int id)
        {
            var entity = await _manager.BranchService.GetOneBranchByIdAsync(id, false);
            return Ok(entity);
        }

        [Authorize(Roles = "Şube Oluşturma")]
        [HttpPost]
        public async Task<IActionResult> CreateBranchAsync([FromBody]BranchForRegistrationDTO branchForRegistrationDTO)
        {
            await _manager.BranchService.CreateOneBranchAsync(branchForRegistrationDTO);
            return StatusCode(201, branchForRegistrationDTO);
        }

        [Authorize(Roles = "Şube Güncelleme")]
        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateBranchAsync([FromRoute(Name ="id")]int id, [FromBody] BranchUpdateDTO branchUpdateDTO)
        {
            await _manager.BranchService.UpdateOneBranchAsync(id, branchUpdateDTO, false);
            return NoContent();
        }

        [Authorize(Roles = "Şube Silme")]
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteBranchAsync([FromRoute(Name ="id")]int id)
        {
            await _manager.BranchService.DeleteOneBranchAsync(id, false);
            return NoContent();
        }
    }
}
