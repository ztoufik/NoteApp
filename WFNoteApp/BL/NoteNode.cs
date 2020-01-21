using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFNoteApp.BL
{
    public class NoteNode:TreeNode
    {
        public string Title { get; set; }
        public string Desc { get; set; }
        public bool IsSaved { get;set;}
        
        public NoteNode(string title="note"):base(title)
        {
            Text = title;
        }


    }
}
