using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.DataTransferObjects.TaskUsersDTOs.RequestDTOs
{
    public record UserIdDTO
    {
        public string UserId { get; init; }
    }
}
