namespace WordDocxEditor.Main
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.comboBox_Templates = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_OptionalId2 = new System.Windows.Forms.NumericUpDown();
            this.label_optionalId2 = new System.Windows.Forms.Label();
            this.checkBox_AutoIncrementCaseId = new System.Windows.Forms.CheckBox();
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
            this.skrótyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cEIDGToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kRSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.narzędziaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generowanieKartOcenyFormalnejToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktualizujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokazUkryjPoleId2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcjaUlicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcjaDodajNumerWNazwiePlikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generowaniePlikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderDocelowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szablonyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wymaganiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wydrukToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drukujPoWygenerowaniuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_history = new System.Windows.Forms.Button();
            this.button_outputDir = new System.Windows.Forms.Button();
            this.button_Archiver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_OptionalId2)).BeginInit();
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
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Numer teczki:";
            // 
            // radioButton_Mr
            // 
            this.radioButton_Mr.AutoSize = true;
            this.radioButton_Mr.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_Mr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.radioButton_Mr.Location = new System.Drawing.Point(260, 262);
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
            this.radioButton_Mrs.Location = new System.Drawing.Point(317, 262);
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
            this.radioButton_Company.Location = new System.Drawing.Point(382, 262);
            this.radioButton_Company.Name = "radioButton_Company";
            this.radioButton_Company.Size = new System.Drawing.Size(63, 23);
            this.radioButton_Company.TabIndex = 25;
            this.radioButton_Company.TabStop = true;
            this.radioButton_Company.Text = "Firma";
            this.radioButton_Company.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_Templates);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 80);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Szablony";
            // 
            // comboBox_Templates
            // 
            this.comboBox_Templates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Templates.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_Templates.FormattingEnabled = true;
            this.comboBox_Templates.Location = new System.Drawing.Point(10, 29);
            this.comboBox_Templates.Name = "comboBox_Templates";
            this.comboBox_Templates.Size = new System.Drawing.Size(435, 27);
            this.comboBox_Templates.TabIndex = 36;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dateTimePicker_Received);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateTimePicker_Response);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 100);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDown_OptionalId2);
            this.groupBox3.Controls.Add(this.label_optionalId2);
            this.groupBox3.Controls.Add(this.checkBox_AutoIncrementCaseId);
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
            this.groupBox3.Location = new System.Drawing.Point(12, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(458, 305);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dane";
            // 
            // numericUpDown_OptionalId2
            // 
            this.numericUpDown_OptionalId2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_OptionalId2.Location = new System.Drawing.Point(10, 230);
            this.numericUpDown_OptionalId2.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDown_OptionalId2.Name = "numericUpDown_OptionalId2";
            this.numericUpDown_OptionalId2.Size = new System.Drawing.Size(185, 27);
            this.numericUpDown_OptionalId2.TabIndex = 102;
            this.numericUpDown_OptionalId2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_optionalId2
            // 
            this.label_optionalId2.AutoSize = true;
            this.label_optionalId2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_optionalId2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label_optionalId2.Location = new System.Drawing.Point(6, 208);
            this.label_optionalId2.Name = "label_optionalId2";
            this.label_optionalId2.Size = new System.Drawing.Size(41, 19);
            this.label_optionalId2.TabIndex = 103;
            this.label_optionalId2.Text = "Id_2:";
            // 
            // checkBox_AutoIncrementCaseId
            // 
            this.checkBox_AutoIncrementCaseId.AutoSize = true;
            this.checkBox_AutoIncrementCaseId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_AutoIncrementCaseId.Location = new System.Drawing.Point(201, 177);
            this.checkBox_AutoIncrementCaseId.Name = "checkBox_AutoIncrementCaseId";
            this.checkBox_AutoIncrementCaseId.Size = new System.Drawing.Size(41, 23);
            this.checkBox_AutoIncrementCaseId.TabIndex = 101;
            this.checkBox_AutoIncrementCaseId.Text = "AI";
            this.checkBox_AutoIncrementCaseId.UseVisualStyleBackColor = true;
            // 
            // checkBox_addNumberToFileName
            // 
            this.checkBox_addNumberToFileName.AutoSize = true;
            this.checkBox_addNumberToFileName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_addNumberToFileName.Location = new System.Drawing.Point(10, 263);
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
            this.label12.Location = new System.Drawing.Point(256, 236);
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
            this.groupBox4.Location = new System.Drawing.Point(12, 541);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(458, 92);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wydruk";
            // 
            // numericUpDown_NumberOfCopies
            // 
            this.numericUpDown_NumberOfCopies.AutoSize = true;
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
            this.button_Generate.Location = new System.Drawing.Point(333, 652);
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
            this.skrótyToolStripMenuItem,
            this.narzędziaToolStripMenuItem,
            this.ustawieniaToolStripMenuItem,
            this.widokToolStripMenuItem,
            this.informacjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(482, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // skrótyToolStripMenuItem
            // 
            this.skrótyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cEIDGToolStripMenuItem1,
            this.kRSToolStripMenuItem1});
            this.skrótyToolStripMenuItem.Name = "skrótyToolStripMenuItem";
            this.skrótyToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.skrótyToolStripMenuItem.Text = "Strony WWW";
            // 
            // cEIDGToolStripMenuItem1
            // 
            this.cEIDGToolStripMenuItem1.Name = "cEIDGToolStripMenuItem1";
            this.cEIDGToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.cEIDGToolStripMenuItem1.Text = "CEIDG";
            this.cEIDGToolStripMenuItem1.Click += new System.EventHandler(this.cEIDGToolStripMenuItem1_Click);
            // 
            // kRSToolStripMenuItem1
            // 
            this.kRSToolStripMenuItem1.Name = "kRSToolStripMenuItem1";
            this.kRSToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.kRSToolStripMenuItem1.Text = "KRS";
            this.kRSToolStripMenuItem1.Click += new System.EventHandler(this.kRSToolStripMenuItem1_Click);
            // 
            // narzędziaToolStripMenuItem
            // 
            this.narzędziaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generowanieKartOcenyFormalnejToolStripMenuItem});
            this.narzędziaToolStripMenuItem.Name = "narzędziaToolStripMenuItem";
            this.narzędziaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.narzędziaToolStripMenuItem.Text = "Narzędzia";
            // 
            // generowanieKartOcenyFormalnejToolStripMenuItem
            // 
            this.generowanieKartOcenyFormalnejToolStripMenuItem.Name = "generowanieKartOcenyFormalnejToolStripMenuItem";
            this.generowanieKartOcenyFormalnejToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.generowanieKartOcenyFormalnejToolStripMenuItem.Text = "Generowanie kart oceny formalnej";
            this.generowanieKartOcenyFormalnejToolStripMenuItem.Click += new System.EventHandler(this.generowanieKartOcenyFormalnejToolStripMenuItem_Click);
            // 
            // ustawieniaToolStripMenuItem
            // 
            this.ustawieniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aktualizujToolStripMenuItem});
            this.ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            this.ustawieniaToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.ustawieniaToolStripMenuItem.Text = "Ustawienia";
            // 
            // aktualizujToolStripMenuItem
            // 
            this.aktualizujToolStripMenuItem.Name = "aktualizujToolStripMenuItem";
            this.aktualizujToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.aktualizujToolStripMenuItem.Text = "Aktualizuj";
            this.aktualizujToolStripMenuItem.Click += new System.EventHandler(this.aktualizujToolStripMenuItem_Click);
            // 
            // widokToolStripMenuItem
            // 
            this.widokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pokazUkryjPoleId2ToolStripMenuItem});
            this.widokToolStripMenuItem.Name = "widokToolStripMenuItem";
            this.widokToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.widokToolStripMenuItem.Text = "Widok";
            // 
            // pokazUkryjPoleId2ToolStripMenuItem
            // 
            this.pokazUkryjPoleId2ToolStripMenuItem.Name = "pokazUkryjPoleId2ToolStripMenuItem";
            this.pokazUkryjPoleId2ToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.pokazUkryjPoleId2ToolStripMenuItem.Text = "Pokaż/Ukryj pole Id_2";
            // 
            // informacjeToolStripMenuItem
            // 
            this.informacjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.daneToolStripMenuItem,
            this.generowaniePlikuToolStripMenuItem,
            this.szablonyToolStripMenuItem,
            this.wydrukToolStripMenuItem});
            this.informacjeToolStripMenuItem.Name = "informacjeToolStripMenuItem";
            this.informacjeToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.informacjeToolStripMenuItem.Text = "Pomoc";
            // 
            // daneToolStripMenuItem
            // 
            this.daneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcjaUlicaToolStripMenuItem,
            this.opcjaDodajNumerWNazwiePlikuToolStripMenuItem});
            this.daneToolStripMenuItem.Name = "daneToolStripMenuItem";
            this.daneToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
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
            // generowaniePlikuToolStripMenuItem
            // 
            this.generowaniePlikuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tagiToolStripMenuItem,
            this.folderDocelowyToolStripMenuItem});
            this.generowaniePlikuToolStripMenuItem.Name = "generowaniePlikuToolStripMenuItem";
            this.generowaniePlikuToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
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
            // szablonyToolStripMenuItem
            // 
            this.szablonyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wymaganiaToolStripMenuItem});
            this.szablonyToolStripMenuItem.Name = "szablonyToolStripMenuItem";
            this.szablonyToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.szablonyToolStripMenuItem.Text = "Szablony";
            // 
            // wymaganiaToolStripMenuItem
            // 
            this.wymaganiaToolStripMenuItem.Name = "wymaganiaToolStripMenuItem";
            this.wymaganiaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.wymaganiaToolStripMenuItem.Text = "Wymagania";
            this.wymaganiaToolStripMenuItem.Click += new System.EventHandler(this.menu_templatesRequirements_Click);
            // 
            // wydrukToolStripMenuItem
            // 
            this.wydrukToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drukujPoWygenerowaniuToolStripMenuItem});
            this.wydrukToolStripMenuItem.Name = "wydrukToolStripMenuItem";
            this.wydrukToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.wydrukToolStripMenuItem.Text = "Wydruk";
            // 
            // drukujPoWygenerowaniuToolStripMenuItem
            // 
            this.drukujPoWygenerowaniuToolStripMenuItem.Name = "drukujPoWygenerowaniuToolStripMenuItem";
            this.drukujPoWygenerowaniuToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.drukujPoWygenerowaniuToolStripMenuItem.Text = "Opcja \"Drukuj po wygenerowaniu\"";
            this.drukujPoWygenerowaniuToolStripMenuItem.Click += new System.EventHandler(this.menu_printDoPrint_Click);
            // 
            // button_history
            // 
            this.button_history.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_history.Location = new System.Drawing.Point(22, 652);
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
            this.button_outputDir.Location = new System.Drawing.Point(98, 652);
            this.button_outputDir.Name = "button_outputDir";
            this.button_outputDir.Size = new System.Drawing.Size(70, 31);
            this.button_outputDir.TabIndex = 32;
            this.button_outputDir.Text = "Folder";
            this.button_outputDir.UseVisualStyleBackColor = true;
            this.button_outputDir.Click += new System.EventHandler(this.button_outputDir_Click);
            // 
            // button_Archiver
            // 
            this.button_Archiver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Archiver.Location = new System.Drawing.Point(174, 652);
            this.button_Archiver.Name = "button_Archiver";
            this.button_Archiver.Size = new System.Drawing.Size(70, 31);
            this.button_Archiver.TabIndex = 33;
            this.button_Archiver.Text = "Archiwizuj";
            this.button_Archiver.UseVisualStyleBackColor = true;
            this.button_Archiver.Click += new System.EventHandler(this.button_Archiver_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(482, 701);
            this.Controls.Add(this.button_Archiver);
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
            this.Name = "MainForm";
            this.Text = "WordDocxEditor - Zakrzewski Kamil - v1.6.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_OptionalId2)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox_Templates;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktualizujToolStripMenuItem;
        private System.Windows.Forms.Button button_Archiver;
        private System.Windows.Forms.CheckBox checkBox_AutoIncrementCaseId;
        private System.Windows.Forms.ToolStripMenuItem narzędziaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skrótyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generowanieKartOcenyFormalnejToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cEIDGToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kRSToolStripMenuItem1;
        private System.Windows.Forms.NumericUpDown numericUpDown_OptionalId2;
        private System.Windows.Forms.Label label_optionalId2;
        private System.Windows.Forms.ToolStripMenuItem widokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokazUkryjPoleId2ToolStripMenuItem;
    }
}

