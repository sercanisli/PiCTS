using Microsoft.EntityFrameworkCore.Migrations;

namespace PiCTS.WebAPI.Migrations
{
    public partial class RefactoringForMainRoot3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "09df0d58-1463-4cbf-a7cd-9ce5db3a3c3b");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "25b82c67-e22b-4695-b527-44a483982006");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "30f8a3b1-4fb0-469b-a480-427e580e7104");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3968638d-94fc-4d4a-b804-605ab70f819e");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "40879ed5-c904-4d38-9ded-4bbb319d001e");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "46dba540-c013-4952-b395-772fb9f354c0");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "4ef78241-e1e9-4902-9b8d-3f19fc269ab4");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "56f0998c-42aa-4b0b-b4c3-f89f1375a853");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "660a1d38-1a9d-410e-99ad-82fdb8fa47ad");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "67422a19-0366-44e9-a49b-21f7cd03e121");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "72767629-bb85-40e7-9208-0235adb090b3");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "72e924cf-4692-4586-9115-b91c26c3b9ac");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "7dba741e-79e6-4e72-9dcc-d6d0addfcc6f");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "836c7f3f-7346-41df-a197-8104f29237af");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "8907c37b-1e96-45d8-8d07-7d9aeffc3607");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "8fbdba19-0aab-4581-a1a2-c13e1ef76ad5");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b0071e99-4706-4cdd-90f3-4ba0e4bf5c86");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "bbde7b3d-9413-4e98-b35a-b151fa55ed4a");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c09d3117-d312-4f92-bd27-8045b14587fe");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c21cf2c3-20a6-48e3-ad5e-a1773be3abef");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "cb0128ca-9598-4d1b-ae80-d09d13fedfaf");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d59ea91b-09c0-4fb7-a2e8-9c07f88cd074");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ea94eb39-93aa-4ca7-aba5-82ef985cbc68");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ef9dc7d4-8a06-4d65-85a1-4289e647bb1c");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "f486736d-a313-4071-96fd-191c5387d1b8", "e7aa8975-521b-4955-bf75-64076756e84b", "CreateUser", "CREATEUSER" },
                    { "7b2035d8-5e7e-47ff-80b7-d3c603fc6464", "b94eb2e1-6373-4ee8-932d-4cc4c84611dc", "EditConnectionType", "EDITCONNECTIONTYPE" },
                    { "8ac2c3e3-a297-4756-8660-359461b28de5", "be34cb27-3915-4b65-95b9-2d5d638a58d3", "CreateConnectionType", "CREATECONNECTIONTYPE" },
                    { "21c5fa8d-8511-4199-a083-cda68d49a185", "2de5fb47-0a8f-4242-8e1c-dcb7d289e0de", "ReadConnection", "READCONNECTION" },
                    { "353c95fa-45cf-4f9c-80cb-36cdbedff1bc", "504f4a70-02f8-45f6-8e7f-d2d371b47417", "DeleteConnection", "DELETECONNECTION" },
                    { "06f564dc-8d39-4e66-870f-abb77626996f", "3d55196f-8b3d-4915-972f-4b0adc858475", "EditConnection", "EDITCONNECTION" },
                    { "ad1c68a3-47a0-443a-b2c3-3df005396a64", "65380c0c-5141-4d5f-9e0e-f6fc0f7ddb4e", "CreateConnection", "CREATECONNECTION" },
                    { "3c2f2a8c-7b6a-47cf-9ef8-2a6f38e544c3", "49b8f728-3713-49b0-8146-9835a9f6ac94", "ReadPerson", "READPERSON" },
                    { "623fb41f-8171-4068-8ece-28f472c99300", "14f9a36f-82e1-49d8-ac0e-8943f341c063", "DeletePerson", "DELETEPERSON" },
                    { "180cdc5e-b934-4361-94c4-8a5f20efe288", "9c2eff0e-ef90-47ff-a78d-21339532697b", "EditPerson", "EDITPERSON" },
                    { "b6cf1f23-20bd-4900-84b2-7b32cd1bc160", "0218848a-b18b-4821-a54f-84e7c16ca940", "CreatePerson", "CREATEPERSON" },
                    { "e44760a0-6348-49dc-9658-8dc1f47ad1bb", "e9e19f2d-85ed-43d9-b441-f91c80db2d24", "ReadBranch", "READBRANCH" },
                    { "076253a0-0536-46ce-bda9-b3866c1ede6a", "1884ccd9-5ec2-4a48-be74-c91246f605ef", "DeleteBranch", "DELETEBRANCH" },
                    { "39d51e69-8911-4b6d-97ee-9e542e766b0e", "dc21f1c8-5dee-4d0e-bee3-6d18f5141556", "EditBranch", "EDITBRANCH" },
                    { "bc4b41d7-1bd8-4c00-8765-a93d64930406", "c275824b-b3e0-4507-af84-aa67e4baed35", "CreateBranch", "CREATEBRANCH" },
                    { "f2b974a7-f7e9-48c4-bd76-70284ffd8526", "7a8c171a-e838-4857-a5cb-93ccefcb5bee", "ReadCompany", "READCOMPANY" },
                    { "c953aa2f-e724-4d63-a25e-5c93967a432b", "b5746eaf-1738-4a8d-a421-896dc3fa2d2b", "DeleteCompany", "DELETECOMPANY" },
                    { "994650da-770b-460a-8d0a-3c89a75c14f3", "b197319f-5456-4a9e-8afa-e028859c9fcc", "EditCompany", "EDITCOMPANY" },
                    { "3706fcbf-b1d8-4397-940c-0c57381e6792", "112e2102-2fbc-469f-a468-c3baf1c9febc", "CreateCompany", "CREATECOMPANY" },
                    { "e3024863-bc88-4727-af3f-c4dc1a16d783", "1bf30f38-246f-4f71-b901-3603f5516852", "ReadUser", "READUSER" },
                    { "9c37b6af-a70d-4963-abfd-cf54476fefb5", "7b0f409e-baa1-44b0-bed6-ae8139add974", "DeleteUser", "DELETEUSER" },
                    { "b7b3a561-3912-44ef-9a41-017588185607", "1aff0177-6ef4-4550-afc3-1813c359b44b", "EditUser", "EDITUSER" },
                    { "aa0755de-32bf-40b2-8f52-4ea360c04fbb", "7fc320c7-9517-490f-9104-1ea65cd6ac03", "DeleteConnectionType", "DELETECONNECTIONTYPE" },
                    { "b5780e29-5d46-4bdc-9da1-0b3fb4c07d58", "545cfa1a-4978-4892-87b4-b76a84ae89e4", "ReadConnectionType", "READCONNECTIONTYPE" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "06f564dc-8d39-4e66-870f-abb77626996f");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "076253a0-0536-46ce-bda9-b3866c1ede6a");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "180cdc5e-b934-4361-94c4-8a5f20efe288");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "21c5fa8d-8511-4199-a083-cda68d49a185");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "353c95fa-45cf-4f9c-80cb-36cdbedff1bc");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3706fcbf-b1d8-4397-940c-0c57381e6792");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "39d51e69-8911-4b6d-97ee-9e542e766b0e");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3c2f2a8c-7b6a-47cf-9ef8-2a6f38e544c3");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "623fb41f-8171-4068-8ece-28f472c99300");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "7b2035d8-5e7e-47ff-80b7-d3c603fc6464");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "8ac2c3e3-a297-4756-8660-359461b28de5");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "994650da-770b-460a-8d0a-3c89a75c14f3");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9c37b6af-a70d-4963-abfd-cf54476fefb5");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "aa0755de-32bf-40b2-8f52-4ea360c04fbb");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ad1c68a3-47a0-443a-b2c3-3df005396a64");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b5780e29-5d46-4bdc-9da1-0b3fb4c07d58");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b6cf1f23-20bd-4900-84b2-7b32cd1bc160");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b7b3a561-3912-44ef-9a41-017588185607");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "bc4b41d7-1bd8-4c00-8765-a93d64930406");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c953aa2f-e724-4d63-a25e-5c93967a432b");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e3024863-bc88-4727-af3f-c4dc1a16d783");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e44760a0-6348-49dc-9658-8dc1f47ad1bb");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f2b974a7-f7e9-48c4-bd76-70284ffd8526");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f486736d-a313-4071-96fd-191c5387d1b8");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "836c7f3f-7346-41df-a197-8104f29237af", "8495c9a3-cf9d-4fe0-8b1e-063b2e88bf65", "CreateUser", "CREATEUSER" },
                    { "b0071e99-4706-4cdd-90f3-4ba0e4bf5c86", "445314cc-dea1-4f97-9e0d-225dcd93d7ca", "EditConnectionType", "EDITCONNECTIONTYPE" },
                    { "4ef78241-e1e9-4902-9b8d-3f19fc269ab4", "456cbce8-c8bb-47b7-854a-670650f0eef9", "CreateConnectionType", "CREATECONNECTIONTYPE" },
                    { "ef9dc7d4-8a06-4d65-85a1-4289e647bb1c", "c3a33f5d-d0fa-4621-bfea-de7b60158748", "ReadConnection", "READCONNECTION" },
                    { "56f0998c-42aa-4b0b-b4c3-f89f1375a853", "f485338e-da83-40d2-9dcf-8f890bdbd679", "DeleteConnection", "DELETECONNECTION" },
                    { "30f8a3b1-4fb0-469b-a480-427e580e7104", "ebeda62e-ee56-419b-b934-e9bd9bd10132", "EditConnection", "EDITCONNECTION" },
                    { "40879ed5-c904-4d38-9ded-4bbb319d001e", "dbd1624b-24e6-4534-892f-6feaaaff9b08", "CreateConnection", "CREATECONNECTION" },
                    { "660a1d38-1a9d-410e-99ad-82fdb8fa47ad", "1870739b-eb28-4cda-a470-ecc554ff7ef4", "ReadPerson", "READPERSON" },
                    { "c09d3117-d312-4f92-bd27-8045b14587fe", "76896f24-387d-4093-af5c-464eac51a69f", "DeletePerson", "DELETEPERSON" },
                    { "8907c37b-1e96-45d8-8d07-7d9aeffc3607", "b663d87e-7b04-4b68-a33a-54d692c99cf7", "EditPerson", "EDITPERSON" },
                    { "3968638d-94fc-4d4a-b804-605ab70f819e", "10be05e5-bc54-4bd3-b0ba-a17c3118794b", "CreatePerson", "CREATEPERSON" },
                    { "72e924cf-4692-4586-9115-b91c26c3b9ac", "ffee3419-03c5-48be-bbfc-6155107f26cb", "ReadBranch", "READBRANCH" },
                    { "72767629-bb85-40e7-9208-0235adb090b3", "681a8384-38dd-4084-9860-093b7f5fda34", "DeleteBranch", "DELETEBRANCH" },
                    { "d59ea91b-09c0-4fb7-a2e8-9c07f88cd074", "48c3061d-de4d-41b7-9bfd-206af1842ea2", "EditBranch", "EDITBRANCH" },
                    { "c21cf2c3-20a6-48e3-ad5e-a1773be3abef", "46f1a578-1cbc-4d24-9b14-d2ccae4f32ed", "CreateBranch", "CREATEBRANCH" },
                    { "cb0128ca-9598-4d1b-ae80-d09d13fedfaf", "090b1345-911a-4609-8da0-1b424136f171", "ReadCompany", "READCOMPANY" },
                    { "7dba741e-79e6-4e72-9dcc-d6d0addfcc6f", "74227a4d-f885-4c2d-b410-f8a4793aca2c", "DeleteCompany", "DELETECOMPANY" },
                    { "09df0d58-1463-4cbf-a7cd-9ce5db3a3c3b", "676604c3-372c-48e7-851e-fb36c375fc09", "EditCompany", "EDITCOMPANY" },
                    { "25b82c67-e22b-4695-b527-44a483982006", "b2f04ece-1e3a-4e3e-ba8d-8d421d8e9e8f", "CreateCompany", "CREATECOMPANY" },
                    { "ea94eb39-93aa-4ca7-aba5-82ef985cbc68", "6612bcd2-a309-440f-8f5b-5a35969d7903", "ReadUser", "READUSER" },
                    { "46dba540-c013-4952-b395-772fb9f354c0", "80e2ec40-617c-4690-8f25-5a0ac696f7c6", "DeleteUser", "DELETEUSER" },
                    { "8fbdba19-0aab-4581-a1a2-c13e1ef76ad5", "2d6e0fa4-ad50-4a30-8f08-d2799ea4e867", "EditUser", "EDITUSER" },
                    { "bbde7b3d-9413-4e98-b35a-b151fa55ed4a", "acba5955-3644-47c2-8408-c39d9b709250", "DeleteConnectionType", "DELETECONNECTIONTYPE" },
                    { "67422a19-0366-44e9-a49b-21f7cd03e121", "cd0580ef-52a8-48d8-ad99-5f01126ca5d1", "ReadConnectionType", "READCONNECTIONTYPE" }
                });
        }
    }
}
