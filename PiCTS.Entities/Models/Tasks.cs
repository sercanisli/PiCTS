using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.Models
{
    public class Tasks : Entity
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public string Description { get; set; }
        public int Progress { get; set; }
        public bool IsCompleted { get; set; }

        public List<string> Dependencies { get; set; }
        public List<string> Users { get; set; }

        public Tasks()
        {
            IsCompleted = false;
        }
    }
}
