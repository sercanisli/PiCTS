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
        public string TaskName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }



        public enum Status
        {
            UnAssigned,
            Assigned,
            On,
            Done
        }
    }
}
