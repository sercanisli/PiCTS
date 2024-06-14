using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.Exceptions
{
    public sealed class ChildRootNotFoundException : NotFoundException
    {
        public ChildRootNotFoundException(int id) : base($"Child Root with id : {id} could not found")
        {
        }
    }
}
