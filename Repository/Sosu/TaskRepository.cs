using Entities.Contexts;
using Entities.Sosu;
using Repository.Classes;
using Microsoft.AspNetCore.Mvc;
using TaskSosu = Entities.Sosu.Task;
using Microsoft.AspNetCore.Http;

namespace Repository.Sosu;

public class TaskRepository
    : Repository<SosuContext, TaskSosu>
{
    public TaskRepository(SosuContext context)
        : base(context)
    {
    }

    public ActionResult MarkTaskAsComplete(int employeeId, int taskId)
    {
        var task = GetByID(taskId);

        if (task is null)
            return new StatusCodeResult(StatusCodes.Status404NotFound);

        task.IsComplete = true;
        task.CompletedBy = employeeId;

        Save();

        return new StatusCodeResult(StatusCodes.Status200OK);
    }
}