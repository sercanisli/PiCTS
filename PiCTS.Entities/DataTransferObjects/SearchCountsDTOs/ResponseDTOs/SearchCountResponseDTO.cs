using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.DataTransferObjects.SearchCountsDTOs.ResponseDTOs
{
    public record SearchCountResponseDTO
    {
        public int Id { get; init; }
        public int Count { get; init; }
        public int DateofMonth { get; init; }

    }
}
