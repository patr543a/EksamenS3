using Entities.Interfaces;
using Entities.Sosu;

namespace Entities.Dto.Sosu;

public class EmployeeDto
    : IDto<EmployeeDto>
{
    public int EmployeeId { get; set; }

    public string Name { get; set; } = null!;

    public string Initials { get; set; } = null!;

    public EmployeeDto(Employee? employee)
    {
        if (employee is null)
            return;

        EmployeeId = employee.EmployeeId;
        Name = employee.Name;
        Initials = employee.Initials;
    }
}
