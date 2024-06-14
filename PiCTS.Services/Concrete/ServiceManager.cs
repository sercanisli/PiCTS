using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using PiCTS.Entities.Models;
using PiCTS.Repositories.Contract;
using PiCTS.Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Services.Concrete
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICompanyService> _companyService;
        private readonly Lazy<IBranchService> _branchService;
        private readonly Lazy<IPersonService> _personService;
        private readonly Lazy<IConnectionService> _connectionService;
        private readonly Lazy<IConnectionTypeService> _connectionTypeService;
        private readonly Lazy<IUserService> _userService;
        private readonly Lazy<IUserRolesService> _userRolesService;
        private readonly Lazy<IRoleService> _roleService;
        private readonly Lazy<IMainRootService> _mainRootService;
        private readonly Lazy<IChildRootService> _childRootService;
        private readonly Lazy<IUserBranchesService> _userBranchesService;
        private readonly Lazy<IBranchMainRootService> _branchMainRootService;
        private readonly Lazy<IBranchChildRootService> _branchChildRootService;
        private readonly Lazy<IDashboardService> _dashboardService;
        private readonly Lazy<ISearchCountsService> _searchCountsService;
        private readonly Lazy<ISearchCountofCompaniesService> _searchCountofCompaniesService;


        private readonly Lazy<IAuthenticationService> _authenticationService;

        public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper, ILoggerService logger, UserManager<User> userManager, IConfiguration configuration, RoleManager<Role> roleManager)
        {
            _companyService = new Lazy<ICompanyService>(() => new CompanyManager(repositoryManager, mapper));
            _branchService = new Lazy<IBranchService>(() => new BranchManager(repositoryManager, mapper));
            _personService = new Lazy<IPersonService>(() => new PersonManager(repositoryManager, mapper));
            _connectionService = new Lazy<IConnectionService>(() => new ConnectionManager(repositoryManager, mapper, userManager));
            _connectionTypeService = new Lazy<IConnectionTypeService>(() => new ConnectionTypeManager(repositoryManager, mapper));
            _authenticationService = new Lazy<IAuthenticationService>(() => new AuthenticationManager(logger, mapper, userManager, configuration));
            _userService = new Lazy<IUserService>(() => new UserManager(userManager, mapper, repositoryManager));
            _userRolesService = new Lazy<IUserRolesService>(() => new UserRolesManager(userManager, repositoryManager, mapper, roleManager));
            _roleService = new Lazy<IRoleService>(() => new RoleManager(roleManager, repositoryManager, mapper));
            _mainRootService = new Lazy<IMainRootService>(() => new MainRootManager(repositoryManager, mapper));
            _childRootService = new Lazy<IChildRootService>(() => new ChildRootManager(repositoryManager, mapper));
            _userBranchesService = new Lazy<IUserBranchesService>(() => new UserBranchesManager(repositoryManager, mapper, userManager));
            _branchMainRootService = new Lazy<IBranchMainRootService>(() => new BranchMainRootManager(repositoryManager, mapper));
            _branchChildRootService = new Lazy<IBranchChildRootService>(() => new BranchChildRootManager(repositoryManager, mapper));
            _dashboardService = new Lazy<IDashboardService>(() => new DashboardManager(repositoryManager, userManager));
            _searchCountsService = new Lazy<ISearchCountsService>(() => new SearchCountsManager(repositoryManager, mapper));
            _searchCountofCompaniesService = new Lazy<ISearchCountofCompaniesService>(() => new SearchCountofCompaniesManager(repositoryManager, mapper));
        }

        public ICompanyService CompanyService => _companyService.Value;
        public IBranchService BranchService => _branchService.Value;
        public IPersonService PersonService => _personService.Value;
        public IConnectionService ConnectionService => _connectionService.Value;
        public IConnectionTypeService ConnectionTypeService => _connectionTypeService.Value;
        public IUserService UserService => _userService.Value;
        public IUserRolesService UserRolesService => _userRolesService.Value;
        public IRoleService RoleService => _roleService.Value;
        public IMainRootService MainRootService => _mainRootService.Value;
        public IChildRootService ChildRootService => _childRootService.Value;
        public IUserBranchesService UserBranchesService => _userBranchesService.Value;
        public IBranchMainRootService BranchMainRootService => _branchMainRootService.Value;
        public IBranchChildRootService BranchChildRootService => _branchChildRootService.Value;
        public IDashboardService DashboardService => _dashboardService.Value;
        public ISearchCountsService SearchCountsService => _searchCountsService.Value;
        public ISearchCountofCompaniesService SearchCountofCompaniesService => _searchCountofCompaniesService.Value;

        public IAuthenticationService AuthenticationService => _authenticationService.Value;
    }
}
