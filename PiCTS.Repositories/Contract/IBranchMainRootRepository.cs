using PiCTS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Repositories.Contract
{
    public interface IBranchMainRootRepository : IRepositoryBase<BranchMainRoot>
    {
        Task<IEnumerable<BranchMainRoot>> GetAllMainRootsAsync(bool trackChanges);
        Task<BranchMainRoot> GetOneBranchMainRootByIdAsync(int id, bool trackChanges);
        void CreateOneBranchMainRoot(BranchMainRoot branchMainRoot);
        void UpdateOneBranchMainRoot(BranchMainRoot branchMainRoot);
        void DeleteOneBranchMainRoot(BranchMainRoot branchMainRoot);
    }
}
