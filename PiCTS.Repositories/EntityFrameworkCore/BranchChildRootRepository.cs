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
    public class BranchChildRootRepository : RepositoryBase<BranchChildRoot>, IBranchChildRootRepository
    {
        public BranchChildRootRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateOneBranchChildRoot(BranchChildRoot branchChildRoot) => Create(branchChildRoot);

        public void DeleteOneBranchChildRoot(BranchChildRoot branchChildRoot) => Update(branchChildRoot);

        public async Task<IEnumerable<BranchChildRoot>> GetAllBranchChildRootAsync(bool trackChanges) =>
            await FindAll(trackChanges)
                .Where(bcr => bcr.IsDeleted != true)
                .ToListAsync();

        public async Task<BranchChildRoot> GetOneBranchChildRootByIdAsync(int id, bool trackChanges) =>
            await FindByCondition(bcr => bcr.Id == id && bcr.IsDeleted != true, trackChanges)
                .SingleOrDefaultAsync();

        public void UpdateOneBranchChildRoot(BranchChildRoot branchChildRoot) => Update(branchChildRoot);
    }
}
