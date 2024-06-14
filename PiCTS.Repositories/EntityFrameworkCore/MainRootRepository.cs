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
    public class MainRootRepository : RepositoryBase<MainRoot>, IMainRootRepository
    {
        public MainRootRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateOneMainRoot(MainRoot mainRoot) => Create(mainRoot);

        public void DeleteOneMainRoot(MainRoot mainRoot) => Delete(mainRoot);

        public async Task<IEnumerable<MainRoot>> GetAllMainRootsAsync(bool trackChanges) =>
            await FindAll(trackChanges)
                .Include(mr => mr.Children)
                .Where(mr=>mr.IsDeleted != true)
                .ToListAsync();

        public async Task<MainRoot> GetOneMainRootByIdAsync(int id, bool trackChanges) =>
            await FindByCondition(mr => mr.Id == id && mr.IsDeleted != true, trackChanges)
                .Include(mr => mr.Children)
                .SingleOrDefaultAsync();

        public void UpdateOneMainRoot(MainRoot mainRoot) => Update(mainRoot);
    }
}
