using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

using WordDocxEditor.Common;
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
        private UiCommon _uiCommon = new UiCommon();
        private DataVerifier _dataVerifier = new DataVerifier();
        private WordGenerator _wordGenerator = new WordGenerator();
        private HistoryView _historyView = new HistoryView();

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
                                                          { TemplateId.Company, radioButton_Company } },
                                 checkBox_addNumberToFileName);
        }

        private void button_loadTemplates_Click(object sender, EventArgs e) => _uiTemplates.HandleTemplatesSelectionFromDisk();

        private void button_Generate_Click(object sender, EventArgs e)
        {
            UiInputSummary summary = new UiInputSummary(_uiInformations, _uiDate, _uiPrint, _uiTemplates);
            DataVerifierResult result = _dataVerifier.Verify(summary);

            if (!result.IsSuccess)
            {
                _uiCommon.ShowError(result.ErrorMessage);
            }
            else
            {
                SwitchButtons(false);
                bool isSuccess = _wordGenerator.Generate(summary);

                if (isSuccess)
                {
                    _historyView.AddEntry(summary);
                    MessageBox.Show($"Wygenerowano dokument: {summary.Informations.Name}",
                                 "Generator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _uiInformations.Clear();
                }
                else
                {
                    MessageBox.Show("Wygenerowanie pliku nie powiodło się.", "Generator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                SwitchButtons(true);
            }
        }

        private void SwitchButtons(bool mode)
        {
            button_Generate.Enabled = mode;
            button_Generate.BackColor = mode ? Color.FromArgb(0,0,0,0) : Color.Green;
            button_history.Enabled = mode;
            button_loadTemplates.Enabled = mode;
        }

        private void button_history_Click(object sender, EventArgs e) => _historyView.ShowDialog();

        private void menu_templatesRequirements_Click(object sender, EventArgs e) => _uiHelp.templatesReuiremets();

        private void menu_informationsStreet_Click(object sender, EventArgs e) => _uiHelp.informationsStreet();

        private void menu_informationsAddNumberToFileName_Click(object sender, EventArgs e) => _uiHelp.informationsAddNumberToFileName();

        private void menu_informationsAddressCorrectness_Click(object sender, EventArgs e) => _uiHelp.informationsAddressCorrectness();

        private void Menu_informationsAutoTemplateDetection_Click(object sender, EventArgs e) => _uiHelp.informationsAutoTemplateDetection();

        private void menu_printDoPrint_Click(object sender, EventArgs e) => _uiHelp.printDoPrint();

        private void menu_generatorTags_Click(object sender, EventArgs e) => _uiHelp.generatorTags();

        private void menu_generatorOutputDirectory_Click(object sender, EventArgs e) => _uiHelp.generatorOutputDirectory();

        private void button_outputDir_Click(object sender, EventArgs e) => new DirectoryPaths().OpenOutputDirectoryInExplorer();
    }
}