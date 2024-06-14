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
    class SearchCountofCompaniesConfiguration : IEntityTypeConfiguration<SearchCountofCompanies>
    {
        public void Configure(EntityTypeBuilder<SearchCountofCompanies> builder)
        {
            builder.ToTable("SearchCountsofCompanies").HasKey(scoc => scoc.Id);

            builder.HasOne(scoc => scoc.Company);
        }
    }
}
