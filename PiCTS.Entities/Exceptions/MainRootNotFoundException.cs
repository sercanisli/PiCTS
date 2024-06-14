using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.Exceptions
{
    public sealed class MainRootNotFoundException : NotFoundException
    {
        public MainRootNotFoundException(int id) : base($"Main Root with id : {id} could not found")
        {
        }
    }
}
