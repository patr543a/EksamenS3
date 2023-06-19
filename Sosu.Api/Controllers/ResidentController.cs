using Microsoft.AspNetCore.Mvc;
using Sosu.Api.Base;
using Sosu.Api.Interfaces;

namespace Sosu.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ResidentController 
    : CustomController<IResidentService>
{
    public ResidentController(IResidentService service)
        : base(service)
    {
    }
}
