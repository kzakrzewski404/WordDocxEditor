namespace WordDocxEditor
{
    partial class HistoryView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryView));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_ExportToExcel = new System.Windows.Forms.Button();
            this.label_numberOfEntries = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Nr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReceived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateResponse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.template = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasPrinted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfCopies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nr,
            this.name,
            this.address,
            this.city,
            this.dateReceived,
            this.dateResponse,
            this.template,
            this.wasPrinted,
            this.numberOfCopies,
            this.dateOfEntry});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(1060, 298);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_ExportToExcel
            // 
            this.button_ExportToExcel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_ExportToExcel.Location = new System.Drawing.Point(948, 318);
            this.button_ExportToExcel.Name = "button_ExportToExcel";
            this.button_ExportToExcel.Size = new System.Drawing.Size(124, 31);
            this.button_ExportToExcel.TabIndex = 6;
            this.button_ExportToExcel.Text = "Exportuj do Excel\'a";
            this.button_ExportToExcel.UseVisualStyleBackColor = true;
            this.button_ExportToExcel.Click += new System.EventHandler(this.button_ExportToExcel_Click);
            // 
            // label_numberOfEntries
            // 
            this.label_numberOfEntries.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_numberOfEntries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label_numberOfEntries.Location = new System.Drawing.Point(84, 323);
            this.label_numberOfEntries.Name = "label_numberOfEntries";
            this.label_numberOfEntries.Size = new System.Drawing.Size(142, 25);
            this.label_numberOfEntries.TabIndex = 34;
            this.label_numberOfEntries.Text = "9999";
            this.label_numberOfEntries.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label8.Location = new System.Drawing.Point(8, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 25);
            this.label8.TabIndex = 33;
            this.label8.Text = "Wpisów:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Nr
            // 
            this.Nr.HeaderText = "Nr.";
            this.Nr.MinimumWidth = 45;
            this.Nr.Name = "Nr";
            this.Nr.ReadOnly = true;
            this.Nr.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nr.Width = 45;
            // 
            // name
            // 
            this.name.HeaderText = "Nazwa";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.name.Width = 165;
            // 
            // address
            // 
            this.address.HeaderText = "Adres";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.address.Width = 165;
            // 
            // city
            // 
            this.city.HeaderText = "Miasto";
            this.city.Name = "city";
            this.city.ReadOnly = true;
            this.city.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dateReceived
            // 
            this.dateReceived.HeaderText = "Wpłynęło";
            this.dateReceived.Name = "dateReceived";
            this.dateReceived.ReadOnly = true;
            this.dateReceived.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dateReceived.Width = 80;
            // 
            // dateResponse
            // 
            this.dateResponse.HeaderText = "Odpowiedź";
            this.dateResponse.Name = "dateResponse";
            this.dateResponse.ReadOnly = true;
            this.dateResponse.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dateResponse.Width = 80;
            // 
            // template
            // 
            this.template.HeaderText = "Szablon";
            this.template.Name = "template";
            this.template.ReadOnly = true;
            this.template.Width = 160;
            // 
            // wasPrinted
            // 
            this.wasPrinted.HeaderText = "Druk";
            this.wasPrinted.Name = "wasPrinted";
            this.wasPrinted.ReadOnly = true;
            this.wasPrinted.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.wasPrinted.Width = 40;
            // 
            // numberOfCopies
            // 
            this.numberOfCopies.HeaderText = "Ilość";
            this.numberOfCopies.Name = "numberOfCopies";
            this.numberOfCopies.ReadOnly = true;
            this.numberOfCopies.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.numberOfCopies.Width = 40;
            // 
            // dateOfEntry
            // 
            this.dateOfEntry.HeaderText = "Data wpisu w historii";
            this.dateOfEntry.Name = "dateOfEntry";
            this.dateOfEntry.ReadOnly = true;
            this.dateOfEntry.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dateOfEntry.Width = 140;
            // 
            // HistoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1084, 361);
            this.Controls.Add(this.label_numberOfEntries);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_ExportToExcel);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HistoryView";
            this.Text = "Historia wygenerowanych dokumentów";
            this.Load += new System.EventHandler(this.OnFormShowing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_ExportToExcel;
        private System.Windows.Forms.Label label_numberOfEntries;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nr;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReceived;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateResponse;
        private System.Windows.Forms.DataGridViewTextBoxColumn template;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasPrinted;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfCopies;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfEntry;
    }
}