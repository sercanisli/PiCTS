using PiCTS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Repositories.Contract
{
    public interface IChildRootRepository : IRepositoryBase<ChildRoot>
    {
        Task<IEnumerable<ChildRoot>> GetAllChildRootsAsync(bool trackChanges);
        Task<ChildRoot> GetOneChildRootByIdAsync(int id, bool trackChanges);
        void CreateOneChildRoot(ChildRoot childRoot);
        void UpdateOneChildRoot(ChildRoot childRoot);
        void DeleteOneChildRoot(ChildRoot childRoot);
    }
}
