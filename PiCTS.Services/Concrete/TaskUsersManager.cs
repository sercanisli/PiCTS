using AutoMapper;
using Microsoft.AspNetCore.Identity;
using PiCTS.Entities.DataTransferObjects.TaskUsersDTOs.ResponseDTOs;
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
    public class TaskUsersManager : ITaskUsersService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public TaskUsersManager(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public async Task<TaskUsers> CreateOneTaskUsersAsync(TaskUsers taskUsers)
        {
            _manager.TaskUsersRepository.CreateTaskUser(taskUsers);
            await _manager.SaveChanges();
            return taskUsers;
        }

        public async Task DeleteOneTaskUsersAsync(int taskId, bool trackChanges)
        {
            var taskUsers = await _manager.TaskUsersRepository.GetAllTaskUsersByTaskIdAsync(taskId, false);
            if(taskUsers == null)
            {
                throw new TaskUserNotFoundException(taskId);
            }
            foreach (var tu in taskUsers)
            {
                _manager.TaskUsersRepository.DeleteTaskUser(tu);
            }
            await _manager.SaveChanges();
        }

        public async Task<IEnumerable<TaskUsersResponseDTO>> GetAllTaskUsersAsync(bool trackChanges)
        {
            var taskUsers = await _manager.TaskUsersRepository.GetAllTaskUsersAsync(trackChanges);
            return _mapper.Map<IEnumerable<TaskUsersResponseDTO>>(taskUsers);
        }

        public async Task<IEnumerable<TaskUsersResponseDTO>> GetAllTaskUsersByTaskIdAsync(int taskId, bool trackChanges)
        {
            var taskUsers = await _manager.TaskUsersRepository.GetAllTaskUsersByTaskIdAsync(taskId, trackChanges);
            return _mapper.Map<IEnumerable<TaskUsersResponseDTO>>(taskUsers);
        }

        public async Task UpdateOneTaskUsersAsync(int taskId, List<TaskUsers> taskUsers, bool trackChanges)
        {
            var entities = await _manager.TaskUsersRepository.GetAllTaskUsersByTaskIdAsync(taskId, false);
            if(entities == null)
            {
                throw new TaskUserNotFoundException(taskId);
            }

            var task = await _manager.TasksRepository.GetOneTaskByIdAsync(taskId, false);
            if(task == null)
            {
                throw new TaskNotFoundException(taskId);
            }

            foreach (var entity in entities)
            {
                var deleteEntity = new TaskUsers
                {
                    TaskId = entity.TaskId,
                    UserId = entity.UserId
                };
                _manager.TaskUsersRepository.DeleteTaskUser(deleteEntity);
            }

            if (taskUsers.Count() > 0)
            {
                foreach (var tu in taskUsers)
                {
                    _manager.TaskUsersRepository.CreateTaskUser(tu);
                }
            }
            await _manager.SaveChanges();
        }
    }
}
