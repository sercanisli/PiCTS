using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.DataTransferObjects.PersonDTOs.ResponseDTOs
{
    public record PersonForConnectionResponseDTO
    {
        public int BranchId { get; init; }
        public string FullName { get; init; }
        public string Phone { get; init; }
    }
}
