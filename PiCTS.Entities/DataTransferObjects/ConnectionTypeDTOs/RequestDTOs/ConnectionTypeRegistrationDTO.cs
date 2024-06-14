using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.DataTransferObjects.ConnectionTypeDTOs.RequestDTOs
{
    public record ConnectionTypeRegistrationDTO
    {
        public string Type { get; init; }
        public string Description { get; init; }
    }
}
