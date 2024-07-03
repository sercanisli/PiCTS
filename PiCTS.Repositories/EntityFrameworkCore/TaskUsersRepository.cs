using Microsoft.EntityFrameworkCore;
using PiCTS.Entities.Models;
using PiCTS.Repositories.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Repositories.EntityFrameworkCore
{
    public class TaskUsersRepository : RepositoryBase<TaskUsers>, ITaskUsersRepository
    {
        public TaskUsersRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateTaskUser(TaskUsers taskUsers) => Create(taskUsers);

        public void DeleteTaskUser(TaskUsers taskUsers) => Delete(taskUsers);

        public async Task<IEnumerable<TaskUsers>> GetAllTaskUsersAsync(bool trackChanges) =>
            await FindAll(trackChanges).ToListAsync();

        public async Task<IEnumerable<TaskUsers>> GetAllTaskUsersByTaskIdAsync(int taskId, bool trackChanges) =>
            await FindAll(trackChanges)
                .Where(tu => tu.TaskId == taskId)
                .Include(tu => tu.User)
                .ToListAsync();

        public void UpdateTaskUser(TaskUsers taskUsers) => Update(taskUsers);
    }
}
