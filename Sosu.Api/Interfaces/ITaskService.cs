using Entities.Dto.Sosu;
using Sosu.Api.Base;

namespace Sosu.Api.Interfaces;

/// <summary>
/// Provides the method needed to be a TaskService
/// </summary>
public interface ITaskService
    : IService
{
    /// <summary>
    /// Gets a list of Tasks from the given Resident
    /// </summary>
    /// <param name="residentId">Id of the Resident to get the Tasks from</param>
    /// <returns>A list of Task from the given Resident</returns>
    IEnumerable<TaskDto> GetAllTasksFromResident(int residentId);

    /// <summary>
    /// Marks a Task in the database as complete
    /// </summary>
    /// <param name="employeeId">Id of the Employee who completed it</param>
    /// <param name="taskId">Id of Task getting completed</param>
    /// <returns>The result of marking the Task as complete</returns>
    void MarkTaskAsComplete(int employeeId, int taskId); 
}
