using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.Exceptions
{
    public sealed class UserNotFounByNameException : NotFoundException
    {
        public UserNotFounByNameException(string userName) : base($"User with Username : {userName} could not found")
        {
        }
    }
}
