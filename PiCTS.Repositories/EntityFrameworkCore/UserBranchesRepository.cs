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
    public class UserBranchesRepository : RepositoryBase<UserBranches>, IUserBranchesRepository
    {
        public UserBranchesRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateOneUserBranch(UserBranches userBranches) => Create(userBranches);

        public void DeleteOneUserBranch(UserBranches userBranches) => Delete(userBranches);

        public async Task<IEnumerable<UserBranches>> GetAllUserBranchesAsync(bool trackChanges) =>
            await FindAll(trackChanges).ToListAsync();

        public async Task<IEnumerable<UserBranches>> GetAllUserBranchesByUserId(string userId, bool trackChanges) =>
            await FindAll(trackChanges)
                .Where(ub => ub.UserId == userId)
                .Include(ub => ub.Branch)
                .Include(ub => ub.Branch.Company)
                .ToListAsync();

        public void UpdateOneUserBranch(UserBranches userBranches) => Update(userBranches);
    }
}
