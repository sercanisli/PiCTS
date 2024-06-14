using PiCTS.Entities.DataTransferObjects.MainRootDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.MainRootDTOs.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Services.Contract
{
    public interface IMainRootService
    {
        Task<IEnumerable<MainRootResponseDTO>> GetAllMainRootsAsync(bool trackChanges);
        Task<MainRootResponseDTO> GetOneMainRootByIdAsync(int id, bool trackChanges);
        Task<MainRootResponseDTO> CreateOneMainRootAsync(MainRootRegistrationDTO mainRootRegistrationDTO);
        Task UpdateOneMainRootAsync(int id, MainRootUpdateDTO mainRootUpdate, bool trackChanges);
        Task DeleteOneMainRootAsync(int id, bool trackChanges);
    }
}
