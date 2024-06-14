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
    public class ChildRootConfiguration : IEntityTypeConfiguration<ChildRoot>
    {
        public void Configure(EntityTypeBuilder<ChildRoot> builder)
        {
            builder.ToTable("ChildRoots").HasKey(cr => cr.Id);
        }
    }
}
