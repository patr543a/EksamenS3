using Entities.Dto.Sosu;
using Entities.Interfaces;

namespace Entities.Sosu;

/// <summary>
/// Represents a Note
/// </summary>
public partial class Note
    : IDtoConversion<Note, NoteDto>
{
    /// <summary>
    /// Id of Employee
    /// </summary>
    public int EmployeeId { get; set; }

    /// <summary>
    /// Id of Task
    /// </summary>
    public int TaskId { get; set; }

    /// <summary>
    /// Text of Note
    /// </summary>
    public string Text { get; set; } = null!;

    /// <summary>
    /// Reference to an Employee
    /// </summary>
    public virtual Employee? Employee { get; set; } = null!;

    /// <summary>
    /// Reference to a Task
    /// </summary>
    public virtual Task? Task { get; set; } = null!;

    /// <summary>
    /// Converts this into a NoteDto
    /// </summary>
    /// <returns>NoteDto of this Note</returns>
    public NoteDto ToDto()
        => new(this);
}
