using Entities.Interfaces;
using Entities.Sosu;

namespace Entities.Dto.Sosu;

public class ResidentDto
    : IDto<ResidentDto>
{
    public int ResidentId { get; set; }

    public string Name { get; set; } = null!;

    public string Room { get; set; } = null!;

    public ResidentDto(Resident? resident)
    {
        if (resident is null)
            return;

        ResidentId = resident.ResidentId;
        Name = resident.Name;
        Room = resident.RoomId;
    }
}
