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
    public class TasksRepository : RepositoryBase<Tasks>, ITasksRepository
    {
        public TasksRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateTask(Tasks tasks) => Create(tasks);

        public void DeleteTask(Tasks tasks) => Delete(tasks);

        public async Task<IEnumerable<Tasks>> GetAllTasksAsync(bool trackChanges) =>
            await FindAll(trackChanges)
                .Where(t => t.IsDeleted != true)
                .ToListAsync();

        public async Task<Tasks> GetOneTaskByIdAsync(int id, bool trackChanges) =>
            await FindByCondition(t => t.Id == id && t.IsDeleted != true, trackChanges)
                .SingleOrDefaultAsync();

        public void UpdateTask(Tasks tasks) => Update(tasks);
    }
}
