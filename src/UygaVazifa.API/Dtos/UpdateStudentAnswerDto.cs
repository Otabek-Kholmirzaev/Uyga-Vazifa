using System.ComponentModel.DataAnnotations.Schema;
using UygaVazifa.API.Entities;
using UygaVazifa.API.Entities.Enums;

namespace UygaVazifa.API.Dtos;

public class UpdateStudentAnswerDto
{
    public string? File { get; set; }
    public ECommentType CommentType { get; set; }

    public Guid? HomeworkId { get; set; }
    public Guid StudentId { get; set; }

    public EResultStudentAnswer? Result { get; set; }
    public EStudentAnswerStatus? Status { get; set; }
}