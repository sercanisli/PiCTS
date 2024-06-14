using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.Models
{
    public class UserBranches
    {
        public string UserId { get; set; }
        public int BranchId { get; set; }

        public User User { get; set; }
        public Branch Branch { get; set; }
    }
}
