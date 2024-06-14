using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.Models
{
    public class SearchCountofCompanies
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int Count { get; set; }

        public virtual Company? Company { get; set; }
    }
}
