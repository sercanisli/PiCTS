using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PiCTS.WebAPI.Migrations
{
    public partial class addmigrationrefactorinForUserEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0763f1b9-43b3-4850-a179-3483d6c51bc7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d19ab6a-2054-4947-84b1-41c875701cbb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ea86a14-7d6e-48ab-96b5-d654a185b6c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1021b178-4de9-427d-b3c9-558842d8d2dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18c836c6-eef7-4e22-9814-0a0ee514d22c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24ae883a-6623-4a89-97b9-988d524975ee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38fe8663-7640-40ad-b60e-ca479c8d4b44");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ddefd1f-70b6-4fdb-9c5e-28bf9a5fbf78");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4439b8c3-f704-4495-a991-a11fe244886b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d8db8ba-48e5-4ca1-8f4d-134345bb4024");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "573c29a4-f53d-4988-95c4-24b8c523b959");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c739616-f13c-4eb9-986a-bf7b7c6dfdc1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70244936-b91c-43b2-b8d4-55b4420f4547");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "822fa8a5-e221-44d8-bd4e-4a332d0094b5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "861e41bc-98ac-4f57-badf-30c1557fd941");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c750bb8-af11-4daf-9f63-c2315b8380b2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d3d18c2-b5d2-4d0e-a305-b3dbe8979623");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a27de950-f7e8-4f68-81e5-7f368da0db2c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b50ea778-ffe8-44f5-8054-dd3a27f9cbe8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b73df39e-c660-48f5-950c-c7a523c7dc07");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b834559b-bdb0-4f3e-be25-1ef17f43378b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be0a965e-4a3e-4a62-b221-e2171f2b4939");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4c6b743-faff-44af-abdc-8f98317e18b3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb92abc2-e502-434b-ad2e-3bf0ba4f5f22");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b50ea778-ffe8-44f5-8054-dd3a27f9cbe8", "12ed4893-54bc-46b5-9cab-b6d4c80173c9", "CreateUser", "CREATEUSER" },
                    { "0763f1b9-43b3-4850-a179-3483d6c51bc7", "fbe23d1d-5523-4434-a68d-614cd6f93049", "EditConnectionType", "EDITCONNECTIONTYPE" },
                    { "38fe8663-7640-40ad-b60e-ca479c8d4b44", "307f915f-23ac-49c6-9598-83dab9b700de", "CreateConnectionType", "CREATECONNECTIONTYPE" },
                    { "6c739616-f13c-4eb9-986a-bf7b7c6dfdc1", "66a69977-e58a-418c-a7ae-ee368b001202", "ReadConnection", "READCONNECTION" },
                    { "b73df39e-c660-48f5-950c-c7a523c7dc07", "1932ef8a-7835-4535-946f-6f9da6349318", "DeleteConnection", "DELETECONNECTION" },
                    { "18c836c6-eef7-4e22-9814-0a0ee514d22c", "69e28b43-5d16-4d3e-af91-6754be231f1e", "EditConnection", "EDITCONNECTION" },
                    { "4d8db8ba-48e5-4ca1-8f4d-134345bb4024", "a1c0e833-b4e6-476d-af96-c93f5dbafe1a", "CreateConnection", "CREATECONNECTION" },
                    { "861e41bc-98ac-4f57-badf-30c1557fd941", "cda3d5bc-4345-4380-8872-42dcd0617cc2", "ReadPerson", "READPERSON" },
                    { "0d19ab6a-2054-4947-84b1-41c875701cbb", "130f41dc-a3f3-425c-9d60-91210847acc7", "DeletePerson", "DELETEPERSON" },
                    { "573c29a4-f53d-4988-95c4-24b8c523b959", "002d12b8-a2dc-4def-b5c1-f25caa4993dc", "EditPerson", "EDITPERSON" },
                    { "0ea86a14-7d6e-48ab-96b5-d654a185b6c4", "b7a8ef63-8585-4889-a5f7-5e9014b95931", "CreatePerson", "CREATEPERSON" },
                    { "24ae883a-6623-4a89-97b9-988d524975ee", "770511d2-d9e8-4910-a52d-64564cac47c5", "ReadBranch", "READBRANCH" },
                    { "70244936-b91c-43b2-b8d4-55b4420f4547", "566f8639-0141-485c-b1ab-bc10ff1f9ea8", "DeleteBranch", "DELETEBRANCH" },
                    { "9c750bb8-af11-4daf-9f63-c2315b8380b2", "127d6022-290b-4ef8-8748-c99d1a0dc890", "EditBranch", "EDITBRANCH" },
                    { "eb92abc2-e502-434b-ad2e-3bf0ba4f5f22", "1abbef1d-d592-44f6-862a-c0d46e78e3e7", "CreateBranch", "CREATEBRANCH" },
                    { "1021b178-4de9-427d-b3c9-558842d8d2dc", "31f3db01-b82c-4f37-8394-6f9799166711", "ReadCompany", "READCOMPANY" },
                    { "9d3d18c2-b5d2-4d0e-a305-b3dbe8979623", "fe23e61f-e606-4b40-90a1-c212e48a7af8", "DeleteCompany", "DELETECOMPANY" },
                    { "4439b8c3-f704-4495-a991-a11fe244886b", "80578a33-157b-4ab6-a92a-67bd6224db20", "EditCompany", "EDITCOMPANY" },
                    { "b834559b-bdb0-4f3e-be25-1ef17f43378b", "293f84a0-5ab7-4e0d-a473-8ee42e5505c0", "CreateCompany", "CREATECOMPANY" },
                    { "a27de950-f7e8-4f68-81e5-7f368da0db2c", "a69d60be-319b-4b72-88c2-60c80f00fb02", "ReadUser", "READUSER" },
                    { "d4c6b743-faff-44af-abdc-8f98317e18b3", "21eca79d-6a82-4436-a066-c264484e96e3", "DeleteUser", "DELETEUSER" },
                    { "be0a965e-4a3e-4a62-b221-e2171f2b4939", "99e4caf7-e68d-4d41-b281-261fe3dbe516", "EditUser", "EDITUSER" },
                    { "3ddefd1f-70b6-4fdb-9c5e-28bf9a5fbf78", "0c340ee4-8610-48f4-8ab4-547c1d6cbe60", "DeleteConnectionType", "DELETECONNECTIONTYPE" },
                    { "822fa8a5-e221-44d8-bd4e-4a332d0094b5", "20844dbc-318f-4723-b5a6-321405afe321", "ReadConnectionType", "READCONNECTIONTYPE" }
                });
        }
    }
}
