namespace UygaVazifa.API.Models;

public class UserGroupResponseModel
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }

    public virtual UserResponseModel? User { get; set; }
    public virtual GroupResponseModel? Group { get; set; }
}