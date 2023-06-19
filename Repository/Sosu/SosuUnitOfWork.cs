using Entities.Contexts;
using Repository.Classes;

namespace Repository.Sosu;

public class SosuUnitOfWork
    : UnitOfWorkBase<SosuContext>
{
    private EmployeeRepository? _employeeRepository;
    private NoteRepository? _noteRepository;
    private ResidentRepository? _residentRepository;
    private TaskRepository? _taskRepository;

    public EmployeeRepository EmployeeRepository
        => _employeeRepository ??= new(_context);

    public NoteRepository NoteRepository
        => _noteRepository ??= new(_context);

    public ResidentRepository ResidentRepository
        => _residentRepository ??= new(_context);
    
    public TaskRepository TaskRepository
        => _taskRepository ??= new(_context);
}
