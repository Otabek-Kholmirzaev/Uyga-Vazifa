using System.ComponentModel.DataAnnotations.Schema;
using UygaVazifa.API.Entities.Enums;

namespace UygaVazifa.API.Entities;

public class StudentAnswer
{
    public Guid Id { get; set; }
    public string? File { get; set; }
    public ECommentType CommentType { get; set; }
    /// <summary>
    /// Bu property qachonki StudentAnswer.Comment null bo`lsa va teacher studentga izoh yozmoqchi bo`lsa shu propertyga .Add qiladi
    /// </summary>
    public virtual List<Comment>? Comments { get; set; } //Qachonki comment null bo`lsa va teacher studentga izoh yozmoqchi bo`lsa shu propertyga yozadi

    public Guid? HomeworkId { get; set; }
    [ForeignKey(nameof(HomeworkId))]
    public virtual Homework? Homework { get; set; }

    public Guid StudentId { get; set; }

    [ForeignKey(nameof(StudentId))]
    public virtual User? Student { get; set; }

    public EResultStudentAnswer? Result { get; set; } //accepted, rejected
    public EStudentAnswerStatus? Status { get; set; } //Old, new
}