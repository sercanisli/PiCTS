using PiCTS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Repositories.Contract
{
    public interface ITaskUsersRepository : IRepositoryBase<TaskUsers>
    {
        Task<IEnumerable<TaskUsers>> GetAllTaskUsersAsync(bool trackChanges);
        Task<IEnumerable<TaskUsers>> GetAllTaskUsersByTaskIdAsync(int taskId, bool trackChanges);
        void CreateTaskUser(TaskUsers taskUsers);
        void UpdateTaskUser(TaskUsers taskUsers);
        void DeleteTaskUser(TaskUsers taskUsers);
    }
}
