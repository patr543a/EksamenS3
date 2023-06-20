using Entities.Interfaces;
using Entities.Sosu;
using Task = Entities.Sosu.Task;

namespace Entities.Dto.Sosu;

/// <summary>
/// Dto of Task
/// </summary>
public class TaskDto
    : IDto<TaskDto>
{
    /// <summary>
    /// Id of Task
    /// </summary>
    public int TaskId { get; set; }

    /// <summary>
    /// Title of Task
    /// </summary>
    public string Title { get; set; } = null!;

    /// <summary>
    /// Description of Task
    /// </summary>
    public string Description { get; set; } = null!;

    /// <summary>
    /// Start date of Task
    /// </summary>
    public DateTime StartDate { get; set; }

    /// <summary>
    /// End date of Task
    /// </summary>
    public DateTime EndDate { get; set; }

    /// <summary>
    /// Determines if Task is complete
    /// </summary>
    public bool IsComplete { get; set; }

    /// <summary>
    /// Who the Task was completed by. Null if IsComplete is false
    /// </summary>
    public virtual EmployeeDto? CompletedBy { get; set; }

    /// <summary>
    /// Reference to a list of Notes
    /// </summary>
    public virtual ICollection<NoteDto>? Notes { get; set; } = new List<NoteDto>();

    /// <summary>
    /// Reference to a ResidentDto
    /// </summary>
    public virtual ResidentDto? Resident { get; set; } = null!;

    /// <summary>
    /// Creates a new TaskDto from Task
    /// </summary>
    /// <param name="task">Task to make Dto of</param>
    public TaskDto(Task? task)
    {
        // If null return
        if (task is null)
            return;

        // Set properties
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
