using Microsoft.EntityFrameworkCore.Migrations;

namespace PiCTS.WebAPI.Migrations
{
    public partial class RefactoringForMainRoot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
