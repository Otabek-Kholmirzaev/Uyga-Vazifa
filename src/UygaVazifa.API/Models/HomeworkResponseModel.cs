using System.ComponentModel.DataAnnotations.Schema;
using UygaVazifa.API.Entities;
using UygaVazifa.API.Entities.Enums;

namespace UygaVazifa.API.Models;

public class HomeworkResponseModel
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public List<string>? Files { get; set; }
    public DateTime? CreatedDate { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public EHomeworkStatus Status { get; set; }

    public GroupResponseModel? Group { get; set; }
    public UserResponseModel? Issuer { get; set; }

    public List<StudentAnswerResponseModel>? StudentAnswers { get; set; }
}