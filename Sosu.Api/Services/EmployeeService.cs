using Repository.Sosu;
using Sosu.Api.Base;
using Sosu.Api.Interfaces;

namespace Sosu.Api.Services;

/// <summary>
/// Represents an IEmployeeService
/// </summary>
public class EmployeeService
    : ServiceBase<SosuUnitOfWork>, IEmployeeService
{
}
