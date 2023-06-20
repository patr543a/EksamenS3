using Entities.Dto.Sosu;
using Microsoft.AspNetCore.Mvc;
using Sosu.Api.Base;
using Sosu.Api.Interfaces;
using Task = System.Threading.Tasks.Task;

namespace Sosu.Api.Controllers;

/// <summary>
/// API controller for actions with Tasks
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class TaskController 
    : CustomController<ITaskService>
{
    /// <summary>
    /// Creates a new TaskController with the given ITaskService
    /// </summary>
    /// <param name="service">ITaskService to use</param>
    public TaskController(ITaskService service)
        : base(service)
    {        
    }

    /// <summary>
    /// Gets a list of Tasks from the given Resident
    /// </summary>
    /// <param name="residentId">Id of the Resident to get the Tasks from</param>
    /// <returns>A list of Task from the given Resident</returns>
    [HttpGet]
    [Route("getFromResident")]
    public async Task<ActionResult<IEnumerable<TaskDto>>> GetAllTasksFromResident(int? residentId)
    {
        // If null return BadRequest
        if (residentId is null)
            return BadRequest("Missing parameters");

        // Return result
        return Ok(await Task.FromResult(_service.GetAllTasksFromResident((int)residentId)));
    }

    /// <summary>
    /// Marks a Task in the database as complete
    /// </summary>
    /// <param name="employeeId">Id of the Employee who completed it</param>
    /// <param name="taskId">Id of Task getting completed</param>
    /// <returns>The result of marking the Task as complete</returns>
    [HttpPut]
    [Route("markAsComplete")]
    public async Task<ActionResult> MarkTaskAsComplete(int? employeeId, int? taskId)
    {
        // If null return BadRequest
        if (employeeId is null || taskId is null)
            return BadRequest("Missing parameters");

        // Mark as complete
        _service.MarkTaskAsComplete((int)employeeId, (int)taskId);

        // Return result
        return await Task.FromResult(Ok());
    }
}
