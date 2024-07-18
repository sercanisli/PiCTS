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
        public string Id { get; init; }
        public string ProjectId { get; init; }
        public string Name { get; init; }
        public DateTime Start { get; init; }
        public DateTime End { get; init; }
        public string Description { get; init; }
        public string Progress { get; init; }
        public bool IsCompleted { get; init; }

        public List<string> Dependencies { get; init; }
        public List<string> Users { get; init; }
    }
}
