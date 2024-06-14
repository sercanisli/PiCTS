using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PiCTS.WebAPI.Migrations
{
    public partial class addRefreshTokenFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6b2b347e-89a5-43c9-bf14-79f66bf6c451", "bd91643d-6630-4f14-a541-35e86be5c45f", "CreateUser", "CREATEUSER" },
                    { "b2907576-4487-4b2d-87b9-ef1ecc453307", "15d2b1cb-1405-46de-8a05-a0e6760ed388", "EditConnectionType", "EDITCONNECTIONTYPE" },
                    { "a45ce565-90e7-496f-9a8c-6c4569e85c75", "02b2d369-9d3a-4591-b55a-f85b43a06710", "CreateConnectionType", "CREATECONNECTIONTYPE" },
                    { "5dd047e3-2759-4141-928e-5a9264333dac", "cb04b0d8-c8aa-41bc-b494-33a4e174433c", "ReadConnection", "READCONNECTION" },
                    { "66077ef4-6cdf-4e68-ba4b-ce95714a2aef", "de2db42a-f1b9-4327-8992-779e83843a08", "DeleteConnection", "DELETECONNECTION" },
                    { "a690659c-d84a-41ea-bef5-2c1bdcf59401", "80a54e7f-6693-4ea1-9a96-f982f28d3c0f", "EditConnection", "EDITCONNECTION" },
                    { "276fc5e2-e311-4c89-bf65-a65f62fa8322", "2eca7854-a0b1-4958-85c2-3b78ad3a622d", "CreateConnection", "CREATECONNECTION" },
                    { "3b4b961a-475d-46a6-86c7-1aebd91baca3", "973044b1-5599-4a8d-9683-0ca5813c51ca", "ReadPerson", "READPERSON" },
                    { "4ac97d64-5896-4ec4-a64a-65d520389a06", "e4a30a1f-d071-424d-a049-9d8cd42e5729", "DeletePerson", "DELETEPERSON" },
                    { "285fd58d-dbac-44ba-bca0-eaebcc521f12", "c844e843-6f2b-4635-a118-198681006fed", "EditPerson", "EDITPERSON" },
                    { "ffa1753b-e28a-4d07-9779-a4891e7ed204", "e9b51326-5769-4609-a47d-3ad666b3209f", "CreatePerson", "CREATEPERSON" },
                    { "8877297b-b927-4766-9762-fcf221173de3", "facd925e-1c9c-4b16-9b99-eba46136cab7", "ReadBranch", "READBRANCH" },
                    { "fb815bb4-0f72-40a9-99db-fdaa27a38ec9", "d4f4e540-1abc-46f6-8f17-19e404af0659", "DeleteBranch", "DELETEBRANCH" },
                    { "7c118c5b-4f10-4ce2-a94b-6ceaa6ed670d", "7312d108-d16f-47b5-af96-e0717276f469", "EditBranch", "EDITBRANCH" },
                    { "6b5ad876-85d2-4a0a-95c9-ea0de6948fd8", "9b0ef9db-c38b-44a7-9ac3-c4423b5cfcc8", "CreateBranch", "CREATEBRANCH" },
                    { "dd28dc3c-2c23-4acd-96b4-b88ebedd32fd", "303f9269-e4bd-4dae-93a3-1c5fe40f7044", "ReadCompany", "READCOMPANY" },
                    { "1ae46b18-338b-4d22-971c-ebf50a74407c", "83267a65-0c57-4fdb-8af2-432c5a6bc550", "DeleteCompany", "DELETECOMPANY" },
                    { "c6499e2f-607a-4f65-a131-86b238809d04", "43fe6cc3-0195-42d5-bd24-bf2434755f9f", "EditCompany", "EDITCOMPANY" },
                    { "1aed294f-1259-4cce-acc4-4293724795ed", "89aa6bfc-7688-4abb-9637-d625c9132bc3", "CreateCompany", "CREATECOMPANY" },
                    { "9cc1b82e-efeb-4e73-9f7e-3c564ab024fc", "ea9276c8-c2a5-4ec5-98a5-35d54f0b421c", "ReadUser", "READUSER" },
                    { "614e0fb5-6ec4-4956-9663-6a58be3318e3", "9da1a2de-ad25-46ed-a5f7-d2aa88f22bd2", "DeleteUser", "DELETEUSER" },
                    { "ef86fd5f-310f-4989-9be1-0ebf7e6511df", "9053eaef-012c-4177-9bf0-05b2a51258c6", "EditUser", "EDITUSER" },
                    { "db8f618d-f3de-4619-8bee-7f8caa7697a0", "a52df2c1-cc7c-4420-b432-69d98def9fea", "DeleteConnectionType", "DELETECONNECTIONTYPE" },
                    { "4355a380-dfc4-476d-8d9b-bf7fc91416d0", "fc8a9655-056f-429d-becd-53b3d35f9591", "ReadConnectionType", "READCONNECTIONTYPE" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ae46b18-338b-4d22-971c-ebf50a74407c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1aed294f-1259-4cce-acc4-4293724795ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "276fc5e2-e311-4c89-bf65-a65f62fa8322");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "285fd58d-dbac-44ba-bca0-eaebcc521f12");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b4b961a-475d-46a6-86c7-1aebd91baca3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4355a380-dfc4-476d-8d9b-bf7fc91416d0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ac97d64-5896-4ec4-a64a-65d520389a06");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5dd047e3-2759-4141-928e-5a9264333dac");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "614e0fb5-6ec4-4956-9663-6a58be3318e3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66077ef4-6cdf-4e68-ba4b-ce95714a2aef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b2b347e-89a5-43c9-bf14-79f66bf6c451");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b5ad876-85d2-4a0a-95c9-ea0de6948fd8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c118c5b-4f10-4ce2-a94b-6ceaa6ed670d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8877297b-b927-4766-9762-fcf221173de3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9cc1b82e-efeb-4e73-9f7e-3c564ab024fc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a45ce565-90e7-496f-9a8c-6c4569e85c75");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a690659c-d84a-41ea-bef5-2c1bdcf59401");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2907576-4487-4b2d-87b9-ef1ecc453307");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6499e2f-607a-4f65-a131-86b238809d04");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db8f618d-f3de-4619-8bee-7f8caa7697a0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd28dc3c-2c23-4acd-96b4-b88ebedd32fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef86fd5f-310f-4989-9be1-0ebf7e6511df");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb815bb4-0f72-40a9-99db-fdaa27a38ec9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffa1753b-e28a-4d07-9779-a4891e7ed204");

            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers");

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
    }
}
