using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.DataTransferObjects.ConnectionDTOs.RequestDTOs
{
    public record ConnectionRegistrationDTO
    {
        public int BranchId { get; init; }
        public int ConnectionTypeId { get; init; } 
        public string Link { get; init; }
        public string Username { get; init; }
        public string Password { get; init; }
        public string Description { get; init; }

    }
}
