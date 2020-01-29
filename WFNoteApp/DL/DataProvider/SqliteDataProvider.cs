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
                    Note SelectedNote = notesDb.Notes.FirstOrDefault(
                        (NOTE) => (NOTE.Title==note.Title) && (NOTE.Desc==note.Desc)
                        );
                    notesDb.Notes.Remove(SelectedNote);
                    notesDb.SaveChanges();
                }
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }

        public IEnumerable<INote> RetreiveNote(string title=null)
        {
            try
            {
                using (NotesDbContext notesDb=new NotesDbContext() )
                {
                    IEnumerable<INote> notes = 
                        string.IsNullOrEmpty(title)?notesDb.Notes:notesDb.Notes.Where((note) => note.Title == title);

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

    }
}
