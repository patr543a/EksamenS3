namespace Entities.Sosu;

public partial class Resident
{
    public int ResidentId { get; set; }

    public string Name { get; set; } = null!;

    public string RoomId { get; set; } = null!;

    public virtual ICollection<Task>? Tasks { get; set; } = new List<Task>();
}
