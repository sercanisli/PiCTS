using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.DataTransferObjects.UserDTOs.RequestDTOs
{
    public record UserNameDTO
    {
        public string UserName { get; init; }
    }
}
