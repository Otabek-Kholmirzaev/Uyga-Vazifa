using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UygaVazifa.API.Entities;
using UygaVazifa.API.Entities.Enums;

namespace UygaVazifa.API.Dtos;

public class UpdateGroupDto
{
    [Required]
    public string? Name { get; set; }
    public EGroupStatus? Status { get; set; }

    [Required]
    public Guid TeacherId { get; set; }

    public Guid? AssistantId { get; set; }
}