using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

using WordDocxEditor.Ui;
using WordDocxEditor.Generator;

namespace WordDocxEditor
{
    public partial class Form1 : Form
    {
        private RadioButton[] _templatesRadioButtons = new RadioButton[(int)TemplateId.ENUM_LENGTH];
        private Label[] _labelsWithTemplateName = new Label[(int)TemplateId.ENUM_LENGTH];
        private TemplatesFilePaths _loadedTemplates;

        private UiInformations _uiComponents = new UiInformations();


        public Form1()
        {
            InitializeComponent();

            _uiComponents.BindComponents(textBox_Name, textBox_Address, checkBox_IsStreet, comboBox_City, 
                                         numericUpDown_CaseId, dateTimePicker_Received, dateTimePicker_Response,
                                         new Dictionary<TemplateId, RadioButton> { { TemplateId.Mr, radioButton_Mr },
                                                                                     { TemplateId.Mrs, radioButton_Mrs },
                                                                                     { TemplateId.Company, radioButton_Company },},
                                         checkBox_doPrint, numericUpDown_NumberOfCopies);


            comboBox_City.SelectedIndex = 0;

            SaveUiReferences(TemplateId.Mr, radioButton_Mr, label_MrTemplate);
            SaveUiReferences(TemplateId.Mrs, radioButton_Mrs, label_MrsTemplate);
            SaveUiReferences(TemplateId.Company, radioButton_Company, label_CompanyTemplate);
        }


        private void ClearUi(bool clearNameAndAddress = true, bool clearLablesWithTemplates = false)
        {
            if (clearNameAndAddress)
            {
                textBox_Address.Clear();
                textBox_Name.Clear();
                checkBox_IsStreet.Checked = true;
            }

            if (clearLablesWithTemplates)
            {
                foreach (var item in _labelsWithTemplateName)
                {
                    item.Text = "<Nie wybrano>";
                }
            }
        }

        private TemplateId DetectTemplate(string fullName)
        {
            if (fullName.Contains("."))
            {
                return TemplateId.Company;
            }
            else
            {
                var separated = fullName.Split(' ');
                string firstName = separated[0];

                return firstName.Last() == 'a' ? TemplateId.Mrs : TemplateId.Mr;
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

        private void SaveUiReferences(TemplateId id, RadioButton radioButton, Label label)
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
                MessageBox.Show("Nie znaleziono 3 szablonów", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearUi(false, true);
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
                                                       isStreet: checkBox_IsStreet.Checked,
                                                       city: comboBox_City.SelectedItem.ToString(),
                                                       caseId: (int)numericUpDown_CaseId.Value,
                                                       received: dateTimePicker_Received.Value,
                                                       responded: dateTimePicker_Response.Value);

                WordGenerator generator = new WordGenerator();
                generator.Generate(GetActiveTemplate(), data, checkBox_doPrint.Checked, (int)numericUpDown_NumberOfCopies.Value);

                ClearUi();
                MessageBox.Show($"Wygenerowano dokument: {data.Name}", 
                                 "Generator", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripMenuItem_HelpTags_Click(object sender, EventArgs e) => new UiHelp().ShowTags();

        private void toolStripMenuItem_HelpPrint_Click(object sender, EventArgs e) => new UiHelp().ShowPrint();
    }
}