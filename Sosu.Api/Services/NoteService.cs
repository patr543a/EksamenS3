using Entities.Sosu;
using Repository.Sosu;
using Sosu.Api.Base;
using Sosu.Api.Interfaces;

namespace Sosu.Api.Services;

/// <summary>
/// Represents an INoteService
/// </summary>
public class NoteService
    : ServiceBase<SosuUnitOfWork>, INoteService
{
    /// <summary>
    /// Adds a Note to the database
    /// </summary>
    /// <param name="note">Note to add to the database</param>
    public void AddNote(Note note)
        => _repositories
            .NoteRepository
            .AddNote(note);
}
