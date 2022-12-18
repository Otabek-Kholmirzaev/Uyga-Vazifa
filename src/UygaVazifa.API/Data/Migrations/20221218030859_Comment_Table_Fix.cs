using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UygaVazifa.API.Data.Migrations
{
    public partial class Comment_Table_Fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "StudentAnswers",
                keyColumn: "Id",
                keyValue: new Guid("5f9e5563-9682-4f03-985f-e772368cb4e9"),
                column: "HomeworkId",
                value: new Guid("3bf8c683-c889-405d-b37d-0d198ac8bf7c"));

            migrationBuilder.UpdateData(
                table: "StudentAnswers",
                keyColumn: "Id",
                keyValue: new Guid("b73a1b86-47b9-4553-9ad9-eb52ea9719b9"),
                column: "HomeworkId",
                value: new Guid("3bf8c683-c889-405d-b37d-0d198ac8bf7c"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("12431733-4e80-439b-b5ff-86e1f8c6f77f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "58831201-4834-4b1d-973f-7570a091f054", "AQAAAAEAACcQAAAAEDwJK4b+gVS1jNf2ldoK7fFZYYAv+kks/7KEKLXwhCnhSveMu+qlcQbk0OZmVcDtUw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23d87b67-68a6-498c-a242-2c69576c00d7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "deb17bd1-0582-41bf-be5b-6841dbd1ab82", "AQAAAAEAACcQAAAAEMVyeF7k/rn84Ftb41xRgS84cO1V8Io0DWUqL7U2wmdM11TNq47rkCRNMEfpWjT8DA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f73e4f1d-be15-4eab-a1ba-92747d075b54"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8a05d043-5ee9-4185-ab36-b7c44796d48f", "AQAAAAEAACcQAAAAEFq1kzZ0hC2JjubEr39Kf2V30T4WnB7+TeK+M89fdnqLLHvvmAPC7phYa9iKKMpOXQ==" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("1dac93a4-2cac-45c2-9d8a-c241b8ce5a37"),
                column: "CreatedDate",
                value: new DateTime(2022, 12, 18, 3, 7, 44, 234, DateTimeKind.Utc).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("309b1bcf-cb1d-425e-ab4e-bc16d00d3f7a"),
                column: "CreatedDate",
                value: new DateTime(2022, 12, 18, 3, 6, 4, 234, DateTimeKind.Utc).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("e8f4a63b-15c1-4d66-9405-d9273549c493"),
                column: "CreatedDate",
                value: new DateTime(2022, 12, 18, 3, 5, 44, 234, DateTimeKind.Utc).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("f33b569a-bf39-4ebd-a71c-ccdd495a24da"),
                column: "CreatedDate",
                value: new DateTime(2022, 12, 18, 3, 5, 44, 234, DateTimeKind.Utc).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: new Guid("3bf8c683-c889-405d-b37d-0d198ac8bf7c"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 18, 3, 5, 44, 233, DateTimeKind.Utc).AddTicks(8280), new DateTime(2022, 12, 20, 3, 5, 44, 233, DateTimeKind.Utc).AddTicks(8321), new DateTime(2022, 12, 19, 3, 5, 44, 233, DateTimeKind.Utc).AddTicks(8300) });

            migrationBuilder.UpdateData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: new Guid("f26b793b-74e4-4edc-aa7c-e86e0eb5854f"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 18, 3, 5, 44, 233, DateTimeKind.Utc).AddTicks(8424), new DateTime(2022, 12, 21, 3, 5, 44, 233, DateTimeKind.Utc).AddTicks(8432), new DateTime(2022, 12, 20, 3, 5, 44, 233, DateTimeKind.Utc).AddTicks(8427) });

            migrationBuilder.UpdateData(
                table: "StudentAnswers",
                keyColumn: "Id",
                keyValue: new Guid("5f9e5563-9682-4f03-985f-e772368cb4e9"),
                column: "HomeworkId",
                value: null);

            migrationBuilder.UpdateData(
                table: "StudentAnswers",
                keyColumn: "Id",
                keyValue: new Guid("b73a1b86-47b9-4553-9ad9-eb52ea9719b9"),
                column: "HomeworkId",
                value: null);
        }
    }
}
