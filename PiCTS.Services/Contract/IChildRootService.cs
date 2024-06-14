using PiCTS.Entities.DataTransferObjects.ChildRootDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.ChildRootDTOs.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Services.Contract
{
    public interface IChildRootService
    {
        Task<IEnumerable<ChildRootResponseDTO>> GetAllChildRootsAsync(bool trackChanges);
        Task<ChildRootResponseDTO> GetOneChildRootByIdAsync(int id, bool trackChanges);
        Task<ChildRootResponseDTO> CreateOneChildRootAsync(ChildRootRegistrationDTO childRootRegistrationDTO);
        Task UpdateOneChildRootAsync(int id, ChildRootUpdateDTO childRootUpdateDTO, bool trackChanges);
        Task DeleteOneChildRootAsync(int id, bool trackChanges);
    }
}
