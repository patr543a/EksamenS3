using Entities.Dto.Sosu;
using Sosu.Api.Base;

namespace Sosu.Api.Interfaces;

public interface IResidentService
    : IService
{
    IEnumerable<ResidentDto> GetAllResidents();
}
