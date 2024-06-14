using PiCTS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Repositories.Contract
{
    public interface IBranchRepository : IRepositoryBase<Branch>
    {
        Task<IEnumerable<Branch>> GetAllBranchesAsync(bool trackChanges);
        Task<IEnumerable<Branch>> GetAllLimitedBranchesAsync(bool trackChanges);
        Task<IEnumerable<Branch>> GetAllBranchesWithDeletedAsycn(int companyId ,bool trackChanges);
        Task<Branch> GetOneBranchByIdAsync(int id, bool trackChanges);
        void CreateOneBranch(Branch branch);
        void UpdateOneBranch(Branch branch); 
        void DeleteOneBranch(Branch branch);
    }
}
