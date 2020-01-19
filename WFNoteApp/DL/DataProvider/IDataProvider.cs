using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFNoteApp.DL.DB;

namespace WFNoteApp.DL.DataProvider
{
    public interface IDataProvider
    {
        bool SaveNote(INote note);

        bool DeleteNote(INote note);

        bool UpdateNote(INote oldnote,INote newnote );

        IEnumerable<INote> RetreiveNote(string title);
    }
}
