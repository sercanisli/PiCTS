using Microsoft.EntityFrameworkCore.Migrations;

namespace PiCTS.WebAPI.Migrations
{
    public partial class refactoringForUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AspNetUsers");

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
    }
}
