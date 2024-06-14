using PiCTS.Entities.DataTransferObjects;
using PiCTS.Entities.DataTransferObjects.ConnectionDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.ConnectionDTOs.ResponseDTOs;
using PiCTS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Services.Contract
{
    public interface IConnectionService
    {
        Task<IEnumerable<ConnectionResponseDTO>> GetAllConnectionsAsync(bool trackChanges);
        Task<IEnumerable<ConnectionsByBranchIdResponseDTO>> GetAllConnectionsByBrachIdAsync(string userName ,bool trackChanges);
        Task<ConnectionResponseDTO> GetOneConnectionByIdAsync(int id, bool trackChanges);
        Task<ConnectionResponseDTO> CreateOneConnectionAsync(ConnectionRegistrationDTO connection);
        Task UpdateOneConnectionAsync(int id, ConnectionUpdateDTO connectionUpdateDTO, bool trackChanges);
        Task DeleteOneConnectionAsync(int id, bool trackChanges);
    }
}
