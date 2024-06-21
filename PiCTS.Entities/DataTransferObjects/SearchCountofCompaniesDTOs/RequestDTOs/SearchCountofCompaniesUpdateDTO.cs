using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Entities.DataTransferObjects.SearchCountofCompaniesDTOs.RequestDTOs
{
    public record SearchCountofCompaniesUpdateDTO
    {
        public int CompanyId { get; init; }
        public int Count { get; init; }
    }
}
