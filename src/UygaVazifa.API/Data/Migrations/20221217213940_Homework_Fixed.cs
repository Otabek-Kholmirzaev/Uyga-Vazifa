using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UygaVazifa.API.Data.Migrations
{
    public partial class Homework_Fixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<List<string>>(
                name: "Files",
                table: "Homeworks",
                type: "text[]",
                nullable: true);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Files",
                table: "Homeworks");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("12431733-4e80-439b-b5ff-86e1f8c6f77f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ad842ac9-90ae-4410-a880-77977ca9bc47", "AQAAAAEAACcQAAAAEJtneFQ8uK5OmsZAm6jJYTJtDuQtqM/uiK4e3U5A3tSZyTq7bHnxSfKaKMPCHaFTRg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23d87b67-68a6-498c-a242-2c69576c00d7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2d1f19f6-705e-4dfc-867f-c1d87948f948", "AQAAAAEAACcQAAAAEJjevIL0Rrj/NS6pw8iolMGN/viOTEt7XV2IsmbvZf3p2MS8va4j+j8eC05MvuKRQA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f73e4f1d-be15-4eab-a1ba-92747d075b54"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5e810d56-e2fa-4758-a585-bcefe2b4fffb", "AQAAAAEAACcQAAAAEMtKe/k2AEJaipqtX9pZ4xf20r9GLx1mZBkTgA51bxfGbDvg+Ak18/j39u6bFuazJg==" });
        }
    }
}
