using Entities.Dto.Sosu;
using Repository.Sosu;
using Sosu.Api.Base;
using Sosu.Api.Interfaces;

namespace Sosu.Api.Services;

/// <summary>
/// Represents an IResidentService
/// </summary>
public class ResidentService
    : ServiceBase<SosuUnitOfWork>, IResidentService
{
    /// <summary>
    /// Gets a list of all Residents
    /// </summary>
    /// <returns>A list of all Residents</returns>
    public IEnumerable<ResidentDto> GetAllResidents()
        => _repositories
            .ResidentRepository
            .Get()
            .Select(r => r.ToDto());
}
