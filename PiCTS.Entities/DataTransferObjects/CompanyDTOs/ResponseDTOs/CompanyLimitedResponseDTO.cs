using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.DataTransferObjects.CompanyDTOs.ResponseDTOs
{
    public record CompanyLimitedResponseDTO
    {
        public int Id { get; init; }
        public string CompanyName { get; init; }
    }
}
