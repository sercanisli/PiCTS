using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.DataTransferObjects.AuthenticationDTOs.RequestDTOs
{
    public record UserForRegistrationDTO
    {
        public String? FirstName { get; init; }
        public String? LastName { get; init; }

        public bool IsDeleted { get; init; }

        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; init; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; init; }


        public ICollection<string> Roles { get; init; }
    }
}
