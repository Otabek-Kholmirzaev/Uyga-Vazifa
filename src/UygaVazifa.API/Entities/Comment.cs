using System.ComponentModel.DataAnnotations.Schema;

namespace UygaVazifa.API.Entities;

public class Comment
{
    public Guid Id { get; set; }
    public string? Text { get; set; }
    public DateTime? CreatedDate { get; set; }
    public Guid? ParentId { get; set; }

    [ForeignKey(nameof(ParentId))]
    public virtual Comment? Parent { get; set; }

    public virtual List<Comment>? Children { get; set; }

    public Guid? StudentAnswerId { get; set; }

    [ForeignKey(nameof(StudentAnswerId))]
    public virtual StudentAnswer? StudentAnswer { get; set; }

    public Guid UserId { get; set; }
    [ForeignKey(nameof(UserId))]
    public virtual User? User { get; set; }

}
