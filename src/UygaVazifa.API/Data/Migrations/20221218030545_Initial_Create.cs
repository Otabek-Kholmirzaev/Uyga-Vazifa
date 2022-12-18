using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace UygaVazifa.API.Data.Migrations
{
    public partial class Initial_Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    TeacherId = table.Column<Guid>(type: "uuid", nullable: false),
                    AssistantId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_AspNetUsers_AssistantId",
                        column: x => x.AssistantId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
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
                    Files = table.Column<List<string>>(type: "text[]", nullable: true),
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
                name: "StudentAnswers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    File = table.Column<string>(type: "text", nullable: true),
                    CommentType = table.Column<int>(type: "integer", nullable: false),
                    HomeworkId = table.Column<Guid>(type: "uuid", nullable: true),
                    StudentId = table.Column<Guid>(type: "uuid", nullable: false),
                    Result = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: true)
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
                        name: "FK_StudentAnswers_Homeworks_HomeworkId",
                        column: x => x.HomeworkId,
                        principalTable: "Homeworks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ParentId = table.Column<Guid>(type: "uuid", nullable: true),
                    StudentAnswerId = table.Column<Guid>(type: "uuid", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
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
                        name: "FK_Comments_StudentAnswers_StudentAnswerId",
                        column: x => x.StudentAnswerId,
                        principalTable: "StudentAnswers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("8c242ea4-e9a3-4cfb-b50d-79233f68c988"), "8c242ea4-e9a3-4cfb-b50d-79233f68c988", "Student", "STUDENT" },
                    { new Guid("d0e9c32c-cbcc-4712-abac-63322f206db1"), "d0e9c32c-cbcc-4712-abac-63322f206db1", "Teacher", "TEACHER" },
                    { new Guid("f61d882b-22b4-4588-8f73-b85c7eb319db"), "f61d882b-22b4-4588-8f73-b85c7eb319db", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("12431733-4e80-439b-b5ff-86e1f8c6f77f"), 0, "58831201-4834-4b1d-973f-7570a091f054", "jeffreyway@gmail.com", true, "Jeffrey", "Way", false, null, "JEFFREYWAY@GMAIL.COM", "STUDENT", "AQAAAAEAACcQAAAAEDwJK4b+gVS1jNf2ldoK7fFZYYAv+kks/7KEKLXwhCnhSveMu+qlcQbk0OZmVcDtUw==", null, false, null, false, "student" },
                    { new Guid("23d87b67-68a6-498c-a242-2c69576c00d7"), 0, "deb17bd1-0582-41bf-be5b-6841dbd1ab82", "johndoe@gmail.com", true, "John", "Doe", false, null, "JOHNDOE@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEMVyeF7k/rn84Ftb41xRgS84cO1V8Io0DWUqL7U2wmdM11TNq47rkCRNMEfpWjT8DA==", null, false, null, false, "admin" },
                    { new Guid("f73e4f1d-be15-4eab-a1ba-92747d075b54"), 0, "8a05d043-5ee9-4185-ab36-b7c44796d48f", "annasmith@gmail.com", true, "Anna", "Smith", false, null, "ANNASMITH@GMAIL.COM", "TEACHER", "AQAAAAEAACcQAAAAEFq1kzZ0hC2JjubEr39Kf2V30T4WnB7+TeK+M89fdnqLLHvvmAPC7phYa9iKKMpOXQ==", null, false, null, false, "teacher" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("8c242ea4-e9a3-4cfb-b50d-79233f68c988"), new Guid("12431733-4e80-439b-b5ff-86e1f8c6f77f") },
                    { new Guid("f61d882b-22b4-4588-8f73-b85c7eb319db"), new Guid("23d87b67-68a6-498c-a242-2c69576c00d7") },
                    { new Guid("d0e9c32c-cbcc-4712-abac-63322f206db1"), new Guid("f73e4f1d-be15-4eab-a1ba-92747d075b54") }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "AssistantId", "Name", "Status", "TeacherId" },
                values: new object[] { new Guid("4282f6fc-3643-4da6-ad1c-22ea8f3a8cfe"), null, "Ilmhub .NET Bootcamp", 0, new Guid("f73e4f1d-be15-4eab-a1ba-92747d075b54") });

            migrationBuilder.InsertData(
                table: "StudentAnswers",
                columns: new[] { "Id", "CommentType", "File", "HomeworkId", "Result", "Status", "StudentId" },
                values: new object[,]
                {
                    { new Guid("5f9e5563-9682-4f03-985f-e772368cb4e9"), 0, null, null, 0, 1, new Guid("12431733-4e80-439b-b5ff-86e1f8c6f77f") },
                    { new Guid("b73a1b86-47b9-4553-9ad9-eb52ea9719b9"), 0, "file1.pdf", null, null, 0, new Guid("12431733-4e80-439b-b5ff-86e1f8c6f77f") }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreatedDate", "ParentId", "StudentAnswerId", "Text", "UserId" },
                values: new object[,]
                {
                    { new Guid("e8f4a63b-15c1-4d66-9405-d9273549c493"), new DateTime(2022, 12, 18, 3, 5, 44, 234, DateTimeKind.Utc).AddTicks(3372), null, new Guid("b73a1b86-47b9-4553-9ad9-eb52ea9719b9"), "Noto`g`ri ishlangan.", new Guid("12431733-4e80-439b-b5ff-86e1f8c6f77f") },
                    { new Guid("f33b569a-bf39-4ebd-a71c-ccdd495a24da"), new DateTime(2022, 12, 18, 3, 5, 44, 234, DateTimeKind.Utc).AddTicks(3257), null, new Guid("b73a1b86-47b9-4553-9ad9-eb52ea9719b9"), "Ustoz IStringLocalizerdan foydalansam bo`ladimi?", new Guid("12431733-4e80-439b-b5ff-86e1f8c6f77f") }
                });

            migrationBuilder.InsertData(
                table: "Homeworks",
                columns: new[] { "Id", "CreatedDate", "Description", "EndDate", "Files", "GroupId", "IssuerId", "StartDate", "Status", "Title" },
                values: new object[,]
                {
                    { new Guid("3bf8c683-c889-405d-b37d-0d198ac8bf7c"), new DateTime(2022, 12, 18, 3, 5, 44, 233, DateTimeKind.Utc).AddTicks(8280), null, new DateTime(2022, 12, 20, 3, 5, 44, 233, DateTimeKind.Utc).AddTicks(8321), null, new Guid("4282f6fc-3643-4da6-ad1c-22ea8f3a8cfe"), new Guid("f73e4f1d-be15-4eab-a1ba-92747d075b54"), new DateTime(2022, 12, 19, 3, 5, 44, 233, DateTimeKind.Utc).AddTicks(8300), 0, "Localizerdan foydalanib servislarni implement qiling." },
                    { new Guid("f26b793b-74e4-4edc-aa7c-e86e0eb5854f"), new DateTime(2022, 12, 18, 3, 5, 44, 233, DateTimeKind.Utc).AddTicks(8424), null, new DateTime(2022, 12, 21, 3, 5, 44, 233, DateTimeKind.Utc).AddTicks(8432), null, new Guid("4282f6fc-3643-4da6-ad1c-22ea8f3a8cfe"), new Guid("f73e4f1d-be15-4eab-a1ba-92747d075b54"), new DateTime(2022, 12, 20, 3, 5, 44, 233, DateTimeKind.Utc).AddTicks(8427), 0, "Custom exception middleware yozing." }
                });

            migrationBuilder.InsertData(
                table: "UserGroups",
                columns: new[] { "Id", "GroupId", "UserId" },
                values: new object[] { new Guid("8348fe88-ad5c-4a4e-b88a-adb6f8e728e8"), new Guid("4282f6fc-3643-4da6-ad1c-22ea8f3a8cfe"), new Guid("12431733-4e80-439b-b5ff-86e1f8c6f77f") });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreatedDate", "ParentId", "StudentAnswerId", "Text", "UserId" },
                values: new object[,]
                {
                    { new Guid("1dac93a4-2cac-45c2-9d8a-c241b8ce5a37"), new DateTime(2022, 12, 18, 3, 7, 44, 234, DateTimeKind.Utc).AddTicks(3294), new Guid("f33b569a-bf39-4ebd-a71c-ccdd495a24da"), new Guid("b73a1b86-47b9-4553-9ad9-eb52ea9719b9"), "Ha, albatta foydalanishing mumkin.", new Guid("f73e4f1d-be15-4eab-a1ba-92747d075b54") },
                    { new Guid("309b1bcf-cb1d-425e-ab4e-bc16d00d3f7a"), new DateTime(2022, 12, 18, 3, 6, 4, 234, DateTimeKind.Utc).AddTicks(3390), new Guid("e8f4a63b-15c1-4d66-9405-d9273549c493"), new Guid("b73a1b86-47b9-4553-9ad9-eb52ea9719b9"), "Nimasi noto`g`ri ishlangan ustoz?.", new Guid("12431733-4e80-439b-b5ff-86e1f8c6f77f") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "UserGroups");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "StudentAnswers");

            migrationBuilder.DropTable(
                name: "Homeworks");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
