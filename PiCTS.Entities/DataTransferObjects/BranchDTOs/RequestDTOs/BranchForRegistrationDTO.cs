using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.DataTransferObjects.BranchDTOs.RequestDTOs
{
    public record BranchForRegistrationDTO
    {
        public int Id { get; init; }
        public int CompanyId { get; init; }
        public string BranchName { get; init; }
        public string Description { get; init; }
    }
}
