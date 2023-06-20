using Entities.Sosu;
using Sosu.Api.Base;

namespace Sosu.Api.Interfaces;

public interface INoteService
    : IService
{
    void AddNote(Note note);
}
