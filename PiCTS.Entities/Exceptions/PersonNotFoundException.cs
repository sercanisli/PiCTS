using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.Exceptions
{
    public sealed class PersonNotFoundException : NotFoundException
    {
        public PersonNotFoundException(int id) : base($"Person with id : {id} could not found")
        {
        }
    }
}
