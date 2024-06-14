using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PiCTS.WebAPI.Migrations
{
    public partial class RefactorForRoots : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "00c91e75-4612-4ecc-9323-ae6be3543f5d");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "0d9428ca-16ee-4d5a-a6e9-793d59568fa2");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "0f448c11-9a5f-4f2f-8adf-fbdf7951d997");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "22b01435-b11b-4504-af9c-22e0e796f58b");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3105cd2e-6a2e-4545-a1cd-77ad5638ff42");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "4bf060cf-400f-4915-b284-3af6b8d9b40b");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "5c306f7c-5ec0-4fb5-b08a-feae72f5c681");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "61ea9ac1-61ac-4ae7-a482-342b1ba37c79");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6707c235-09de-473a-ba53-bd121fce9f5c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6b012de6-050d-4e7e-a797-c5fb529963fa");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "74473369-cf84-49cc-bbe7-8fdff59d88e1");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a438d714-20a1-4c46-8ec5-9794732d2fb3");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a4dd9938-38aa-465d-bd75-213c4e353a94");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "adbbaf76-cf4a-480b-a399-d75baf639066");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c2a8d24f-c626-4ea2-9bc3-160a9ab1c77d");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c5ee96c9-668b-4117-b05a-0a61cd96464f");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c936d995-0b73-4aec-a47e-ecf0263e84b7");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "cf5e97da-85e7-4b6e-bea4-8f370bcf2147");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e7be0fd7-99fe-4402-b3be-89194eacf75c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f38bf440-1caa-4f50-9b5b-2368fcc1ebd1");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f659f05c-611f-41a6-9386-0ab192057591");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f8cef120-7323-4856-b7f7-522acaf27324");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "fe890bd8-dbed-4eea-8d29-5787473ed96b");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ff0e627d-777b-4a73-809c-1066da451979");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "MainRoots",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "MainRoots",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "MainRoots",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "MainRoots",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ChildRoots",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "ChildRoots",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ChildRoots",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "ChildRoots",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ff28c058-62df-41a9-a585-2acc78297da3", "e12768ae-a073-4582-9b20-8380ec9cf009", "CreateUser", "CREATEUSER" },
                    { "459bbe26-0d34-4eb2-9f7b-8ab5cb574000", "36f45496-bcc1-4f98-9c0a-12b4a519c28a", "EditConnectionType", "EDITCONNECTIONTYPE" },
                    { "a65c1683-2ed8-4d25-b68a-4fec58275174", "d682fb53-f425-4b65-a946-bbec521f96ad", "CreateConnectionType", "CREATECONNECTIONTYPE" },
                    { "1e590df4-b219-4bda-b2c0-64d245c47da0", "490d53d7-77f8-4aa5-84c8-80f4272bf9ff", "ReadConnection", "READCONNECTION" },
                    { "f74c0f91-1c47-4151-aca9-7a6a9f02d5ff", "34cfcfe2-d90e-48d0-9e10-b59dd123282a", "DeleteConnection", "DELETECONNECTION" },
                    { "58206b35-a8f6-4c70-8d22-ae8085a28030", "a900a693-8b27-4aca-9406-e4be68812d99", "EditConnection", "EDITCONNECTION" },
                    { "550833cd-a594-4641-895c-177a0de5d30f", "3c39d9c4-6476-48c9-97b2-daace1dbd11f", "CreateConnection", "CREATECONNECTION" },
                    { "215fe2bf-9635-4b2e-be20-30ab8e5bfd9c", "9afc3255-9cdb-4e13-9e46-69470b15b641", "ReadPerson", "READPERSON" },
                    { "de577998-3618-4aa0-ae0a-3cc11bfe2684", "37d70df4-9ec0-467f-8e22-d0a3b5f41df8", "DeletePerson", "DELETEPERSON" },
                    { "f0e4f569-92a2-4cad-8dcb-d5cd8b6d72c0", "594f75b3-2d1a-4a3c-80e5-83407a5e6322", "EditPerson", "EDITPERSON" },
                    { "57776eda-8407-43f8-b628-208a4ca29715", "41a38b23-4465-48d2-92f7-2ce0299c0e33", "CreatePerson", "CREATEPERSON" },
                    { "336e9fff-7d22-4f7b-af37-9eec8e1ab27b", "6637f6f7-f953-4469-a3f7-360b2349a258", "ReadBranch", "READBRANCH" },
                    { "0c1792d7-a909-4f3b-9512-34219d0c8e08", "f86db681-5ffd-4def-9192-e7fdb8b5df31", "DeleteBranch", "DELETEBRANCH" },
                    { "c80adb1c-ea46-440d-9f9a-6692d11d86fa", "f3cf17b0-fc6c-48ac-8b88-bd1c443fecd4", "EditBranch", "EDITBRANCH" },
                    { "137b4a1b-10f5-43a8-b73d-690b63511830", "5ce7639c-ee33-40f4-9c39-2cb0f4da5ab5", "CreateBranch", "CREATEBRANCH" },
                    { "d7c79344-7148-49b3-b6f5-9612624f2829", "26953e09-fb7a-492d-a9ea-d7368ad908f4", "ReadCompany", "READCOMPANY" },
                    { "04a2ce30-0c35-4dda-8b1b-34c257143b2e", "83465456-2ec5-4371-ba29-39453f802aba", "DeleteCompany", "DELETECOMPANY" },
                    { "15a7efc6-845d-474d-b2f7-27db8a41786c", "28ae7c6f-494c-4aab-8486-733830729d0c", "EditCompany", "EDITCOMPANY" },
                    { "bbba959f-e863-4ec2-88a7-8a89aefafc1c", "f41772c8-569d-48e7-9006-23bf4aba5939", "CreateCompany", "CREATECOMPANY" },
                    { "edd3914c-2115-4a2b-8d10-66c5fdea801a", "0c4aed99-0753-4006-a726-9b37e804f478", "ReadUser", "READUSER" },
                    { "59472484-c9ca-47e4-9b96-d9af895f6625", "58caa518-4c9e-4d83-9bd7-ef04f7e7fbf7", "DeleteUser", "DELETEUSER" },
                    { "1a85d29d-0fa8-46d1-bc4f-1f92cb71f976", "88aa1520-5baa-4702-9284-83a87f931670", "EditUser", "EDITUSER" },
                    { "77b4bb9a-3f59-4638-9d27-bf3ea5d190f8", "95112a9e-37a1-4b50-871f-34a831ca74b8", "DeleteConnectionType", "DELETECONNECTIONTYPE" },
                    { "6ecda2e4-3600-4ceb-a54d-98bf04568d0d", "87334c6a-09a9-43ae-9e1f-0384fba0246d", "ReadConnectionType", "READCONNECTIONTYPE" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "04a2ce30-0c35-4dda-8b1b-34c257143b2e");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "0c1792d7-a909-4f3b-9512-34219d0c8e08");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "137b4a1b-10f5-43a8-b73d-690b63511830");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "15a7efc6-845d-474d-b2f7-27db8a41786c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1a85d29d-0fa8-46d1-bc4f-1f92cb71f976");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1e590df4-b219-4bda-b2c0-64d245c47da0");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "215fe2bf-9635-4b2e-be20-30ab8e5bfd9c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "336e9fff-7d22-4f7b-af37-9eec8e1ab27b");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "459bbe26-0d34-4eb2-9f7b-8ab5cb574000");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "550833cd-a594-4641-895c-177a0de5d30f");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "57776eda-8407-43f8-b628-208a4ca29715");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "58206b35-a8f6-4c70-8d22-ae8085a28030");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "59472484-c9ca-47e4-9b96-d9af895f6625");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6ecda2e4-3600-4ceb-a54d-98bf04568d0d");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "77b4bb9a-3f59-4638-9d27-bf3ea5d190f8");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a65c1683-2ed8-4d25-b68a-4fec58275174");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "bbba959f-e863-4ec2-88a7-8a89aefafc1c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c80adb1c-ea46-440d-9f9a-6692d11d86fa");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d7c79344-7148-49b3-b6f5-9612624f2829");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "de577998-3618-4aa0-ae0a-3cc11bfe2684");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "edd3914c-2115-4a2b-8d10-66c5fdea801a");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f0e4f569-92a2-4cad-8dcb-d5cd8b6d72c0");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f74c0f91-1c47-4151-aca9-7a6a9f02d5ff");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ff28c058-62df-41a9-a585-2acc78297da3");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "MainRoots");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "MainRoots");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "MainRoots");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "MainRoots");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ChildRoots");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "ChildRoots");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ChildRoots");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "ChildRoots");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "00c91e75-4612-4ecc-9323-ae6be3543f5d", "0e9f5252-46db-4132-91c8-ccb0ac827158", "CreateUser", "CREATEUSER" },
                    { "6707c235-09de-473a-ba53-bd121fce9f5c", "a361b4ed-0fa2-4bd6-bcbe-0bda404d15e6", "EditConnectionType", "EDITCONNECTIONTYPE" },
                    { "61ea9ac1-61ac-4ae7-a482-342b1ba37c79", "19eadd94-4747-4942-b671-b89b74159f6d", "CreateConnectionType", "CREATECONNECTIONTYPE" },
                    { "6b012de6-050d-4e7e-a797-c5fb529963fa", "b4fe217e-ccaa-4ba1-8c2e-84c8a462dac2", "ReadConnection", "READCONNECTION" },
                    { "0d9428ca-16ee-4d5a-a6e9-793d59568fa2", "198531f9-ec37-418c-bd39-9a428780c9e9", "DeleteConnection", "DELETECONNECTION" },
                    { "f8cef120-7323-4856-b7f7-522acaf27324", "8cbef242-d75f-4d57-be7b-3ffc4938a781", "EditConnection", "EDITCONNECTION" },
                    { "a4dd9938-38aa-465d-bd75-213c4e353a94", "edb92d00-f92b-4fbf-a293-0f94d09a7747", "CreateConnection", "CREATECONNECTION" },
                    { "ff0e627d-777b-4a73-809c-1066da451979", "c46d0c2e-f006-4f1a-82cd-bf887ed091ae", "ReadPerson", "READPERSON" },
                    { "e7be0fd7-99fe-4402-b3be-89194eacf75c", "ab1db3a6-6635-4112-9d46-4c1d38c41faf", "DeletePerson", "DELETEPERSON" },
                    { "22b01435-b11b-4504-af9c-22e0e796f58b", "d3f90e72-64b8-41a2-a289-6a4d26463ddc", "EditPerson", "EDITPERSON" },
                    { "f38bf440-1caa-4f50-9b5b-2368fcc1ebd1", "37b6a812-5ebf-490a-a96d-26ba6f1a1c52", "CreatePerson", "CREATEPERSON" },
                    { "74473369-cf84-49cc-bbe7-8fdff59d88e1", "3e243f5d-e6d9-4f87-8962-468c86dd6f04", "ReadBranch", "READBRANCH" },
                    { "5c306f7c-5ec0-4fb5-b08a-feae72f5c681", "476a2a8f-347e-4940-b6e1-96501d76099c", "DeleteBranch", "DELETEBRANCH" },
                    { "3105cd2e-6a2e-4545-a1cd-77ad5638ff42", "7771e97e-b948-402c-be30-223bfaa2253e", "EditBranch", "EDITBRANCH" },
                    { "4bf060cf-400f-4915-b284-3af6b8d9b40b", "57f92ec6-65d8-43d7-8f9a-778db444d3d8", "CreateBranch", "CREATEBRANCH" },
                    { "c5ee96c9-668b-4117-b05a-0a61cd96464f", "beddc25a-2f2c-4f7a-b760-df4f7315e8f1", "ReadCompany", "READCOMPANY" },
                    { "c936d995-0b73-4aec-a47e-ecf0263e84b7", "2c98f2a0-0e4a-4301-86de-826840ed07f6", "DeleteCompany", "DELETECOMPANY" },
                    { "adbbaf76-cf4a-480b-a399-d75baf639066", "132ce566-6958-40d8-a265-335b8a1d219e", "EditCompany", "EDITCOMPANY" },
                    { "0f448c11-9a5f-4f2f-8adf-fbdf7951d997", "aea11f5a-b979-4eeb-9bdf-c14eb570a4a4", "CreateCompany", "CREATECOMPANY" },
                    { "fe890bd8-dbed-4eea-8d29-5787473ed96b", "60cb3b80-a8f4-4546-860b-ba2915e0a4ae", "ReadUser", "READUSER" },
                    { "c2a8d24f-c626-4ea2-9bc3-160a9ab1c77d", "d736f234-e51c-48bd-abe1-70ece85b2ef5", "DeleteUser", "DELETEUSER" },
                    { "f659f05c-611f-41a6-9386-0ab192057591", "6d713ba7-80f6-4357-bbcc-4be56958f98b", "EditUser", "EDITUSER" },
                    { "a438d714-20a1-4c46-8ec5-9794732d2fb3", "7e737e1a-e516-4f70-a94b-3776a955bc85", "DeleteConnectionType", "DELETECONNECTIONTYPE" },
                    { "cf5e97da-85e7-4b6e-bea4-8f370bcf2147", "ed878b94-2041-4675-b9af-aea4002a5dcd", "ReadConnectionType", "READCONNECTIONTYPE" }
                });
        }
    }
}
