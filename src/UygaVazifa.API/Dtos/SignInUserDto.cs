using System.ComponentModel.DataAnnotations;

namespace UygaVazifa.API.Dtos;

public class SignInUserDto
{
    [Required]
    public string UserName { get; set; }
    [Required]
    public string Password { get; set; }
}