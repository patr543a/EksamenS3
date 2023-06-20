using Entities.Dto.Sosu;
using Entities.Sosu;
using Microsoft.AspNetCore.Mvc;
using Sosu.Api.Base;
using Sosu.Api.Interfaces;
using Task = System.Threading.Tasks.Task;

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

    [HttpGet]
    [Route("getFromResident")]
    public async Task<ActionResult<IEnumerable<TaskDto>>> GetAllTasksFromResident(int? residentId)
    {
        if (residentId is null)
            return BadRequest("Missing parameters");

        return Ok(await Task.FromResult(_service.GetAllTasksFromResident((int)residentId)));
    }

    [HttpPut]
    [Route("markAsComplete")]
    public async Task<ActionResult> MarkTaskAsComplete(int? employeeId, int? taskId)
    {
        if (employeeId is null || taskId is null)
            return BadRequest("Missing parameters");

        _service.MarkTaskAsComplete((int)employeeId, (int)taskId);

        return await Task.FromResult(Ok());
    }
}
