using Microsoft.EntityFrameworkCore;
using Repository.Classes;
using Repository.Sosu;

namespace Sosu.Api.Base;

public class ServiceBase<TUnitOfWork, TContext>
    where TUnitOfWork : UnitOfWorkBase, new()
    where TContext : DbContext, new()
{
    protected static readonly SosuUnitOfWork _repositories = new();
}
