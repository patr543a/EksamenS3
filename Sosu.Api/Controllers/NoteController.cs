using Entities.Dto.Sosu;
using Entities.Sosu;
using Microsoft.AspNetCore.Mvc;
using Sosu.Api.Base;
using Sosu.Api.Interfaces;
using Task = System.Threading.Tasks.Task;

namespace Sosu.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class NoteController
    : CustomController<INoteService>
{
    public NoteController(INoteService service)
        : base(service)
    {
    }

    [HttpPost]
    [Route("post")]
    public async Task<ActionResult<NoteDto>> AddNote(Note? note)
    {
        if (note is null)
            return BadRequest("Missing parameters");

        _service.AddNote(note);

        return await Task.FromResult(Ok(note.ToDto()));
    }
}
