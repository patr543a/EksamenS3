using Entities.Dto.Sosu;
using Microsoft.AspNetCore.Mvc;
using Sosu.Api.Base;

namespace Sosu.Api.Interfaces;

public interface ITaskService
    : IService
{
    IEnumerable<TaskDto> GetAllTasksFromResident(int residentId);
    void MarkTaskAsComplete(int employeeId, int taskId); 
}
