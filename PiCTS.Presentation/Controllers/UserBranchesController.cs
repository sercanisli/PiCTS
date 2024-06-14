using Microsoft.AspNetCore.Mvc;
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
    [Route("api/userbranches")]
    public class UserBranchesController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public UserBranchesController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetAllUserBranchesByUserIdAsync([FromRoute] Guid id)
        {
            var userBranches = await _manager.UserBranchesService.GetllUserBranchesByUserIdAsync(id, false);
            return Ok(userBranches);
        }

        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> UpdateUserBranchesAsync([FromRoute(Name = "id")]Guid id ,[FromBody]List<UserBranches> userBranches)
        {
            await _manager.UserBranchesService.UpdateOneUserBranchesAsync(id ,userBranches, false);
            return NoContent();
        }
    }
}
