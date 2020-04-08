using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WordDocxEditor
{
    public partial class Form1 : Form
    {
        private RadioButton[] _templatesSelection = new RadioButton[(int)E_TemplateId.ENUM_LENGTH];
        private string[] _templatesSources = new string[(int)E_TemplateId.ENUM_LENGTH];

        private string _outPath = "";


        public Form1()
        {
            InitializeComponent();

            _outPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $"\\Dokumenty - {DateTime.Today.ToString("yyyy.MM.dd")}";

            comboBox_City.SelectedIndex = 0;

            _templatesSelection[(int)E_TemplateId.Mr] = radioButton_Mr;
            _templatesSelection[(int)E_TemplateId.Mrs] = radioButton_Mrs;
            _templatesSelection[(int)E_TemplateId.Company] = radioButton_Company;
        }

        E_TemplateId DetectTemplate(string fullName)
        {
            if (fullName.Contains("."))
            {
                return E_TemplateId.Company;
            }
            else
            {
                var separated = fullName.Split(' ');
                string firstName = separated[0];

                return firstName.Last() == 'a' ? E_TemplateId.Mrs : E_TemplateId.Mr;
            }
        }

        private void On_textBoxNameFinishedEditing(object sender, EventArgs e)
        {
            DataVerifier verifier = new DataVerifier();

            if (verifier.VerifyName(textBox_Name.Text))
            {
                _templatesSelection[(int)DetectTemplate(textBox_Name.Text)].Checked = true;
            }
        }


        private void button_Generate_Click(object sender, EventArgs e)
        {
            //TODO: no number

            DataVerifier verifier = new DataVerifier();

            if (!verifier.VerifyName(textBox_Name.Text))
            {
                verifier.ShowErrorName();
            }
            else if (!verifier.VerifyAddress(textBox_Address.Text))
            {
                verifier.ShowErrorAddress();
            }
            else if (!verifier.VerifySelectedClient(_templatesSelection))
            {
                verifier.ShowErrorSelectedClient();
            }
            else
            {
                openFileDialog1.ShowDialog();
            }
        }

        private void button_SelectTemplateMr_Click(object sender, EventArgs e) => SelectTemplateSource(E_TemplateId.Mr, label_templateMr);

        private void button_SelectTemplateMrs_Click(object sender, EventArgs e) => SelectTemplateSource(E_TemplateId.Mrs, label_templateMrs);

        private void button_SelectTemplateCompany_Click(object sender, EventArgs e) => SelectTemplateSource(E_TemplateId.Company, label_templateCompany);

        private void SelectTemplateSource(E_TemplateId id, Label targetLabel)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                _templatesSources[(int)id] = openFileDialog1.FileName;
                targetLabel.Text = openFileDialog1.SafeFileName;
            }
            else
            {
                MessageBox.Show("Nie wybrano pliku.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
