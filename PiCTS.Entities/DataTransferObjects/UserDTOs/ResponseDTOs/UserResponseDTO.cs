using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.DataTransferObjects.UserDTOs.ResponseDTOs
{
    public class UserResponseDTO
    {
        public Guid Id { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string UserName { get; init; }
        public string Password { get; init; }

        public ICollection<string> Roles { get; init; }
    }
}
