using Entities.Contexts;
using Repository.Classes;
using TaskSosu = Entities.Sosu.Task;

namespace Repository.Sosu;

public class TaskRepository
    : Repository<SosuContext, TaskSosu>
{
    public TaskRepository(SosuContext context)
        : base(context)
    {
    }

    public void MarkTaskAsComplete(int employeeId, int taskId)
    {
        var task = GetByID(taskId);

        if (task is null)
            throw new Exception("Task was not found");

        task.IsComplete = true;
        task.CompletedBy = employeeId;

        Save();
    }
}