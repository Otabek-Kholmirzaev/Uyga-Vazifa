using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UygaVazifa.API.Data.Migrations
{
    public partial class TablesCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    TeacherId = table.Column<Guid>(type: "uuid", nullable: false),
                    AssistantId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_AspNetUsers_AssistantId",
                        column: x => x.AssistantId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Groups_AspNetUsers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Homeworks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    GroupId = table.Column<Guid>(type: "uuid", nullable: false),
                    IssuerId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Homeworks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Homeworks_AspNetUsers_IssuerId",
                        column: x => x.IssuerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Homeworks_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    GroupId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserGroups_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserGroups_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ParentId = table.Column<Guid>(type: "uuid", nullable: true),
                    HomeworkId = table.Column<Guid>(type: "uuid", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    StudentAnswerId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Comments_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Comments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_Homeworks_HomeworkId",
                        column: x => x.HomeworkId,
                        principalTable: "Homeworks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StudentAnswers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Files = table.Column<List<string>>(type: "text[]", nullable: true),
                    CommentId = table.Column<Guid>(type: "uuid", nullable: true),
                    StudentId = table.Column<Guid>(type: "uuid", nullable: false),
                    Result = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: true),
                    HomeworkId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentAnswers_AspNetUsers_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentAnswers_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentAnswers_Homeworks_HomeworkId",
                        column: x => x.HomeworkId,
                        principalTable: "Homeworks",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Comments_HomeworkId",
                table: "Comments",
                column: "HomeworkId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ParentId",
                table: "Comments",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_StudentAnswerId",
                table: "Comments",
                column: "StudentAnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_AssistantId",
                table: "Groups",
                column: "AssistantId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_TeacherId",
                table: "Groups",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Homeworks_GroupId",
                table: "Homeworks",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Homeworks_IssuerId",
                table: "Homeworks",
                column: "IssuerId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAnswers_CommentId",
                table: "StudentAnswers",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAnswers_HomeworkId",
                table: "StudentAnswers",
                column: "HomeworkId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAnswers_StudentId",
                table: "StudentAnswers",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserGroups_GroupId",
                table: "UserGroups",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_UserGroups_UserId",
                table: "UserGroups",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_StudentAnswers_StudentAnswerId",
                table: "Comments",
                column: "StudentAnswerId",
                principalTable: "StudentAnswers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Homeworks_HomeworkId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentAnswers_Homeworks_HomeworkId",
                table: "StudentAnswers");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_StudentAnswers_StudentAnswerId",
                table: "Comments");

            migrationBuilder.DropTable(
                name: "UserGroups");

            migrationBuilder.DropTable(
                name: "Homeworks");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "StudentAnswers");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("12431733-4e80-439b-b5ff-86e1f8c6f77f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "57a9d659-cc8c-4aa2-a747-e660665cf7a0", "AQAAAAEAACcQAAAAEBUkJ7PpVKerSyCKfDMfOVAOt4hQ1uBziONgPpZatDqtOu6Xw/TN5p2O/O1HpfT58w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23d87b67-68a6-498c-a242-2c69576c00d7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "959764df-606f-4892-a3fd-92dcc850aa91", "AQAAAAEAACcQAAAAEPMlp9HRuuPV0I0HweS4jTQs58/gNrUMcAHuFVt5Cai2+ng7zE8XznG0xKUtPxh2kQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f73e4f1d-be15-4eab-a1ba-92747d075b54"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a35b1276-92c5-489b-aa7c-7265f61a5097", "AQAAAAEAACcQAAAAEPYG0zPRvCHNBBHe4YHMeS5m+4/8JDQcWCx5/n0A8yu3p6XHWz3RLTI9YO8bWUT1EA==" });
        }
    }
}
