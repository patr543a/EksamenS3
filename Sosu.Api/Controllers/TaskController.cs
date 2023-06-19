using Microsoft.AspNetCore.Mvc;
using Sosu.Api.Base;
using Sosu.Api.Interfaces;

namespace Sosu.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TaskController 
    : CustomController<ITaskService>
{
    public TaskController(ITaskService service)
        : base(service)
    {        
    }
}
