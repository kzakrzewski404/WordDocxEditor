using System;
using System.IO;
using System.Windows.Forms;

using WordDocxEditor.History;
using WordDocxEditor.Ui;


namespace WordDocxEditor
{
    public partial class HistoryView : Form
    {
        public HistoryView()
        {
            InitializeComponent();
        }

        public void AddEntry(UiInputSummary data)
        {
            InsertIntoTable(data.Informations.CaseId, data.Informations.Name,
                            data.Informations.Address, data.Informations.City,
                            data.Date.Received, data.Date.Response,
                            new DirectoryInfo(data.SelectedTemplateFilePath).Parent.Name, 
                            data.Print.DoPrint, data.Print.NumberOfCopies);
        }


        private void InsertIntoTable(int id, string name, string address, string city,
                                     DateTime received, DateTime response, string templateName,
                                     bool wasPrinted, int numberOfCopies)
        {
            dataGridView1.Rows.Add(id, name, address, city, received.Date.ToShortDateString(), response.Date.ToShortDateString(),
                                   templateName, wasPrinted ? "Tak" : "", wasPrinted ? numberOfCopies.ToString() : "", DateTime.Now);
        }

        private void button_ExportToExcel_Click(object sender, EventArgs e)
        {
            Exporter exporter = new Exporter();
            exporter.ExportToExcel(dataGridView1);
            MessageBox.Show("Koniec");
        }

        private void OnFormShowing(object sender, EventArgs e) => label_numberOfEntries.Text = dataGridView1.RowCount.ToString();
    }
}