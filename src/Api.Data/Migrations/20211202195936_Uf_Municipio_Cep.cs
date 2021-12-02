using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Uf_Municipio_Cep : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ee41a5f6-ece1-4900-87a2-695fa864a542"));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("1109ab04-a3a5-476e-bdce-6c3e2c2badee"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 35, 930, DateTimeKind.Utc).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("1dd25850-6270-48f8-8b77-2f0f079480ab"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 35, 930, DateTimeKind.Utc).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("22ffbd18-cdb9-45cc-97b0-51e97700bf71"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 35, 930, DateTimeKind.Utc).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("27f7a92b-1979-4e1c-be9d-cd3bb73552a8"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 35, 930, DateTimeKind.Utc).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("29eec4d3-b061-427d-894f-7f0fecc7f65f"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 35, 930, DateTimeKind.Utc).AddTicks(1221));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("3739969c-fd8a-4411-9faa-3f718ca85e70"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 35, 930, DateTimeKind.Utc).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("409b9043-88a4-4e86-9cca-ca1fb0d0d35b"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 35, 930, DateTimeKind.Utc).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("43a0f783-a042-4c46-8688-5dd4489d2ec7"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 35, 930, DateTimeKind.Utc).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("542668d1-50ba-4fca-bbc3-4b27af108ea3"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 35, 930, DateTimeKind.Utc).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("57a9e9f7-9aea-40fe-a783-65d4feb59fa8"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 35, 930, DateTimeKind.Utc).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("5abca453-d035-4766-a81b-9f73d683a54b"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 35, 930, DateTimeKind.Utc).AddTicks(1204));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("5ff1b59e-11e7-414d-827e-609dc5f7e333"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 35, 930, DateTimeKind.Utc).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("7cc33300-586e-4be8-9a4d-bd9f01ee9ad8"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 35, 930, DateTimeKind.Utc).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("837a64d3-c649-4172-a4e0-2b20d3c85224"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 35, 930, DateTimeKind.Utc).AddTicks(1212));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("8411e9bc-d3b2-4a9b-9d15-78633d64fc7c"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 35, 930, DateTimeKind.Utc).AddTicks(1223));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("88970a32-3a2a-4a95-8a18-2087b65f59d1"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 35, 930, DateTimeKind.Utc).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("924e7250-7d39-4e8b-86bf-a8578cbf4002"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 35, 930, DateTimeKind.Utc).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("971dcb34-86ea-4f92-989d-064f749e23c9"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 35, 930, DateTimeKind.Utc).AddTicks(1252));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("9fd3c97a-dc68-4af5-bc65-694cca0f2869"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 35, 930, DateTimeKind.Utc).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("ad5969bd-82dc-4e23-ace2-d8495935dd2e"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 35, 930, DateTimeKind.Utc).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("b81f95e0-f226-4afd-9763-290001637ed4"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 35, 930, DateTimeKind.Utc).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("bd08208b-bfca-47a4-9cd0-37e4e1fa5006"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 35, 930, DateTimeKind.Utc).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("c623f804-37d8-4a19-92c1-67fd162862e6"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 35, 930, DateTimeKind.Utc).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("cb9e6888-2094-45ee-bc44-37ced33c693a"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 35, 930, DateTimeKind.Utc).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("e7e416de-477c-4fa3-a541-b5af5f35ccf6"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 35, 930, DateTimeKind.Utc).AddTicks(1249));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("f85a6cd0-2237-46b1-a103-d3494ab27774"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 35, 930, DateTimeKind.Utc).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("fe8ca516-034f-4249-bc5a-31c85ef220ea"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 35, 930, DateTimeKind.Utc).AddTicks(1247));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("db4a4cd4-04ef-4fca-a913-6dda4d788b5e"), new DateTime(2021, 12, 2, 16, 59, 35, 926, DateTimeKind.Local).AddTicks(4373), "admin@mail.com", "Administrador", new DateTime(2021, 12, 2, 16, 59, 35, 927, DateTimeKind.Local).AddTicks(6991) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("db4a4cd4-04ef-4fca-a913-6dda4d788b5e"));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("1109ab04-a3a5-476e-bdce-6c3e2c2badee"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 2, 320, DateTimeKind.Utc).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("1dd25850-6270-48f8-8b77-2f0f079480ab"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 2, 320, DateTimeKind.Utc).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("22ffbd18-cdb9-45cc-97b0-51e97700bf71"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 2, 320, DateTimeKind.Utc).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("27f7a92b-1979-4e1c-be9d-cd3bb73552a8"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 2, 320, DateTimeKind.Utc).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("29eec4d3-b061-427d-894f-7f0fecc7f65f"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 2, 320, DateTimeKind.Utc).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("3739969c-fd8a-4411-9faa-3f718ca85e70"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 2, 320, DateTimeKind.Utc).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("409b9043-88a4-4e86-9cca-ca1fb0d0d35b"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 2, 320, DateTimeKind.Utc).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("43a0f783-a042-4c46-8688-5dd4489d2ec7"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 2, 320, DateTimeKind.Utc).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("542668d1-50ba-4fca-bbc3-4b27af108ea3"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 2, 320, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("57a9e9f7-9aea-40fe-a783-65d4feb59fa8"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 2, 320, DateTimeKind.Utc).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("5abca453-d035-4766-a81b-9f73d683a54b"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 2, 320, DateTimeKind.Utc).AddTicks(9589));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("5ff1b59e-11e7-414d-827e-609dc5f7e333"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 2, 320, DateTimeKind.Utc).AddTicks(9591));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("7cc33300-586e-4be8-9a4d-bd9f01ee9ad8"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 2, 320, DateTimeKind.Utc).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("837a64d3-c649-4172-a4e0-2b20d3c85224"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 2, 320, DateTimeKind.Utc).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("8411e9bc-d3b2-4a9b-9d15-78633d64fc7c"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 2, 320, DateTimeKind.Utc).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("88970a32-3a2a-4a95-8a18-2087b65f59d1"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 2, 320, DateTimeKind.Utc).AddTicks(9626));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("924e7250-7d39-4e8b-86bf-a8578cbf4002"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 2, 320, DateTimeKind.Utc).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("971dcb34-86ea-4f92-989d-064f749e23c9"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 2, 320, DateTimeKind.Utc).AddTicks(9635));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("9fd3c97a-dc68-4af5-bc65-694cca0f2869"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 2, 320, DateTimeKind.Utc).AddTicks(9624));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("ad5969bd-82dc-4e23-ace2-d8495935dd2e"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 2, 320, DateTimeKind.Utc).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("b81f95e0-f226-4afd-9763-290001637ed4"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 2, 320, DateTimeKind.Utc).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("bd08208b-bfca-47a4-9cd0-37e4e1fa5006"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 2, 320, DateTimeKind.Utc).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("c623f804-37d8-4a19-92c1-67fd162862e6"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 2, 320, DateTimeKind.Utc).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("cb9e6888-2094-45ee-bc44-37ced33c693a"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 2, 320, DateTimeKind.Utc).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("e7e416de-477c-4fa3-a541-b5af5f35ccf6"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 2, 320, DateTimeKind.Utc).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("f85a6cd0-2237-46b1-a103-d3494ab27774"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 2, 320, DateTimeKind.Utc).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("fe8ca516-034f-4249-bc5a-31c85ef220ea"),
                column: "CreateAt",
                value: new DateTime(2021, 12, 2, 19, 59, 2, 320, DateTimeKind.Utc).AddTicks(9630));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("ee41a5f6-ece1-4900-87a2-695fa864a542"), new DateTime(2021, 12, 2, 16, 59, 2, 317, DateTimeKind.Local).AddTicks(4231), "admin@mail.com", "Administrador", new DateTime(2021, 12, 2, 16, 59, 2, 318, DateTimeKind.Local).AddTicks(6083) });
        }
    }
}
