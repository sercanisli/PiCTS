using PiCTS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.DataTransferObjects.MainRootDTOs.RequestDTOs
{
    public record MainRootRegistrationDTO
    {
        public int Id { get; init; }
        public string Key { get; init; }
        public string Label { get; init; }
        public bool Checked { get; init; }
        public bool PartialChecked { get; init; }


        public ICollection<ChildRoot> Children { get; init; }
    }
}
