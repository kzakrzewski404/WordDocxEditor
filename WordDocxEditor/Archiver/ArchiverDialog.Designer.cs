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
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox_DetectedFiles = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox_Archived = new System.Windows.Forms.RichTextBox();
            this.richTextBox_FailedToArchive = new System.Windows.Forms.RichTextBox();
            this.button_Archive = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_FilesToArchive = new System.Windows.Forms.Label();
            this.label_FilesArchived = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_FilesFailedToArchive = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_OpenArchiveDir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Wykryte pliki do archiwizacji:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label1.Location = new System.Drawing.Point(352, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Pomyślnie zarchiwizowane:";
            // 
            // richTextBox_DetectedFiles
            // 
            this.richTextBox_DetectedFiles.Enabled = false;
            this.richTextBox_DetectedFiles.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox_DetectedFiles.Location = new System.Drawing.Point(16, 31);
            this.richTextBox_DetectedFiles.Name = "richTextBox_DetectedFiles";
            this.richTextBox_DetectedFiles.ReadOnly = true;
            this.richTextBox_DetectedFiles.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox_DetectedFiles.Size = new System.Drawing.Size(300, 400);
            this.richTextBox_DetectedFiles.TabIndex = 11;
            this.richTextBox_DetectedFiles.Text = "\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label2.Location = new System.Drawing.Point(692, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Pliki do ręcznej archiwizacji:";
            // 
            // richTextBox_Archived
            // 
            this.richTextBox_Archived.Enabled = false;
            this.richTextBox_Archived.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox_Archived.Location = new System.Drawing.Point(356, 31);
            this.richTextBox_Archived.Name = "richTextBox_Archived";
            this.richTextBox_Archived.ReadOnly = true;
            this.richTextBox_Archived.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox_Archived.Size = new System.Drawing.Size(300, 400);
            this.richTextBox_Archived.TabIndex = 13;
            this.richTextBox_Archived.Text = "";
            // 
            // richTextBox_FailedToArchive
            // 
            this.richTextBox_FailedToArchive.Enabled = false;
            this.richTextBox_FailedToArchive.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox_FailedToArchive.Location = new System.Drawing.Point(696, 31);
            this.richTextBox_FailedToArchive.Name = "richTextBox_FailedToArchive";
            this.richTextBox_FailedToArchive.ReadOnly = true;
            this.richTextBox_FailedToArchive.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox_FailedToArchive.Size = new System.Drawing.Size(300, 400);
            this.richTextBox_FailedToArchive.TabIndex = 15;
            this.richTextBox_FailedToArchive.Text = "";
            // 
            // button_Archive
            // 
            this.button_Archive.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Archive.Location = new System.Drawing.Point(856, 464);
            this.button_Archive.Name = "button_Archive";
            this.button_Archive.Size = new System.Drawing.Size(140, 31);
            this.button_Archive.TabIndex = 16;
            this.button_Archive.Text = "Archiwizuj";
            this.button_Archive.UseVisualStyleBackColor = true;
            this.button_Archive.Click += new System.EventHandler(this.button_Archive_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label3.Location = new System.Drawing.Point(12, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Plików:";
            // 
            // label_FilesToArchive
            // 
            this.label_FilesToArchive.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_FilesToArchive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label_FilesToArchive.Location = new System.Drawing.Point(72, 434);
            this.label_FilesToArchive.Name = "label_FilesToArchive";
            this.label_FilesToArchive.Size = new System.Drawing.Size(100, 19);
            this.label_FilesToArchive.TabIndex = 18;
            this.label_FilesToArchive.Text = "-";
            // 
            // label_FilesArchived
            // 
            this.label_FilesArchived.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_FilesArchived.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label_FilesArchived.Location = new System.Drawing.Point(412, 434);
            this.label_FilesArchived.Name = "label_FilesArchived";
            this.label_FilesArchived.Size = new System.Drawing.Size(100, 19);
            this.label_FilesArchived.TabIndex = 20;
            this.label_FilesArchived.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label7.Location = new System.Drawing.Point(352, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Plików:";
            // 
            // label_FilesFailedToArchive
            // 
            this.label_FilesFailedToArchive.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_FilesFailedToArchive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label_FilesFailedToArchive.Location = new System.Drawing.Point(752, 434);
            this.label_FilesFailedToArchive.Name = "label_FilesFailedToArchive";
            this.label_FilesFailedToArchive.Size = new System.Drawing.Size(100, 19);
            this.label_FilesFailedToArchive.TabIndex = 22;
            this.label_FilesFailedToArchive.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label9.Location = new System.Drawing.Point(692, 434);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = "Plików:";
            // 
            // button_OpenArchiveDir
            // 
            this.button_OpenArchiveDir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_OpenArchiveDir.Location = new System.Drawing.Point(16, 464);
            this.button_OpenArchiveDir.Name = "button_OpenArchiveDir";
            this.button_OpenArchiveDir.Size = new System.Drawing.Size(140, 31);
            this.button_OpenArchiveDir.TabIndex = 23;
            this.button_OpenArchiveDir.Text = "Otwórz folder archiwum";
            this.button_OpenArchiveDir.UseVisualStyleBackColor = true;
            this.button_OpenArchiveDir.Click += new System.EventHandler(this.button_OpenArchiveDir_Click);
            // 
            // ArchiverDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1014, 507);
            this.Controls.Add(this.button_OpenArchiveDir);
            this.Controls.Add(this.label_FilesFailedToArchive);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_FilesArchived);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_FilesToArchive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Archive);
            this.Controls.Add(this.richTextBox_FailedToArchive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox_Archived);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_DetectedFiles);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArchiverDialog";
            this.Text = "Archiwizowanie";
            this.Load += new System.EventHandler(this.ArchiverDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox_DetectedFiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox_Archived;
        private System.Windows.Forms.RichTextBox richTextBox_FailedToArchive;
        private System.Windows.Forms.Button button_Archive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_FilesToArchive;
        private System.Windows.Forms.Label label_FilesArchived;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_FilesFailedToArchive;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_OpenArchiveDir;
    }
}