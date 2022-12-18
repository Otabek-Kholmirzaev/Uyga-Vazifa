using UygaVazifa.API.Entities.Enums;

namespace UygaVazifa.API.Models;

public class GroupResponseModel
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public EGroupStatus Status { get; set; }
    public virtual List<HomeworkResponseModel>? Homeworks { get; set; }
    public virtual List<UserGroupResponseModel>? Users { get; set; }

    public virtual UserResponseModel? Teacher { get; set; }

    public virtual UserResponseModel? Assistant { get; set; }
}