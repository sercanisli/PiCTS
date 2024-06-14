using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.Exceptions
{
    public sealed class SearchCountNotFoundException : NotFoundException
    {
        public SearchCountNotFoundException(int id) : base($"Search Count with id : {id} could not found")
        {
        }
    }
}
