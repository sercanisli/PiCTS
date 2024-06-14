using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.DataTransferObjects.AuthenticationDTOs.ResponseDTOs
{
    public record TokenResponseDTO
    {
        public String AccessToken { get; init; }
        public String RefreshToken { get; init; }
        public string UserName { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
        public IList<string> UserPermissions { get; set; }
    }
}
