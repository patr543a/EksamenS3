using Entities.Interfaces;
using Entities.Sosu;
using Task = Entities.Sosu.Task;

namespace Entities.Dto.Sosu;

public class TaskDto
    : IDto<TaskDto>
{
    public int TaskId { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public bool IsComplete { get; set; }

    public virtual EmployeeDto? CompletedBy { get; set; }

    public virtual ICollection<NoteDto>? Notes { get; set; } = new List<NoteDto>();

    public virtual ResidentDto? Resident { get; set; } = null!;

    public TaskDto(Task? task)
    {
        if (task is null)
            return;

        TaskId = task.TaskId;
        Title = task.Title;
        Description = task.Description;
        StartDate = task.StartDate;
        EndDate = task.EndDate;
        IsComplete = task.IsComplete;
        CompletedBy = task.CompletedByNavigation is null ? null : new(task.CompletedByNavigation);
        Notes = task.Notes is null ? Notes : task.Notes.Select(n => n.ToDto()).ToList();
        Resident = task.Resident is null ? null : new(task.Resident);
    }
}
