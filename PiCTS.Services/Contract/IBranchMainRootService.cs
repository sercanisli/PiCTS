using PiCTS.Entities.DataTransferObjects.BranchMainRootDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.BranchMainRootDTOs.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Services.Contract
{
    public interface IBranchMainRootService
    {
        Task<IEnumerable<BranchMainRootResponseDTO>> GetAllBranchMainRootAsync(bool trackChanges);
        Task<BranchMainRootResponseDTO> GetOneBranchMainRootByIdAsync(int id, bool trackChanges);
        Task<BranchMainRootResponseDTO> CreateOneBranchMainRootAsync(BranchMainRootRegistrationDTO branchMainRootRegistrationDTO);
        Task UpdateOneBranchMainRootAsync(int id, BranchMainRootUpdateDTO branchMainRootUpdateDTO, bool trackChanges);
        Task DeleteOneBranchMainRootAsync(int id, bool trackChanges);
    }
}
