using Entities.Dto.Sosu;
using Microsoft.AspNetCore.Mvc;
using Sosu.Api.Base;
using Sosu.Api.Interfaces;

namespace Sosu.Api.Controllers;

/// <summary>
/// API controller for actions with Residents
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class ResidentController 
    : CustomController<IResidentService>
{
    /// <summary>
    /// Creates a new ResidentController with the given IResidentService
    /// </summary>
    /// <param name="service">IResidentService to use</param>
    public ResidentController(IResidentService service)
        : base(service)
    {
    }

    /// <summary>
    /// Gets a list of all Residents
    /// </summary>
    /// <returns>A list of all Residents</returns>
    [HttpGet]
    [Route("get")]
    public async Task<ActionResult<IEnumerable<ResidentDto>>> GetAllResidents()
        => Ok(await Task.FromResult(_service.GetAllResidents()));
}
