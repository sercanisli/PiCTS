using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiCTS.Repositories.EntityFrameworkCore.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                    new IdentityRole
                    {
                        Name= "CreateUser",
                        NormalizedName = "CREATEUSER"
                    },
                    new IdentityRole
                    {
                        Name = "EditUser",
                        NormalizedName = "EDITUSER"
                    },
                    new IdentityRole
                    {
                        Name = "DeleteUser",
                        NormalizedName = "DELETEUSER"
                    },
                    new IdentityRole
                    {
                        Name = "ReadUser",
                        NormalizedName ="READUSER"
                    },
                    new IdentityRole
                    {
                        Name = "CreateCompany",
                        NormalizedName = "CREATECOMPANY"
                    },
                    new IdentityRole
                    {
                        Name = "EditCompany",
                        NormalizedName = "EDITCOMPANY"
                    },
                    new IdentityRole
                    {
                        Name = "DeleteCompany",
                        NormalizedName = "DELETECOMPANY"
                    },
                    new IdentityRole
                    {
                        Name = "ReadCompany",
                        NormalizedName = "READCOMPANY"
                    },
                    new IdentityRole
                    {
                        Name = "CreateBranch",
                        NormalizedName = "CREATEBRANCH"
                    },
                    new IdentityRole
                    {
                        Name = "EditBranch",
                        NormalizedName = "EDITBRANCH"
                    },
                    new IdentityRole
                    {
                        Name = "DeleteBranch",
                        NormalizedName = "DELETEBRANCH"
                    },
                    new IdentityRole
                    {
                        Name = "ReadBranch",
                        NormalizedName = "READBRANCH"
                    },
                    new IdentityRole
                    {
                        Name = "CreatePerson",
                        NormalizedName = "CREATEPERSON"
                    },
                    new IdentityRole
                    {
                        Name = "EditPerson",
                        NormalizedName = "EDITPERSON"
                    },
                    new IdentityRole
                    {
                        Name = "DeletePerson",
                        NormalizedName = "DELETEPERSON"
                    },
                    new IdentityRole
                    {
                        Name = "ReadPerson",
                        NormalizedName = "READPERSON"
                    },
                    new IdentityRole
                    {
                        Name = "CreateConnection",
                        NormalizedName = "CREATECONNECTION"
                    },
                    new IdentityRole
                    {
                        Name = "EditConnection",
                        NormalizedName = "EDITCONNECTION"
                    },
                    new IdentityRole
                    {
                        Name = "DeleteConnection",
                        NormalizedName = "DELETECONNECTION"
                    },
                    new IdentityRole
                    {
                        Name = "ReadConnection",
                        NormalizedName = "READCONNECTION"
                    },
                    new IdentityRole
                    {
                        Name = "CreateConnectionType",
                        NormalizedName = "CREATECONNECTIONTYPE"
                    },
                    new IdentityRole
                    {
                        Name = "EditConnectionType",
                        NormalizedName = "EDITCONNECTIONTYPE"
                    },
                    new IdentityRole
                    {
                        Name = "DeleteConnectionType",
                        NormalizedName = "DELETECONNECTIONTYPE"
                    },
                    new IdentityRole
                    {
                        Name = "ReadConnectionType",
                        NormalizedName = "READCONNECTIONTYPE"
                    }
                );
        }
    }
}
