using Repository.Classes;

namespace Sosu.Api.Base;

/// <summary>
/// The base of a service
/// </summary>
/// <typeparam name="TUnitOfWork">The UnitOfWork class to use</typeparam>
/// <typeparam name="TContext">The context to use</typeparam>
public class ServiceBase<TUnitOfWork>
    where TUnitOfWork : UnitOfWorkBase, new()
{
    /// <summary>
    /// A UnitOfWork class of type TUnitOfWork
    /// </summary>
    protected static readonly TUnitOfWork _repositories = new();
}
