using System.ComponentModel.DataAnnotations.Schema;
using UygaVazifa.API.Entities.Enums;

namespace UygaVazifa.API.Entities;

public class Group
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public EGroupStatus Status { get; set; }
    public virtual List<Homework>? Homeworks { get; set; }
    public virtual List<UserGroup>? Users { get; set; }

    public Guid TeacherId { get; set; }

    [ForeignKey(nameof(TeacherId))]
    public virtual User? Teacher { get; set; }

    public Guid AssistantId { get; set; }

    [ForeignKey(nameof(AssistantId))]
    public virtual User? Assistant { get; set; }
}
