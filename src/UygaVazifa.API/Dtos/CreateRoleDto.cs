using System.ComponentModel.DataAnnotations;

namespace UygaVazifa.API.Dtos;

public class CreateRoleDto
{
    [Required]
    public string? Name { get; set; }
}