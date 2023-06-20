using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Repository.Classes;

/// <summary>
/// The base of a Repository using EntityFramework
/// </summary>
/// <typeparam name="TContext">The context this Repository will use</typeparam>
/// <typeparam name="TEntity">The entity from the context this Repository will use</typeparam>
public abstract class Repository<TContext, TEntity>
    : IDisposable
    where TContext : DbContext
    where TEntity : class
{
    /// <summary>
    /// Context of type TContext
    /// </summary>
    protected readonly TContext _context;

    /// <summary>
    /// DbSet of type TEntity
    /// </summary>
    protected readonly DbSet<TEntity> _dbSet;

    /// <summary>
    /// Creates a new Repository with the given context of type TContext
    /// </summary>
    /// <param name="context">Context this Repository will use</param>
    public Repository(TContext context)
    {
        // Set fields
        _context = context;
        _dbSet = _context.Set<TEntity>();
    }

    /// <summary>
    /// Gets all TEntity from it's table from the database
    /// </summary>
    /// <param name="filter">Determines what TEntity's will be returned</param>
    /// <param name="orderBy">Determines what order TEntity's will be returned in</param>
    /// <param name="includeProperties">What other tables to include in the command</param>
    /// <returns></returns>
    public virtual IEnumerable<TEntity> Get(
        Expression<Func<TEntity, bool>>? filter = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
        string includeProperties = "")
    {
        // Convert to IQueryable<TEntity>
        var query = _dbSet as IQueryable<TEntity>;

        // If includeProperties is not empty include tables it defines
        if (includeProperties != string.Empty)
            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                query = query.Include(includeProperty);

        // Filter the query
        if (filter is not null)
            query = query.Where(filter);

        // Order list and return it
        return orderBy is null ? query : orderBy(query);
    }

    /// <summary>
    /// Gets a TEntity by an id
    /// </summary>
    /// <param name="id">Id to search for</param>
    /// <returns>A TEnity with the given id</returns>
    /// <exception cref="InvalidOperationException" />
    public virtual TEntity? GetByID(object id)
        => _dbSet.Find(id);

    /// <summary>
    /// Adds a TEnity to it's table
    /// </summary>
    /// <param name="entity">TEntity to add</param>
    public virtual void Insert(TEntity entity)
        => _dbSet.Add(entity);

    /// <summary>
    /// Deletes a TEntiy from it's table by id
    /// </summary>
    /// <param name="id">Id of the TEntity to delete</param>
    /// <exception cref="InvalidOperationException" />
    public virtual void Delete(object id)
    {
        // Get entity to delete
        var entityToDelete = _dbSet.Find(id);

        // If null return
        if (entityToDelete is null)
            return;

        // Delete entity
        Delete(entityToDelete);
    }

    /// <summary>
    /// Deletes the given TEntity from it's table
    /// </summary>
    /// <param name="entityToDelete">TEntity to delete</param>
    public virtual void Delete(TEntity entityToDelete)
    {
        // If not attached attach it
        if (_context.Entry(entityToDelete).State == EntityState.Detached)
            _dbSet.Attach(entityToDelete);

        // Remove it
        _dbSet.Remove(entityToDelete);
    }

    /// <summary>
    /// Updates the given TEntiy
    /// </summary>
    /// <param name="entityToUpdate">TEntiy to update</param>
    public virtual void Update(TEntity entityToUpdate)
    {
        // Attach
        _dbSet.Attach(entityToUpdate);

        // Change state
        _context.Entry(entityToUpdate).State = EntityState.Modified;
    }

    /// <summary>
    /// Saves changes made by other operations
    /// </summary>
    /// <exception cref="InvalidOperationException" />
    public virtual void Save()
        => _context.SaveChanges();

    /// <summary>
    /// Disposes of this class
    /// </summary>
    public void Dispose()
    {
        // Save changes and Dispose context
        _context.SaveChanges();
        _context.Dispose();

        // SuppressFinalize
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// Detaches the given TEntity from EntityFramework
    /// </summary>
    /// <param name="entity">TEntity to detach</param>
    public void Detach(TEntity entity)
        => _context.Entry(entity).State = EntityState.Detached;

    /// <summary>
    /// Detaches the given object from EntityFramework
    /// </summary>
    /// <param name="entity">Object to detach</param>
    public void Detach(object entity)
        => _context.Entry(entity).State = EntityState.Detached;

    /// <summary>
    /// Finalizer
    /// </summary>
    ~Repository()
        => Dispose();
}
