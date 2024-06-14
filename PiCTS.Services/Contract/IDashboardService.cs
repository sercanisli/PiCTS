using PiCTS.Entities.DataTransferObjects.DashboardDTOs.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Services.Contract
{
    public interface IDashboardService
    {
        Task<DashboardResponseDTO> GetDashboardCounts();
    }
}
