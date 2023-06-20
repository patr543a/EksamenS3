using Entities.Contexts;
using Entities.Sosu;
using Repository.Classes;

namespace Repository.Sosu;

/// <summary>
/// A Repository used for Resident
/// </summary>
public class ResidentRepository
    : Repository<SosuContext, Resident>
{
    /// <summary>
    /// Creates a new ResidentRepository from a SosuContext
    /// </summary>
    /// <param name="context">The SosuContext to use</param>
    public ResidentRepository(SosuContext context)
        : base(context)
    {
    }
}
