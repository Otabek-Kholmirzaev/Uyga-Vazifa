namespace UygaVazifa.API.Dtos;

public class UpdateCommentDto
{
    public string? Text { get; set; }
    public Guid? ParentId { get; set; }

    public Guid? StudentAnswerId { get; set; }
}
