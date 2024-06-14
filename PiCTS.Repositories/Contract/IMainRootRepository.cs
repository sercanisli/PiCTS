using PiCTS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Repositories.Contract
{
    public interface IMainRootRepository : IRepositoryBase<MainRoot>
    {
        Task<IEnumerable<MainRoot>> GetAllMainRootsAsync(bool trackChanges);
        Task<MainRoot> GetOneMainRootByIdAsync(int id, bool trackChanges);
        void CreateOneMainRoot(MainRoot mainRoot);
        void UpdateOneMainRoot(MainRoot mainRoot);
        void DeleteOneMainRoot(MainRoot mainRoot);
    }
}
