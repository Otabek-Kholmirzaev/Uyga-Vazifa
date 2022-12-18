using Microsoft.AspNetCore.Identity;

namespace UygaVazifa.API.Entities;

public class User : IdentityUser<Guid>
{
    public string FirstName { get; set; }
    public string? LastName { get; set; }

    public virtual List<UserGroup>? Groups { get; set; }
    public virtual List<UserHomework>? UserHomeworks { get; set; }
}