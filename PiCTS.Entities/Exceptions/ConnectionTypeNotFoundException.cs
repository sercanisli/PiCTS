using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.Exceptions
{
    public sealed class ConnectionTypeNotFoundException : NotFoundException
    {
        public ConnectionTypeNotFoundException(int id) : base($"Connection Type with id : {id} could not found")
        {
        }
    }
}
