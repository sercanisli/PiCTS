using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PiCTS.Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Presentation.Controllers
{
    [ApiController]
    [Route("api/dashboard")]
    public class DashboardController : ControllerBase
    {
        IServiceManager _manager;

        public DashboardController(IServiceManager manager)
        {
            _manager = manager;
        }

        [Authorize(Roles = "Dashboard Gorme")]
        [HttpGet]
        public async Task<IActionResult> GetDashboardItemsCount()
        {
            var entities = await _manager.DashboardService.GetDashboardCounts();
            return Ok(entities);
        }
    }
}
