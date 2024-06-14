using PiCTS.Entities.DataTransferObjects.SearchCountofCompaniesDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.SearchCountofCompaniesDTOs.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Services.Contract
{
    public interface ISearchCountofCompaniesService
    {
        Task<IEnumerable<SearchCountofCompaniesResponseDTO>> GetAllSearchCountofCompaniesAsync(bool trackChanges);
        Task<SearchCountofCompaniesResponseDTO> GetOneSearchCountofcompanyAsync(int id, bool trackChanges);
        Task<SearchCountofCompaniesResponseDTO> CreateOneSearchCountofCompanyAsync(SearchCountofCompaniesRegistrationDTO searchCountofCompaniesRegistrationDTO);
        Task UpdateOneSearchCountofCompany(SearchCountofCompaniesUpdateDTO searchCountofCompaniesUpdateDTO, bool trackChanges);
        Task DeleteOneSearchCountofCompany(int id, bool trackChanges);
    }
}
