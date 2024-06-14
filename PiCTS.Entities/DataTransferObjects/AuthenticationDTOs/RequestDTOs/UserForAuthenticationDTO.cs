using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.DataTransferObjects.AuthenticationDTOs.RequestDTOs
{
    public record UserForAuthenticationDTO
    {
        [Required(ErrorMessage = "Username is required")]
        public string? Username { get; init; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; init; }
    }
}
