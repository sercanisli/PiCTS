using PiCTS.Entities.DataTransferObjects.BranchDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.BranchDTOs.ResponseDTOs;
using PiCTS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Services.Contract
{
    public interface IBranchService
    {
        Task<IEnumerable<BranchResponseDTO>> GetAllBranchesAsync(string userName, bool trackChanges);
        Task<IEnumerable<BranchLimitedResponseDTO>> GetAllLimitedBranchesAsync(bool trackChanges);
        Task<BranchResponseDTO> GetOneBranchByIdAsync(int id, bool trackChanges);
        Task<BranchResponseDTO> CreateOneBranchAsync(BranchForRegistrationDTO branchForRegistrationDTO);
        Task UpdateOneBranchAsync(int id, BranchUpdateDTO branchUpdateDTO, bool trackChanges);
        Task DeleteOneBranchAsync(int id, bool trackChanges);
    }
}
