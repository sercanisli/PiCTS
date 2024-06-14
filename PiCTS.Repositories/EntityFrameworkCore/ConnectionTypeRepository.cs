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
    public class ConnectionTypeRepository : RepositoryBase<ConnectionType>, IConnectionTypeRepository
    {
        public ConnectionTypeRepository(RepositoryContext context) : base(context)
        {
        }
        public void CreateOneConnectionType(ConnectionType connectionType) => Create(connectionType);

        public void DeleteOneConnectionType(ConnectionType connectionType) => Delete(connectionType);

        public async Task<IEnumerable<ConnectionType>> GetAllConnectionTypesAsync(bool trackChanges) =>
            await FindAll(trackChanges)
                .Where(ct => ct.IsDeleted != true)
                .ToListAsync();

        public async Task<ConnectionType> GetOneConnectionTypeByIdAsync(int id, bool trackChanges) =>
            await FindByCondition(ct => ct.Id == id && ct.IsDeleted != true, trackChanges)
                .SingleOrDefaultAsync();

        public void UpdateOneConnectionType(ConnectionType connectionType) => Update(connectionType);
    }
}
