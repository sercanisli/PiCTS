using Microsoft.AspNetCore.Mvc;
using PiCTS.Entities.DataTransferObjects.SearchCountsDTOs.RequestDTOs;
using PiCTS.Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Presentation.Controllers
{
    [ApiController]
    [Route("api/searchcounts")]
    public class SearchCountsController :ControllerBase
    {
        private readonly IServiceManager _manager;

        public SearchCountsController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSearchCountsAsync()
        {
            var entities = await _manager.SearchCountsService.GetAllSearchCountsAsync(false);
            return Ok(entities);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSearchCountsAsync([FromBody]SearchCountUpdateDTO searchCountUpdateDTO)
        {
            await _manager.SearchCountsService.UpdateOneSearchCountAsync(searchCountUpdateDTO, false);
            return NoContent();
        }
    }
}
