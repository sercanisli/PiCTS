using Microsoft.EntityFrameworkCore.Migrations;

namespace PiCTS.WebAPI.Migrations
{
    public partial class RefactoringForMainRoot2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "036908ab-70d8-44ca-ad60-8114dd746ddb");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2e9ed4a2-3d33-4a06-b854-275c2ca9d6f4");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3ccd58e9-4afa-4f42-9bfc-db5558bbe1b2");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3cdf8903-cd68-4e6b-9a42-b8ae8b52347f");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3f585515-bd41-4599-8ca6-f6788a9de2f5");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "51106f6c-77a5-420f-b1d9-9c1918ea0c25");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "548378c4-d733-4e3a-907d-02d0bf537f06");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "575dda19-b6a7-4f38-9015-616b85eff29a");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "5a9c66df-6a85-41d6-9a2c-7d9bd62dd2f8");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6b4f808b-fb15-43c8-8e61-5c97935c951e");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "717bada0-4919-4e8c-b25d-366702fcc35a");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "76fe6b03-29fd-403d-86e9-f1e71e568243");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "7d2eacb2-cd75-490a-8eed-ed8905c940de");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "7daabfe0-9c7f-47d7-bc19-c84dec98ad22");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "81bbfd9f-8c4d-4671-9039-1f8f36af0b26");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "8d35ab3c-17bf-476b-a9c6-f59ff46d4633");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9e2c0a65-7d9d-4506-a91e-3161532a7bce");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ac928afd-6443-4e81-b7e4-9c41a602f1dc");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "bd04cb7d-4ddb-42ae-9b0e-0bbb3ee413d2");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "cb3f507e-c69b-4309-91c1-4dc7cdc3b700");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d127bbee-4c19-44ff-8b5c-5c92e6340d78");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d18f5dda-ebaf-4097-a15f-22ead41fd599");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ef47970e-55fc-4e3a-8a14-0861adae6162");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f6bd6e7c-2d12-427d-b21d-846c45b4fd41");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "d127bbee-4c19-44ff-8b5c-5c92e6340d78", "fbc07750-120a-452d-9ac2-b678c4ccb594", "CreateUser", "CREATEUSER" },
                    { "bd04cb7d-4ddb-42ae-9b0e-0bbb3ee413d2", "679ba99c-6a43-4fb1-b00d-245d539dee1d", "EditConnectionType", "EDITCONNECTIONTYPE" },
                    { "7d2eacb2-cd75-490a-8eed-ed8905c940de", "fd112ab1-d02f-4ee8-8af0-2361fdbb6f1a", "CreateConnectionType", "CREATECONNECTIONTYPE" },
                    { "ef47970e-55fc-4e3a-8a14-0861adae6162", "d040dc6b-68df-49e8-b99f-798181594cf8", "ReadConnection", "READCONNECTION" },
                    { "6b4f808b-fb15-43c8-8e61-5c97935c951e", "a99240f2-9c73-4739-bd0b-14eeb22de5a3", "DeleteConnection", "DELETECONNECTION" },
                    { "cb3f507e-c69b-4309-91c1-4dc7cdc3b700", "27377924-dc0d-4c56-9baa-107d0b1522b2", "EditConnection", "EDITCONNECTION" },
                    { "76fe6b03-29fd-403d-86e9-f1e71e568243", "beae927c-fcbe-4c43-93be-b2f4459c92ea", "CreateConnection", "CREATECONNECTION" },
                    { "ac928afd-6443-4e81-b7e4-9c41a602f1dc", "1af11e16-86ff-4ac3-abeb-2c8bd21d20d0", "ReadPerson", "READPERSON" },
                    { "3ccd58e9-4afa-4f42-9bfc-db5558bbe1b2", "e3322468-2099-48df-92c4-5dd0ee773111", "DeletePerson", "DELETEPERSON" },
                    { "5a9c66df-6a85-41d6-9a2c-7d9bd62dd2f8", "08636f25-abe0-4558-8f30-37bb9525e5f4", "EditPerson", "EDITPERSON" },
                    { "3cdf8903-cd68-4e6b-9a42-b8ae8b52347f", "ddb7d027-caa7-4d8b-bd7c-0ea8e93a6b48", "CreatePerson", "CREATEPERSON" },
                    { "7daabfe0-9c7f-47d7-bc19-c84dec98ad22", "2673cccd-1e77-4075-92fa-cfcf24051137", "ReadBranch", "READBRANCH" },
                    { "3f585515-bd41-4599-8ca6-f6788a9de2f5", "8daa00fb-8536-4e36-a434-5251c0c9781d", "DeleteBranch", "DELETEBRANCH" },
                    { "81bbfd9f-8c4d-4671-9039-1f8f36af0b26", "9e470aaf-f2a7-4442-9dbf-0418753e3f21", "EditBranch", "EDITBRANCH" },
                    { "9e2c0a65-7d9d-4506-a91e-3161532a7bce", "a3348226-0bfa-4fdf-8189-2d198160937c", "CreateBranch", "CREATEBRANCH" },
                    { "d18f5dda-ebaf-4097-a15f-22ead41fd599", "b48af7c3-ba87-4d37-88a8-2247041c343a", "ReadCompany", "READCOMPANY" },
                    { "51106f6c-77a5-420f-b1d9-9c1918ea0c25", "35c10431-68f4-4ad4-b225-71fe0023438f", "DeleteCompany", "DELETECOMPANY" },
                    { "2e9ed4a2-3d33-4a06-b854-275c2ca9d6f4", "4475dc26-03e9-45d8-b31d-1396131883ca", "EditCompany", "EDITCOMPANY" },
                    { "717bada0-4919-4e8c-b25d-366702fcc35a", "ba9e498e-6163-442f-a789-362bf3b77b52", "CreateCompany", "CREATECOMPANY" },
                    { "8d35ab3c-17bf-476b-a9c6-f59ff46d4633", "4a9a9c54-01f8-46a5-8dcb-9fa180c5f80d", "ReadUser", "READUSER" },
                    { "575dda19-b6a7-4f38-9015-616b85eff29a", "288d5ad2-1b5c-464e-8e79-5bdcc2e9bd9c", "DeleteUser", "DELETEUSER" },
                    { "548378c4-d733-4e3a-907d-02d0bf537f06", "8c760c42-58ce-4355-a6f1-7f0702c62eb0", "EditUser", "EDITUSER" },
                    { "036908ab-70d8-44ca-ad60-8114dd746ddb", "d65d4089-b55c-437f-89eb-257ab155f2eb", "DeleteConnectionType", "DELETECONNECTIONTYPE" },
                    { "f6bd6e7c-2d12-427d-b21d-846c45b4fd41", "89f95412-66bc-40e2-a639-9c6b38e4c785", "ReadConnectionType", "READCONNECTIONTYPE" }
                });
        }
    }
}
