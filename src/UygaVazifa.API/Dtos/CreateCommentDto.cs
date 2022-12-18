using System.ComponentModel.DataAnnotations.Schema;

namespace UygaVazifa.API.Dtos;

public class CreateCommentDto
{
    public string? Text { get; set; }
    public DateTime? CreatedDate { get; set; }
    public Guid? ParentId { get; set; }
    public Guid? StudentAnswerId { get; set; }
    public Guid UserId { get; set; }
}