using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.DataTransferObjects.CompanyDTOs.RequestDTOs
{
    public record CompanyRegistrationDTO
    {
        public string CompanyName { get; init; }
        public string Description { get; init; }
    }
}
