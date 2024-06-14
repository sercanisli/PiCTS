using PiCTS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Repositories.Contract
{
    public interface IConnectionTypeRepository : IRepositoryBase<ConnectionType>
    {
        Task<IEnumerable<ConnectionType>> GetAllConnectionTypesAsync(bool trackChanges);
        Task<ConnectionType> GetOneConnectionTypeByIdAsync(int id, bool trackChanges);
        void CreateOneConnectionType(ConnectionType connectionType);
        void UpdateOneConnectionType(ConnectionType connectionType);
        void DeleteOneConnectionType(ConnectionType connectionType);
    }
}
