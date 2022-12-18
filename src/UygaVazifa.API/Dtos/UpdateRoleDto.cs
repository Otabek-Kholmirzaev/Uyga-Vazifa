using System.ComponentModel.DataAnnotations;

namespace UygaVazifa.API.Dtos;

public class UpdateRoleDto
{
    [Required]
    public string? Name { get; set; }
}