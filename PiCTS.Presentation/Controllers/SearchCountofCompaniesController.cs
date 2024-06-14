using Microsoft.AspNetCore.Mvc;
using PiCTS.Entities.DataTransferObjects.SearchCountofCompaniesDTOs.RequestDTOs;
using PiCTS.Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Presentation.Controllers
{
    [ApiController]
    [Route("api/searchcountsofcompanies")]
    public class SearchCountofCompaniesController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public SearchCountofCompaniesController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSearchCountofCompaniesAsync()
        {
            var entities = await _manager.SearchCountofCompaniesService.GetAllSearchCountofCompaniesAsync(false);
            return Ok(entities);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateOneSearchCountofCompanyAsync([FromBody] SearchCountofCompaniesUpdateDTO searchCountofCompaniesUpdateDTO)
        {
            await _manager.SearchCountofCompaniesService.UpdateOneSearchCountofCompany(searchCountofCompaniesUpdateDTO, false);
            return NoContent();
        }
    }
}
