using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.Models
{
    public class Project : Entity
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public int CompanyId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public int Progress { get; set; }

        public ICollection<Tasks> Tasks { get; set; }
        public Company Company { get; set; }

        public Project()
        {
            IsCompleted = false;
        }
    }
}
