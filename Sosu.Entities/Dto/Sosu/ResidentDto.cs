using Entities.Interfaces;
using Entities.Sosu;

namespace Entities.Dto.Sosu;

/// <summary>
/// Dto of Resident
/// </summary>
public class ResidentDto
    : IDto<ResidentDto>
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
    public string Room { get; set; } = null!;

    /// <summary>
    /// Creates a ResidenDto from Resident
    /// </summary>
    /// <param name="resident">Resident to make Dto of</param>
    public ResidentDto(Resident? resident)
    {
        // If null return
        if (resident is null)
            return;

        // Set properties
        ResidentId = resident.ResidentId;
        Name = resident.Name;
        Room = resident.RoomId;
    }
}
