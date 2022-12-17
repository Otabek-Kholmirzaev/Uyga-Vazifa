using System.ComponentModel.DataAnnotations.Schema;
using UygaVazifa.API.Entities.Enums;

namespace UygaVazifa.API.Entities;

public class Homework
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public List<string>? Files { get; set; }
    public DateTime? CreatedDate { get; set; } 
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public EHomeworkStatus Status { get; set; }

    public Guid GroupId { get; set; }

    [ForeignKey(nameof(GroupId))]
    public virtual Group? Group { get; set; }

    public Guid IssuerId { get; set; }

    [ForeignKey(nameof(IssuerId))]
    public virtual User? Issuer { get; set; }

    public List<StudentAnswer>? StudentAnswers { get; set; }
}