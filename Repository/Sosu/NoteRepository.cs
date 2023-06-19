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

    public ActionResult AddNote(Note note)
    {
        try
        {
            Insert(note);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);

            return new StatusCodeResult(StatusCodes.Status500InternalServerError);
        }

        Save();

        return new StatusCodeResult(StatusCodes.Status200OK);
    }
}
