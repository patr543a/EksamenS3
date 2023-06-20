using Entities.Dto.Sosu;
using Entities.Interfaces;

namespace Entities.Sosu;

/// <summary>
/// Represents an Employee
/// </summary>
public partial class Employee
    : IDtoConversion<Employee, EmployeeDto>
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
    /// Reference to a list of Notes
    /// </summary>
    public virtual ICollection<Note>? Notes { get; set; } = new List<Note>();

    /// <summary>
    /// Reference to a list of Tasks
    /// </summary>
    public virtual ICollection<Task>? Tasks { get; set; } = new List<Task>();

    /// <summary>
    /// Converts this into a EmployeeDto
    /// </summary>
    /// <returns>EmployeeDto of this Employee</returns>
    public EmployeeDto ToDto()
        => new(this);
}
