using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PiCTS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Repositories.EntityFrameworkCore.Configurations
{
    public class UserBranchesConfiguration : IEntityTypeConfiguration<UserBranches>
    {
        public void Configure(EntityTypeBuilder<UserBranches> builder)
        {
            builder.ToTable("UserBranches");
            builder.HasKey(ub => new { ub.UserId, ub.BranchId });
        }
    }
}
