using Entities.Interfaces;
using Entities.Sosu;

namespace Entities.Dto.Sosu;

/// <summary>
/// Dto of Note
/// </summary>
public class NoteDto
    : IDto<NoteDto>
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
    /// Reference to EmployeeDto
    /// </summary>
    public virtual EmployeeDto? Employee { get; set; } = null!;

    /// <summary>
    /// Creates a new NoteDto from Note
    /// </summary>
    /// <param name="note">Note to make Dto of</param>
    public NoteDto(Note? note)
    {
        // If null return
        if (note is null)
            return;

        // Set properties
        EmployeeId = note.EmployeeId;
        TaskId = note.TaskId;
        Text = note.Text;
        Employee = note.Employee is null ? null : new(note.Employee);
    }
}
