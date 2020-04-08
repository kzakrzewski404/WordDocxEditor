using System;
using System.Linq;
using System.Windows.Forms;


namespace WordDocxEditor
{
    public partial class Form1 : Form
    {
        private RadioButton[] _templatesRadioButtons = new RadioButton[(int)E_TemplateId.ENUM_LENGTH];
        private string[] _templatesSources = new string[(int)E_TemplateId.ENUM_LENGTH];


        public Form1()
        {
            InitializeComponent();

            comboBox_City.SelectedIndex = 0;

            _templatesRadioButtons[(int)E_TemplateId.Mr] = radioButton_Mr;
            _templatesRadioButtons[(int)E_TemplateId.Mrs] = radioButton_Mrs;
            _templatesRadioButtons[(int)E_TemplateId.Company] = radioButton_Company;
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
                _templatesRadioButtons[(int)DetectTemplate(textBox_Name.Text)].Checked = true;
            }
        }


        private void button_Generate_Click(object sender, EventArgs e)
        {
            DataVerifier verifier = new DataVerifier();

            if (!verifier.VerifyName(textBox_Name.Text))
            {
                verifier.ShowErrorName();
            }
            else if (!verifier.VerifyAddress(textBox_Address.Text))
            {
                verifier.ShowErrorAddress();
            }
            else if (!verifier.VerifyIfSelectedTemplate(_templatesRadioButtons))
            {
                verifier.ShowErrorSelectedTemplate();
            }
            else if (!verifier.VerifyIfTemplatesAreLoaded(_templatesSources))
            {
                verifier.showErrorNoLoadedTemplates();
            }
            else
            {
                GeneratorData data = new GeneratorData(name: textBox_Name.Text,
                                                       address: textBox_Address.Text,
                                                       city: comboBox_City.SelectedItem.ToString(),
                                                       caseId: (int)numericUpDown_CaseId.Value,
                                                       received: dateTimePicker_Received.Value,
                                                       responded: dateTimePicker_Responded.Value);

                Generator generator = new Generator();
                generator.Generate(GetActiveTemplate(), data, checkBox_doPrint.Checked, (int)numericUpDown_NumberOfCopies.Value);

                ClearUi();
                MessageBox.Show($"Wygenerowano dokument: {data.Name}");
            }
        }

        private void ClearUi()
        {
            textBox_Address.Clear();
            textBox_Name.Clear();
        }

        private string GetActiveTemplate()
        {
            for (int i = 0; i < _templatesRadioButtons.Length; i++)
            {
                if (_templatesRadioButtons[i].Checked)
                {
                    return _templatesSources[i];
                }
            }

            return _templatesSources[0];
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
