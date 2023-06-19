using Entities.Contexts;
using Entities.Dto.Sosu;
using Microsoft.AspNetCore.Mvc;
using Repository.Sosu;
using Sosu.Api.Base;
using Sosu.Api.Interfaces;
using Task = Entities.Sosu.Task;

namespace Sosu.Api.Services;

public class TaskService
    : ServiceBase<SosuUnitOfWork, SosuContext>, ITaskService
{
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

    public ActionResult MarkTaskAsComplete(int employeeId, int taskId)
        => _repositories
            .TaskRepository
            .MarkTaskAsComplete(employeeId, taskId);
}
