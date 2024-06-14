using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.Exceptions
{
    public sealed class ConnectionNotFoundException : NotFoundException
    {
        public ConnectionNotFoundException(int id) : base($"Connection with id : {id} could not found")
        {
        }
    }
}
