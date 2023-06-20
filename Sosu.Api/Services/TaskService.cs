using Entities.Dto.Sosu;
using Repository.Sosu;
using Sosu.Api.Base;
using Sosu.Api.Interfaces;

namespace Sosu.Api.Services;

/// <summary>
/// Represents an ITaskService
/// </summary>
public class TaskService
    : ServiceBase<SosuUnitOfWork>, ITaskService
{
    /// <summary>
    /// Gets a list of Tasks from the given Resident
    /// </summary>
    /// <param name="residentId">Id of the Resident to get the Tasks from</param>
    /// <returns>A list of Task from the given Resident</returns>
    public IEnumerable<TaskDto> GetAllTasksFromResident(int residentId)
        => _repositories
            .TaskRepository
            .Get(t => t.ResidentId == residentId, null, "CompletedByNavigation,Notes,Resident")
            .Select(t =>
            {
                if (t.IsComplete)
                    t.CompletedBy = null;

                return t.ToDto();
            });

    /// <summary>
    /// Marks a Task in the database as complete
    /// </summary>
    /// <param name="employeeId">Id of the Employee who completed it</param>
    /// <param name="taskId">Id of Task getting completed</param>
    /// <returns>The result of marking the Task as complete</returns>
    public void MarkTaskAsComplete(int employeeId, int taskId)
        => _repositories
            .TaskRepository
            .MarkTaskAsComplete(employeeId, taskId);
}
