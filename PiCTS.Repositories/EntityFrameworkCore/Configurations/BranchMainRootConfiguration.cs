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
    public class BranchMainRootConfiguration : IEntityTypeConfiguration<BranchMainRoot>
    {
        public void Configure(EntityTypeBuilder<BranchMainRoot> builder)
        {
            builder.ToTable("BranchMainRoots").HasKey(bmr => bmr.Id);

            builder.HasMany(bmr => bmr.Children);
        }
    }
}
