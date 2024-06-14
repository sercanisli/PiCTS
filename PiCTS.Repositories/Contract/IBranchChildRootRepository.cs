using PiCTS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Repositories.Contract
{
    public interface IBranchChildRootRepository : IRepositoryBase<BranchChildRoot>
    {
        Task<IEnumerable<BranchChildRoot>> GetAllBranchChildRootAsync(bool trackChanges);
        Task<BranchChildRoot> GetOneBranchChildRootByIdAsync(int id, bool trackChanges);
        void CreateOneBranchChildRoot(BranchChildRoot branchChildRoot);
        void UpdateOneBranchChildRoot(BranchChildRoot branchChildRoot);
        void DeleteOneBranchChildRoot(BranchChildRoot branchChildRoot);
    }
}
