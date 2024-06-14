using AutoMapper;
using PiCTS.Entities.DataTransferObjects.ConnectionTypeDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.ConnectionTypeDTOs.ResponseDTOs;
using PiCTS.Entities.Exceptions;
using PiCTS.Entities.Models;
using PiCTS.Repositories.Contract;
using PiCTS.Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Services.Concrete
{
    public class ConnectionTypeManager : IConnectionTypeService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public ConnectionTypeManager(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<ConnectionTypeResponseDTO> CreateOneConnectionTypeAsync(ConnectionTypeRegistrationDTO connectionTypeRegistrationDTO)
        {
            var connectionType = _mapper.Map<ConnectionType>(connectionTypeRegistrationDTO);

            IsConnectionTypeNull(connectionType);

            await IsTypeExist(connectionType);

            connectionType.CreatedDate = DateTime.Now;
            _repositoryManager.ConnectionTypeRepository.CreateOneConnectionType(connectionType);
            await _repositoryManager.SaveChanges();
            return _mapper.Map<ConnectionTypeResponseDTO>(connectionType);
        }

        public async Task DeleteOneConnectionTypeAsync(int id, bool trackChanges)
        {
            var entity = await _repositoryManager.ConnectionTypeRepository.GetOneConnectionTypeByIdAsync(id, trackChanges);
            if(entity == null)
            {
                throw new ConnectionTypeNotFoundException(id);
            }
            entity.CreatedDate = entity.CreatedDate;
            entity.UpdatedDate = entity.UpdatedDate;
            entity.DeletedDate = DateTime.Now;
            entity.IsDeleted = true;
            _repositoryManager.ConnectionTypeRepository.UpdateOneConnectionType(entity);
            await _repositoryManager.SaveChanges();
        }

        public async Task<IEnumerable<ConnectionTypeResponseDTO>> GetAllConnectionTypesAsync(bool trackChanges)
        {
            var entities = await _repositoryManager.ConnectionTypeRepository.GetAllConnectionTypesAsync(trackChanges);
            return _mapper.Map<IEnumerable<ConnectionTypeResponseDTO>>(entities);
        }

        public async Task<IEnumerable<ConnectionTypeLimitedResponseDTO>> GetAllLimitedConnectionTypesAsync(bool trackChanges)
        {
            var entities = await _repositoryManager.ConnectionTypeRepository.GetAllConnectionTypesAsync(trackChanges);
            return _mapper.Map<IEnumerable<ConnectionTypeLimitedResponseDTO>>(entities);
        }

        public async Task<ConnectionTypeResponseDTO> GetOneConnectionTypeByIdAsync(int id, bool trackChanges)
        {
            var entity = await _repositoryManager.ConnectionTypeRepository.GetOneConnectionTypeByIdAsync(id, trackChanges);
            if(entity == null)
            {
                throw new ConnectionTypeNotFoundException(id);
            }
            return _mapper.Map<ConnectionTypeResponseDTO>(entity);
        } 

        public async Task UpdateOneConnectionTypeAsync(int id, ConnectionTypeUpdateDTO connectionTypeUpdateDTO, bool trackChanges)
        {
            var entity = await _repositoryManager.ConnectionTypeRepository.GetOneConnectionTypeByIdAsync(id, trackChanges);
            if(entity == null)
            {
                throw new ConnectionTypeNotFoundException(id);
            }

            var connectionType = _mapper.Map<ConnectionType>(connectionTypeUpdateDTO);

            IsConnectionTypeNull(connectionType);

            //await IsTypeExist(connectionType);

            connectionType.CreatedDate = entity.CreatedDate;
            connectionType.UpdatedDate = DateTime.Now;

            _repositoryManager.ConnectionTypeRepository.UpdateOneConnectionType(connectionType);

            await _repositoryManager.SaveChanges();
        }

        private async Task IsTypeExist(ConnectionType connectionType)
        {
            var entities = await GetAllConnectionTypesAsync(false);

            foreach (var entity in entities)
            {
                if(entity.Type == connectionType.Type)
                {
                    throw new Exception("Connection Type must be uniq");
                }
            }
        }

        private void IsConnectionTypeNull(ConnectionType connectionType)
        {
            if(connectionType.Type == null)
            {
                throw new ArgumentNullException(nameof(connectionType));
            }
        }
    }
}
