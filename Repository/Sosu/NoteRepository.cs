using Entities.Contexts;
using Entities.Sosu;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Classes;

namespace Repository.Sosu;

public class NoteRepository
    : Repository<SosuContext, Note>
{
    public NoteRepository(SosuContext context)
        : base(context)
    {
    }

    public void AddNote(Note note)
    {
        Insert(note);

        Save();
    }
}
