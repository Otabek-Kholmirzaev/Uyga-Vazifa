using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UygaVazifa.API.Data.Migrations
{
    public partial class GroupSeed_Data_Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_AspNetUsers_AssistantId",
                table: "Groups");

            migrationBuilder.AlterColumn<Guid>(
                name: "AssistantId",
                table: "Groups",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

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

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "AssistantId", "Name", "Status", "TeacherId" },
                values: new object[] { new Guid("4282f6fc-3643-4da6-ad1c-22ea8f3a8cfe"), null, "Ilmhub .NET Bootcamp", 0, new Guid("f73e4f1d-be15-4eab-a1ba-92747d075b54") });

            migrationBuilder.InsertData(
                table: "Homeworks",
                columns: new[] { "Id", "CreatedDate", "Description", "EndDate", "Files", "GroupId", "IssuerId", "StartDate", "Status", "Title" },
                values: new object[,]
                {
                    { new Guid("3bf8c683-c889-405d-b37d-0d198ac8bf7c"), new DateTime(2022, 12, 17, 22, 49, 58, 145, DateTimeKind.Utc).AddTicks(4371), null, new DateTime(2022, 12, 19, 22, 49, 58, 145, DateTimeKind.Utc).AddTicks(4385), null, new Guid("4282f6fc-3643-4da6-ad1c-22ea8f3a8cfe"), new Guid("f73e4f1d-be15-4eab-a1ba-92747d075b54"), new DateTime(2022, 12, 18, 22, 49, 58, 145, DateTimeKind.Utc).AddTicks(4376), 0, "Localizerdan foydalanib servislarni implement qiling." },
                    { new Guid("f26b793b-74e4-4edc-aa7c-e86e0eb5854f"), new DateTime(2022, 12, 17, 22, 49, 58, 145, DateTimeKind.Utc).AddTicks(4397), null, new DateTime(2022, 12, 20, 22, 49, 58, 145, DateTimeKind.Utc).AddTicks(4399), null, new Guid("4282f6fc-3643-4da6-ad1c-22ea8f3a8cfe"), new Guid("f73e4f1d-be15-4eab-a1ba-92747d075b54"), new DateTime(2022, 12, 19, 22, 49, 58, 145, DateTimeKind.Utc).AddTicks(4398), 0, "Custom exception middleware yozing." }
                });

            migrationBuilder.InsertData(
                table: "UserGroups",
                columns: new[] { "Id", "GroupId", "UserId" },
                values: new object[] { new Guid("8348fe88-ad5c-4a4e-b88a-adb6f8e728e8"), new Guid("4282f6fc-3643-4da6-ad1c-22ea8f3a8cfe"), new Guid("12431733-4e80-439b-b5ff-86e1f8c6f77f") });

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_AspNetUsers_AssistantId",
                table: "Groups",
                column: "AssistantId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_AspNetUsers_AssistantId",
                table: "Groups");

            migrationBuilder.DeleteData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: new Guid("3bf8c683-c889-405d-b37d-0d198ac8bf7c"));

            migrationBuilder.DeleteData(
                table: "Homeworks",
                keyColumn: "Id",
                keyValue: new Guid("f26b793b-74e4-4edc-aa7c-e86e0eb5854f"));

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: new Guid("8348fe88-ad5c-4a4e-b88a-adb6f8e728e8"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("4282f6fc-3643-4da6-ad1c-22ea8f3a8cfe"));

            migrationBuilder.AlterColumn<Guid>(
                name: "AssistantId",
                table: "Groups",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("12431733-4e80-439b-b5ff-86e1f8c6f77f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7d3d60c0-5fb4-475b-a974-464074d49f09", "AQAAAAEAACcQAAAAEP3LOxb663UWf7CXb7nJNIYNC6J/jHs8mtVg1Vw7z//oU+K50ZHqp7M6aV01fHtS3w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23d87b67-68a6-498c-a242-2c69576c00d7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8d574049-c23a-4021-a0b0-abcfca39b0ed", "AQAAAAEAACcQAAAAEE/DKoXiQNnPStNC7mOepbKisRIQiEiHESwnjTIqUawck1f3S0URojoTqqrn6oS0lg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f73e4f1d-be15-4eab-a1ba-92747d075b54"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d3aa8311-c0cb-4874-8fb2-e99ac15dab81", "AQAAAAEAACcQAAAAELtCTE3q2UcFK0EOcnEcJc5FglWX4ba3PAojaKQh70WMsde36CmlTu5TK1TsDljzZQ==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_AspNetUsers_AssistantId",
                table: "Groups",
                column: "AssistantId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
