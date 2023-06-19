using Microsoft.AspNetCore.Mvc;

namespace Sosu.Api.Base;

public abstract class CustomController<TService>
    : ControllerBase
    where TService : IService
{
    protected IService _service;

    public CustomController(IService service)
        => _service = service;
}
