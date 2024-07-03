using PiCTS.Entities.DataTransferObjects.TasksDTOs.RequestDTOs;
using PiCTS.Entities.DataTransferObjects.TasksDTOs.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Services.Contract
{
    public interface ITaskService
    {
        Task<IEnumerable<TasksResponseDTO>> GetAllTasksAsync(bool trackChanges);
        Task<TasksResponseDTO> GetOneTaskByIdAsync(int id, bool trackChanges);
        Task<TasksResponseDTO> CreateTaskAsync(TasksRegistrationDTO tasksRegistrationDTO);
        Task UpdateTaskAsync(int id, TasksUpdateDTO tasksUpdateDTO, bool trackChanges);
        Task DeleteTaskAsync(int id, bool trackChanges);
    }
}
