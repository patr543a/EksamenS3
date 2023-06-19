using Entities.Dto.Sosu;
using Entities.Sosu;
using Microsoft.AspNetCore.Mvc;
using Sosu.Api.Base;

namespace Sosu.Api.Interfaces;

public interface INoteService
    : IService
{
    ActionResult AddNote(Note note);
}
