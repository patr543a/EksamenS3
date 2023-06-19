using Entities.Contexts;
using Entities.Sosu;
using Repository.Classes;

namespace Repository.Sosu;

public class NoteRepository
    : Repository<SosuContext, Note>
{
    public NoteRepository(SosuContext context)
        : base(context)
    {
    }
}
