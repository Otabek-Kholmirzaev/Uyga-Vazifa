namespace UygaVazifa.API.Models;

public class CommentResponseModel
{
    public Guid Id { get; set; }
    public string? Text { get; set; }
    public DateTime? CreatedDate { get; set; }
    public CommentResponseModel? Parent { get; set; }

    public virtual List<CommentResponseModel>? Children { get; set; }

    public StudentAnswerResponseModel? StudentAnswer { get; set; }

    public virtual UserResponseModel? User { get; set; }
}