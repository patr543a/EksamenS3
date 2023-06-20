using Entities.Contexts;
using Repository.Classes;
using TaskSosu = Entities.Sosu.Task;

namespace Repository.Sosu;

/// <summary>
/// A Repository used for Task
/// </summary>
public class TaskRepository
    : Repository<SosuContext, TaskSosu>
{
    /// <summary>
    /// Creates a new TaskRepository from a SosuContext
    /// </summary>
    /// <param name="context">The SosuContext to use</param>
    public TaskRepository(SosuContext context)
        : base(context)
    {
    }

    /// <summary>
    /// Marks a Task as complete in the database
    /// </summary>
    /// <param name="employeeId">Id of the Employee to complete the Task</param>
    /// <param name="taskId">Id of the Task that is getting completed</param>
    /// <exception cref="Exception" />
    public void MarkTaskAsComplete(int employeeId, int taskId)
    {
        // Get task. If null throw exception
        var task = GetByID(taskId) ?? throw new Exception("Task was not found");

        // Update task
        task.IsComplete = true;
        task.CompletedBy = employeeId;

        // Save changes
        Save();
    }
}