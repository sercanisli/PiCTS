using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PiCTS.Entities.DataTransferObjects.PersonDTOs.RequestDTOs;
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
    [Route("api/persons")]
    public class PersonsController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public PersonsController(IServiceManager manager)
        {
            _manager = manager;
        }

        //[Authorize(Roles = "ReadPerson")]
        [HttpGet("GetAllPersonsAsync")]
        public async Task<IActionResult> GetAllPersonsAsync()
        {
            var entities = await _manager.PersonService.GetAllPersonsAsync(false);
            return Ok(entities);
        }

        //[Authorize(Roles = "ReadPerson")]
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOnePersonAsync([FromRoute(Name = "id")]int id)
        {
            var entity = await _manager.PersonService.GetOnePersonByIdAsync(id, false);
            return Ok(entity);
        }

        //[Authorize(Roles = "CreatePerson")]
        [HttpPost]
        public async Task<IActionResult> CreatePersonAsync([FromBody]PersonRegistrationDTO personRegistrationDTO)
        {
            await _manager.PersonService.CreateOnePersonAsync(personRegistrationDTO);
            return StatusCode(201, personRegistrationDTO);
        }

        //[Authorize(Roles = "EditPerson")]
        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdatePersonAsync([FromRoute(Name = "id")]int id, [FromBody]PersonUpdateDTO personUpdateDTO)
        {
            await _manager.PersonService.UpdateOnePersonAsync(id, personUpdateDTO, false);
            return NoContent();
        }

        //[Authorize(Roles = "DeletePerson")]
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeletePersonAsync([FromRoute(Name = "id")]int id)
        {
            await _manager.PersonService.DeleteOnePersonAsync(id, false);
            return NoContent();
        }
    }
}
