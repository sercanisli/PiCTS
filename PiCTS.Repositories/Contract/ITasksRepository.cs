using PiCTS.Entities.DataTransferObjects.TasksDTOs.ResponseDTOs;
using PiCTS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Repositories.Contract
{
    public interface ITasksRepository : IRepositoryBase<Tasks>
    {
        Task<IEnumerable<Tasks>> GetAllTasksAsync(bool trackChanges);
        //Task<IEnumerable<TasksResponseDTO>> GetAllTasksAsync(bool trackChanges);
        Task<IEnumerable<Tasks>> GetAllTasksByProjectIdAsync(int projectId, bool trackChanges);
        Task<Tasks> GetOneTaskByIdAsync(int id, bool trackChanges);
        void CreateTask(Tasks tasks);
        void UpdateTask(Tasks tasks);
        void DeleteTask(Tasks tasks);
    }
}
