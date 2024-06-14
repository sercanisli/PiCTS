using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.Exceptions
{
    public sealed class SearchCountofCompaniesNotFoundException : NotFoundException
    {
        public SearchCountofCompaniesNotFoundException(int id) : base($"Search Count of Company with id : {id} could not found")
        {
        }
    }
}
