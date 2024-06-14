using PiCTS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Repositories.Contract
{
    public interface IConnectionRepository : IRepositoryBase<Connection>
    {
        Task<IEnumerable<Connection>> GetAllConnectionsAsync(bool trackChanges);
        Task<IEnumerable<Connection>> GetAllConnectionsByBranchIdAsync(int id, bool trackChanges);
        Task<Connection> GetOneConnectionByIdAsync(int id, bool trackChanges);
        void CreateOneConnection(Connection connection);
        void UpdateOneConnection(Connection connection);
        void DeleteOneConnection(Connection connection);
    }
}
