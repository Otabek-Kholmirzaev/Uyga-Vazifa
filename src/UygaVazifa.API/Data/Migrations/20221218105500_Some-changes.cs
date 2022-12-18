using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UygaVazifa.API.Data.Migrations
{
    public partial class Somechanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserHomework",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    HomeworkId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserHomework", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserHomework_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserHomework_Homeworks_HomeworkId",
                        column: x => x.HomeworkId,
                        principalTable: "Homeworks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("12431733-4e80-439b-b5ff-86e1f8c6f77f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b15b805a-677b-40c0-91ab-fefc2b6a13f2", "AQAAAAEAACcQAAAAEAFDDtdsnCqhQfdRx8KtzfbKEgcxLE8iJLt13uAeL6kCYlE5DXhmEdYBPtL76VpvAw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23d87b67-68a6-498c-a242-2c69576c00d7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6f9c4c2b-1352-46b1-8d58-4aca917bea33", "AQAAAAEAACcQAAAAEJKildNCRe+7Glce4gDiwxITeR44utFW2CPSE0fMkNiubbg/DEXtvu0GYFQ8sRqhtQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f73e4f1d-be15-4eab-a1ba-92747d075b54"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1f179f15-b6fb-4dbd-9097-addff38f15f1", "AQAAAAEAACcQAAAAEFzqDKITn5DSLl6dKefLT11mko6EjKKAS2w+6t/ZQ7uaYaxr3N+f6416QUeciRml0w==" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("1dac93a4-2cac-45c2-9d8a-c241b8ce5a37"),
                column: "CreatedDate",
                value: new DateTime(2022, 12, 18, 10, 56, 59, 414, DateTimeKind.Utc).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("309b1bcf-cb1d-425e-ab4e-bc16d00d3f7a"),
                column: "CreatedDate",
                value: new DateTime(2022, 12, 18, 10, 55, 19, 414, DateTimeKind.Utc).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("e8f4a63b-15c1-4d66-9405-d9273549c493"),
                column: "CreatedDate",
                value: new DateTime(2022, 12, 18, 10, 54, 59, 414, DateTimeKind.Utc).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("f33b569a-bf39-4ebd-a71c-ccdd495a24da"),
                column: "CreatedDate",
                value: new DateTime(2022, 12, 18, 10, 54, 59, 414, DateTimeKind.Utc).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: new Guid("3bf8c683-c889-405d-b37d-0d198ac8bf7c"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 18, 10, 54, 59, 414, DateTimeKind.Utc).AddTicks(5347), new DateTime(2022, 12, 20, 10, 54, 59, 414, DateTimeKind.Utc).AddTicks(5359), new DateTime(2022, 12, 19, 10, 54, 59, 414, DateTimeKind.Utc).AddTicks(5352) });

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: new Guid("f26b793b-74e4-4edc-aa7c-e86e0eb5854f"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 18, 10, 54, 59, 414, DateTimeKind.Utc).AddTicks(5370), new DateTime(2022, 12, 21, 10, 54, 59, 414, DateTimeKind.Utc).AddTicks(5373), new DateTime(2022, 12, 20, 10, 54, 59, 414, DateTimeKind.Utc).AddTicks(5371) });

            migrationBuilder.CreateIndex(
                name: "IX_UserHomework_HomeworkId",
                table: "UserHomework",
                column: "HomeworkId");

            migrationBuilder.CreateIndex(
                name: "IX_UserHomework_UserId",
                table: "UserHomework",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserHomework");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("12431733-4e80-439b-b5ff-86e1f8c6f77f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b06deeb5-5429-4989-b747-6525102ae2ca", "AQAAAAEAACcQAAAAEEKWC3JVNI8M4cM/uRGE4gUmRLsqGxRBNGu2FmrcNur2hDYgvIEUy2zu6i1/BeoHOw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23d87b67-68a6-498c-a242-2c69576c00d7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c0293a59-26ee-47c8-90e6-94cad259bc33", "AQAAAAEAACcQAAAAEOgV1B8IfCf//JoyEV9egsjRIbONYOyE2/4kub6iO72gOICLI0AjQQPgyJjwAuzEIQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f73e4f1d-be15-4eab-a1ba-92747d075b54"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c960ac7d-d975-4c75-b051-2dbdffad2f3f", "AQAAAAEAACcQAAAAEF4QDJ65V2r6yauTpVqcR+FJqvTuyGR7ProzMzKCP8GHgEGMRYX0j/QKZ8+T2x5u+A==" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("1dac93a4-2cac-45c2-9d8a-c241b8ce5a37"),
                column: "CreatedDate",
                value: new DateTime(2022, 12, 18, 3, 10, 58, 344, DateTimeKind.Utc).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("309b1bcf-cb1d-425e-ab4e-bc16d00d3f7a"),
                column: "CreatedDate",
                value: new DateTime(2022, 12, 18, 3, 9, 18, 344, DateTimeKind.Utc).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("e8f4a63b-15c1-4d66-9405-d9273549c493"),
                column: "CreatedDate",
                value: new DateTime(2022, 12, 18, 3, 8, 58, 344, DateTimeKind.Utc).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("f33b569a-bf39-4ebd-a71c-ccdd495a24da"),
                column: "CreatedDate",
                value: new DateTime(2022, 12, 18, 3, 8, 58, 344, DateTimeKind.Utc).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: new Guid("3bf8c683-c889-405d-b37d-0d198ac8bf7c"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 18, 3, 8, 58, 344, DateTimeKind.Utc).AddTicks(3682), new DateTime(2022, 12, 20, 3, 8, 58, 344, DateTimeKind.Utc).AddTicks(3699), new DateTime(2022, 12, 19, 3, 8, 58, 344, DateTimeKind.Utc).AddTicks(3687) });

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: new Guid("f26b793b-74e4-4edc-aa7c-e86e0eb5854f"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 18, 3, 8, 58, 344, DateTimeKind.Utc).AddTicks(3710), new DateTime(2022, 12, 21, 3, 8, 58, 344, DateTimeKind.Utc).AddTicks(3713), new DateTime(2022, 12, 20, 3, 8, 58, 344, DateTimeKind.Utc).AddTicks(3711) });
        }
    }
}
