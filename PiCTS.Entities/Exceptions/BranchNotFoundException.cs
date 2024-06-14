using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.Exceptions
{
    public sealed class BranchNotFoundException : NotFoundException
    {
        public BranchNotFoundException(int id) : base($"Branch with id : {id} could not found")
        {
        }
    }
}
