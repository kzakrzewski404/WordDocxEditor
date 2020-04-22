using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using WordDocxEditor.History.Export;
using WordDocxEditor.Main.Data;
using WordDocxEditor.Shared.UI;


namespace WordDocxEditor.History
{
    public partial class HistoryDialog : Form
    {
        private UiMessages _common = new UiMessages();
        private ExcelExporter _exporter = new ExcelExporter();


        public HistoryDialog()
        {
            InitializeComponent();
        }

        public void AddEntry(UiEntriesSummary data)
        {
            InsertIntoTable(data.BasicInformations.CaseId, data.BasicInformations.Name,
                            data.BasicInformations.Address, data.BasicInformations.City,
                            data.Date.Received, data.Date.Response,
                            new DirectoryInfo(data.SelectedTemplateFilePath).Parent.Name, 
                            data.Print.DoPrint, data.Print.NumberOfCopies);
        }


        private void InsertIntoTable(int id, string name, string address, string city,
                                     DateTime received, DateTime response, string templateName,
                                     bool wasPrinted, int numberOfCopies)
        {
            dataGridView1.Rows.Add(id, name, address, city, received.Date.ToShortDateString(), response.Date.ToShortDateString(),
                                   templateName, wasPrinted ? "Tak" : "", wasPrinted ? numberOfCopies.ToString() : "", 
                                   DateTime.Now.ToString("H.mm.ss - dd.MM.yyyy"));
        }

        private void button_ExportToExcel_Click(object sender, EventArgs e)
        {
            SwitchButtons(false);

            bool result = _exporter.ExportToExcel(dataGridView1);
            if (result)
            {
                MessageBox.Show("Plik został zapisany.", "Potwierdzenie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _common.ShowError("Wystąpił nieoczekiwany błąd podczas eksportu.");
            }

            SwitchButtons(true);
        }

        private void OnFormShowing(object sender, EventArgs e) => label_numberOfEntries.Text = dataGridView1.RowCount.ToString();

        private void SwitchButtons(bool mode)
        {
            button_ExportToExcel.Enabled = mode;
            button_ExportToExcel.BackColor = mode ? Color.FromArgb(0, 0, 0, 0) : Color.Green;
        }
    }
}