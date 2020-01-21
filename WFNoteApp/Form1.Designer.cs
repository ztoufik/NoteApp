namespace WFNoteApp
{
    partial class FormNote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TrVwNotesList = new System.Windows.Forms.TreeView();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.RTxtDesc = new System.Windows.Forms.RichTextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblDesc = new System.Windows.Forms.Label();
            this.LblNotesList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TrVwNotesList
            // 
            this.TrVwNotesList.Location = new System.Drawing.Point(21, 55);
            this.TrVwNotesList.Name = "TrVwNotesList";
            this.TrVwNotesList.Size = new System.Drawing.Size(160, 367);
            this.TrVwNotesList.TabIndex = 0;
            this.TrVwNotesList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TrVwNotesList_AfterSelect);
            // 
            // TxtTitle
            // 
            this.TxtTitle.Enabled = false;
            this.TxtTitle.Location = new System.Drawing.Point(269, 55);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(242, 20);
            this.TxtTitle.TabIndex = 1;
            // 
            // RTxtDesc
            // 
            this.RTxtDesc.Enabled = false;
            this.RTxtDesc.Location = new System.Drawing.Point(269, 116);
            this.RTxtDesc.Name = "RTxtDesc";
            this.RTxtDesc.Size = new System.Drawing.Size(427, 306);
            this.RTxtDesc.TabIndex = 2;
            this.RTxtDesc.Text = "";
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(266, 33);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(28, 13);
            this.LblTitle.TabIndex = 3;
            this.LblTitle.Text = "Titre";
            // 
            // LblDesc
            // 
            this.LblDesc.AutoSize = true;
            this.LblDesc.Location = new System.Drawing.Point(266, 92);
            this.LblDesc.Name = "LblDesc";
            this.LblDesc.Size = new System.Drawing.Size(60, 13);
            this.LblDesc.TabIndex = 4;
            this.LblDesc.Text = "Description";
            // 
            // LblNotesList
            // 
            this.LblNotesList.AutoSize = true;
            this.LblNotesList.Location = new System.Drawing.Point(18, 33);
            this.LblNotesList.Name = "LblNotesList";
            this.LblNotesList.Size = new System.Drawing.Size(78, 13);
            this.LblNotesList.TabIndex = 5;
            this.LblNotesList.Text = "Liste des notes";
            // 
            // FormNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblNotesList);
            this.Controls.Add(this.LblDesc);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.RTxtDesc);
            this.Controls.Add(this.TxtTitle);
            this.Controls.Add(this.TrVwNotesList);
            this.Name = "FormNote";
            this.Text = "Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView TrVwNotesList;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.RichTextBox RTxtDesc;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblDesc;
        private System.Windows.Forms.Label LblNotesList;
    }
}

