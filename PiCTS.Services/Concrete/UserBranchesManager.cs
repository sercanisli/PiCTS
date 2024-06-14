using AutoMapper;
using Microsoft.AspNetCore.Identity;
using PiCTS.Entities.DataTransferObjects.UserBranchesDTOs.ResponseDTOs;
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
    public class UserBranchesManager : IUserBranchesService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;

        public UserBranchesManager(IRepositoryManager manager, IMapper mapper, UserManager<User> userManager)
        {
            _manager = manager;
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<UserBranches> CreateOneUserBranchesAsync(UserBranches userBranches)
        {
            _manager.UserBranchesRepository.CreateOneUserBranch(userBranches);
            await _manager.SaveChanges();
            return userBranches;
        }

        public async Task DeleteOneUserBranchesAsync(string id, bool trackChanges)
        {
            var entities = await _manager.UserBranchesRepository.GetAllUserBranchesByUserId(id, false);
            if(entities == null)
            {
                throw new UserBranchesNotFoundException(id);
            }
            foreach (var entity in entities)
            {
                _manager.UserBranchesRepository.DeleteOneUserBranch(entity);
            }
            await _manager.SaveChanges();
        }

        public async Task<IEnumerable<UserBranchesResponseDTO>> GetAllUserBranchesAsync(bool trackChanges)
        {
            var entities = await _manager.UserBranchesRepository.GetAllUserBranchesAsync(trackChanges);
            return _mapper.Map<IEnumerable<UserBranchesResponseDTO>>(entities);
        }

        public async Task<IEnumerable<UserBranchesResponseDTO>> GetllUserBranchesByUserIdAsync(Guid userId, bool trackChanges)
        {
            var id = userId.ToString();
            var entities = await _manager.UserBranchesRepository.GetAllUserBranchesByUserId(id, trackChanges);
            return _mapper.Map<IEnumerable<UserBranchesResponseDTO>>(entities);
        }

        public async Task UpdateOneUserBranchesAsync(Guid userId ,List<UserBranches> userBranches, bool trackChanges)
        {
            var id = userId.ToString();
            var entities = await _manager.UserBranchesRepository.GetAllUserBranchesByUserId(id, false);
            if (entities == null)
            {
                throw new UserBranchesNotFoundException(id);
            }

            var user = await _userManager.FindByIdAsync(id);
            if(user == null)
            {
                throw new UserBranchesNotFoundException(id);
            }

            foreach (var entity in entities)
            {
                var deleteEntity = new UserBranches
                {
                    UserId = entity.UserId,
                    BranchId = entity.BranchId
                };
                _manager.UserBranchesRepository.DeleteOneUserBranch(deleteEntity);
            }

            if (userBranches.Count() > 0 )
            {
                foreach (var uBranches in userBranches)
                {
                    _manager.UserBranchesRepository.CreateOneUserBranch(uBranches);
                }
            }
            await _manager.SaveChanges();
        }
    }
}
