using PiCTS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Repositories.Contract
{
    public interface IProjectRepository : IRepositoryBase<Project>
    {
        Task<IEnumerable<Project>> GetAllProjectsAsync(bool trackChanges);
        Task<Project> GetOneProjectByIdAsync(int id, bool trackChanges);
        void CreateOneProject(Project project);
        void UpdateOneProject(Project project);
        void DeleteOneProject(Project project);
    }
}
