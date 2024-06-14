using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PiCTS.Entities.DataTransferObjects.CompanyDTOs.RequestDTOs;
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
    [Route("api/companies")]
    public class CompaniesController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public CompaniesController(IServiceManager manager)
        {
            _manager = manager;
        }

        //[Authorize(Roles = "ReadCompany")]
        [HttpGet("GetAllCompaniesAsync")]
        public async Task<IActionResult> GetAllCompaniesAsync()
        {
            var entities = await _manager.CompanyService.GetAllCompaniesAsync(false);
            return Ok(entities);
        }

        [HttpGet("GetAllLimitedCompaniesAsync")]
        public async Task<IActionResult> GetAllLimitedCompaniesAsync()
        {
            var entities = await _manager.CompanyService.GetAllLimitedCompaniesAsync(false);
            return Ok(entities);
        }

        //[Authorize(Roles = "ReadCompany")]
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOneCompanyAsync([FromRoute(Name = "id")] int id)
        {
            var entity = await _manager.CompanyService.GetOneCompanyByIdAsync(id, false);
            return Ok(entity);
        }

        //[Authorize(Roles = "CreateCompany")]
        [HttpPost]
        public async Task<IActionResult> CreateCompanyAsync([FromBody] CompanyRegistrationDTO companyRegistrationDTO)
        {
            await _manager.CompanyService.CreateOneCompanyAsync(companyRegistrationDTO);
            return StatusCode(201, companyRegistrationDTO);
        }

        //[Authorize(Roles = "EditCompany")]
        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateCompanyAsync([FromRoute(Name = "id")] int id, [FromBody] CompanyUpdateDTO companyUpdateDTO)
        {
            await _manager.CompanyService.UpdateOneCompanyAsync(id, companyUpdateDTO, false);
            return NoContent();
        }

        //[Authorize(Roles = "DeleteCompany")]
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteCompanyAsync([FromRoute(Name = "id")] int id)
        {
            await _manager.CompanyService.DeleteOneCompanyAsync(id, false);
            return NoContent();
        }
    }
}
