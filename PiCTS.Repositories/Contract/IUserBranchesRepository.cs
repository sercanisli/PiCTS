using PiCTS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Repositories.Contract
{
    public interface IUserBranchesRepository : IRepositoryBase<UserBranches>
    {
        Task<IEnumerable<UserBranches>> GetAllUserBranchesAsync(bool trackChanges);
        Task<IEnumerable<UserBranches>> GetAllUserBranchesByUserId(string userId, bool trackChanges);
        void CreateOneUserBranch(UserBranches userBranches);
        void UpdateOneUserBranch(UserBranches userBranches);
        void DeleteOneUserBranch(UserBranches userBranches);
    }
}
