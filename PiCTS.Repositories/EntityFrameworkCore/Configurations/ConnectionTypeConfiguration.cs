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
    public class ConnectionTypeConfiguration : IEntityTypeConfiguration<ConnectionType>
    {
        public void Configure(EntityTypeBuilder<ConnectionType> builder)
        {
            builder.ToTable("ConnectionTypes").HasKey(ct => ct.Id);

            builder.HasIndex(indexExpression: ct => ct.Id);
        }
    }
}
