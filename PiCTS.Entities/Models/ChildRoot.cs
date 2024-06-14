using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.Models
{
    public class ChildRoot
    {
        public int Id { get; set; }
        public int MainRootId { get; set; }
        public string Key { get; set; }
        public string Label { get; set; }
        public bool Checked { get; set; }
        public bool PartialChecked { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime DeletedDate { get; set; }


        public ChildRoot()
        {
            IsDeleted = false;
        }
    }
}
