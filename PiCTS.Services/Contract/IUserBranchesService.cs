using PiCTS.Entities.DataTransferObjects.UserBranchesDTOs.ResponseDTOs;
using PiCTS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Services.Contract
{
    public interface IUserBranchesService
    {
        Task<IEnumerable<UserBranchesResponseDTO>> GetAllUserBranchesAsync(bool trackChanges);
        Task<IEnumerable<UserBranchesResponseDTO>> GetllUserBranchesByUserIdAsync(Guid userId, bool trackChanges);
        Task<UserBranches> CreateOneUserBranchesAsync(UserBranches userBranches);
        Task UpdateOneUserBranchesAsync(Guid userId, List<UserBranches> userBranches, bool trackChanges);
        Task DeleteOneUserBranchesAsync(string id, bool trackChanges);
    }
}
