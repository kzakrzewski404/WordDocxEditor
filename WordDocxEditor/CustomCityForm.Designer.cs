namespace WordDocxEditor
{
    partial class CustomCityForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_PostalCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_City = new System.Windows.Forms.TextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label4.Location = new System.Drawing.Point(8, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kod pocztowy:";
            // 
            // textBox_PostalCode
            // 
            this.textBox_PostalCode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_PostalCode.Location = new System.Drawing.Point(12, 31);
            this.textBox_PostalCode.MaxLength = 6;
            this.textBox_PostalCode.Name = "textBox_PostalCode";
            this.textBox_PostalCode.Size = new System.Drawing.Size(100, 27);
            this.textBox_PostalCode.TabIndex = 8;
            this.textBox_PostalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Miasto:";
            // 
            // textBox_City
            // 
            this.textBox_City.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_City.Location = new System.Drawing.Point(141, 31);
            this.textBox_City.MaxLength = 6;
            this.textBox_City.Name = "textBox_City";
            this.textBox_City.Size = new System.Drawing.Size(100, 27);
            this.textBox_City.TabIndex = 10;
            this.textBox_City.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_Add
            // 
            this.button_Add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Add.Location = new System.Drawing.Point(141, 113);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(100, 31);
            this.button_Add.TabIndex = 33;
            this.button_Add.Text = "Dodaj";
            this.button_Add.UseVisualStyleBackColor = true;
            // 
            // button_Cancel
            // 
            this.button_Cancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Cancel.Location = new System.Drawing.Point(12, 113);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(100, 31);
            this.button_Cancel.TabIndex = 34;
            this.button_Cancel.Text = "Anuluj";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // CustomCityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(253, 156);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_City);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_PostalCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CustomCityForm";
            this.Text = "Niestandardowe miasto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_PostalCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_City;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Cancel;
    }
}