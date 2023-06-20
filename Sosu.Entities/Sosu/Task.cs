using Entities.Dto.Sosu;
using Entities.Interfaces;

namespace Entities.Sosu;

/// <summary>
/// Represents a Task
/// </summary>
public partial class Task
    : IDtoConversion<Task, TaskDto>
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
    /// Determines if this Task is complete
    /// </summary>
    public bool IsComplete { get; set; }

    /// <summary>
    /// Id of Employee this Task was completed by. Null if IsComplete is false
    /// </summary>
    public int? CompletedBy { get; set; }

    /// <summary>
    /// Id of the Resident the Task is for
    /// </summary>
    public int ResidentId { get; set; }

    /// <summary>
    /// Reference to Employee who completed this Task. Null if IsComplete is false
    /// </summary>
    public virtual Employee? CompletedByNavigation { get; set; }

    /// <summary>
    /// Reference to a list of Notes
    /// </summary>
    public virtual ICollection<Note>? Notes { get; set; } = new List<Note>();

    /// <summary>
    /// Reference to a Resident
    /// </summary>
    public virtual Resident? Resident { get; set; } = null!;

    /// <summary>
    /// Converts this into a TaskDto
    /// </summary>
    /// <returns>TaskDto of this Task</returns>
    public TaskDto ToDto()
        => new(this);
}
