using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UygaVazifa.API.Entities;
using UygaVazifa.API.Entities.Enums;

namespace UygaVazifa.API.Dtos;

public class UpdateHomeworkDto
{
    [Required]
    public string? Title { get; set; }
    public string? Description { get; set; }
    public List<string>? Files { get; set; }
    [Required]
    public DateTime? StartDate { get; set; }
    [Required]
    public DateTime? EndDate { get; set; }
    public EHomeworkStatus? Status { get; set; }
}