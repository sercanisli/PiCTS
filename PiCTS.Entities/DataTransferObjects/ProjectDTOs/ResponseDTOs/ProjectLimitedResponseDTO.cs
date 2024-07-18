using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.DataTransferObjects.ProjectDTOs.ResponseDTOs
{
    public record ProjectLimitedResponseDTO
    {
        public int Id { get; init; }
        public string ProjectName { get; init; }
    }
}
