using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.DataTransferObjects.DashboardDTOs.ResponseDTOs
{
    public record DashboardResponseDTO
    {
        public int CompaniesCount { get; init; }
        public int BranchesCount { get; init; }
        public int UsersCount { get; init; }
        public int ConnectionsCount { get; init; }
    }
}
