using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.Models
{
    public class TaskUsers
    {
        public int TaskId { get; set; }
        public string UserId { get; set; }
        public bool TaskSaw { get; set; }

        public Tasks Task { get; set; }
        public User User { get; set; }

        public TaskUsers()
        {
            TaskSaw = false;
        }
    }
}
