using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.DataTransferObjects.ConnectionTypeDTOs.ResponseDTOs
{
    public record ConnectionTypeResponseDTO
    {
        public int Id { get; init; }
        public string Type { get; init; }
        public string Description { get; init; }
    }
}
