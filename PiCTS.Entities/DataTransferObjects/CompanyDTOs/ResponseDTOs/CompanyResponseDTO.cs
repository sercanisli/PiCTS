using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.DataTransferObjects.CompanyDTOs.ResponseDTOs
{
    public record CompanyResponseDTO
    {
        public int Id { get; init; }
        public string CompanyName { get; init; }
        public string Description { get; init; }
    }
}
