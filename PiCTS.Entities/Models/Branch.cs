using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.Models
{
    public class Branch : Entity
    {
        public int Id { get; set; }
        public int? CompanyId { get; set; }
        public string BranchName { get; set; }
        public string Description { get; set; }

        public virtual Company? Company { get; set; }
        public virtual ICollection<Person> Persons { get; set; }
    }
}
