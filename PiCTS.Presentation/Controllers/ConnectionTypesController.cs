using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PiCTS.Entities.DataTransferObjects.ConnectionTypeDTOs.RequestDTOs;
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
    [Route("api/connectiontypes")]
    public class ConnectionTypesController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public ConnectionTypesController(IServiceManager manager)
        {
            _manager = manager;
        }

        [Authorize(Roles = "Bağlanti Tipi Gorme")]
        [HttpGet("GetAllConnectionTypesAsync")]
        public async Task<IActionResult> GetAllConnectionTypesAsync()
        {
            var entites = await _manager.ConnectionTypeService.GetAllConnectionTypesAsync(false);
            return Ok(entites);
        }

        [HttpGet("GetAllLimitedConnectionTypesAsync")]
        public async Task<IActionResult> GetAllLimitedConnectionTypesAsync()
        {
            var entities = await _manager.ConnectionTypeService.GetAllLimitedConnectionTypesAsync(false);
            return Ok(entities);
        }

        [Authorize(Roles = "Bağlanti Tipi Gorme")]
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOneConnectionTypeAsync([FromRoute(Name = "id")]int id)
        {
            var entity = await _manager.ConnectionTypeService.GetOneConnectionTypeByIdAsync(id, false);
            return Ok(entity);
        }

        [Authorize(Roles = "Bağlanti Tipi Oluşturma")]
        [HttpPost]
        public async Task<IActionResult> CreateConnectionTypeAsync([FromBody]ConnectionTypeRegistrationDTO connectionTypeRegistrationDTO)
        {
            await _manager.ConnectionTypeService.CreateOneConnectionTypeAsync(connectionTypeRegistrationDTO);
            return StatusCode(201, connectionTypeRegistrationDTO);
        }

        [Authorize(Roles = "Bağlanti Tipi Güncelleme")]
        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateConnectionTypeAsync([FromRoute(Name = "id")]int id, [FromBody]ConnectionTypeUpdateDTO connectionTypeUpdateDTO)
        {
            await _manager.ConnectionTypeService.UpdateOneConnectionTypeAsync(id, connectionTypeUpdateDTO, false);
            return NoContent();
        }

        [Authorize(Roles = "Bağlanti Tipi Silme")]
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteConnectionTypeAsync([FromRoute(Name = "id")]int id)
        {
            await _manager.ConnectionTypeService.DeleteOneConnectionTypeAsync(id, false);
            return NoContent();
        }
    }
}
