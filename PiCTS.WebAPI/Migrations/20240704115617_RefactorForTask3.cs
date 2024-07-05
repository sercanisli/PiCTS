using Microsoft.EntityFrameworkCore.Migrations;

namespace PiCTS.WebAPI.Migrations
{
    public partial class RefactorForTask3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TaskName",
                table: "Tasks",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Tasks",
                newName: "Start");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "Tasks",
                newName: "End");

            migrationBuilder.AddColumn<double>(
                name: "Progress",
                table: "Tasks",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Progress",
                table: "Tasks");

            migrationBuilder.RenameColumn(
                name: "Start",
                table: "Tasks",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Tasks",
                newName: "TaskName");

            migrationBuilder.RenameColumn(
                name: "End",
                table: "Tasks",
                newName: "EndDate");
        }
    }
}
