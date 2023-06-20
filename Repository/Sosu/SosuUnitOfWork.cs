using Entities.Contexts;
using Repository.Classes;

namespace Repository.Sosu;

/// <summary>
/// UnitOfWork class used for Sosu API
/// </summary>
public class SosuUnitOfWork
    : UnitOfWorkBase
{
    /// <summary>
    /// Employee Repository
    /// </summary>
    private EmployeeRepository? _employeeRepository;

    /// <summary>
    /// Note Repository
    /// </summary>
    private NoteRepository? _noteRepository;

    /// <summary>
    /// Resident Repository
    /// </summary>
    private ResidentRepository? _residentRepository;

    /// <summary>
    /// Task Repository
    /// </summary>
    private TaskRepository? _taskRepository;

    /// <summary>
    /// Employee Repository
    /// </summary>
    public EmployeeRepository EmployeeRepository
        => _employeeRepository ??= new(new SosuContext());

    /// <summary>
    /// Note Repository
    /// </summary>
    public NoteRepository NoteRepository
        => _noteRepository ??= new(new SosuContext());

    /// <summary>
    /// Resident Repository
    /// </summary>
    public ResidentRepository ResidentRepository
        => _residentRepository ??= new(new SosuContext());

    /// <summary>
    /// Task Repository
    /// </summary>
    public TaskRepository TaskRepository
        => _taskRepository ??= new(new SosuContext());
}
