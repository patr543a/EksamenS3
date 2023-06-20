using Entities.Contexts;
using Entities.Sosu;
using Repository.Classes;

namespace Repository.Sosu;

/// <summary>
/// A Repository used for Employee
/// </summary>
public class EmployeeRepository
    : Repository<SosuContext, Employee>
{
    /// <summary>
    /// Creates a new EmployeeRepository from a SosuContext
    /// </summary>
    /// <param name="context">The SosuContext to use</param>
    public EmployeeRepository(SosuContext context)
        : base(context)
    {
    }
}
