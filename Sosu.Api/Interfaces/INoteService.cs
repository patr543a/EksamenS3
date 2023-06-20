using Entities.Sosu;
using Sosu.Api.Base;

namespace Sosu.Api.Interfaces;

/// <summary>
/// Provides the method needed to be a NoteService
/// </summary>
public interface INoteService
    : IService
{
    /// <summary>
    /// Adds a Note to the database
    /// </summary>
    /// <param name="note">Note to add to the database</param>
    void AddNote(Note note);
}
