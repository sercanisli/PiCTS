using PiCTS.Entities.DataTransferObjects.TaskUsersDTOs.ResponseDTOs;
using PiCTS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Services.Contract
{
    public interface ITaskUsersService
    {
        Task<IEnumerable<TaskUsersResponseDTO>> GetAllTaskUsersAsync(bool trackChanges);
        Task<IEnumerable<TaskUsersResponseDTO>> GetAllTaskUsersByTaskIdAsync(int taskId, bool trackChanges);
        Task<IEnumerable<UserTasksResponseDTO>> GetAllUserTasksByUserIdAsync(string userId, bool trackChanges);
        Task<TaskUsers> CreateOneTaskUsersAsync(TaskUsers taskUsers);
        Task UpdateOneTaskUsersAsync(int taskId, List<TaskUsers> taskUsers, bool trackChanges);
        Task UpdateOneTaskSawAsync(string userId, bool trackChanges);
        Task DeleteOneTaskUsersAsync(int taskId, bool trackChanges);
    }
}
