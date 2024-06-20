using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PiCTS.Entities.DataTransferObjects.ConnectionDTOs.RequestDTOs;
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
    [Route("api/connections")]
    public class ConnectionsController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public ConnectionsController(IServiceManager manager)
        {
            _manager = manager;
        }

        [Authorize(Roles = "Bağlantilari Gorme")]
        [HttpGet("GetAllConnectionsAsync")]
        public async Task<IActionResult> GetAllConnectionsAsync()
        {
            var entities = await _manager.ConnectionService.GetAllConnectionsAsync(false);
            return Ok(entities);
        }

        [HttpGet("GetAllConnectionsByBrachIdAsync")]
        public async Task<IActionResult> GetAllConnectionsByBrachIdAsync()
        {
            var userName = HttpContext.User?.Identity?.Name;
            var entities = await _manager.ConnectionService.GetAllConnectionsByBrachIdAsync(userName, false);
            return Ok(entities);
        }

        [Authorize(Roles = "Bağlantilari Gorme")]
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOneConnection([FromRoute(Name = "id")]int id)
        {
            var entity = await _manager.ConnectionService.GetOneConnectionByIdAsync(id, false);
            return Ok(entity);
        }

        [Authorize(Roles = "Bağlanti Oluşturma")]
        [HttpPost]
        public async Task<IActionResult> CreateConnectionAsync([FromBody]ConnectionRegistrationDTO connectionRegistrationDTO)
        {
            await _manager.ConnectionService.CreateOneConnectionAsync(connectionRegistrationDTO);
            return StatusCode(201, connectionRegistrationDTO);
        }

        [Authorize(Roles = "Bağlanti Güncelleme")]
        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateConnectionAsync([FromRoute(Name = "id")]int id, [FromBody]ConnectionUpdateDTO connectionUpdateDTO)
        {
            await _manager.ConnectionService.UpdateOneConnectionAsync(id, connectionUpdateDTO, false);
            return NoContent();
        }

        [Authorize(Roles = "Bağlanti Silme")]
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteConnectionAsync([FromRoute(Name = "id")]int id)
        {
            await _manager.ConnectionService.DeleteOneConnectionAsync(id, false);
            return NoContent();
        }
    }
}
