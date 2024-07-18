using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.Exceptions
{
    public sealed class UserTasksNotFoundException : NotFoundException
    {
        public UserTasksNotFoundException(string id) : base($"No task definition found for user with id : {id}")
        {
        }
    }
}
