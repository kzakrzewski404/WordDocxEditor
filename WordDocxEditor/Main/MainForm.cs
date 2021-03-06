﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using WordDocxEditor.Archiver;
using WordDocxEditor.History;
using WordDocxEditor.Main.Areas.BasicInformations;
using WordDocxEditor.Main.Areas.Date;
using WordDocxEditor.Main.Areas.Help;
using WordDocxEditor.Main.Areas.Print;
using WordDocxEditor.Main.Areas.Templates;
using WordDocxEditor.Main.Data;
using WordDocxEditor.Shared.Config;
using WordDocxEditor.Shared.Data;
using WordDocxEditor.Shared.UI;
using WordDocxEditor.Word;
using System.IO;

namespace WordDocxEditor.Main
{
    public partial class MainForm : Form
    {
        private BasicInformationsUiController _basicInformationsUiController = new BasicInformationsUiController();
        private DataVerifier _dataVerifier = new DataVerifier();
        private DateUiController _dateUiController = new DateUiController();
        private HelpMessages _helpMessages = new HelpMessages();
        private HistoryDialog _historyDialog = new HistoryDialog();
        private PrintUiController _printUiController = new PrintUiController();
        private TemplatesUiController _templatesUiController = new TemplatesUiController();
        private UiMessages _uiMessages = new UiMessages();
        private WordFileGenerator _wordFileGenerator = new WordFileGenerator();
        private IniCfg _iniCfg = new IniCfg();


        public MainForm()
        {
            InitializeComponent();
            IniCfg forceLoadIni = new IniCfg();

            _dateUiController.Bind(dateTimePicker_Received, dateTimePicker_Response);
            _printUiController.Bind(checkBox_doPrint, numericUpDown_NumberOfCopies);
            _templatesUiController.Bind(comboBox_TemplatesGroup, comboBox_Templates);

            _basicInformationsUiController.Bind(textBox_Name, textBox_Address, checkBox_IsStreet, comboBox_City, numericUpDown_CaseId,
                new Dictionary<TemplateId, RadioButton> { { TemplateId.Mr, radioButton_Mr },
                                                          { TemplateId.Mrs, radioButton_Mrs },
                                                          { TemplateId.Company, radioButton_Company } },
                                                checkBox_addNumberToFileName, checkBox_AutoIncrementCaseId, 
                                                pokazUkryjPoleId2ToolStripMenuItem, numericUpDown_OptionalId2, label_optionalId2,
                                                pokazUkryjPoleImie2ToolStripMenuItem, textBox_Name2);
        }

        private void button_Generate_Click(object sender, EventArgs e)
        {
            UiEntriesSummary summary = new UiEntriesSummary(_basicInformationsUiController, _dateUiController, 
                                                            _printUiController, _templatesUiController);
            VerifierResult result = _dataVerifier.Verify(summary);

            if (!result.IsSuccess)
            {
                _uiMessages.ShowError(result.ErrorMessage);
            }
            else
            {
                SwitchButtons(false);
                bool isSuccess = _wordFileGenerator.Generate(summary);

                if (isSuccess)
                {
                    _historyDialog.AddEntry(summary);
                    MessageBox.Show($"Wygenerowano dokument: {summary.BasicInformations.Name}",
                                 "Generator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _basicInformationsUiController.Clear();
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
            button_Generate.BackColor = mode ? Color.FromArgb(0, 0, 0, 0) : Color.Green;
            button_history.Enabled = mode;
        }

        private void button_history_Click(object sender, EventArgs e) => _historyDialog.ShowDialog();

        private void button_Archiver_Click(object sender, EventArgs e) => new ArchiverDialog().ShowDialog();

        private void menu_templatesRequirements_Click(object sender, EventArgs e) => _helpMessages.templatesReuiremets();

        private void menu_informationsStreet_Click(object sender, EventArgs e) => _helpMessages.informationsStreet();

        private void menu_informationsAddNumberToFileName_Click(object sender, EventArgs e) => _helpMessages.informationsAddNumberToFileName();

        private void menu_printDoPrint_Click(object sender, EventArgs e) => _helpMessages.printDoPrint();

        private void menu_generatorTags_Click(object sender, EventArgs e) => _helpMessages.generatorTags();

        private void menu_generatorOutputDirectory_Click(object sender, EventArgs e) => _helpMessages.generatorOutputDirectory();

        private void button_outputDir_Click(object sender, EventArgs e) => new OutputDirectory().OpenOutputDirectoryInExplorer();

        private void aktualizujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy rozpocząć automatyczną aktualizację?", "Aktualizacja", 
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (File.Exists(_iniCfg.GetEntry(IniEntryId.AutoUpdaterApp)))
                {
                    Process.Start(_iniCfg.GetEntry(IniEntryId.AutoUpdaterApp));
                }
                else
                {
                    _uiMessages.ShowError($"Nie odnaleziono aplikacji: {_iniCfg.GetEntry(IniEntryId.AutoUpdaterApp)}");
                }
            }
        }

        private void cEIDGToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("https://prod.ceidg.gov.pl/CEIDG/CEIDG.Public.UI/Search.aspx");
        }

        private void kRSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("https://ekrs.ms.gov.pl/web/wyszukiwarka-krs/strona-glowna/index.html");
        }

        private void generowanieKartOcenyFormalnejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //todo
        }
    }
}