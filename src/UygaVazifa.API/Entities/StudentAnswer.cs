using System.ComponentModel.DataAnnotations.Schema;
using UygaVazifa.API.Entities.Enums;

namespace UygaVazifa.API.Entities;

public class StudentAnswer
{
    public Guid Id { get; set; }
    public List<IFormFile>? Files { get; set; }
    public Comment? Comment { get; set; }
    /// <summary>
    /// Bu property qachonki StudentAnswer.Comment null bo`lsa va teacher studentga izoh yozmoqchi bo`lsa shu propertyga .Add qiladi
    /// </summary>
    public List<Comment>? ResultComments { get; set; } //Qachonki comment null bo`lsa va teacher studentga izoh yozmoqchi bo`lsa shu propertyga yozadi

    public Guid StudentId { get; set; }

    [ForeignKey(nameof(StudentId))]
    public User? Student { get; set; }

    public EResultStudentAnswer? Result { get; set; } //accepted, rejected
    public EStudentAnswerStatus? Status { get; set; } //Old, new
}
