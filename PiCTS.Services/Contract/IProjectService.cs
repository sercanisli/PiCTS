using PiCTS.Entities.DataTransferObjects.ProjectDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.ProjectDTOs.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Services.Contract
{
    public interface IProjectService
    {
        Task<IEnumerable<ProjectResponseDTO>> GetAllProjectsAsync(bool trackChanges);
        Task<ProjectResponseDTO> GetOneProjectByIdAsync(int id, bool trackChanges);
        Task<ProjectResponseDTO> CreateOneProjectAsync(ProjectRegistrationDTO projectRegistrationDTO);
        Task UpdateOneProjectAsync(int id, ProjectUpdateDTO projectUpdateDTO, bool trackChanges);
        Task DeleteOneProjectAsync(int id, bool trackChanges);
    }
}
