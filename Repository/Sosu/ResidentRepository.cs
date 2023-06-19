using Entities.Contexts;
using Entities.Sosu;
using Repository.Classes;

namespace Repository.Sosu;

public class ResidentRepository
    : Repository<SosuContext, Resident>
{
    public ResidentRepository(SosuContext context)
        : base(context)
    {
    }
}
