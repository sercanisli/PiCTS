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
    public class ProjectRepository : RepositoryBase<Project>, IProjectRepository
    {
        public ProjectRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateOneProject(Project project) => Create(project);

        public void DeleteOneProject(Project project) => Delete(project);

        public async Task<IEnumerable<Project>> GetAllLimitedProjectAsync(bool trackChanges) =>
            await FindAll(trackChanges)
                .Where(p => p.IsDeleted != true)
                .ToListAsync();

        public async Task<IEnumerable<Project>> GetAllProjectsAsync(bool trackChanges) =>
            await FindAll(trackChanges)
                .Where(p => p.IsDeleted != true)
                .Include(p => p.Company)
                .ToListAsync();

        public async Task<Project> GetOneProjectByIdAsync(int id, bool trackChanges) =>
            await FindByCondition(p => p.Id == id && p.IsDeleted != true, trackChanges)
                .Include(p => p.Company)
                .SingleOrDefaultAsync();

        public void UpdateOneProject(Project project) => Update(project);
    }
}
