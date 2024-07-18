using AutoMapper;
using PiCTS.Entities.DataTransferObjects.ProjectDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.ProjectDTOs.ResponseDTOs;
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
    public class ProjectManager : IProjectService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public ProjectManager(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<ProjectResponseDTO> CreateOneProjectAsync(ProjectRegistrationDTO projectRegistrationDTO)
        {
            var project = _mapper.Map<Project>(projectRegistrationDTO);

            IsProjectNull(project);

            project.CreatedDate = DateTime.Now;
            _repositoryManager.ProjectRepository.CreateOneProject(project);
            await _repositoryManager.SaveChanges();
            return _mapper.Map<ProjectResponseDTO>(project);
        }

        public async Task DeleteOneProjectAsync(int id, bool trackChanges)
        {
            var project = await _repositoryManager.ProjectRepository.GetOneProjectByIdAsync(id, trackChanges);
            if(project == null)
            {
                throw new ProjectNotFoundException(id);
            }

            project.CreatedDate = project.CreatedDate;
            project.UpdatedDate = project.UpdatedDate;
            project.DeletedDate = DateTime.Now;
            project.IsDeleted = true;

            _repositoryManager.ProjectRepository.UpdateOneProject(project);
            await _repositoryManager.SaveChanges();
        }

        public async Task<IEnumerable<ProjectLimitedResponseDTO>> GetAllLimitedProjectAsync(bool trackChanges)
        {
            var limitedProjects = await _repositoryManager.ProjectRepository.GetAllLimitedProjectAsync(trackChanges);
            return _mapper.Map<IEnumerable<ProjectLimitedResponseDTO>>(limitedProjects);
        }

        public async Task<IEnumerable<ProjectResponseDTO>> GetAllProjectsAsync(bool trackChanges)
        {
            var projects = await _repositoryManager.ProjectRepository.GetAllProjectsAsync(trackChanges);
            return _mapper.Map<IEnumerable<ProjectResponseDTO>>(projects);
        }

        public async Task<ProjectResponseDTO> GetOneProjectByIdAsync(int id, bool trackChanges)
        {
            var project = await _repositoryManager.ProjectRepository.GetOneProjectByIdAsync(id, trackChanges);
            if(project == null)
            {
                throw new ProjectNotFoundException(id);
            }
            return _mapper.Map<ProjectResponseDTO>(project);
        }

        public async Task UpdateOneProjectAsync(int id, ProjectUpdateDTO projectUpdateDTO, bool trackChanges)
        {
            var entity = await _repositoryManager.ProjectRepository.GetOneProjectByIdAsync(id, trackChanges);
            if(entity == null)
            {
                throw new ProjectNotFoundException(id);
            }

            var project = _mapper.Map<Project>(projectUpdateDTO);

            IsProjectNull(project);

            project.CreatedDate = entity.CreatedDate;
            project.DeletedDate = entity.DeletedDate;
            project.UpdatedDate = DateTime.Now;

            _repositoryManager.ProjectRepository.UpdateOneProject(project);
            await _repositoryManager.SaveChanges();
        }

        private void IsProjectNull(Project project)
        {
            if (project == null)
            {
                throw new ArgumentNullException(nameof(project));
            }
        }
    }
}
