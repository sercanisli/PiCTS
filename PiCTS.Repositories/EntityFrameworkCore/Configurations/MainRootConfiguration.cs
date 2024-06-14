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
    public class MainRootConfiguration : IEntityTypeConfiguration<MainRoot>
    {
        public void Configure(EntityTypeBuilder<MainRoot> builder)
        {
            builder.ToTable("MainRoots").HasKey(mr => mr.Id);

            builder.HasMany(mr => mr.Children);
        }
    }
}
