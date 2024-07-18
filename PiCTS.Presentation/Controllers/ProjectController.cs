using Microsoft.AspNetCore.Mvc;
using PiCTS.Entities.DataTransferObjects.ProjectDTOs.RequestDTOs;
using PiCTS.Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Presentation.Controllers
{
    [ApiController]
    [Route("api/projects")]
    public class ProjectController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public ProjectController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet("GetAllProjectsAsync")]
        public async Task<IActionResult> GetAllProjectsAsync()
        {
            var entities = await _manager.ProjectService.GetAllProjectsAsync(false);
            return Ok(entities);
        }

        [HttpGet("GetAllLimitedProjectAsync")]
        public async Task<IActionResult> GetAllLimitedProjectAsync()
        {
            var entities = await _manager.ProjectService.GetAllLimitedProjectAsync(false);
            return Ok(entities);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOneProjectByIdAsync([FromRoute(Name = "id")]int id)
        {
            var entity = await _manager.ProjectService.GetOneProjectByIdAsync(id, false);
            return Ok(entity);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProjectAsync([FromBody]ProjectRegistrationDTO projectRegistrationDTO)
        {
            await _manager.ProjectService.CreateOneProjectAsync(projectRegistrationDTO);
            return StatusCode(201, projectRegistrationDTO);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateProjectAsync([FromRoute(Name = "id")]int id,[FromBody]ProjectUpdateDTO projectUpdateDTO)
        {
            await _manager.ProjectService.UpdateOneProjectAsync(id, projectUpdateDTO, false);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteProjectAsync([FromRoute(Name = "id")]int id)
        {
            await _manager.ProjectService.DeleteOneProjectAsync(id, false);
            return NoContent();
        }
    }
}
