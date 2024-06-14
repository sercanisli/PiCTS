using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.DataTransferObjects.SearchCountsDTOs.RequestDTOs
{
    public record SearchCountRegistrationDTO
    {
        public int Count { get; init; }
        public int DateofMonth { get; init; }

    }
}
