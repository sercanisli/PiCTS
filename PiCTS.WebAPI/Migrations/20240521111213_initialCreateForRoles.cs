using Microsoft.EntityFrameworkCore.Migrations;

namespace PiCTS.WebAPI.Migrations
{
    public partial class initialCreateForRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "011d71ac-bfa6-4a28-8a07-b59a52fd072a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19331728-4161-42fa-9e22-0ba9baef74fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1faee0a2-1483-4afc-86e3-fb2a400b0aa0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26e0eed0-a1e1-4cd3-8176-04667dbc4ab5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a88c1c9-bfbd-4fdd-b987-5cae3b37b318");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cae14c6-d3b1-44c9-bd8e-bd19d2a97465");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e223698-ee6e-4c27-99c4-a20bd8af77f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f924847-4fb2-4d74-87fb-af25200dad75");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d1ff09b-05d4-49b3-9910-205f4af0c060");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78d78279-e783-4748-8c36-2e00ee05561a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c843011-d55c-49ab-8bae-88e0f6182f0c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81f22f6f-1a39-438b-bf54-0dd6913daa1e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f51aa0e-255b-4d9b-a360-4a9c5342e353");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f594b03-d406-48f3-abe7-f6e999bda39a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c02dc503-c957-4cdc-a7a4-755def05e33c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c350dfa9-74eb-4c24-b21a-df91e753d421");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d017308b-bf1e-4670-8079-0092b1ab3976");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3589693-443b-4509-84c8-f2e93292567a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d57209dc-c477-43ee-bbb9-72d662842a7a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6fbd006-e536-42d3-aa1c-5124c01ad394");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed08ba42-4a50-4945-8bdb-80f1af21b6cd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee18f032-f72b-475a-bff2-2b0eca000e4a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc9c3828-d54a-4b0a-9092-118934fa2128");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fec29cda-50c1-42d4-bc18-4178bf145b71");

            migrationBuilder.AddColumn<string>(
                name: "ParentKey",
                table: "AspNetRoles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "IdentityRole",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "50128add-1800-4002-97c9-eb0c47ff01bc", "a9c9c092-df31-4ce4-9901-408f7a367000", "CreateUser", "CREATEUSER" },
                    { "27d57a68-57c2-4985-860e-a3a23d08dfc6", "fe60c836-3cce-4890-aea9-077e8b6823cd", "EditConnectionType", "EDITCONNECTIONTYPE" },
                    { "a503114f-770f-46f9-a83e-215f04c88d95", "5189d73f-a14b-4e2f-ac56-988ba5d1dcbb", "CreateConnectionType", "CREATECONNECTIONTYPE" },
                    { "776e6f49-6e6a-408e-af43-192912b52eb3", "a1db34fa-2198-4433-9b2f-fb0a438090ee", "ReadConnection", "READCONNECTION" },
                    { "1bbd52b7-6050-4beb-95c3-de7e7612a806", "8479696d-0f89-4f11-86c5-143eec273074", "DeleteConnection", "DELETECONNECTION" },
                    { "3d49dde6-273e-40eb-8f74-70213b2769f2", "02cd73fc-8dd2-43d9-b30c-62229657c217", "EditConnection", "EDITCONNECTION" },
                    { "980c6810-5874-4f4f-a891-cde8cc55abcb", "15271c3a-6fb5-4e3b-98d6-3d4512fbfb2a", "CreateConnection", "CREATECONNECTION" },
                    { "64e7c709-4761-4171-b1a2-45ea0a2e2a51", "2faa9265-a81b-441c-bf75-41eb7aa1c14b", "ReadPerson", "READPERSON" },
                    { "06f45806-070c-4150-9906-aa64f5fb83d3", "a4f2d434-cb90-4e11-8491-5a6212f07029", "DeletePerson", "DELETEPERSON" },
                    { "4aeb4d5e-8eb6-49c3-96ac-ba18cfcd2b0e", "be58f176-e540-40ae-8faf-67beaa37a8b8", "EditPerson", "EDITPERSON" },
                    { "fcb030d3-fe18-4f9a-bea3-8255171fc741", "5890b7a2-64cc-4e0d-8355-1f08f2ec6884", "CreatePerson", "CREATEPERSON" },
                    { "8e9e0d09-5a89-40be-b51d-bf1a16082701", "2a722031-ab7f-43d4-a46c-fea6d92f13ad", "ReadBranch", "READBRANCH" },
                    { "4e63b77e-9b68-4481-b7de-837d5e600356", "ed9394df-f88c-4962-8f40-91ec25e7d44a", "DeleteBranch", "DELETEBRANCH" },
                    { "398192f1-8d60-414e-adbf-b908aaabecc0", "a458ea56-0dcb-4f3d-b81f-6be86f43c000", "EditBranch", "EDITBRANCH" },
                    { "40c472d5-e1fd-47cf-b7b0-360bcc9a6a4c", "549dda26-8835-4f4d-acff-4d72bdc2f75a", "CreateBranch", "CREATEBRANCH" },
                    { "5c532fd3-bc81-4fbb-9f5f-a8a9efb4d17d", "8ec17d42-bd32-4377-8fb9-875ee0ded36f", "ReadCompany", "READCOMPANY" },
                    { "f6890c4f-ab0a-43c8-a709-ad15a87489fd", "a2ec9536-d283-47ec-87a4-1f9cf1ea49d9", "DeleteCompany", "DELETECOMPANY" },
                    { "60abfa76-4edf-448a-915b-bafdddf8aed7", "938c3dd5-ba92-4370-973b-79bec24ebb9a", "EditCompany", "EDITCOMPANY" },
                    { "25632edb-22f2-464c-820a-d131da3a4717", "4639b856-796f-401e-92c4-5a7018d49008", "CreateCompany", "CREATECOMPANY" },
                    { "50cc3c56-ef0d-4d06-afc2-66a544e9cffe", "31be1703-7c7e-42b1-baa2-874e823cc2a0", "ReadUser", "READUSER" },
                    { "796fd7b9-8c61-43dd-8198-ddfa61852d9c", "0ee37c7f-7115-4356-9e20-3d29423892f8", "DeleteUser", "DELETEUSER" },
                    { "c9c4b408-b446-43c7-8968-c192e33de7fe", "dc02620e-da83-4aaa-b859-b151534363dd", "EditUser", "EDITUSER" },
                    { "5e76654e-e70c-4f97-b3e7-d731e14c4770", "b00af35b-d294-4717-be91-5ae10c353bc8", "DeleteConnectionType", "DELETECONNECTIONTYPE" },
                    { "805bfc1d-1fda-4518-ad0e-16a28b375dbd", "76c1ccd7-8a52-423e-91eb-f0e057ab578d", "ReadConnectionType", "READCONNECTIONTYPE" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityRole");

            migrationBuilder.DropColumn(
                name: "ParentKey",
                table: "AspNetRoles");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9f594b03-d406-48f3-abe7-f6e999bda39a", "aa703dda-f5d7-4815-89e0-b0493829ad3b", "CreateUser", "CREATEUSER" },
                    { "81f22f6f-1a39-438b-bf54-0dd6913daa1e", "52e1262a-e189-476d-bc90-edbeae40c960", "EditConnectionType", "EDITCONNECTIONTYPE" },
                    { "c350dfa9-74eb-4c24-b21a-df91e753d421", "b5931e6b-fefd-4d2e-a235-3d869d981375", "CreateConnectionType", "CREATECONNECTIONTYPE" },
                    { "3cae14c6-d3b1-44c9-bd8e-bd19d2a97465", "79341433-747f-4abf-bbd6-7d9e8b2e2cba", "ReadConnection", "READCONNECTION" },
                    { "1faee0a2-1483-4afc-86e3-fb2a400b0aa0", "5ddbc299-f51f-42f2-a5c9-645a09e5483a", "DeleteConnection", "DELETECONNECTION" },
                    { "26e0eed0-a1e1-4cd3-8176-04667dbc4ab5", "9d09cf12-58e2-44b6-8060-0645a7757fd1", "EditConnection", "EDITCONNECTION" },
                    { "5f924847-4fb2-4d74-87fb-af25200dad75", "c61a2eac-3c28-465d-a071-6d5480575cc4", "CreateConnection", "CREATECONNECTION" },
                    { "e6fbd006-e536-42d3-aa1c-5124c01ad394", "404f249e-dec6-4185-9f15-0ca126dd945d", "ReadPerson", "READPERSON" },
                    { "d3589693-443b-4509-84c8-f2e93292567a", "2774e025-48d9-4777-94d2-01619f33bb0e", "DeletePerson", "DELETEPERSON" },
                    { "c02dc503-c957-4cdc-a7a4-755def05e33c", "e7d9c000-9e5b-4f07-b3da-7ae3c559f5b2", "EditPerson", "EDITPERSON" },
                    { "011d71ac-bfa6-4a28-8a07-b59a52fd072a", "82f1d86d-a1c1-4c09-80f9-c5514ce493c8", "CreatePerson", "CREATEPERSON" },
                    { "ee18f032-f72b-475a-bff2-2b0eca000e4a", "9173c352-036a-4070-81b1-2ae43412919f", "ReadBranch", "READBRANCH" },
                    { "5e223698-ee6e-4c27-99c4-a20bd8af77f3", "0aef7fc7-8766-4a1f-8d09-77646eb0df14", "DeleteBranch", "DELETEBRANCH" },
                    { "78d78279-e783-4748-8c36-2e00ee05561a", "a046d7d8-7c59-4eb8-a3e8-ebb9bcc8f839", "EditBranch", "EDITBRANCH" },
                    { "ed08ba42-4a50-4945-8bdb-80f1af21b6cd", "89526b4f-8231-41f5-9495-87d231c9ddaf", "CreateBranch", "CREATEBRANCH" },
                    { "8f51aa0e-255b-4d9b-a360-4a9c5342e353", "f7eb7200-7d4f-4b5f-a05b-f4772a5ce4db", "ReadCompany", "READCOMPANY" },
                    { "fec29cda-50c1-42d4-bc18-4178bf145b71", "c11c2f7a-6b2d-4430-b764-e2a27c346524", "DeleteCompany", "DELETECOMPANY" },
                    { "fc9c3828-d54a-4b0a-9092-118934fa2128", "b4c6dc4c-fc3b-45eb-ab4d-4bb17d1b8a4d", "EditCompany", "EDITCOMPANY" },
                    { "d57209dc-c477-43ee-bbb9-72d662842a7a", "8e7377dd-c8b0-4ce6-8057-98c93e1e8993", "CreateCompany", "CREATECOMPANY" },
                    { "19331728-4161-42fa-9e22-0ba9baef74fd", "0e663a09-3b3d-436f-b486-5f4a5a3c09a3", "ReadUser", "READUSER" },
                    { "6d1ff09b-05d4-49b3-9910-205f4af0c060", "3252ea2a-1666-4d21-9f07-08b44a2578b6", "DeleteUser", "DELETEUSER" },
                    { "2a88c1c9-bfbd-4fdd-b987-5cae3b37b318", "d4aca387-f930-48ab-b3ae-8ed0fb22b6f3", "EditUser", "EDITUSER" },
                    { "7c843011-d55c-49ab-8bae-88e0f6182f0c", "aebd9e37-af5e-458e-9549-525c6a56a3fd", "DeleteConnectionType", "DELETECONNECTIONTYPE" },
                    { "d017308b-bf1e-4670-8079-0092b1ab3976", "6d244e6a-d5a5-4074-beaa-b6d0fda35a2b", "ReadConnectionType", "READCONNECTIONTYPE" }
                });
        }
    }
}
