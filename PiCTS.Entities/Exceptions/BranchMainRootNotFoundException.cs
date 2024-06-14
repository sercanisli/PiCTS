using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.Exceptions
{
    public sealed class BranchMainRootNotFoundException : NotFoundException
    {
        public BranchMainRootNotFoundException(int id) : base($"Branch Main Root with id : {id} could not found")
        {
        }
    }
}
