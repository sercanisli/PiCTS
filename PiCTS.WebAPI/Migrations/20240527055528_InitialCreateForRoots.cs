using Microsoft.EntityFrameworkCore.Migrations;

namespace PiCTS.WebAPI.Migrations
{
    public partial class InitialCreateForRoots : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "06f45806-070c-4150-9906-aa64f5fb83d3");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1bbd52b7-6050-4beb-95c3-de7e7612a806");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "25632edb-22f2-464c-820a-d131da3a4717");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "27d57a68-57c2-4985-860e-a3a23d08dfc6");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "398192f1-8d60-414e-adbf-b908aaabecc0");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3d49dde6-273e-40eb-8f74-70213b2769f2");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "40c472d5-e1fd-47cf-b7b0-360bcc9a6a4c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "4aeb4d5e-8eb6-49c3-96ac-ba18cfcd2b0e");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "4e63b77e-9b68-4481-b7de-837d5e600356");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "50128add-1800-4002-97c9-eb0c47ff01bc");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "50cc3c56-ef0d-4d06-afc2-66a544e9cffe");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "5c532fd3-bc81-4fbb-9f5f-a8a9efb4d17d");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "5e76654e-e70c-4f97-b3e7-d731e14c4770");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "60abfa76-4edf-448a-915b-bafdddf8aed7");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "64e7c709-4761-4171-b1a2-45ea0a2e2a51");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "776e6f49-6e6a-408e-af43-192912b52eb3");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "796fd7b9-8c61-43dd-8198-ddfa61852d9c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "805bfc1d-1fda-4518-ad0e-16a28b375dbd");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "8e9e0d09-5a89-40be-b51d-bf1a16082701");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "980c6810-5874-4f4f-a891-cde8cc55abcb");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a503114f-770f-46f9-a83e-215f04c88d95");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c9c4b408-b446-43c7-8968-c192e33de7fe");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f6890c4f-ab0a-43c8-a709-ad15a87489fd");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "fcb030d3-fe18-4f9a-bea3-8255171fc741");

            migrationBuilder.CreateTable(
                name: "MainRoots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Checked = table.Column<bool>(type: "bit", nullable: false),
                    PartialChecked = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainRoots", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChildRoots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainRootId = table.Column<int>(type: "int", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Checked = table.Column<bool>(type: "bit", nullable: false),
                    PartialChecked = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChildRoots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChildRoots_MainRoots_MainRootId",
                        column: x => x.MainRootId,
                        principalTable: "MainRoots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ChildRoots_MainRootId",
                table: "ChildRoots",
                column: "MainRootId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChildRoots");

            migrationBuilder.DropTable(
                name: "MainRoots");

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
    }
}
