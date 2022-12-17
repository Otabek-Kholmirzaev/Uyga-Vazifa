using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UygaVazifa.API.Data.Migrations
{
    public partial class StudentAnswer_Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("12431733-4e80-439b-b5ff-86e1f8c6f77f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "edbcd6ac-cb0d-4e05-9452-97dfdfc0e275", "AQAAAAEAACcQAAAAEI2eZGk4zNKqvLv7kQCIACNL1TMdxD6m4cRSze/X2MM/HK/abQYFyXHKExd8MFmsvA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23d87b67-68a6-498c-a242-2c69576c00d7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f34e3eef-a943-4ec6-a102-65026773b454", "AQAAAAEAACcQAAAAEJzWgegb4rkOaL71t0QL5FhKQ8tDuNUk/7JbJofEtRNz65cIRlXJzf75hwmiHdlKeA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f73e4f1d-be15-4eab-a1ba-92747d075b54"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e3ab13bb-c1c2-4ffa-be37-750c923615e1", "AQAAAAEAACcQAAAAEAjop/axWIW+bVb45er5KMO2E4Xxdru+o3tJgTpR3apoCBOYatTokiUhHH4P4ALjBQ==" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreatedDate", "HomeworkId", "ParentId", "StudentAnswerId", "Text", "UserId" },
                values: new object[,]
                {
                    { new Guid("e8f4a63b-15c1-4d66-9405-d9273549c493"), new DateTime(2022, 12, 17, 23, 25, 54, 849, DateTimeKind.Utc).AddTicks(5970), new Guid("3bf8c683-c889-405d-b37d-0d198ac8bf7c"), null, null, "Noto`g`ri ishlangan.", new Guid("12431733-4e80-439b-b5ff-86e1f8c6f77f") },
                    { new Guid("f33b569a-bf39-4ebd-a71c-ccdd495a24da"), new DateTime(2022, 12, 17, 23, 25, 54, 849, DateTimeKind.Utc).AddTicks(5950), new Guid("3bf8c683-c889-405d-b37d-0d198ac8bf7c"), null, null, "Ustoz IStringLocalizerdan foydalansam bo`ladimi?", new Guid("12431733-4e80-439b-b5ff-86e1f8c6f77f") }
                });

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: new Guid("3bf8c683-c889-405d-b37d-0d198ac8bf7c"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 17, 23, 25, 54, 849, DateTimeKind.Utc).AddTicks(5756), new DateTime(2022, 12, 19, 23, 25, 54, 849, DateTimeKind.Utc).AddTicks(5766), new DateTime(2022, 12, 18, 23, 25, 54, 849, DateTimeKind.Utc).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: new Guid("f26b793b-74e4-4edc-aa7c-e86e0eb5854f"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 17, 23, 25, 54, 849, DateTimeKind.Utc).AddTicks(5773), new DateTime(2022, 12, 20, 23, 25, 54, 849, DateTimeKind.Utc).AddTicks(5774), new DateTime(2022, 12, 19, 23, 25, 54, 849, DateTimeKind.Utc).AddTicks(5773) });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreatedDate", "HomeworkId", "ParentId", "StudentAnswerId", "Text", "UserId" },
                values: new object[,]
                {
                    { new Guid("1dac93a4-2cac-45c2-9d8a-c241b8ce5a37"), new DateTime(2022, 12, 17, 23, 27, 54, 849, DateTimeKind.Utc).AddTicks(5956), new Guid("3bf8c683-c889-405d-b37d-0d198ac8bf7c"), new Guid("f33b569a-bf39-4ebd-a71c-ccdd495a24da"), null, "Ha, albatta foydalanishing mumkin.", new Guid("f73e4f1d-be15-4eab-a1ba-92747d075b54") },
                    { new Guid("309b1bcf-cb1d-425e-ab4e-bc16d00d3f7a"), new DateTime(2022, 12, 17, 23, 26, 14, 849, DateTimeKind.Utc).AddTicks(5974), new Guid("3bf8c683-c889-405d-b37d-0d198ac8bf7c"), new Guid("e8f4a63b-15c1-4d66-9405-d9273549c493"), null, "Nimasi noto`g`ri ishlangan ustoz?.", new Guid("12431733-4e80-439b-b5ff-86e1f8c6f77f") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("1dac93a4-2cac-45c2-9d8a-c241b8ce5a37"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("309b1bcf-cb1d-425e-ab4e-bc16d00d3f7a"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("e8f4a63b-15c1-4d66-9405-d9273549c493"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("f33b569a-bf39-4ebd-a71c-ccdd495a24da"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("12431733-4e80-439b-b5ff-86e1f8c6f77f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "082b92b1-5edf-4d35-9b05-a35ff85c12ed", "AQAAAAEAACcQAAAAEAnQJ+rJ0xGV0o1fudLSsxAf+a0U3YLUe6zFyV830AgqKH+4QAutpP4npvAMEes/ew==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23d87b67-68a6-498c-a242-2c69576c00d7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eb5aeab3-375e-41e6-a020-6c01b93395a6", "AQAAAAEAACcQAAAAEPkMCuunQt+TbTKXSe8q0GS7Tau9sIp8JkvMzt6WQTXYHbV31YKQ/PTt6fcLbuMrvw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f73e4f1d-be15-4eab-a1ba-92747d075b54"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1e99f11f-7e0a-42c5-ac75-60e59b2c40fb", "AQAAAAEAACcQAAAAENJ3upNgIYOoEKeVbAJvgTy0f1bliDIDecyNewDzvxI733KUrzTZ0m+LcMQGtRTWjQ==" });

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: new Guid("3bf8c683-c889-405d-b37d-0d198ac8bf7c"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 17, 22, 49, 58, 145, DateTimeKind.Utc).AddTicks(4371), new DateTime(2022, 12, 19, 22, 49, 58, 145, DateTimeKind.Utc).AddTicks(4385), new DateTime(2022, 12, 18, 22, 49, 58, 145, DateTimeKind.Utc).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: new Guid("f26b793b-74e4-4edc-aa7c-e86e0eb5854f"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 17, 22, 49, 58, 145, DateTimeKind.Utc).AddTicks(4397), new DateTime(2022, 12, 20, 22, 49, 58, 145, DateTimeKind.Utc).AddTicks(4399), new DateTime(2022, 12, 19, 22, 49, 58, 145, DateTimeKind.Utc).AddTicks(4398) });
        }
    }
}
