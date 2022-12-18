using System.ComponentModel.DataAnnotations.Schema;
using UygaVazifa.API.Entities;
using UygaVazifa.API.Entities.Enums;

namespace UygaVazifa.API.Models;

public class StudentAnswerResponseModel
{
    public Guid Id { get; set; }
    public string? File { get; set; }
    public ECommentType CommentType { get; set; }
    public virtual List<CommentResponseModel>? Comments { get; set; } //Qachonki comment null bo`lsa va teacher studentga izoh yozmoqchi bo`lsa shu propertyga yozadi

    public HomeworkResponseModel? Homework { get; set; }

    public UserResponseModel? Student { get; set; }

    public EResultStudentAnswer? Result { get; set; } //accepted, rejected
    public EStudentAnswerStatus? Status { get; set; } //Old, new
}