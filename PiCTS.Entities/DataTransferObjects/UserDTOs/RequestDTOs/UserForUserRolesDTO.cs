using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.DataTransferObjects.UserDTOs.RequestDTOs
{
    public record UserForUserRolesDTO
    {
        public Guid Id { get; init; }
        public ICollection<string> Roles { get; init; }

        public UserForUserRolesDTO()
        {
            Roles = new List<string>();
        }
    }
}
