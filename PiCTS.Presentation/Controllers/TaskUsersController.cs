using Microsoft.AspNetCore.Mvc;
using PiCTS.Entities.DataTransferObjects.TaskUsersDTOs.RequestDTOs;
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
    [Route("api/taskusers")]
    public class TaskUsersController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public TaskUsersController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAllTaskUsersByTaskIdAsync([FromRoute] int id)
        {
            var taskUsers = await _manager.TaskUsersService.GetAllTaskUsersByTaskIdAsync(id, false);
            return Ok(taskUsers);
        }

        [HttpPost("GetAllUserTasksByUserIdAsync")]
        public async Task<IActionResult> GetAllUserTasksByUserIdAsync([FromBody] UserIdDTO userIdDTO)
        {
            var userTasks = await _manager.TaskUsersService.GetAllUserTasksByUserIdAsync(userIdDTO.UserId, false);
            return Ok(userTasks);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateTaskUsersAsync([FromRoute(Name = "id")] int id, [FromBody] List<TaskUsers> taskUsers)
        {
            await _manager.TaskUsersService.UpdateOneTaskUsersAsync(id, taskUsers, false);
            return NoContent();
        }

        [HttpPut("UpdateOneTaskSawAsync")]
        public async Task<IActionResult> UpdateOneTaskSawAsync([FromBody]UserIdDTO userIdDTO)
        {
            await _manager.TaskUsersService.UpdateOneTaskSawAsync(userIdDTO.UserId, false);
            return NoContent();
        }
    }
}
