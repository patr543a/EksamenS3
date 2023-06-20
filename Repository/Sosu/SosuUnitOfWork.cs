using Entities.Contexts;
using Repository.Classes;

namespace Repository.Sosu;

public class SosuUnitOfWork
    : UnitOfWorkBase
{
    private EmployeeRepository? _employeeRepository;
    private NoteRepository? _noteRepository;
    private ResidentRepository? _residentRepository;
    private TaskRepository? _taskRepository;

    public EmployeeRepository EmployeeRepository
        => _employeeRepository ??= new(new SosuContext());

    public NoteRepository NoteRepository
        => _noteRepository ??= new(new SosuContext());

    public ResidentRepository ResidentRepository
        => _residentRepository ??= new(new SosuContext());
    
    public TaskRepository TaskRepository
        => _taskRepository ??= new(new SosuContext());
}
