using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.DataTransferObjects.UserDTOs.RequestDTOs
{
    public class UserStatusUpdateDTO
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
