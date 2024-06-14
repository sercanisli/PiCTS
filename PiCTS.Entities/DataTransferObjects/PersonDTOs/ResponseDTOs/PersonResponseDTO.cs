using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.DataTransferObjects.PersonDTOs.ResponseDTOs
{
    public record PersonResponseDTO
    {
        public int Id { get; init; }
        public int BranchId { get; init; }
        public string BranchBranchName { get; init; }
        public string FullName { get; init; }
        public string Phone { get; init; }
    }
}
