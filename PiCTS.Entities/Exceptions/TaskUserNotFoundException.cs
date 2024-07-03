using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.Exceptions
{
    public sealed class TaskUserNotFoundException : NotFoundException
    {
        public TaskUserNotFoundException(int id) : base($"The Task User with task id : {id} could not found")
        {
        }
    }
}
