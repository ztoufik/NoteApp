using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFNoteApp.DL.DB
{
    public interface INote
    {
         int Id { get; set; }
         string Title { get; set; }
         string Desc { get; set; }
    }
}
