using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UygaVazifa.API.Entities;

namespace UygaVazifa.API.Data;

public class AppDbContext : IdentityDbContext<User, Role, Guid>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
    public DbSet<Homework> Homeworks { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<UserGroup> UserGroups { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<StudentAnswer> StudentAnswers { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        SeedData(builder);  
    }

    private void SeedData(ModelBuilder builder)
    {
        Dictionary<string, Guid> userRoleInfo = new()
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
            Id = userRoleInfo["adminId"],
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
            Id = userRoleInfo["teacherId"],
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
            Id = userRoleInfo["studentId"],
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
            Id = userRoleInfo["adminRoleId"],
            Name = "Admin",
            NormalizedName = "AdMiN".ToUpper(),
            ConcurrencyStamp = userRoleInfo["adminRoleId"].ToString()
        });
        
        builder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
        {
            RoleId = userRoleInfo["adminRoleId"],
            UserId = userRoleInfo["adminId"]
        });
        #endregion

        #region TeacherRole
        builder.Entity<Role>().HasData(new Role()
        {
            Id = userRoleInfo["teacherRoleId"],
            Name = "Teacher",
            NormalizedName = "Teacher".ToUpper(),
            ConcurrencyStamp = userRoleInfo["teacherRoleId"].ToString()
        });

        builder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
        {
            RoleId = userRoleInfo["teacherRoleId"],
            UserId = userRoleInfo["teacherId"]
        });
        #endregion

        #region StudentRole
        builder.Entity<Role>().HasData(new Role()
        {
            Id = userRoleInfo["studentRoleId"],
            Name = "Student",
            NormalizedName = "Student".ToUpper(),
            ConcurrencyStamp = userRoleInfo["studentRoleId"].ToString()
        });

        builder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
        {
            RoleId = userRoleInfo["studentRoleId"],
            UserId = userRoleInfo["studentId"]
        });
        #endregion
    }
}