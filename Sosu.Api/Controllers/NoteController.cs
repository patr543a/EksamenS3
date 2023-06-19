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
    public async Task<ActionResult> AddNote(Note? note)
    {
        if (note is null)
            return BadRequest("Missing parameters");

        return await Task.FromResult(_service.AddNote(note));
    }
}
