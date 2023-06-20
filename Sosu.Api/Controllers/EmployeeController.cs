using Microsoft.AspNetCore.Mvc;
using Sosu.Api.Base;
using Sosu.Api.Interfaces;

namespace Sosu.Api.Controllers;

/// <summary>
/// API controller for actions with Employees
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class EmployeeController 
    : CustomController<IEmployeeService>
{
    /// <summary>
    /// Creates a new EmployeeController with the given IEmployeeService
    /// </summary>
    /// <param name="service">IEmployeeService to use</param>
    public EmployeeController(IEmployeeService service)
        : base(service)
    {
    }
}
