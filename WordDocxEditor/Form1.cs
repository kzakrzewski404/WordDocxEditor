using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace WordDocxEditor
{
    public partial class Form1 : Form
    {
        private RadioButton[] _templatesRadioButtons = new RadioButton[(int)E_TemplateId.ENUM_LENGTH];
        private Label[] _labelsWithTemplateName = new Label[(int)E_TemplateId.ENUM_LENGTH];
        private TemplatesLoaderSummary _loadedTemplates;


        public Form1()
        {
            InitializeComponent();

            comboBox_City.SelectedIndex = 0;

            SaveUiReferences(E_TemplateId.Mr, radioButton_Mr, label_MrTemplate);
            SaveUiReferences(E_TemplateId.Mrs, radioButton_Mrs, label_MrsTemplate);
            SaveUiReferences(E_TemplateId.Company, radioButton_Company, label_CompanyTemplate);
        }


        private void ClearUi()
        {
            textBox_Address.Clear();
            textBox_Name.Clear();
        }

        private E_TemplateId DetectTemplate(string fullName)
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

        private string GetActiveTemplate()
        {
            for (int i = 0; i < _templatesRadioButtons.Length; i++)
            {
                if (_templatesRadioButtons[i].Checked)
                {
                    return _loadedTemplates.FilePaths[i];
                }
            }

            return _loadedTemplates.FilePaths[0];
        }

        private void SaveUiReferences(E_TemplateId id, RadioButton radioButton, Label label)
        {
            _templatesRadioButtons[(int)id] = radioButton;
            _labelsWithTemplateName[(int)id] = label;
        }

        private void On_textBoxNameFinishedEditing(object sender, EventArgs e)
        {
            DataVerifier verifier = new DataVerifier();

            if (verifier.VerifyName(textBox_Name.Text))
            {
                _templatesRadioButtons[(int)DetectTemplate(textBox_Name.Text)].Checked = true;
            }
        }

        private void button_loadTemplates_Click(object sender, EventArgs e)
        {
            TemplatesLoader loader = new TemplatesLoader();
            _loadedTemplates = loader.Load();

            if (!_loadedTemplates.IsSuccess)
            {
                MessageBox.Show("Nie udało się wczytać szablonów.\nNie znaleziono 3 szablonów",
                                "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                for (int i = 0; i < _loadedTemplates.FilePaths.Length; i++)
                {
                    _labelsWithTemplateName[i].Text = Path.GetFileName(_loadedTemplates.FilePaths[i]);
                }
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
            else if (!verifier.VerifyIfTemplatesAreLoaded(_loadedTemplates))
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

        private void toolStripMenuItem_HelpTags_Click(object sender, EventArgs e) => new UiHelp().ShowTags();

        private void toolStripMenuItem_HelpPrint_Click(object sender, EventArgs e) => new UiHelp().ShowPrint();
    }
}