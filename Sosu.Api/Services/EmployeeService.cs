using Entities.Contexts;
using Repository.Sosu;
using Sosu.Api.Base;
using Sosu.Api.Interfaces;

namespace Sosu.Api.Services;

public class EmployeeService
    : ServiceBase<SosuUnitOfWork, SosuContext>, IEmployeeService
{
}
