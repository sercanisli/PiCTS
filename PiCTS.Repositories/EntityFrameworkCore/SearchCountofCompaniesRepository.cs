using Microsoft.EntityFrameworkCore;
using PiCTS.Entities.Models;
using PiCTS.Repositories.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Repositories.EntityFrameworkCore
{
    public class SearchCountofCompaniesRepository : RepositoryBase<SearchCountofCompanies>, ISearchCountofCompaniesRepository
    {
        public SearchCountofCompaniesRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateOneSearchCountofCompany(SearchCountofCompanies searchCountofCompanies) => Create(searchCountofCompanies);

        public void DeleteOneSearchCountofCompnay(SearchCountofCompanies searchCountofCompanies) => Delete(searchCountofCompanies);

        public async Task<IEnumerable<SearchCountofCompanies>> GetAllSearchCountofCompaniesAsync(bool trackChanges) =>
            await FindAll(trackChanges)
                .Include(scoc => scoc.Company)
                .ToListAsync();

        public async Task<SearchCountofCompanies> GetOneSearchCountofCompanyAsync(int id, bool trackChanges) =>
            await FindByCondition(scoc => scoc.Id == id, trackChanges)
                .SingleOrDefaultAsync();

        public void UpdateOneSearchCountofCompany(SearchCountofCompanies searchCountofCompanies) => Update(searchCountofCompanies);
    }
}
