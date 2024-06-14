using Microsoft.EntityFrameworkCore.Migrations;

namespace PiCTS.WebAPI.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Connections_Branches_BranchId",
                table: "Connections");

            migrationBuilder.DropForeignKey(
                name: "FK_Connections_ConnectionTypes_ConnectionTypeId",
                table: "Connections");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ConnectionTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ConnectionTypeId",
                table: "Connections",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BranchId",
                table: "Connections",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Connections_Branches_BranchId",
                table: "Connections",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Connections_ConnectionTypes_ConnectionTypeId",
                table: "Connections",
                column: "ConnectionTypeId",
                principalTable: "ConnectionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Connections_Branches_BranchId",
                table: "Connections");

            migrationBuilder.DropForeignKey(
                name: "FK_Connections_ConnectionTypes_ConnectionTypeId",
                table: "Connections");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ConnectionTypes");

            migrationBuilder.AlterColumn<int>(
                name: "ConnectionTypeId",
                table: "Connections",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BranchId",
                table: "Connections",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Connections_Branches_BranchId",
                table: "Connections",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Connections_ConnectionTypes_ConnectionTypeId",
                table: "Connections",
                column: "ConnectionTypeId",
                principalTable: "ConnectionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
