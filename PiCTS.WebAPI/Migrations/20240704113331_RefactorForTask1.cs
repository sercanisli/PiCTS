using Microsoft.EntityFrameworkCore.Migrations;

namespace PiCTS.WebAPI.Migrations
{
    public partial class RefactorForTask1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Tasks_TasksId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Tasks_TasksId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_TasksId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_TasksId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TasksId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "TasksId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "RandomNumbers",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RandomNumbers",
                table: "Tasks");

            migrationBuilder.AddColumn<int>(
                name: "TasksId",
                table: "Tasks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TasksId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TasksId",
                table: "Tasks",
                column: "TasksId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TasksId",
                table: "AspNetUsers",
                column: "TasksId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Tasks_TasksId",
                table: "AspNetUsers",
                column: "TasksId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Tasks_TasksId",
                table: "Tasks",
                column: "TasksId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
