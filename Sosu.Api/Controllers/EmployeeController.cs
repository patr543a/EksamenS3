﻿using Microsoft.AspNetCore.Mvc;
using Sosu.Api.Base;
using Sosu.Api.Interfaces;

namespace Sosu.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeeController 
    : CustomController<IEmployeeService>
{
    public EmployeeController(IEmployeeService service)
        : base(service)
    {
    }
}
