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
    public class BranchRepository : RepositoryBase<Branch>, IBranchRepository
    {
        public BranchRepository(RepositoryContext context) : base(context)
        {
        }


        public void CreateOneBranch(Branch branch) => Create(branch);

        public void DeleteOneBranch(Branch branch) => Delete(branch);

        public async Task<IEnumerable<Branch>> GetAllBranchesAsync(bool trackChanges) =>
            await FindAll(trackChanges)
                .Include(b=>b.Company)
                .Where(b => b.IsDeleted != true)
                .ToListAsync();

        public async Task<IEnumerable<Branch>> GetAllBranchesWithDeletedAsycn(int companyId, bool trackChanges) =>
            await FindAll(trackChanges)
                .Where(b => b.CompanyId == companyId)
                .ToListAsync();

        public async Task<IEnumerable<Branch>> GetAllLimitedBranchesAsync(bool trackChanges) =>
            await FindAll(trackChanges)
                .Where(b => b.IsDeleted != true)
                .ToListAsync();

        public async Task<Branch> GetOneBranchByIdAsync(int id, bool trackChanges) =>
            await FindByCondition(b => b.Id == id && b.IsDeleted != true, trackChanges)
                .Include(b => b.Company)
                .SingleOrDefaultAsync();

        public void UpdateOneBranch(Branch branch) => Update(branch);
    }
}
