using PiCTS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.DataTransferObjects.TasksDTOs.RequestDTOs
{
    public record TasksRegistrationDTO
    {
        public int Id { get; init; }
        public int ProjectId { get; init; }
        public string Name { get; init; }
        public DateTime? Start { get; init; }
        public DateTime? End { get; init; }
        public string Description { get; init; }
        public string Progress { get; init; }
        public Status Statuses { get; init; }

        public List<string> Dependencies { get; init; }
        public List<string> Users { get; init; }

        

        public enum Status
        {
            UnAssigned = 0,
            Assigned = 1,
            On = 2,
            Done = 3
        }
    }
}
