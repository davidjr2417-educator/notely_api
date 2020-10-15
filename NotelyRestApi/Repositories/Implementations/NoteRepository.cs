using NotelyRestApi.Database;
using NotelyRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotelyRestApi.Repositories.Implementations
{
    public class NoteRepository :INoteRepository
    {
        private NotelyDbContext _context;
        public NoteRepository(NotelyDbContext context)
        {
            _context = context;
        }
        public Note FindNoteById(long id)
        {
            var notes = _context.Notes.Find(id);
            return notes;
        }
        public IEnumerable<Note> GetAllNotes()
        {
            var notes = _context.Notes;
            return notes;
        }
        public void SaveNote(Note note)
        {
            _context.Notes.Add(note);
            _context.SaveChanges();
        }
        public void EditNote(Note note)
        {
            _context.Notes.Update(note);
            _context.SaveChanges();
        }
        public void DeleteNote(Note note)
        {
            _context.Notes.Remove(note);
            _context.SaveChanges();
        }
    }
}
