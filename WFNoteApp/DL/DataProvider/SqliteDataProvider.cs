using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFNoteApp.DL.DB;

namespace WFNoteApp.DL.DataProvider
{
    class SqliteDataProvider : IDataProvider
    {
        public SqliteDataProvider()
        {
            using (NotesDbContext notescontext=new NotesDbContext())
            {
                notescontext.Database.Migrate();
            }
        }

        public bool DeleteNote(INote note)
        {
            try
            {
                using (NotesDbContext notesDb=new NotesDbContext())
                {
                    notesDb.Notes.Remove(note as Note);
                    notesDb.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<INote> RetreiveNote(string title)
        {
            try
            {
                using (NotesDbContext notesDb=new NotesDbContext() )
                {
                    IEnumerable<INote> notes = notesDb.Notes.Where((note) => note.Title == title);

                    return notes.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool SaveNote(INote note)
        {
            try
            {
                Note NoteToSave = note as Note;
                using (NotesDbContext notesDb=new NotesDbContext())
                {
                    notesDb.Notes.Add(NoteToSave);
                    notesDb.SaveChanges();
                    return true;
                }
            }
            catch (Exception )
            {
                return false;
            }
        }

        public bool UpdateNote(INote oldnote, INote newnote)
        {
            try
            {
                using (NotesDbContext notesDb=new NotesDbContext())
                {
                    INote SelectedNote = notesDb.Notes.Single(
                        (note) => (note.Title == oldnote.Title) && (note.Desc == oldnote.Desc)
                        );

                    SelectedNote.Title = newnote.Title;
                    SelectedNote.Desc = newnote.Desc;

                    notesDb.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
