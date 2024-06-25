using AutoMapper;
using Microsoft.AspNetCore.Identity;
using PiCTS.Entities.DataTransferObjects;
using PiCTS.Entities.DataTransferObjects.ConnectionDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.ConnectionDTOs.ResponseDTOs;
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
    public class ConnectionManager : IConnectionService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;

        public ConnectionManager(IRepositoryManager repositoryManager, IMapper mapper, UserManager<User> userManager)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<ConnectionResponseDTO> CreateOneConnectionAsync(ConnectionRegistrationDTO connectionRegistrationDTO)
        {
            var connection = _mapper.Map<Connection>(connectionRegistrationDTO);
            IsConnectionNull(connection);

            connection.CreatedDate = DateTime.Now;
            _repositoryManager.ConnectionRepository.CreateOneConnection(connection);
            await _repositoryManager.SaveChanges();
            return _mapper.Map<ConnectionResponseDTO>(connection);
        }

        public async Task DeleteOneConnectionAsync(int id, bool trackChanges)
        {
            var entity = await _repositoryManager.ConnectionRepository.GetOneConnectionByIdAsync(id, trackChanges);
            if (entity == null)
            {
                throw new ConnectionNotFoundException(id);
            }
            entity.CreatedDate = entity.CreatedDate;
            entity.UpdatedDate = entity.UpdatedDate;
            entity.DeletedDate = DateTime.Now;
            entity.IsDeleted = true;
            _repositoryManager.ConnectionRepository.UpdateOneConnection(entity);
            await _repositoryManager.SaveChanges();
        }

        public async Task<IEnumerable<ConnectionResponseDTO>> GetAllConnectionsAsync(bool trackChanges)
        {
            var entities = await _repositoryManager.ConnectionRepository.GetAllConnectionsAsync(trackChanges);
            return _mapper.Map<IEnumerable<ConnectionResponseDTO>>(entities);
        }

        public async Task<IEnumerable<ConnectionsByBranchIdResponseDTO>> GetAllConnectionsByBrachIdAsync(string userName, bool trackChanges)
        {
            var connections = new List<Connection>();
            var user = await _userManager.FindByNameAsync(userName);
            var userId = new Guid(user.Id);
            if (user == null)
            {
                throw new UserNotFoundException(userId);
            }
            var userBranches = await _repositoryManager.UserBranchesRepository.GetAllUserBranchesByUserId(user.Id, false);
            foreach (var uBranch in userBranches)
            {
                var branchConnections = await _repositoryManager.ConnectionRepository.GetAllConnectionsByBranchIdAsync(uBranch.BranchId, false);
                connections.AddRange(branchConnections);
            }


            var userRoles = await _userManager.GetRolesAsync(user);

            if (!userRoles.Contains("Yetkili Kişi Bilgileri Gorme"))
            {
                foreach (var entity in connections)
                {
                    foreach (var person in entity.Branch.Persons)
                    {
                        person.FullName = "*****";
                        person.Phone = "*****";
                    }
                }
            }

            if(!userRoles.Contains("Bağlanti Bilgileri Gorme"))
            {
                foreach (var entity in connections)
                {
                    entity.Username = "*****";
                    entity.Password = "*****";
                }
            }

            return _mapper.Map<IEnumerable<ConnectionsByBranchIdResponseDTO>>(connections);

        }

        public async Task<ConnectionResponseDTO> GetOneConnectionByIdAsync(int id, bool trackChanges)
        {
            var entity = await _repositoryManager.ConnectionRepository.GetOneConnectionByIdAsync(id, trackChanges);
            if (entity == null)
            {
                throw new ConnectionNotFoundException(id);
            }
            return _mapper.Map<ConnectionResponseDTO>(entity);
        }

        public async Task UpdateOneConnectionAsync(int id, ConnectionUpdateDTO connectionUpdateDTO, bool trackChanges)
        {
            var entity = await _repositoryManager.ConnectionRepository.GetOneConnectionByIdAsync(id, trackChanges);
            if (entity == null)
            {
                throw new ConnectionNotFoundException(id);
            }
            var connection = _mapper.Map<Connection>(connectionUpdateDTO);
            IsConnectionNull(connection);

            connection.CreatedDate = entity.CreatedDate;
            connection.UpdatedDate = DateTime.Now;

            _repositoryManager.ConnectionRepository.UpdateOneConnection(connection);

            await _repositoryManager.SaveChanges();
        }

        private void IsConnectionNull(Connection connection)
        {
            if (connection.Link == null)
            {
                throw new ArgumentNullException(nameof(connection));
            }
        }
    }
}
