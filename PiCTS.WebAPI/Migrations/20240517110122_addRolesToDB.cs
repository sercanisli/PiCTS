using Microsoft.EntityFrameworkCore.Migrations;

namespace PiCTS.WebAPI.Migrations
{
    public partial class addRolesToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "79372db5-05eb-43e1-86db-7bad33a25758", "da8ceca2-f0e4-42b0-ae1d-9ea485540211", "CreateUser", "CREATEUSER" },
                    { "86d2cad2-79b8-40ef-b531-738857c94556", "967e87e9-9a40-404e-8a5e-cbfc2ec35a84", "EditConnectionType", "EDITCONNECTIONTYPE" },
                    { "4e539359-14f8-4cd8-a97c-861d473156a1", "5a3f8383-c5a8-454e-84b4-98830b3317de", "CreateConnectionType", "CREATECONNECTIONTYPE" },
                    { "3b420646-42ed-43bd-946e-05b87b09850c", "81eacf7d-8fdb-42ab-95bd-91dc30546edf", "ReadConnection", "READCONNECTION" },
                    { "f56aef62-e7ad-48d2-96da-e50bbfa7070f", "fa264bd5-ac0d-430c-a958-6d732408038d", "DeleteConnection", "DELETECONNECTION" },
                    { "a7041098-6540-40d4-9130-2e7fdd22e1fe", "82b1aef4-ef20-45b9-8069-8e85b8f6b2f7", "EditConnection", "EDITCONNECTION" },
                    { "2eb62a9a-1e6c-467e-881d-4612ee6aacc4", "880a72a2-eebf-419d-8bd1-4be73ecbbf12", "CreateConnection", "CREATECONNECTION" },
                    { "f5fd110a-9798-43ee-9f8c-477b7e05f170", "52e13428-bfa0-4606-a529-fc46ad83a3fe", "ReadPerson", "READPERSON" },
                    { "62207483-8ce9-45f7-bc82-3a9ba8d73619", "9dc3fd13-6274-4e0d-9c0b-a2f00dde5393", "DeletePerson", "DELETEPERSON" },
                    { "737cd8fc-a392-4aca-840e-4aa29a09ef55", "a8166380-a047-4261-96ff-4733f7febde4", "EditPerson", "EDITPERSON" },
                    { "3511d6a7-bd73-4302-8572-9722ee5e4244", "d51e72de-32e6-4178-b0b8-53e0a5c58b9d", "CreatePerson", "CREATEPERSON" },
                    { "d3f907e3-8b4a-4268-b8c8-f6a2eaa526cb", "9d5a99e0-e93a-4bab-8ab5-e42e265ebcc4", "ReadBranch", "READBRANCH" },
                    { "5f7722c4-e5ac-43a3-b011-d77893b9bcac", "b4fe279f-4c21-46b3-8c38-dd30ab46b4da", "DeleteBranch", "DELETEBRANCH" },
                    { "a94de6d8-06c2-45e3-b898-ddc34e202c91", "7d65b424-5dc5-418f-b461-2c234a6b4764", "EditBranch", "EDITBRANCH" },
                    { "bbc3551e-2d98-479f-b94c-2b8cc80adedd", "d3bff9b8-6858-4e33-8899-82c47ac6b16e", "CreateBranch", "CREATEBRANCH" },
                    { "905fce84-de15-439c-9af7-2b8190c3809e", "f2d3b45d-3975-46f4-b762-72a6026fb438", "ReadCompany", "READCOMPANY" },
                    { "5337f6e1-66f4-4d71-92e8-e98bce56275a", "757e3fb0-cdc2-4d06-9085-20d7ad09b4ca", "DeleteCompany", "DELETECOMPANY" },
                    { "656884d6-ecb7-4754-9480-da31410eab81", "50e2913d-ccee-4614-b632-1818c46daed1", "EditCompany", "EDITCOMPANY" },
                    { "98f9686a-398c-48a1-b18d-ddd479fae17b", "ed78b0c6-d94b-464a-91b0-0add3249cdff", "CreateCompany", "CREATECOMPANY" },
                    { "cc9efa2a-7291-467e-b037-95c25dd184b6", "12adc433-e82d-4ee6-88ae-8b32644ea21a", "ReadUser", "READUSER" },
                    { "17f1d302-e7c0-466b-ad34-375b028ac7b0", "53c59b19-d32a-412f-ba9b-0fd081e92bf2", "DeleteUser", "DELETEUSER" },
                    { "11f1bd2b-5eb6-4d6f-9984-4a3fbc107330", "b1bb9132-bb79-4a72-abbe-4708eb52003e", "EditUser", "EDITUSER" },
                    { "bb340d70-e761-42d1-8338-8087a208720b", "7820b55e-c229-4723-8ee9-45f47125fcb3", "DeleteConnectionType", "DELETECONNECTIONTYPE" },
                    { "4c88e6ab-e94c-40cf-ba49-d8acd73e340e", "de980011-9a5e-4e51-b843-88f26bbc1ed4", "ReadConnectionType", "READCONNECTIONTYPE" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11f1bd2b-5eb6-4d6f-9984-4a3fbc107330");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17f1d302-e7c0-466b-ad34-375b028ac7b0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2eb62a9a-1e6c-467e-881d-4612ee6aacc4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3511d6a7-bd73-4302-8572-9722ee5e4244");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b420646-42ed-43bd-946e-05b87b09850c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c88e6ab-e94c-40cf-ba49-d8acd73e340e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e539359-14f8-4cd8-a97c-861d473156a1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5337f6e1-66f4-4d71-92e8-e98bce56275a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f7722c4-e5ac-43a3-b011-d77893b9bcac");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62207483-8ce9-45f7-bc82-3a9ba8d73619");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "656884d6-ecb7-4754-9480-da31410eab81");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "737cd8fc-a392-4aca-840e-4aa29a09ef55");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79372db5-05eb-43e1-86db-7bad33a25758");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86d2cad2-79b8-40ef-b531-738857c94556");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "905fce84-de15-439c-9af7-2b8190c3809e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "98f9686a-398c-48a1-b18d-ddd479fae17b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7041098-6540-40d4-9130-2e7fdd22e1fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a94de6d8-06c2-45e3-b898-ddc34e202c91");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb340d70-e761-42d1-8338-8087a208720b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bbc3551e-2d98-479f-b94c-2b8cc80adedd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc9efa2a-7291-467e-b037-95c25dd184b6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3f907e3-8b4a-4268-b8c8-f6a2eaa526cb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f56aef62-e7ad-48d2-96da-e50bbfa7070f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f5fd110a-9798-43ee-9f8c-477b7e05f170");
        }
    }
}
