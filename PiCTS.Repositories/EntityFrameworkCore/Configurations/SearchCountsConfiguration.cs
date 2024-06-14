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
    public class SearchCountsConfiguration : IEntityTypeConfiguration<SearchCounts>
    {
        public void Configure(EntityTypeBuilder<SearchCounts> builder)
        {
            builder.ToTable("SearchCounts").HasKey(sc => sc.Id);
        }
    }
}
