using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UygaVazifa.API.Entities;
using UygaVazifa.API.Entities.Enums;

namespace UygaVazifa.API.Dtos;

public class CreateStudentAnswerDto
{
    public string? File { get; set; }
    public ECommentType? CommentType { get; set; }
    public Guid? HomeworkId { get; set; }

    [Required]
    public Guid StudentId { get; set; }
}