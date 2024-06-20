using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PiCTS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Repositories.EntityFrameworkCore
{
    public class RepositoryContext : IdentityDbContext<User,Role,string> 
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Connection> Connections { get; set; }
        public DbSet<ConnectionType> ConnectionTypes { get; set; }
        public DbSet<BranchChildRoot> BranchChildRoots { get; set; }
        public DbSet<BranchMainRoot> BranchMainRoots { get; set; }
        public DbSet<MainRoot> MainRoots { get; set; }
        public DbSet<ChildRoot> ChildRoots { get; set; }
        public DbSet<SearchCountofCompanies> SearchCountofCompanies { get; set; }
        public DbSet<SearchCounts> SearchCounts { get; set; }
        public DbSet<UserBranches> UserBranches { get; set; }


        public RepositoryContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
    }
}
