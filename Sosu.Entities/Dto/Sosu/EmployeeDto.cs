using Entities.Interfaces;
using Entities.Sosu;

namespace Entities.Dto.Sosu;

/// <summary>
/// Dto of Employee
/// </summary>
public class EmployeeDto
    : IDto<EmployeeDto>
{
    /// <summary>
    /// Id of Employee
    /// </summary>
    public int EmployeeId { get; set; }

    /// <summary>
    /// Name of Employee
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Initials of Employee
    /// </summary>
    public string Initials { get; set; } = null!;

    /// <summary>
    /// Creates a new DtoEmployee from Employee
    /// </summary>
    /// <param name="employee">Employee to make Dto of</param>
    public EmployeeDto(Employee? employee)
    {
        // If null return
        if (employee is null)
            return;

        // Set properties
        EmployeeId = employee.EmployeeId;
        Name = employee.Name;
        Initials = employee.Initials;
    }
}
