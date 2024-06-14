using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.DataTransferObjects.AuthenticationDTOs.RequestDTOs
{
    public record TokenDTO
    {
        public String AccessToken { get; init; }
        public String RefreshToken { get; init; }
    }
}
