using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace WordDocxEditor
{
    public partial class Form1 : Form
    {
        private RadioButton[] _templatesRadioButtons = new RadioButton[(int)E_TemplateId.ENUM_LENGTH];
        private Label[] _labelsWithTemplateName = new Label[(int)E_TemplateId.ENUM_LENGTH];
        private string[] _templatesSources = new string[(int)E_TemplateId.ENUM_LENGTH];


        public Form1()
        {
            InitializeComponent();

            comboBox_City.SelectedIndex = 0;

            _templatesRadioButtons[(int)E_TemplateId.Mr] = radioButton_Mr;
            _templatesRadioButtons[(int)E_TemplateId.Mrs] = radioButton_Mrs;
            _templatesRadioButtons[(int)E_TemplateId.Company] = radioButton_Company;

            _labelsWithTemplateName[(int)E_TemplateId.Mr] = label_templateMr;
            _labelsWithTemplateName[(int)E_TemplateId.Mrs] = label_templateMrs;
            _labelsWithTemplateName[(int)E_TemplateId.Company] = label_templateCompany;
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
                verifier.ShowErrorNoLoadedTemplates();
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

        private void wydrukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wydruk dokumentu jest wykonywany na domyślnej w systemie drukarce.",
                            "Wydruk", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tagiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tagi które są wyszukiwane w dokumencie:\n\n" +
                "<name> - Imie i nazwisko / nazwa\n" +
                "<addr> - Adres (ulica i numer budynku)\n" +
                "<city> - kod pocztowy i miejscowość\n" +
                "<id> - numer sprawy\n" +
                "<dateIn> - data przyjęcia pisma\n" +
                "<dateOut> - data odpowiedzi na pismo",
                "Tagi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_loadTemplates_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                FileInfo[] files = directoryInfo.GetFiles("_*");

                if (!LoadTemplates(files))
                {
                    MessageBox.Show("Nie udało się wczytać szablonów.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano folderu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool LoadTemplates(FileInfo[] files)
        {
            if (files.Length == 3)
            {
                _templatesSources[(int)E_TemplateId.Mr] = FindTemplateFile(files, "_pan_");
                _templatesSources[(int)E_TemplateId.Mrs] = FindTemplateFile(files, "_pani_");
                _templatesSources[(int)E_TemplateId.Company] = FindTemplateFile(files, "_firma_");

                for (int i = 0; i < _templatesSources.Length; i++)
                {
                    if (_templatesSources[i] == null)
                    {
                        return false;
                    }
                    else
                    {
                        _labelsWithTemplateName[i].Text = Path.GetFileName(_templatesSources[i]);
                    }
                }

                return true;
            }

            return false;
        }

        private string FindTemplateFile(FileInfo[] files, string searchPattern)
        {
            return files.Where(x => x.Name.Contains(searchPattern)).Select(x => x.Name).FirstOrDefault();
        }
    }
}