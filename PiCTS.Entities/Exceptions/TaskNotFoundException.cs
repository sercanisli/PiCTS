using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.Exceptions
{
    public sealed class TaskNotFoundException : NotFoundException
    {
        public TaskNotFoundException(int id) : base($"The Task with id : {id} could not found")
        {
        }
    }
}
