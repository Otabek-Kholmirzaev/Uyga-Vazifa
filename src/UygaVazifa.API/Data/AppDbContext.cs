using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UygaVazifa.API.Entities;
using UygaVazifa.API.Entities.Enums;

namespace UygaVazifa.API.Data;

public class AppDbContext : IdentityDbContext<User, Role, Guid>
{
    public DbSet<Homework> Homeworks { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<UserGroup> UserGroups { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<StudentAnswer> StudentAnswers { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseLazyLoadingProxies();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        SeedData(builder);  
    }

    private void SeedData(ModelBuilder builder)
    {
        Dictionary<string, Guid> idInformations = new()
        {
            { "groupId", Guid.Parse("4282f6fc-3643-4da6-ad1c-22ea8f3a8cfe") },
            { "theFirstHomeworkId", Guid.Parse("3bf8c683-c889-405d-b37d-0d198ac8bf7c") },
            { "theSecondHomeworkId", Guid.Parse("f26b793b-74e4-4edc-aa7c-e86e0eb5854f") },
            { "userGroupId", Guid.Parse("8348fe88-ad5c-4a4e-b88a-adb6f8e728e8") },
            { "theFirstCommentId", Guid.Parse("f33b569a-bf39-4ebd-a71c-ccdd495a24da") },
            { "theSecondCommentId", Guid.Parse("1dac93a4-2cac-45c2-9d8a-c241b8ce5a37") },
            { "theThirdCommentId", Guid.Parse("e8f4a63b-15c1-4d66-9405-d9273549c493") },
            { "theFourthCommentId", Guid.Parse("309b1bcf-cb1d-425e-ab4e-bc16d00d3f7a") },
            { "theFirstStudentAnswerId", Guid.Parse("b73a1b86-47b9-4553-9ad9-eb52ea9719b9") },
            { "theSecondStudentAnswerId", Guid.Parse("5f9e5563-9682-4f03-985f-e772368cb4e9") },
        };

        Dictionary<string, string> informations = new()
        {
            { "groupName", "Ilmhub .NET Bootcamp" },
        };

        Dictionary<string, Guid> userRoleInformations = new()
        {
            { "adminId", Guid.Parse("23d87b67-68a6-498c-a242-2c69576c00d7") },
            { "adminRoleId", Guid.Parse("f61d882b-22b4-4588-8f73-b85c7eb319db") },
            { "teacherId", Guid.Parse("f73e4f1d-be15-4eab-a1ba-92747d075b54") },
            { "teacherRoleId", Guid.Parse("d0e9c32c-cbcc-4712-abac-63322f206db1") },
            { "studentId",Guid.Parse("12431733-4e80-439b-b5ff-86e1f8c6f77f") },
            { "studentRoleId",Guid.Parse("8c242ea4-e9a3-4cfb-b50d-79233f68c988") },
        };

        #region AdminUserSeedData
        Dictionary<string, string> adminInfo = new()
        {
            { "firstName", "John" },
            { "lastName", "Doe" },
            { "email", "johndoe@gmail.com" },
            { "userName", "admin" },
            { "password", "admin123" }
        };

        var adminEntity = new User()
        {
            Id = userRoleInformations["adminId"],
            FirstName = adminInfo["firstName"],
            LastName = adminInfo["lastName"],
            UserName = adminInfo["userName"],
            NormalizedUserName = adminInfo["userName"].ToUpper(),
            Email = adminInfo["email"],
            NormalizedEmail = adminInfo["email"].ToUpper(),
            EmailConfirmed = true
        };

        PasswordHasher<User> passwordHasher = new PasswordHasher<User>();
        adminEntity.PasswordHash = passwordHasher.HashPassword(adminEntity, adminInfo["password"]);
        #endregion

        #region TeacherUserSeedData
        Dictionary<string, string> teacherInfo = new()
        {
            { "firstName", "Anna" },
            { "lastName", "Smith" },
            { "email", "annasmith@gmail.com" },
            { "userName", "teacher" },
            { "password", "teacher123" }
        };

        var teacherEntity = new User()
        {
            Id = userRoleInformations["teacherId"],
            FirstName = teacherInfo["firstName"],
            LastName = teacherInfo["lastName"],
            UserName = teacherInfo["userName"],
            NormalizedUserName = teacherInfo["userName"].ToUpper(),
            Email = teacherInfo["email"],
            NormalizedEmail = teacherInfo["email"].ToUpper(),
            EmailConfirmed = true
        };
        teacherEntity.PasswordHash = passwordHasher.HashPassword(teacherEntity, teacherInfo["password"]);
        #endregion

        #region StudentUserSeedData
        Dictionary<string, string> studentInfo = new()
        {
            { "firstName", "Jeffrey" },
            { "lastName", "Way" },
            { "email", "jeffreyway@gmail.com" },
            { "userName", "student" },
            { "password", "student123" }
        };

        var studentEntity = new User()
        {
            Id = userRoleInformations["studentId"],
            FirstName = studentInfo["firstName"],
            LastName = studentInfo["lastName"],
            UserName = studentInfo["userName"],
            NormalizedUserName = studentInfo["userName"].ToUpper(),
            Email = studentInfo["email"],
            NormalizedEmail = studentInfo["email"].ToUpper(),
            EmailConfirmed = true
        };
        studentEntity.PasswordHash = passwordHasher.HashPassword(studentEntity, studentInfo["password"]);
        #endregion

        builder.Entity<User>().HasData(adminEntity);
        builder.Entity<User>().HasData(teacherEntity);
        builder.Entity<User>().HasData(studentEntity);

        #region AdminRole
        builder.Entity<Role>().HasData(new Role()
        {
            Id = userRoleInformations["adminRoleId"],
            Name = "Admin",
            NormalizedName = "AdMiN".ToUpper(),
            ConcurrencyStamp = userRoleInformations["adminRoleId"].ToString()
        });
        
        builder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
        {
            RoleId = userRoleInformations["adminRoleId"],
            UserId = userRoleInformations["adminId"]
        });
        #endregion

        #region TeacherRole
        builder.Entity<Role>().HasData(new Role()
        {
            Id = userRoleInformations["teacherRoleId"],
            Name = "Teacher",
            NormalizedName = "Teacher".ToUpper(),
            ConcurrencyStamp = userRoleInformations["teacherRoleId"].ToString()
        });

        builder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
        {
            RoleId = userRoleInformations["teacherRoleId"],
            UserId = userRoleInformations["teacherId"]
        });
        #endregion

        #region StudentRole
        builder.Entity<Role>().HasData(new Role()
        {
            Id = userRoleInformations["studentRoleId"],
            Name = "Student",
            NormalizedName = "Student".ToUpper(),
            ConcurrencyStamp = userRoleInformations["studentRoleId"].ToString()
        });

        builder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
        {
            RoleId = userRoleInformations["studentRoleId"],
            UserId = userRoleInformations["studentId"]
        });
        #endregion

        builder.Entity<Homework>().HasData(new List<Homework>()
        {
            new()
            {
                Id = idInformations["theFirstHomeworkId"],
                Title = "Localizerdan foydalanib servislarni implement qiling.",
                CreatedDate = DateTime.UtcNow,
                StartDate = DateTime.UtcNow.AddDays(1),
                EndDate = DateTime.UtcNow.AddDays(2),
                Status = EHomeworkStatus.Created,
                IssuerId = userRoleInformations["teacherId"],
                GroupId = idInformations["groupId"]
            },
            new()
            {
                Id = idInformations["theSecondHomeworkId"],
                Title = "Custom exception middleware yozing.",
                CreatedDate = DateTime.UtcNow,
                StartDate = DateTime.UtcNow.AddDays(2),
                EndDate = DateTime.UtcNow.AddDays(3),
                Status = EHomeworkStatus.Created,
                IssuerId = userRoleInformations["teacherId"],
                GroupId = idInformations["groupId"]
            }
        });

        builder.Entity<UserGroup>().HasData(new List<UserGroup>()
        {
            new()
            {
                Id = idInformations["userGroupId"],
                GroupId = idInformations["groupId"],
                UserId = userRoleInformations["studentId"]
            }
        });

        builder.Entity<Group>().HasData(new Group()
        {
            Id = idInformations["groupId"],
            Name = informations["groupName"],
            Status = EGroupStatus.Created,
            TeacherId = userRoleInformations["teacherId"]
        });

        builder.Entity<StudentAnswer>().HasData(new List<StudentAnswer>()
        {
            new StudentAnswer()
            {
                Id = idInformations["theFirstStudentAnswerId"],
                File = "file1.pdf",
                StudentId = userRoleInformations["studentId"],
                Status = EStudentAnswerStatus.New,
                HomeworkId = idInformations["theFirstHomeworkId"]
            },
            //Ustoz check qilgandagi answer
            new StudentAnswer()
            {
                Id = idInformations["theSecondStudentAnswerId"],
                StudentId = userRoleInformations["studentId"],
                Status = EStudentAnswerStatus.Old,
                Result = EResultStudentAnswer.Rejected,
                HomeworkId = idInformations["theFirstHomeworkId"]
            }
        });

        builder.Entity<Comment>().HasData(new List<Comment>()
        {
            new Comment()
            {
                Id = idInformations["theFirstCommentId"],
                Text = "Ustoz IStringLocalizerdan foydalansam bo`ladimi?",
                CreatedDate = DateTime.UtcNow,
                StudentAnswerId = idInformations["theFirstStudentAnswerId"],
                UserId = userRoleInformations["studentId"]
            },

            new Comment()
            {
                Id = idInformations["theSecondCommentId"],
                Text = "Ha, albatta foydalanishing mumkin.",
                ParentId = idInformations["theFirstCommentId"],
                CreatedDate = DateTime.UtcNow.AddMinutes(2),
                StudentAnswerId = idInformations["theFirstStudentAnswerId"],
                UserId = userRoleInformations["teacherId"]
            }
        });

        builder.Entity<Comment>().HasData(new List<Comment>()
        {
            new()
            {
                Id = idInformations["theThirdCommentId"],
                Text = "Noto`g`ri ishlangan.",
                CreatedDate = DateTime.UtcNow,
                StudentAnswerId = idInformations["theFirstStudentAnswerId"],
                UserId = userRoleInformations["studentId"]
            },
            new()
            {
                Id = idInformations["theFourthCommentId"],
                Text = "Nimasi noto`g`ri ishlangan ustoz?.",
                ParentId = idInformations["theThirdCommentId"],
                CreatedDate = DateTime.UtcNow.AddSeconds(20),
                StudentAnswerId = idInformations["theFirstStudentAnswerId"],
                UserId = userRoleInformations["studentId"]
            }
        });

    }
}