using Entities.Contexts;
using Entities.Dto.Sosu;
using Microsoft.AspNetCore.Mvc;
using Repository.Sosu;
using Sosu.Api.Base;
using Sosu.Api.Interfaces;

namespace Sosu.Api.Services;

public class TaskService
    : ServiceBase<SosuUnitOfWork, SosuContext>, ITaskService
{
    public IEnumerable<TaskDto> GetAllTasksFromResident(int residentId)
    {
        throw new NotImplementedException();
    }

    public ActionResult MarkTaskAsComplete(int employeeId, int taskId)
    {
        throw new NotImplementedException();
    }
}
