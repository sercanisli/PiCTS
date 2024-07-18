using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.DataTransferObjects.TasksDTOs.RequestDTOs
{
    public record TaskProgressUpdateDTO
    {
        public int Id { get; init; }
        public int Progress { get; init; }
    }
}
