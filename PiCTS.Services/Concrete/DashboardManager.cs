using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PiCTS.Entities.DataTransferObjects.DashboardDTOs.ResponseDTOs;
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
    public class DashboardManager : IDashboardService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly UserManager<User> _userManager;

        public DashboardManager(IRepositoryManager repositoryManager, UserManager<User> userManager)
        {
            _repositoryManager = repositoryManager;
            _userManager = userManager;
        }

        public async Task<DashboardResponseDTO> GetDashboardCounts()
        {
            var companies = await _repositoryManager.CompanyRepository.GetAllCompaniesAsync(false);
            var companiesCount = companies.Count();

            var branhes = await _repositoryManager.BranchRepository.GetAllBranchesAsync(false);
            var branchesCount = branhes.Count();

            var users = await _userManager.Users.ToListAsync();
            var usersCount = users.Where(u => u.IsDeleted != true).Count();

            var connections = await _repositoryManager.ConnectionRepository.GetAllConnectionsAsync(false);
            var connectionsCount = connections.Count();

            var dashboardResponse = new DashboardResponseDTO()
            {
                CompaniesCount = companiesCount,
                BranchesCount = branchesCount,
                UsersCount = usersCount,
                ConnectionsCount = connectionsCount
            };

            return dashboardResponse;
        }
    }
}
