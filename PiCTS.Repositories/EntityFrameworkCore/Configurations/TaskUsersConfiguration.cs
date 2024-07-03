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
    public class TaskUsersConfiguration : IEntityTypeConfiguration<TaskUsers>
    {
        public void Configure(EntityTypeBuilder<TaskUsers> builder)
        {
            builder.ToTable("TaskUsers");
            builder.HasKey(tu => new { tu.TaskId, tu.UserId });
        }
    }
}
