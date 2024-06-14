using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.Exceptions
{
    public sealed class BranchChildRootNotFoundException : NotFoundException
    {
        public BranchChildRootNotFoundException(int id) : base($"Branch Child Root with id : {id} could not found")
        {
        }
    }
}
