using Entities.Contexts;
using Entities.Sosu;
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
}