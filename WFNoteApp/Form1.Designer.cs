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
            this.TrVwNotesList.BackColor = System.Drawing.Color.White;
            this.TrVwNotesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrVwNotesList.ForeColor = System.Drawing.Color.Black;
            this.TrVwNotesList.Location = new System.Drawing.Point(21, 55);
            this.TrVwNotesList.Name = "TrVwNotesList";
            this.TrVwNotesList.Size = new System.Drawing.Size(224, 407);
            this.TrVwNotesList.TabIndex = 0;
            this.TrVwNotesList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TrVwNotesList_AfterSelect);
            // 
            // TxtTitle
            // 
            this.TxtTitle.BackColor = System.Drawing.Color.White;
            this.TxtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTitle.Enabled = false;
            this.TxtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTitle.ForeColor = System.Drawing.Color.Black;
            this.TxtTitle.Location = new System.Drawing.Point(269, 55);
            this.TxtTitle.Multiline = true;
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(454, 47);
            this.TxtTitle.TabIndex = 1;
            // 
            // RTxtDesc
            // 
            this.RTxtDesc.BackColor = System.Drawing.Color.White;
            this.RTxtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTxtDesc.Enabled = false;
            this.RTxtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTxtDesc.ForeColor = System.Drawing.Color.Black;
            this.RTxtDesc.Location = new System.Drawing.Point(269, 156);
            this.RTxtDesc.Name = "RTxtDesc";
            this.RTxtDesc.Size = new System.Drawing.Size(561, 306);
            this.RTxtDesc.TabIndex = 2;
            this.RTxtDesc.Text = "";
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(266, 22);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(54, 26);
            this.LblTitle.TabIndex = 3;
            this.LblTitle.Text = "Titre";
            // 
            // LblDesc
            // 
            this.LblDesc.AutoSize = true;
            this.LblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDesc.Location = new System.Drawing.Point(266, 121);
            this.LblDesc.Name = "LblDesc";
            this.LblDesc.Size = new System.Drawing.Size(121, 26);
            this.LblDesc.TabIndex = 4;
            this.LblDesc.Text = "Description";
            // 
            // LblNotesList
            // 
            this.LblNotesList.AutoSize = true;
            this.LblNotesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNotesList.Location = new System.Drawing.Point(18, 22);
            this.LblNotesList.Name = "LblNotesList";
            this.LblNotesList.Size = new System.Drawing.Size(158, 26);
            this.LblNotesList.TabIndex = 5;
            this.LblNotesList.Text = "Liste des notes";
            // 
            // FormNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(855, 481);
            this.Controls.Add(this.LblNotesList);
            this.Controls.Add(this.LblDesc);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.RTxtDesc);
            this.Controls.Add(this.TxtTitle);
            this.Controls.Add(this.TrVwNotesList);
            this.ForeColor = System.Drawing.Color.Black;
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

