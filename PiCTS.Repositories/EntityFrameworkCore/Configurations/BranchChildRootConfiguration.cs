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
    public class BranchChildRootConfiguration : IEntityTypeConfiguration<BranchChildRoot>
    {
        public void Configure(EntityTypeBuilder<BranchChildRoot> builder)
        {
            builder.ToTable("BranchChildRoots").HasKey(bcr => bcr.Id);
        }
    }
}
