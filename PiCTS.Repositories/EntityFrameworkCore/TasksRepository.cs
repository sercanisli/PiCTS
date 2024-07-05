using Microsoft.EntityFrameworkCore;
using PiCTS.Entities.DataTransferObjects.TasksDTOs.ResponseDTOs;
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

        public async Task<IEnumerable<Tasks>> GetAllTasksByProjectIdAsync(int projectId, bool trackChanges) =>
            await FindAll(trackChanges)
                .Where(t => t.ProjectId == projectId && t.IsDeleted != true)
                .ToListAsync();

        /* public async Task<IEnumerable<TasksResponseDTO>> GetAllTasksAsync(bool trackChanges)
        {
            var list = await FindAll(trackChanges)
                .Where(t => t.IsDeleted != true)
                .ToListAsync();

            List<TasksResponseDTO> list2 = new List<TasksResponseDTO>();
            foreach(var item in list)
            {
                TasksResponseDTO item2 = new TasksResponseDTO
                {
                    Id = item.Id,
                    ProjectId = item.ProjectId,
                    Name=item.Name,
                    Start=item.Start.ToString("yyyy-MM-dd"),
                    End=item.End.ToString("yyyy-MM-dd"),
                    Description = item.Description,
                    Progress = item.Progress,
                    Statuses = (TasksResponseDTO.Status)item.Statuses,
                    Dependencies = item.Dependencies
                };
                list2.Add(item2);
            }
            return list2;

        } */

        public async Task<Tasks> GetOneTaskByIdAsync(int id, bool trackChanges) =>
            await FindByCondition(t => t.Id == id && t.IsDeleted != true, trackChanges)
                .SingleOrDefaultAsync();

        public void UpdateTask(Tasks tasks) => Update(tasks);
    }
}
