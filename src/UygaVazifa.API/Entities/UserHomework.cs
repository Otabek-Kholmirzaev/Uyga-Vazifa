using System.ComponentModel.DataAnnotations.Schema;

namespace UygaVazifa.API.Entities;

public class UserHomework
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }

    [ForeignKey(nameof(UserId))]
    public virtual User? User { get; set; }

    public Guid HomeworkId { get; set; }

    [ForeignKey(nameof(HomeworkId))]
    public virtual Homework? Homework { get; set; }
}
