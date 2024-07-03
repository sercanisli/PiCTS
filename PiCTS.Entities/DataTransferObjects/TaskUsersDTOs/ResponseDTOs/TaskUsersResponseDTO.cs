using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.DataTransferObjects.TaskUsersDTOs.ResponseDTOs
{
    public record TaskUsersResponseDTO
    {
        public string UserId { get; init; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
    }
}
