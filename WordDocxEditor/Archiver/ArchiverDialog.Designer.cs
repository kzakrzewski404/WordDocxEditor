namespace WordDocxEditor.Archiver
{
    partial class ArchiverDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArchiverDialog));
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox_DetectedFiles = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Archived = new System.Windows.Forms.RichTextBox();
            this.button_Archive = new System.Windows.Forms.Button();
            this.button_OpenArchiveDir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Wykryte pliki:";
            // 
            // richTextBox_DetectedFiles
            // 
            this.richTextBox_DetectedFiles.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox_DetectedFiles.Location = new System.Drawing.Point(16, 31);
            this.richTextBox_DetectedFiles.Name = "richTextBox_DetectedFiles";
            this.richTextBox_DetectedFiles.ReadOnly = true;
            this.richTextBox_DetectedFiles.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox_DetectedFiles.Size = new System.Drawing.Size(400, 400);
            this.richTextBox_DetectedFiles.TabIndex = 11;
            this.richTextBox_DetectedFiles.Text = "\n";
            // 
            // richTextBox_Archived
            // 
            this.richTextBox_Archived.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox_Archived.Location = new System.Drawing.Point(442, 31);
            this.richTextBox_Archived.Name = "richTextBox_Archived";
            this.richTextBox_Archived.ReadOnly = true;
            this.richTextBox_Archived.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox_Archived.Size = new System.Drawing.Size(400, 400);
            this.richTextBox_Archived.TabIndex = 13;
            this.richTextBox_Archived.Text = "";
            // 
            // button_Archive
            // 
            this.button_Archive.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Archive.Location = new System.Drawing.Point(718, 449);
            this.button_Archive.Name = "button_Archive";
            this.button_Archive.Size = new System.Drawing.Size(124, 31);
            this.button_Archive.TabIndex = 1;
            this.button_Archive.Text = "Archiwizuj";
            this.button_Archive.UseVisualStyleBackColor = true;
            this.button_Archive.Click += new System.EventHandler(this.button_Archive_Click);
            // 
            // button_OpenArchiveDir
            // 
            this.button_OpenArchiveDir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_OpenArchiveDir.Location = new System.Drawing.Point(146, 450);
            this.button_OpenArchiveDir.Name = "button_OpenArchiveDir";
            this.button_OpenArchiveDir.Size = new System.Drawing.Size(124, 31);
            this.button_OpenArchiveDir.TabIndex = 2;
            this.button_OpenArchiveDir.Text = "Otwórz archiwum";
            this.button_OpenArchiveDir.UseVisualStyleBackColor = true;
            this.button_OpenArchiveDir.Click += new System.EventHandler(this.button_OpenArchiveDir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label1.Location = new System.Drawing.Point(438, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Przebieg archiwizacji:";
            // 
            // button_Refresh
            // 
            this.button_Refresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Refresh.Location = new System.Drawing.Point(16, 450);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(124, 31);
            this.button_Refresh.TabIndex = 22;
            this.button_Refresh.Text = "Odśwież";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // ArchiverDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(854, 492);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_OpenArchiveDir);
            this.Controls.Add(this.button_Archive);
            this.Controls.Add(this.richTextBox_Archived);
            this.Controls.Add(this.richTextBox_DetectedFiles);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArchiverDialog";
            this.Text = "Archiwizowanie";
            this.Load += new System.EventHandler(this.OnArchiverDialogDisplay);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox_DetectedFiles;
        private System.Windows.Forms.RichTextBox richTextBox_Archived;
        private System.Windows.Forms.Button button_Archive;
        private System.Windows.Forms.Button button_OpenArchiveDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Refresh;
    }
}