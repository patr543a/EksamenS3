using Entities.Contexts;
using Entities.Sosu;
using Repository.Classes;

namespace Repository.Sosu;

/// <summary>
/// A Repository used for Note
/// </summary>
public class NoteRepository
    : Repository<SosuContext, Note>
{
    /// <summary>
    /// Creates a new NoteRepository from a SosuContext
    /// </summary>
    /// <param name="context">The SosuContext to use</param>
    public NoteRepository(SosuContext context)
        : base(context)
    {
    }

    /// <summary>
    /// Adds a Note to the database
    /// </summary>
    /// <param name="note">Note to add</param>
    /// <exception cref="InvalidOperationException" />
    public void AddNote(Note note)
    {
        Insert(note);

        Save();
    }
}
