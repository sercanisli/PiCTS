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
    public class ConnectionRepository : RepositoryBase<Connection>, IConnectionRepository
    {
        public ConnectionRepository(RepositoryContext context) : base(context)
        {
        }


        public void CreateOneConnection(Connection connection) => Create(connection);

        public void DeleteOneConnection(Connection connection) => Delete(connection);

        public async Task<IEnumerable<Connection>> GetAllConnectionsAsync(bool trackChanges) =>
            await FindAll(trackChanges)
                .Include(c => c.Branch)
                .Include(c=> c.Branch.Company)
                .Include(c => c.ConnectionType)
                .Where(c => c.IsDeleted != true)
                .ToListAsync();

        public async Task<IEnumerable<Connection>> GetAllConnectionsByBranchIdAsync(int id, bool trackChanges) =>
            await FindAll(trackChanges)
                .Include(c => c.Branch)
                .Include(c => c.ConnectionType)
                .Include(c=> c.Branch.Company)
                .Include(c=> c.Branch.Persons)
                .Where(c => c.BranchId == id && c.IsDeleted != true)
                .ToListAsync();

        public async Task<Connection> GetOneConnectionByIdAsync(int id, bool trackChanges) =>
            await FindByCondition(c => c.Id == id && c.IsDeleted != true, trackChanges)
                .Include(c => c.Branch)
                .Include(c=> c.Branch.Company)
                .Include(c => c.ConnectionType)
                .SingleOrDefaultAsync();

        public void UpdateOneConnection(Connection connection) => Update(connection);
    }
}
