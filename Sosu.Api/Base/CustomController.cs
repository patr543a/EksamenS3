using Microsoft.AspNetCore.Mvc;

namespace Sosu.Api.Base;

/// <summary>
/// A custom controller used for Sosu API
/// </summary>
/// <typeparam name="TService">The IService to use</typeparam>
public abstract class CustomController<TService>
    : ControllerBase
    where TService : IService
{
    /// <summary>
    /// Sevice of type TService
    /// </summary>
    protected TService _service;

    /// <summary>
    /// Creates a new CustomController with the given service
    /// </summary>
    /// <param name="service">Service to use</param>
    public CustomController(TService service)
        => _service = service;
}
