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
    public class BranchMainRootRepository : RepositoryBase<BranchMainRoot>, IBranchMainRootRepository
    {
        public BranchMainRootRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateOneBranchMainRoot(BranchMainRoot branchMainRoot) => Create(branchMainRoot);

        public void DeleteOneBranchMainRoot(BranchMainRoot branchMainRoot) => Delete(branchMainRoot);

        public async Task<IEnumerable<BranchMainRoot>> GetAllMainRootsAsync(bool trackChanges) =>
            await FindAll(trackChanges)
                .Include(bmr => bmr.Children)
                .Where(bmr => bmr.IsDeleted != true)
                .ToListAsync();

        public async Task<BranchMainRoot> GetOneBranchMainRootByIdAsync(int id, bool trackChanges) =>
            await FindByCondition(bmr => bmr.Id == id && bmr.IsDeleted != true, trackChanges)
                .Include(bmr => bmr.Children)
                .SingleOrDefaultAsync();

        public void UpdateOneBranchMainRoot(BranchMainRoot branchMainRoot) => Update(branchMainRoot);
    }
}
