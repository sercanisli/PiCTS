using PiCTS.Entities.DataTransferObjects.PersonDTOs.ResponseDTOs;
using PiCTS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.DataTransferObjects.ConnectionDTOs.ResponseDTOs
{
    public record ConnectionsByBranchIdResponseDTO
    {
        public int Id { get; init; }
        public int BranchId { get; init; }
        public int ConnectionTypeId { get; init; }
        public string ConnectionTypeType { get; init; }
        public string Link { get; init; }
        public string  Username { get; init; }
        public string Password { get; init; }
        public string Description { get; init; }
        public int BranchCompanyId { get; init; }
        public string BranchCompanyCompanyName { get; init; }
        public string BranchBranchName { get; init; }
        public List<PersonForConnectionResponseDTO> BranchPersons { get; init; }
    }
}
