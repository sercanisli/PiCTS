using Microsoft.AspNetCore.Mvc;
using PiCTS.Entities.DataTransferObjects.TasksDTOs.RequestDTOs;
using PiCTS.Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Presentation.Controllers
{
    [ApiController]
    [Route("api/tasks")]
    public class TaskController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public TaskController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet("GetAllTasksAsync")]
        public async Task<IActionResult> GetAllTasksAsync()
        {
            var entities = await _manager.TaskService.GetAllTasksAsync(false);
            return Ok(entities);
        }

        [HttpGet("GetAllTasksByProjectIdAsync/{id:int}")]
        public async Task<IActionResult> GetAllTasksByProjectIdAsync([FromRoute(Name ="id")]int id)
        {
            var entities = await _manager.TaskService.GetAllTasksByProjectIdAsync(id, false);
            return Ok(entities);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOneTaskByIdAsync([FromRoute(Name = "id")]int id)
        {
            var entity = await _manager.TaskService.GetOneTaskByIdAsync(id, false);
            return Ok(entity);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTaskAsync([FromBody]TasksRegistrationDTO tasksRegistrationDTO)
        {
            var entitiy = await _manager.TaskService.CreateTaskAsync(tasksRegistrationDTO);
            return StatusCode(201, entitiy);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateTaskAsync([FromRoute(Name = "id")]int id, [FromBody]TasksUpdateDTO tasksUpdateDTO)
        {
            await _manager.TaskService.UpdateTaskAsync(id, tasksUpdateDTO, false);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteTaskAsync([FromRoute(Name = "id")]int id)
        {
            await _manager.TaskService.DeleteTaskAsync(id, false);
            return NoContent();
        }
    }
}
