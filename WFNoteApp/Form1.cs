using Squirrel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFNoteApp.BL;

namespace WFNoteApp
{
    public partial class FormNote : Form
    {
        public FormNote()
        {
            InitializeComponent();

            try
            {
                RestoreSavedNote();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }

            CheckForUpdate();
        }

        private async Task CheckForUpdate()
        {
            using (var manager=new UpdateManager(@"D:\NoteApp\Releases"))
            {
                await manager.UpdateApp();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.N))
            {
                CtrlNHandler();
                return true;
            }

            if (keyData == (Keys.Control | Keys.S))
            {
                CtrlSHandler();
                return true;
            }

            if (keyData == (Keys.Control | Keys.E))
            {
                CtrlEHandler();
                return true;
            }

            if (keyData == (Keys.Control | Keys.D))
            {
                CtrlDHandler();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void CtrlDHandler()
        {
            NoteNode note = TrVwNotesList.SelectedNode as NoteNode;

            if (note?.IsSaved??false)
            {
                if (ML.DeleteNoteNode(note))
                {
                    TxtTitle.Text = RTxtDesc.Text = string.Empty;

                    note.IsSaved = false;
                    TrVwNotesList.Nodes.Remove(note); 
                }
                else
                {
                    MessageBox.Show("failed deletion");
                }
            }
        }

        private void CtrlEHandler()
        {
            NoteNode note = TrVwNotesList.SelectedNode as NoteNode;

            if (note?.IsSaved ?? false)
            {
                if (ML.DeleteNoteNode(note))
                {
                    TxtTitle.Enabled = RTxtDesc.Enabled = true;
                    note.IsSaved = false;
                    note.ForeColor = Color.Yellow;
                    note.BackColor = Color.Red; 
                }
                else
                {
                    MessageBox.Show("failed deletion");
                }
            }
        }

        private void CtrlNHandler()
        {
            if ((TrVwNotesList.SelectedNode as NoteNode)?.IsSaved ??true )
            {
                TxtTitle.Text = RTxtDesc.Text = string.Empty;
                TxtTitle.Enabled = RTxtDesc.Enabled = true;
                TxtTitle.Focus();

                TreeNode node = new NoteNode();
                node.ForeColor = Color.Yellow;
                node.BackColor = Color.Red;
                TrVwNotesList.Nodes.Add(node);

                TrVwNotesList.SelectedNode=node; 
            }
        }

        private void CtrlSHandler()
        {
            NoteNode note = TrVwNotesList.SelectedNode as NoteNode;

            if (!note?.IsSaved??false)
            {
                note.Text = note.Title = TxtTitle.Text;
                note.Desc = RTxtDesc.Text;

                if (ML.SaveNoteNode(note))
                {
                    note.IsSaved = true;

                    note.ForeColor = Color.Black;
                    note.BackColor = Color.White;

                    TxtTitle.Enabled = RTxtDesc.Enabled = false;
                } 
            }

        }

        private void RestoreSavedNote()
        {
            IEnumerable<NoteNode> noteslist = ML.RetrieveNotes(null);
            if (noteslist.Count()>0)
            {
                foreach (var note in noteslist)
                {
                    note.IsSaved = true;
                    TrVwNotesList.Nodes.Add(note);
                }
                TrVwNotesList.SelectedNode = TrVwNotesList.Nodes?[0];
                TxtTitle.Text = (TrVwNotesList.SelectedNode as NoteNode)?.Title;
                RTxtDesc.Text = (TrVwNotesList.SelectedNode as NoteNode)?.Desc; 
            }
        }

        private void TrVwNotesList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Action)
            {
                case TreeViewAction.ByKeyboard:

                case TreeViewAction.ByMouse:
                    {
                        TxtTitle.Text = (e.Node as NoteNode)?.Title;
                        RTxtDesc.Text = (e.Node as NoteNode)?.Desc;
                        break;
                    }

            }
        }
    }
}
