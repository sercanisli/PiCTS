using PiCTS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.DataTransferObjects.TasksDTOs.ResponseDTOs
{
    public record TasksResponseDTO
    {
        public int Id { get; init; }
        public int ProjectId { get; init; }
        public string TaskName { get; init; }
        public DateTime StartDate { get; init; }
        public DateTime EndDate { get; init; }
        public string Description { get; init; }

        public ICollection<User> Responsible { get; init; }


        public enum Status
        {
            UnAssigned,
            Assigned,
            On,
            Done
        }
    }
}
