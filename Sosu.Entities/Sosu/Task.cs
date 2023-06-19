using Entities.Dto.Sosu;
using Entities.Interfaces;

namespace Entities.Sosu;

public partial class Task
    : IDtoConversion<Task, TaskDto>
{
    public int TaskId { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public bool IsComplete { get; set; }

    public int? CompletedBy { get; set; }

    public int ResidentId { get; set; }

    public virtual Employee? CompletedByNavigation { get; set; }

    public virtual ICollection<Note>? Notes { get; set; } = new List<Note>();

    public virtual Resident? Resident { get; set; } = null!;

    public TaskDto ToDto()
        => new(this);
}
