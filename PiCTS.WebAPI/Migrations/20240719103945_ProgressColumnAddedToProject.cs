using Microsoft.EntityFrameworkCore.Migrations;

namespace PiCTS.WebAPI.Migrations
{
    public partial class ProgressColumnAddedToProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Progress",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Progress",
                table: "Projects");
        }
    }
}
