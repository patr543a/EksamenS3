using Microsoft.EntityFrameworkCore;

namespace Repository.Classes;

public abstract class UnitOfWorkBase<TContext>
    where TContext : DbContext, new()
{
    protected static readonly TContext _context = new();
}
