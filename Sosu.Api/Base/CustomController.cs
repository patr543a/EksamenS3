using Microsoft.AspNetCore.Mvc;

namespace Sosu.Api.Base;

public abstract class CustomController<TService>
    : ControllerBase
    where TService : IService
{
    protected TService _service;

    public CustomController(TService service)
        => _service = service;
}
