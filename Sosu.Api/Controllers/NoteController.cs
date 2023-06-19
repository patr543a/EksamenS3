using Microsoft.AspNetCore.Mvc;
using Sosu.Api.Base;
using Sosu.Api.Interfaces;

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
}
