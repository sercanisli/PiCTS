using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.DataTransferObjects.ConnectionTypeDTOs.RequestDTOs
{
    public record ConnectionTypeUpdateDTO
    {
        public int Id { get; init; }
        public string Type { get; init; }
        public string Description { get; init; }
    }
}
