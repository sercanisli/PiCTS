using AutoMapper;
using PiCTS.Entities.DataTransferObjects.TasksDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.TasksDTOs.ResponseDTOs;
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
    public class TaskManager : ITaskService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public TaskManager(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<TasksResponseDTO> CreateTaskAsync(TasksRegistrationDTO tasksRegistrationDTO)
        {
            var task = _mapper.Map<Tasks>(tasksRegistrationDTO);

            IsTaskNull(task);

            task.Start = task.Start.AddDays(1);
            task.End = task.End.AddDays(1);

            task.CreatedDate = DateTime.Now;
            _repositoryManager.TasksRepository.CreateTask(task);
            await _repositoryManager.SaveChanges();
            return _mapper.Map<TasksResponseDTO>(task);
        }

        public async Task DeleteTaskAsync(int id, int projectId, bool trackChanges)
        {

            var tasks = await _repositoryManager.TasksRepository.GetAllTasksByProjectIdAsync(projectId, trackChanges);
            var task = await _repositoryManager.TasksRepository.GetOneTaskByIdAsync(id, trackChanges);

            if (task == null)
            {
                throw new TaskNotFoundException(id);
            }

            foreach (var t in tasks)
            {
                if (t.Dependencies.Contains(task.Id.ToString()))
                {
                    t.Dependencies.Remove(task.Id.ToString());
                    _repositoryManager.TasksRepository.UpdateTask(t);
                }
            }

            task.CreatedDate = task.CreatedDate;
            task.UpdatedDate = task.UpdatedDate;
            task.DeletedDate = DateTime.Now;
            task.IsDeleted = true;

            _repositoryManager.TasksRepository.UpdateTask(task);
            await _repositoryManager.SaveChanges();
        }

        public async Task<IEnumerable<TasksResponseDTO>> GetAllTasksAsync(bool trackChanges)
        {
            var tasks = await _repositoryManager.TasksRepository.GetAllTasksAsync(trackChanges);
            return _mapper.Map<IEnumerable<TasksResponseDTO>>(tasks);
        }

        public async Task<IEnumerable<TasksResponseDTO>> GetAllTasksByProjectIdAsync(int projectId, bool trackChanges)
        {
            var tasks = await _repositoryManager.TasksRepository.GetAllTasksByProjectIdAsync(projectId, trackChanges);
            return _mapper.Map<IEnumerable<TasksResponseDTO>>(tasks);
        }

        public async Task<TasksResponseDTO> GetOneTaskByIdAsync(int id, bool trackChanges)
        {
            var task = await _repositoryManager.TasksRepository.GetOneTaskByIdAsync(id, trackChanges);
            if(task == null)
            {
                throw new TaskNotFoundException(id);
            }
            return _mapper.Map<TasksResponseDTO>(task);
        }

        public async Task UpdateTaskAsync(int id, TasksUpdateDTO tasksUpdateDTO, bool trackChanges)
        {
            var entity = await _repositoryManager.TasksRepository.GetOneTaskByIdAsync(id, trackChanges);
            if(entity == null)
            {
                throw new TaskNotFoundException(id);
            }

            var task = _mapper.Map<Tasks>(tasksUpdateDTO);

            IsTaskNull(task);

            task.Start = task.Start.AddDays(1);
            task.End = task.End.AddDays(1);

            task.CreatedDate = entity.CreatedDate;
            task.DeletedDate = entity.DeletedDate;
            task.UpdatedDate = DateTime.Now;

            _repositoryManager.TasksRepository.UpdateTask(task);
            await _repositoryManager.SaveChanges();
        }

        private void IsTaskNull(Tasks task)
        {
            if (task == null)
            {
                throw new ArgumentNullException(nameof(task));
            }
        }
    }
}
