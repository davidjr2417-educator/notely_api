using NotelyRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotelyRestApi.Repositories
{
    public interface INoteRepository
    {

        Note FindNoteById(long id);

        IEnumerable<Note> GetAllNotes();

        void SaveNote(Note note);

        void EditNote(Note note);

        void DeleteNote(Note note);
    }
}
