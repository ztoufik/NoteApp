﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFNoteApp.DL.DataProvider;
using WFNoteApp.DL.DB;

namespace WFNoteApp.BL
{
    public static class ML
    {
        private static IDataProvider dataProvider;

        static  ML()
        {
            dataProvider = new SqliteDataProvider();
        }

        public static bool SaveNoteNode(NoteNode noteNode)
        {
            Note note = NoteNode2Note(noteNode);

            return dataProvider.SaveNote(note);
            
        }

        public static bool DeleteNoteNode(NoteNode noteNode)
        {
            Note note = NoteNode2Note(noteNode);

            return dataProvider.DeleteNote(note);
           
        }

        public static IEnumerable<NoteNode> RetrieveNotes(string Title)
        {
            return dataProvider.RetreiveNote(Title).ToList().Select((NOTE)=>Note2NoteNode(NOTE as Note));
        }

        private static Note NoteNode2Note(NoteNode noteNode)
        {
            return new Note()
            {
                Title = noteNode.Title,
                Desc = noteNode.Desc
            };
        }
        
        private static NoteNode Note2NoteNode(Note note)
        {
            return new NoteNode(note.Title)
            {
                Title = note.Title,
                Desc = note.Desc,
            };
        }
    }
}
