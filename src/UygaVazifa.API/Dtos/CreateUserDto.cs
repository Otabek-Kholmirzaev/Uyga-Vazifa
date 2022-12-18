using System.ComponentModel.DataAnnotations;

namespace UygaVazifa.API.Dtos;

public class CreateUserDto
{
    [Required]
    public string UserName { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string FirstName { get; set; }
    public string? LastName { get; set; }
    [Required]
    public string Password { get; set; }
}