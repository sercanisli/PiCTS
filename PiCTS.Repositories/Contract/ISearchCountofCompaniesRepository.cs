using PiCTS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Repositories.Contract
{
    public interface ISearchCountofCompaniesRepository : IRepositoryBase<SearchCountofCompanies>
    {
        Task<IEnumerable<SearchCountofCompanies>> GetAllSearchCountofCompaniesAsync(bool trackChanges);
        Task<SearchCountofCompanies> GetOneSearchCountofCompanyAsync(int id, bool trackChanges);
        void CreateOneSearchCountofCompany(SearchCountofCompanies searchCountofCompanies);
        void UpdateOneSearchCountofCompany(SearchCountofCompanies searchCountofCompanies);
        void DeleteOneSearchCountofCompnay(SearchCountofCompanies searchCountofCompanies);
    }
}
