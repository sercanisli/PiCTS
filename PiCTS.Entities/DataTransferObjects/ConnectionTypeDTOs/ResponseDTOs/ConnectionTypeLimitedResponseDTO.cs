using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.DataTransferObjects.ConnectionTypeDTOs.ResponseDTOs
{
    public record ConnectionTypeLimitedResponseDTO
    {
        public int Id { get; init; }
        public string Type { get; init; }
    }
}
