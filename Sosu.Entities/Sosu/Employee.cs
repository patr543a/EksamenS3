namespace Entities.Sosu;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string Name { get; set; } = null!;

    public string Initials { get; set; } = null!;

    public virtual ICollection<Note>? Notes { get; set; } = new List<Note>();

    public virtual ICollection<Task>? Tasks { get; set; } = new List<Task>();
}
