using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.DataTransferObjects.TaskUsersDTOs.ResponseDTOs
{
    public record UserTasksResponseDTO
    {
        public string UserId { get; init; }
        public int TaskId { get; init; }
        public int TaskProjectId { get; init; }
        public string TaskName { get; init; }
        public string TaskDescription { get; init; }
        public bool TaskIsCompleted { get; init; }
        public int TaskProgress { get; init; }
        public bool TaskSaw { get; init; }
    }
}
