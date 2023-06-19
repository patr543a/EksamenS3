using Entities.Interfaces;
using Entities.Sosu;

namespace Entities.Dto.Sosu;

public class NoteDto
    : IDto<NoteDto>
{
    public int EmployeeId { get; set; }

    public int TaskId { get; set; }

    public string Text { get; set; } = null!;

    public virtual EmployeeDto? Employee { get; set; } = null!;

    public NoteDto(Note? note)
    {
        if (note is null)
            return;

        EmployeeId = note.EmployeeId;
        TaskId = note.TaskId;
        Text = note.Text;
        Employee = note.Employee is null ? null : new(note.Employee);
    }
}
