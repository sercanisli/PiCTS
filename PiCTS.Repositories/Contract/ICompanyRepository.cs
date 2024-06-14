using PiCTS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Repositories.Contract
{
    public interface ICompanyRepository : IRepositoryBase<Company>
    {
        Task<IEnumerable<Company>> GetAllCompaniesAsync(bool trackChanges);
        Task<IEnumerable<Company>> GetAllCompaniesWithDeletedAsync(bool trackChanges);
        Task<Company> GetOneCompanyByIdAsync(int id, bool trackChanges);
        void CreateOneCompany(Company company);
        void UpdateOneCompany(Company company);
        void DeleteOneCompany(Company company);
    }
}
