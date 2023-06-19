using Entities.Contexts;
using Entities.Dto.Sosu;
using Microsoft.AspNetCore.Mvc;
using Repository.Sosu;
using Sosu.Api.Base;
using Sosu.Api.Interfaces;

namespace Sosu.Api.Services;

public class NoteService
    : ServiceBase<SosuUnitOfWork, SosuContext>, INoteService
{
    public ActionResult<NoteDto> AddNote(NoteDto note)
    {
        throw new NotImplementedException();
    }
}
