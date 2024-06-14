using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.DataTransferObjects.SearchCountofCompaniesDTOs.ResponseDTOs
{
    public record SearchCountofCompaniesResponseDTO
    {
        public int Id { get; init; }
        public int CompanyId { get; init; }
        public string CompanyCompanyName { get; init; }
        public int Count { get; init; }
    }
}
