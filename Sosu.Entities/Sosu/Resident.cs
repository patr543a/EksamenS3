using Entities.Dto.Sosu;
using Entities.Interfaces;

namespace Entities.Sosu;

/// <summary>
/// Represents a Resident
/// </summary>
public partial class Resident
    : IDtoConversion<Resident, ResidentDto>
{
    /// <summary>
    /// Id of Resident
    /// </summary>
    public int ResidentId { get; set; }

    /// <summary>
    /// Name of Resident
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Room name of Resident
    /// </summary>
    public string RoomId { get; set; } = null!;

    /// <summary>
    /// Reference to a list of Tasks
    /// </summary>
    public virtual ICollection<Task>? Tasks { get; set; } = new List<Task>();

    /// <summary>
    /// Converts this into a ResidentDto
    /// </summary>
    /// <returns>ResidentDto of this Resident</returns>
    public ResidentDto ToDto()
        => new(this);
}
