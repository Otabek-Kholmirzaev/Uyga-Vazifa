using System.ComponentModel.DataAnnotations;
using UygaVazifa.API.Entities.Enums;

namespace UygaVazifa.API.Dtos;

public class CreateHomeworkDto
{
    [Required]
    public string? Title { get; set; }
    public string? Description { get; set; }
    public List<IFormFile>? Files { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public EGroupStatus Status { get; set; }
}