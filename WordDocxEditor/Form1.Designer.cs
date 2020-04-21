namespace WordDocxEditor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_Received = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Response = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.comboBox_City = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton_Mr = new System.Windows.Forms.RadioButton();
            this.radioButton_Mrs = new System.Windows.Forms.RadioButton();
            this.radioButton_Company = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_loadTemplates = new System.Windows.Forms.Button();
            this.label_CompanyTemplate = new System.Windows.Forms.Label();
            this.label_MrsTemplate = new System.Windows.Forms.Label();
            this.label_MrTemplate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox_addNumberToFileName = new System.Windows.Forms.CheckBox();
            this.checkBox_IsStreet = new System.Windows.Forms.CheckBox();
            this.numericUpDown_CaseId = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_NumberOfCopies = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBox_doPrint = new System.Windows.Forms.CheckBox();
            this.button_Generate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szablonyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wymaganiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcjaUlicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcjaDodajNumerWNazwiePlikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wydrukToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drukujPoWygenerowaniuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generowaniePlikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderDocelowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_history = new System.Windows.Forms.Button();
            this.button_outputDir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CaseId)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumberOfCopies)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data otrzymania wniosku:";
            // 
            // dateTimePicker_Received
            // 
            this.dateTimePicker_Received.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.dateTimePicker_Received.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker_Received.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Received.Location = new System.Drawing.Point(10, 47);
            this.dateTimePicker_Received.Name = "dateTimePicker_Received";
            this.dateTimePicker_Received.Size = new System.Drawing.Size(185, 27);
            this.dateTimePicker_Received.TabIndex = 20;
            this.dateTimePicker_Received.TabStop = false;
            // 
            // dateTimePicker_Response
            // 
            this.dateTimePicker_Response.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.dateTimePicker_Response.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker_Response.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Response.Location = new System.Drawing.Point(260, 47);
            this.dateTimePicker_Response.Name = "dateTimePicker_Response";
            this.dateTimePicker_Response.Size = new System.Drawing.Size(185, 27);
            this.dateTimePicker_Response.TabIndex = 21;
            this.dateTimePicker_Response.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label2.Location = new System.Drawing.Point(256, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data nadania odpowiedzi:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Name.Location = new System.Drawing.Point(10, 45);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(435, 27);
            this.textBox_Name.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Imię i nazwisko / Nazwa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adres:";
            // 
            // textBox_Address
            // 
            this.textBox_Address.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Address.Location = new System.Drawing.Point(10, 109);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(362, 27);
            this.textBox_Address.TabIndex = 2;
            // 
            // comboBox_City
            // 
            this.comboBox_City.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_City.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_City.FormattingEnabled = true;
            this.comboBox_City.Items.AddRange(new object[] {
            "95-060 Brzeziny",
            "95-061 Dmosin",
            "95-063 Rogów",
            "95-047 Jeżów",
            "<Dodaj>"});
            this.comboBox_City.Location = new System.Drawing.Point(260, 175);
            this.comboBox_City.Name = "comboBox_City";
            this.comboBox_City.Size = new System.Drawing.Size(185, 27);
            this.comboBox_City.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label5.Location = new System.Drawing.Point(6, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Numer dokumentu:";
            // 
            // radioButton_Mr
            // 
            this.radioButton_Mr.AutoSize = true;
            this.radioButton_Mr.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_Mr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.radioButton_Mr.Location = new System.Drawing.Point(260, 252);
            this.radioButton_Mr.Name = "radioButton_Mr";
            this.radioButton_Mr.Size = new System.Drawing.Size(51, 23);
            this.radioButton_Mr.TabIndex = 23;
            this.radioButton_Mr.TabStop = true;
            this.radioButton_Mr.Text = "Pan";
            this.radioButton_Mr.UseVisualStyleBackColor = true;
            // 
            // radioButton_Mrs
            // 
            this.radioButton_Mrs.AutoSize = true;
            this.radioButton_Mrs.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_Mrs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.radioButton_Mrs.Location = new System.Drawing.Point(317, 252);
            this.radioButton_Mrs.Name = "radioButton_Mrs";
            this.radioButton_Mrs.Size = new System.Drawing.Size(55, 23);
            this.radioButton_Mrs.TabIndex = 24;
            this.radioButton_Mrs.TabStop = true;
            this.radioButton_Mrs.Text = "Pani";
            this.radioButton_Mrs.UseVisualStyleBackColor = true;
            // 
            // radioButton_Company
            // 
            this.radioButton_Company.AutoSize = true;
            this.radioButton_Company.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_Company.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.radioButton_Company.Location = new System.Drawing.Point(382, 252);
            this.radioButton_Company.Name = "radioButton_Company";
            this.radioButton_Company.Size = new System.Drawing.Size(63, 23);
            this.radioButton_Company.TabIndex = 25;
            this.radioButton_Company.TabStop = true;
            this.radioButton_Company.Text = "Firma";
            this.radioButton_Company.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_loadTemplates);
            this.groupBox1.Controls.Add(this.label_CompanyTemplate);
            this.groupBox1.Controls.Add(this.label_MrsTemplate);
            this.groupBox1.Controls.Add(this.label_MrTemplate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 122);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Szablony";
            // 
            // button_loadTemplates
            // 
            this.button_loadTemplates.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_loadTemplates.Location = new System.Drawing.Point(376, 19);
            this.button_loadTemplates.Name = "button_loadTemplates";
            this.button_loadTemplates.Size = new System.Drawing.Size(70, 31);
            this.button_loadTemplates.TabIndex = 35;
            this.button_loadTemplates.Text = "Wybierz";
            this.button_loadTemplates.UseVisualStyleBackColor = true;
            this.button_loadTemplates.Click += new System.EventHandler(this.button_loadTemplates_Click);
            // 
            // label_CompanyTemplate
            // 
            this.label_CompanyTemplate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_CompanyTemplate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label_CompanyTemplate.Location = new System.Drawing.Point(62, 76);
            this.label_CompanyTemplate.Name = "label_CompanyTemplate";
            this.label_CompanyTemplate.Size = new System.Drawing.Size(300, 25);
            this.label_CompanyTemplate.TabIndex = 32;
            this.label_CompanyTemplate.Text = "<Nie wybrano>";
            this.label_CompanyTemplate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_MrsTemplate
            // 
            this.label_MrsTemplate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_MrsTemplate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label_MrsTemplate.Location = new System.Drawing.Point(62, 46);
            this.label_MrsTemplate.Name = "label_MrsTemplate";
            this.label_MrsTemplate.Size = new System.Drawing.Size(300, 25);
            this.label_MrsTemplate.TabIndex = 31;
            this.label_MrsTemplate.Text = "<Nie wybrano>";
            this.label_MrsTemplate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_MrTemplate
            // 
            this.label_MrTemplate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_MrTemplate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label_MrTemplate.Location = new System.Drawing.Point(62, 16);
            this.label_MrTemplate.Name = "label_MrTemplate";
            this.label_MrTemplate.Size = new System.Drawing.Size(300, 25);
            this.label_MrTemplate.TabIndex = 30;
            this.label_MrTemplate.Text = "<Nie wybrano>";
            this.label_MrTemplate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label8.Location = new System.Drawing.Point(6, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 25);
            this.label8.TabIndex = 29;
            this.label8.Text = "Firma:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label7.Location = new System.Drawing.Point(6, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 25);
            this.label7.TabIndex = 28;
            this.label7.Text = "Pani:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Pan:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dateTimePicker_Received);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateTimePicker_Response);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 100);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox_addNumberToFileName);
            this.groupBox3.Controls.Add(this.checkBox_IsStreet);
            this.groupBox3.Controls.Add(this.numericUpDown_CaseId);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox_Name);
            this.groupBox3.Controls.Add(this.radioButton_Mr);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.comboBox_City);
            this.groupBox3.Controls.Add(this.radioButton_Company);
            this.groupBox3.Controls.Add(this.radioButton_Mrs);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox_Address);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupBox3.Location = new System.Drawing.Point(12, 272);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(458, 295);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dane";
            // 
            // checkBox_addNumberToFileName
            // 
            this.checkBox_addNumberToFileName.AutoSize = true;
            this.checkBox_addNumberToFileName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_addNumberToFileName.Location = new System.Drawing.Point(10, 222);
            this.checkBox_addNumberToFileName.Name = "checkBox_addNumberToFileName";
            this.checkBox_addNumberToFileName.Size = new System.Drawing.Size(210, 23);
            this.checkBox_addNumberToFileName.TabIndex = 100;
            this.checkBox_addNumberToFileName.Text = "Dodaj numer w nazwie pliku";
            this.checkBox_addNumberToFileName.UseVisualStyleBackColor = true;
            // 
            // checkBox_IsStreet
            // 
            this.checkBox_IsStreet.AutoSize = true;
            this.checkBox_IsStreet.Checked = true;
            this.checkBox_IsStreet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_IsStreet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_IsStreet.Location = new System.Drawing.Point(384, 111);
            this.checkBox_IsStreet.Name = "checkBox_IsStreet";
            this.checkBox_IsStreet.Size = new System.Drawing.Size(61, 23);
            this.checkBox_IsStreet.TabIndex = 100;
            this.checkBox_IsStreet.Text = "Ulica";
            this.checkBox_IsStreet.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_CaseId
            // 
            this.numericUpDown_CaseId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_CaseId.Location = new System.Drawing.Point(10, 175);
            this.numericUpDown_CaseId.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDown_CaseId.Name = "numericUpDown_CaseId";
            this.numericUpDown_CaseId.Size = new System.Drawing.Size(185, 27);
            this.numericUpDown_CaseId.TabIndex = 4;
            this.numericUpDown_CaseId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label9.Location = new System.Drawing.Point(256, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 30;
            this.label9.Text = "Miejscowość:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label12.Location = new System.Drawing.Point(256, 226);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 19);
            this.label12.TabIndex = 26;
            this.label12.Text = "Szablon:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numericUpDown_NumberOfCopies);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.checkBox_doPrint);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupBox4.Location = new System.Drawing.Point(12, 573);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(458, 92);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wydruk";
            // 
            // numericUpDown_NumberOfCopies
            // 
            this.numericUpDown_NumberOfCopies.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_NumberOfCopies.Location = new System.Drawing.Point(260, 44);
            this.numericUpDown_NumberOfCopies.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_NumberOfCopies.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_NumberOfCopies.Name = "numericUpDown_NumberOfCopies";
            this.numericUpDown_NumberOfCopies.Size = new System.Drawing.Size(185, 27);
            this.numericUpDown_NumberOfCopies.TabIndex = 29;
            this.numericUpDown_NumberOfCopies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label13.Location = new System.Drawing.Point(256, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 19);
            this.label13.TabIndex = 28;
            this.label13.Text = "Liczba kopii:";
            // 
            // checkBox_doPrint
            // 
            this.checkBox_doPrint.AutoSize = true;
            this.checkBox_doPrint.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_doPrint.Location = new System.Drawing.Point(10, 37);
            this.checkBox_doPrint.Name = "checkBox_doPrint";
            this.checkBox_doPrint.Size = new System.Drawing.Size(196, 23);
            this.checkBox_doPrint.TabIndex = 99;
            this.checkBox_doPrint.Text = "Drukuj po wygenerowaniu";
            this.checkBox_doPrint.UseVisualStyleBackColor = true;
            // 
            // button_Generate
            // 
            this.button_Generate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Generate.Location = new System.Drawing.Point(334, 690);
            this.button_Generate.Name = "button_Generate";
            this.button_Generate.Size = new System.Drawing.Size(124, 31);
            this.button_Generate.TabIndex = 5;
            this.button_Generate.Text = "Generuj";
            this.button_Generate.UseVisualStyleBackColor = true;
            this.button_Generate.Click += new System.EventHandler(this.button_Generate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(482, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informacjeToolStripMenuItem
            // 
            this.informacjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szablonyToolStripMenuItem,
            this.daneToolStripMenuItem,
            this.wydrukToolStripMenuItem,
            this.generowaniePlikuToolStripMenuItem});
            this.informacjeToolStripMenuItem.Name = "informacjeToolStripMenuItem";
            this.informacjeToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.informacjeToolStripMenuItem.Text = "Pomoc";
            // 
            // szablonyToolStripMenuItem
            // 
            this.szablonyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wymaganiaToolStripMenuItem});
            this.szablonyToolStripMenuItem.Name = "szablonyToolStripMenuItem";
            this.szablonyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.szablonyToolStripMenuItem.Text = "Szablony";
            // 
            // wymaganiaToolStripMenuItem
            // 
            this.wymaganiaToolStripMenuItem.Name = "wymaganiaToolStripMenuItem";
            this.wymaganiaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wymaganiaToolStripMenuItem.Text = "Wymagania";
            this.wymaganiaToolStripMenuItem.Click += new System.EventHandler(this.menu_templatesRequirements_Click);
            // 
            // daneToolStripMenuItem
            // 
            this.daneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcjaUlicaToolStripMenuItem,
            this.opcjaDodajNumerWNazwiePlikuToolStripMenuItem});
            this.daneToolStripMenuItem.Name = "daneToolStripMenuItem";
            this.daneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.daneToolStripMenuItem.Text = "Dane";
            // 
            // opcjaUlicaToolStripMenuItem
            // 
            this.opcjaUlicaToolStripMenuItem.Name = "opcjaUlicaToolStripMenuItem";
            this.opcjaUlicaToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.opcjaUlicaToolStripMenuItem.Text = "Opcja \"Ulica\"";
            this.opcjaUlicaToolStripMenuItem.Click += new System.EventHandler(this.menu_informationsStreet_Click);
            // 
            // opcjaDodajNumerWNazwiePlikuToolStripMenuItem
            // 
            this.opcjaDodajNumerWNazwiePlikuToolStripMenuItem.Name = "opcjaDodajNumerWNazwiePlikuToolStripMenuItem";
            this.opcjaDodajNumerWNazwiePlikuToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.opcjaDodajNumerWNazwiePlikuToolStripMenuItem.Text = "Opcja \"Dodaj numer w nazwie pliku\"";
            this.opcjaDodajNumerWNazwiePlikuToolStripMenuItem.Click += new System.EventHandler(this.menu_informationsAddNumberToFileName_Click);
            // 
            // wydrukToolStripMenuItem
            // 
            this.wydrukToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drukujPoWygenerowaniuToolStripMenuItem});
            this.wydrukToolStripMenuItem.Name = "wydrukToolStripMenuItem";
            this.wydrukToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wydrukToolStripMenuItem.Text = "Wydruk";
            // 
            // drukujPoWygenerowaniuToolStripMenuItem
            // 
            this.drukujPoWygenerowaniuToolStripMenuItem.Name = "drukujPoWygenerowaniuToolStripMenuItem";
            this.drukujPoWygenerowaniuToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.drukujPoWygenerowaniuToolStripMenuItem.Text = "Opcja \"Drukuj po wygenerowaniu\"";
            this.drukujPoWygenerowaniuToolStripMenuItem.Click += new System.EventHandler(this.menu_printDoPrint_Click);
            // 
            // generowaniePlikuToolStripMenuItem
            // 
            this.generowaniePlikuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tagiToolStripMenuItem,
            this.folderDocelowyToolStripMenuItem});
            this.generowaniePlikuToolStripMenuItem.Name = "generowaniePlikuToolStripMenuItem";
            this.generowaniePlikuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generowaniePlikuToolStripMenuItem.Text = "Generowanie pliku";
            // 
            // tagiToolStripMenuItem
            // 
            this.tagiToolStripMenuItem.Name = "tagiToolStripMenuItem";
            this.tagiToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.tagiToolStripMenuItem.Text = "Tagi";
            this.tagiToolStripMenuItem.Click += new System.EventHandler(this.menu_generatorTags_Click);
            // 
            // folderDocelowyToolStripMenuItem
            // 
            this.folderDocelowyToolStripMenuItem.Name = "folderDocelowyToolStripMenuItem";
            this.folderDocelowyToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.folderDocelowyToolStripMenuItem.Text = "Folder docelowy";
            this.folderDocelowyToolStripMenuItem.Click += new System.EventHandler(this.menu_generatorOutputDirectory_Click);
            // 
            // button_history
            // 
            this.button_history.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_history.Location = new System.Drawing.Point(23, 690);
            this.button_history.Name = "button_history";
            this.button_history.Size = new System.Drawing.Size(70, 31);
            this.button_history.TabIndex = 31;
            this.button_history.Text = "Historia";
            this.button_history.UseVisualStyleBackColor = true;
            this.button_history.Click += new System.EventHandler(this.button_history_Click);
            // 
            // button_outputDir
            // 
            this.button_outputDir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_outputDir.Location = new System.Drawing.Point(99, 690);
            this.button_outputDir.Name = "button_outputDir";
            this.button_outputDir.Size = new System.Drawing.Size(70, 31);
            this.button_outputDir.TabIndex = 32;
            this.button_outputDir.Text = "Folder";
            this.button_outputDir.UseVisualStyleBackColor = true;
            this.button_outputDir.Click += new System.EventHandler(this.button_outputDir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(482, 741);
            this.Controls.Add(this.button_outputDir);
            this.Controls.Add(this.button_history);
            this.Controls.Add(this.button_Generate);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(498, 780);
            this.MinimumSize = new System.Drawing.Size(498, 726);
            this.Name = "Form1";
            this.Text = "WordDocxEditor - Zakrzewski Kamil - v1.0.4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CaseId)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumberOfCopies)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Received;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Response;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.ComboBox comboBox_City;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton_Mr;
        private System.Windows.Forms.RadioButton radioButton_Mrs;
        private System.Windows.Forms.RadioButton radioButton_Company;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_CompanyTemplate;
        private System.Windows.Forms.Label label_MrsTemplate;
        private System.Windows.Forms.Label label_MrTemplate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_Generate;
        private System.Windows.Forms.NumericUpDown numericUpDown_NumberOfCopies;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkBox_doPrint;
        private System.Windows.Forms.NumericUpDown numericUpDown_CaseId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informacjeToolStripMenuItem;
        private System.Windows.Forms.Button button_loadTemplates;
        private System.Windows.Forms.CheckBox checkBox_IsStreet;
        private System.Windows.Forms.CheckBox checkBox_addNumberToFileName;
        private System.Windows.Forms.ToolStripMenuItem szablonyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wymaganiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcjaUlicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcjaDodajNumerWNazwiePlikuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wydrukToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drukujPoWygenerowaniuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generowaniePlikuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tagiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem folderDocelowyToolStripMenuItem;
        private System.Windows.Forms.Button button_history;
        private System.Windows.Forms.Button button_outputDir;
    }
}

