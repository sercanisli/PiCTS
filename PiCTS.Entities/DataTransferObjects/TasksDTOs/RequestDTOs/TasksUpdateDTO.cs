using PiCTS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.DataTransferObjects.TasksDTOs.RequestDTOs
{
    public record TasksUpdateDTO
    {
        public int Id { get; init; }
        public int ProjectId { get; init; }
        public string TaskName { get; init; }
        public DateTime StartDate { get; init; }
        public DateTime EndDate { get; init; }
        public string Description { get; init; }
        public Status Statuses { get; init; }

        public List<int> Dependencies { get; init; }


        public enum Status
        {
            UnAssigned = 0,
            Assigned = 1,
            On = 2,
            Done = 3
        }
    }
}
