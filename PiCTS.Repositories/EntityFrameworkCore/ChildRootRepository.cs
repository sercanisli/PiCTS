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
    public class ChildRootRepository : RepositoryBase<ChildRoot>, IChildRootRepository
    {
        public ChildRootRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateOneChildRoot(ChildRoot childRoot) => Create(childRoot);

        public void DeleteOneChildRoot(ChildRoot childRoot) => Delete(childRoot);

        public async Task<IEnumerable<ChildRoot>> GetAllChildRootsAsync(bool trackChanges) =>
            await FindAll(trackChanges)
                .Where(cr => cr.IsDeleted != true)
                .ToListAsync();

        public async Task<ChildRoot> GetOneChildRootByIdAsync(int id, bool trackChanges) =>
            await FindByCondition(cr => cr.Id == id && cr.IsDeleted != true, trackChanges)
                .SingleOrDefaultAsync();

        public void UpdateOneChildRoot(ChildRoot childRoot) => Update(childRoot);
    }
}
