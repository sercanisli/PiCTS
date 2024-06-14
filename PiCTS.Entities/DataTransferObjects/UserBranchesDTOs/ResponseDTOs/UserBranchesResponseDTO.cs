using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.DataTransferObjects.UserBranchesDTOs.ResponseDTOs
{
    public record UserBranchesResponseDTO
    {
        public int BranchId { get; init; }
        public string BranchBranchName { get; init; }
        public string BranchCompanyCompanyName { get; init; }
    }
}
