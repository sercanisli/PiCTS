using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.Models
{
    public class Connection : Entity
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int ConnectionTypeId { get; set; }
        public string Link { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }


        public virtual Branch? Branch { get; set; }
        public virtual ConnectionType? ConnectionType { get; set; }
    }
}
