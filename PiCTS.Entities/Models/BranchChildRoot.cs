using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.Models
{
    public class BranchChildRoot
    {
        public int Id { get; set; }
        public int BranchMainRootId { get; set; }
        public string Key { get; set; }
        public string Label { get; set; }
        public bool Checked { get; set; }
        public bool PartialChecked { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime DeletedDate { get; set; }


        public BranchChildRoot()
        {
            IsDeleted = false;
        }
    }
}
