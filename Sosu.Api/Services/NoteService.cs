using Entities.Contexts;
using Entities.Sosu;
using Microsoft.AspNetCore.Mvc;
using Repository.Sosu;
using Sosu.Api.Base;
using Sosu.Api.Interfaces;

namespace Sosu.Api.Services;

public class NoteService
    : ServiceBase<SosuUnitOfWork, SosuContext>, INoteService
{
    public ActionResult AddNote(Note note)
        => _repositories
            .NoteRepository
            .AddNote(note);
}
