using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Services.Contract
{
    public interface IServiceManager
    {
        ICompanyService CompanyService { get; }
        IBranchService BranchService { get; }
        IPersonService PersonService { get; }
        IConnectionService ConnectionService { get; }
        IConnectionTypeService ConnectionTypeService { get; }
        IUserService UserService { get; }
        IUserRolesService UserRolesService { get; }
        IRoleService RoleService { get; }
        IMainRootService MainRootService { get; }
        IChildRootService ChildRootService { get; }
        IUserBranchesService UserBranchesService { get; }
        IBranchMainRootService BranchMainRootService { get; }
        IBranchChildRootService BranchChildRootService { get; }
        IDashboardService DashboardService { get; }
        ISearchCountsService SearchCountsService { get; }
        ISearchCountofCompaniesService SearchCountofCompaniesService { get; }

        IAuthenticationService AuthenticationService { get; }
    }
}
