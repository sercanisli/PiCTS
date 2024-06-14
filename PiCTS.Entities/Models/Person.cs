using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.Models
{
    public class Person : Entity
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }

        public virtual Branch? Branch { get; set; }
    }
}
