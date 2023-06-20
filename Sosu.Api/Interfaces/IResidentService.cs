using Entities.Dto.Sosu;
using Sosu.Api.Base;

namespace Sosu.Api.Interfaces;

/// <summary>
/// Provides the method needed to be a TaskService
/// </summary>
public interface IResidentService
    : IService
{
    /// <summary>
    /// Gets a list of all Residents
    /// </summary>
    /// <returns>A list of all Residents</returns>
    IEnumerable<ResidentDto> GetAllResidents();
}
