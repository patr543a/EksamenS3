using Entities.Dto.Sosu;
using Entities.Sosu;
using Microsoft.AspNetCore.Mvc;
using Sosu.Api.Base;
using Sosu.Api.Interfaces;
using Task = System.Threading.Tasks.Task;

namespace Sosu.Api.Controllers;

/// <summary>
/// API controller for actions with Notes
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class NoteController
    : CustomController<INoteService>
{
    /// <summary>
    /// Creates a new NoteController with the given INoteService
    /// </summary>
    /// <param name="service">INoteService to use</param>
    public NoteController(INoteService service)
        : base(service)
    {
    }

    /// <summary>
    /// Adds a Note to the database
    /// </summary>
    /// <param name="note">Note to add to the database</param>
    /// <returns>The result of adding the Note</returns>
    [HttpPost]
    [Route("post")]
    public async Task<ActionResult<NoteDto>> AddNote(Note? note)
    {
        // If null return BadRequest
        if (note is null)
            return BadRequest("Missing parameters");

        // Add note
        _service.AddNote(note);

        // Return result
        return await Task.FromResult(Ok(note.ToDto()));
    }
}
