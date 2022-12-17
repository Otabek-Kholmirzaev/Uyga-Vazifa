using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UygaVazifa.API.Entities;

namespace UygaVazifa.API.Data;

public class AppDbContext : IdentityDbContext<User, Role, Guid>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
}