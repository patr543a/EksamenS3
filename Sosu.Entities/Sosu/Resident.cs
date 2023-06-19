using Entities.Dto.Sosu;
using Entities.Interfaces;

namespace Entities.Sosu;

public partial class Resident
    : IDtoConversion<Resident, ResidentDto>
{
    public int ResidentId { get; set; }

    public string Name { get; set; } = null!;

    public string RoomId { get; set; } = null!;

    public virtual ICollection<Task>? Tasks { get; set; } = new List<Task>();

    public ResidentDto ToDto()
        => new(this);
}
