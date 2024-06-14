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
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(RepositoryContext context) : base(context)
        {
        }


        public void CreateOneCompany(Company company) => Create(company);

        public void DeleteOneCompany(Company company) => Delete(company);

        public async Task<IEnumerable<Company>> GetAllCompaniesAsync(bool trackChanges) =>
            await FindAll(trackChanges)
                .Where(c=>c.IsDeleted != true)
                .ToListAsync();

        public async Task<IEnumerable<Company>> GetAllCompaniesWithDeletedAsync(bool trackChanges) =>
            await FindAll(trackChanges)
                .ToListAsync();

        public async Task<Company> GetOneCompanyByIdAsync(int id, bool trackChanges) =>
            await FindByCondition(c => c.Id == id && c.IsDeleted != true, trackChanges)
                .SingleOrDefaultAsync();

        public void UpdateOneCompany(Company company) => Update(company);
    }
}
