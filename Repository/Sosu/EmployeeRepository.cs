using Entities.Contexts;
using Entities.Sosu;
using Repository.Classes;

namespace Repository.Sosu;

public class EmployeeRepository
    : Repository<SosuContext, Employee>
{
    public EmployeeRepository(SosuContext context)
        : base(context)
    {
    }
}
