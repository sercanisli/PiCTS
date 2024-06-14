using PiCTS.Entities.DataTransferObjects.ConnectionTypeDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.ConnectionTypeDTOs.ResponseDTOs;
using PiCTS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Services.Contract
{
    public interface IConnectionTypeService
    {
        Task<IEnumerable<ConnectionTypeResponseDTO>> GetAllConnectionTypesAsync(bool trackChanges);
        Task<IEnumerable<ConnectionTypeLimitedResponseDTO>> GetAllLimitedConnectionTypesAsync(bool trackChanges);
        Task<ConnectionTypeResponseDTO> GetOneConnectionTypeByIdAsync(int id, bool trackChanges);
        Task<ConnectionTypeResponseDTO> CreateOneConnectionTypeAsync(ConnectionTypeRegistrationDTO connectionTypeRegistrationDTO);
        Task UpdateOneConnectionTypeAsync(int id, ConnectionTypeUpdateDTO connectionTypeUpdateDTO, bool trackChanges);
        Task DeleteOneConnectionTypeAsync(int id, bool trackChanges);
    }
}
