using PiCTS.Entities.DataTransferObjects.CompanyDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.CompanyDTOs.ResponseDTOs;
using PiCTS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Services.Contract
{
    public interface ICompanyService
    {
        Task<IEnumerable<CompanyResponseDTO>> GetAllCompaniesAsync(bool trackChanges);
        Task<IEnumerable<CompanyLimitedResponseDTO>> GetAllLimitedCompaniesAsync(bool trackChanges);
        Task<CompanyResponseDTO> GetOneCompanyByIdAsync(int id, bool trackChanges);
        Task<CompanyResponseDTO> CreateOneCompanyAsync(CompanyRegistrationDTO companyRegistrationDTO);
        Task UpdateOneCompanyAsync(int id, CompanyUpdateDTO companyUpdateDTO, bool trackChanges);
        Task DeleteOneCompanyAsync(int id, bool trackChanges);
    }
}
