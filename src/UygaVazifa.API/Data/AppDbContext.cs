using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UygaVazifa.API.Entities;

namespace UygaVazifa.API.Data;

public class AppDbContext : IdentityDbContext<User, Role, Guid>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
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
            { "roleId", Guid.Parse("f61d882b-22b4-4588-8f73-b85c7eb319db") }
        };

        Dictionary<string, string> adminInfo = new()
        {
            { "firstName", "John" },
            { "lastName", "Doe" },
            { "email", "johndoe@gmail.com" },
            { "userName", "admin" },
            { "password", "admin123" }
        };

        var appUser = new User()
        {
            Id = Guid.NewGuid(),
            FirstName = adminInfo["firstName"],
            LastName = adminInfo["lastName"],
            UserName = adminInfo["userName"],
            NormalizedUserName = adminInfo["userName"].ToUpper(),
            Email = adminInfo["email"],
            NormalizedEmail = adminInfo["email"].ToUpper(),
            EmailConfirmed = true
        };

        PasswordHasher<User> passwordHasher = new PasswordHasher<User>();
        appUser.PasswordHash = passwordHasher.HashPassword(appUser, adminInfo["password"]);

        builder.Entity<User>().HasData(appUser);

        builder.Entity<Role>().HasData(new Role()
        {
            Id = userRoleInfo["roleId"],
            Name = "Admin",
            NormalizedName = "AdMiN".ToUpper(),
            ConcurrencyStamp = userRoleInfo["roleId"].ToString()
        });
        
        List<string> roleNames = new() { "Teacher", "Assistant", "Student" };

        foreach (var roleName in roleNames)
            builder.Entity<Role>().HasData(new Role()
            {
                Id = Guid.NewGuid(),
                Name = roleName,
                NormalizedName = roleName.ToUpper()
            });

        builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
        {
            RoleId = userRoleInfo["roleId"].ToString(),
            UserId = userRoleInfo["adminId"].ToString()
        });
    }
}