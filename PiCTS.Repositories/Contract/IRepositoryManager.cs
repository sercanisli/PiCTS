using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Repositories.Contract
{
    public interface IRepositoryManager
    {
        ICompanyRepository CompanyRepository { get; }
        IBranchRepository BranchRepository { get; }
        IPersonRepository PersonRepository { get; }
        IConnectionRepository ConnectionRepository { get; }
        IConnectionTypeRepository ConnectionTypeRepository { get; }
        IMainRootRepository MainRootRepository { get; }
        IChildRootRepository ChildRootRepository { get; }
        IUserBranchesRepository UserBranchesRepository { get; }
        IBranchMainRootRepository BranchMainRootRepository { get; }
        IBranchChildRootRepository BranchChildRootRepository { get; }
        ISearchCountsRepository SearchCountsRepository { get; }
        ISearchCountofCompaniesRepository SearchCountofCompaniesRepository { get; }
        IProjectRepository ProjectRepository { get; }
        ITasksRepository TasksRepository { get; }
        ITaskUsersRepository TaskUsersRepository { get; }

        Task SaveChanges();
    }
}
