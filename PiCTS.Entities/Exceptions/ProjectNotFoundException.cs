using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.Exceptions
{
    public sealed class ProjectNotFoundException : NotFoundException
    {
        public ProjectNotFoundException(int id) : base($"The project with id : {id} could not found.")
        {
        }
    }
}
