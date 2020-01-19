using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFNoteApp
{
    public partial class FormNote : Form
    {
        public FormNote()
        {
            InitializeComponent();
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
        }

        private void CtrlEHandler()
        {
        }

        private void CtrlNHandler()
        {
        }

        private void CtrlSHandler()
        {
        }
    }
}
