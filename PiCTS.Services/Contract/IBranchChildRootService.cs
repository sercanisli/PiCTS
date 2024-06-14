using PiCTS.Entities.DataTransferObjects.BranchChildRootDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.BranchChildRootDTOs.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Services.Contract
{
    public interface IBranchChildRootService
    {
        Task<IEnumerable<BranchChildRootResponseDTO>> GetAllBranchChildRootAsync(bool trackChanges);
        Task<BranchChildRootResponseDTO> GetOneBranchChildRootByIdAsync(int id, bool trackChanges);
        Task<BranchChildRootResponseDTO> CreateOneBranchChildRootAsync(BranchChildRootRegistrationDTO branchChildRootRegistrationDTO);
        Task UpdateOneBranchChildRootAsync(int id, BranchChildRootUpdateDTO branchChildRootUpdateDTO, bool trackChanges);
        Task DeleteOneBranchChildRootAsync(int id, bool trackChanges);
    }
}
