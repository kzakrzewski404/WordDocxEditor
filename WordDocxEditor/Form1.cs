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
        private UiDate _uiDate = new UiDate();
        private UiHelp _uiHelp = new UiHelp();
        private UiInformations _uiInformations = new UiInformations();
        private UiPrint _uiPrint = new UiPrint();
        private UiTemplates _uiTemplates = new UiTemplates();


        public Form1()
        {
            InitializeComponent();

            _uiDate.Bind(dateTimePicker_Received, dateTimePicker_Response);
            _uiPrint.Bind(checkBox_doPrint, numericUpDown_NumberOfCopies);
            _uiTemplates.Bind(new Dictionary<TemplateId, Label> { { TemplateId.Mr, label_MrTemplate }, 
                                                                  { TemplateId.Mrs, label_MrsTemplate }, 
                                                                  { TemplateId.Company, label_CompanyTemplate } });

            _uiInformations.Bind(textBox_Name, textBox_Address, checkBox_IsStreet, comboBox_City, numericUpDown_CaseId,
                new Dictionary<TemplateId, RadioButton> { { TemplateId.Mr, radioButton_Mr },
                                                          { TemplateId.Mrs, radioButton_Mrs },
                                                          { TemplateId.Company, radioButton_Company } });
        }

        private void button_loadTemplates_Click(object sender, EventArgs e) => _uiTemplates.HandleTemplatesSelectionFromDisk();

        private void button_Generate_Click(object sender, EventArgs e)
        {
            DataVerifier verifier = new DataVerifier();

            //if succes then generate
            //else show error


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

        private void toolStripMenuItem_HelpTags_Click(object sender, EventArgs e) => _uiHelp.ShowTags();

        private void toolStripMenuItem_HelpPrint_Click(object sender, EventArgs e) => _uiHelp.ShowPrint();
    }
}