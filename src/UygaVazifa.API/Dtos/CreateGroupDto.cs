using System.ComponentModel.DataAnnotations;

namespace UygaVazifa.API.Dtos;

public class CreateGroupDto
{
    [Required]
    public string? Name { get; set; }

    [Required]
    public Guid TeacherId { get; set; }
    public Guid AssistantId { get; set; }
}