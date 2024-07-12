using PiCTS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.DataTransferObjects.ProjectDTOs.ResponseDTOs
{
    public record ProjectResponseDTO
    {
        public int Id { get; init; }
        public int CompanyId { get; set; }
        public string CompanyCompanyName { get; set; }
        public string ProjectName { get; init; }
        public DateTime? StartDate { get; init; }
        public DateTime? EndDate { get; init; }
        public string Description { get; init; }
        public Status Statuses { get; set; }
        public string StatusName => Statuses.ToString();




        public enum Status
        {
            On,
            Done
        }
    }
}
