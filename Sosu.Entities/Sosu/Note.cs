namespace Entities.Sosu;

public partial class Note
{
    public int EmployeeId { get; set; }

    public int TaskId { get; set; }

    public string Text { get; set; } = null!;

    public virtual Employee? Employee { get; set; } = null!;

    public virtual Task? Task { get; set; } = null!;
}
