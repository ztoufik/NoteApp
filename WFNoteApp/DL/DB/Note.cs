using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFNoteApp.DL.DB
{
    public class Note : INote
    {
        public int Id { get ; set ; }
        public string Title { get ; set; }
        public string Desc { get; set; }
    }
}
