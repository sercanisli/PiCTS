using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.Models
{
    public class Company : Entity
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
    }
}
