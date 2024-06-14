using PiCTS.Repositories.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Repositories.EntityFrameworkCore
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;

        private readonly Lazy<ICompanyRepository> _companyRepository;
        private readonly Lazy<IBranchRepository> _branchRepository;
        private readonly Lazy<IPersonRepository> _personRepository;
        private readonly Lazy<IConnectionRepository> _connectionRepository;
        private readonly Lazy<IConnectionTypeRepository> _connectionTypeRepository;
        private readonly Lazy<IMainRootRepository> _mainRootRepository;
        private readonly Lazy<IChildRootRepository> _childRootRepository;
        private readonly Lazy<IUserBranchesRepository> _userBranchesRepository;
        private readonly Lazy<IBranchMainRootRepository> _branchMainRootRepository;
        private readonly Lazy<IBranchChildRootRepository> _branchChildRootRepository;
        private readonly Lazy<ISearchCountsRepository> _searchCountsRepository;
        private readonly Lazy<ISearchCountofCompaniesRepository> _searchCountofCompaniesRepository;

        public RepositoryManager(RepositoryContext context)
        {
            _context = context;

            _companyRepository = new Lazy<ICompanyRepository>(() => new CompanyRepository(_context));
            _branchRepository = new Lazy<IBranchRepository>(() => new BranchRepository(_context));
            _personRepository = new Lazy<IPersonRepository>(() => new PersonRepository(_context));
            _connectionRepository = new Lazy<IConnectionRepository>(() => new ConnectionRepository(_context));
            _connectionTypeRepository = new Lazy<IConnectionTypeRepository>(() => new ConnectionTypeRepository(_context));
            _mainRootRepository = new Lazy<IMainRootRepository>(() => new MainRootRepository(_context));
            _childRootRepository = new Lazy<IChildRootRepository>(() => new ChildRootRepository(_context));
            _userBranchesRepository = new Lazy<IUserBranchesRepository>(() => new UserBranchesRepository(_context));
            _branchMainRootRepository = new Lazy<IBranchMainRootRepository>(() => new BranchMainRootRepository(_context));
            _branchChildRootRepository = new Lazy<IBranchChildRootRepository>(() => new BranchChildRootRepository(_context));
            _searchCountsRepository = new Lazy<ISearchCountsRepository>(() => new SearchCountsRepository(_context));
            _searchCountofCompaniesRepository = new Lazy<ISearchCountofCompaniesRepository>(() => new SearchCountofCompaniesRepository(_context));
        }


        public ICompanyRepository CompanyRepository => _companyRepository.Value;
        public IBranchRepository BranchRepository => _branchRepository.Value;
        public IPersonRepository PersonRepository => _personRepository.Value;
        public IConnectionRepository ConnectionRepository => _connectionRepository.Value;
        public IConnectionTypeRepository ConnectionTypeRepository => _connectionTypeRepository.Value;
        public IMainRootRepository MainRootRepository => _mainRootRepository.Value;
        public IChildRootRepository ChildRootRepository => _childRootRepository.Value;
        public IUserBranchesRepository UserBranchesRepository => _userBranchesRepository.Value;
        public IBranchMainRootRepository BranchMainRootRepository => _branchMainRootRepository.Value;
        public IBranchChildRootRepository BranchChildRootRepository => _branchChildRootRepository.Value;
        public ISearchCountsRepository SearchCountsRepository => _searchCountsRepository.Value;
        public ISearchCountofCompaniesRepository SearchCountofCompaniesRepository => _searchCountofCompaniesRepository.Value;

        public async Task SaveChanges() => await _context.SaveChangesAsync();
    }
}
