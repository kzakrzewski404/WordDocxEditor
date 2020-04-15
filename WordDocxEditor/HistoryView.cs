using System;
using System.IO;
using System.Windows.Forms;

using WordDocxEditor.Ui;
using WordDocxEditor.History;


namespace WordDocxEditor
{
    public partial class HistoryView : Form
    {
        public HistoryView()
        {
            InitializeComponent();
            for (int i = 0; i < 20; i++)
            {
                //AddRow(i, "imie", "sloneczna 22", "brzeziny 95-060", DateTime.Now.Date, DateTime.Now.Date, "portal - umowa i formularz", false, 0);
            }
            
        }

        public void AddEntry(UiInputSummary data)
        {
            InsertIntoTable(data.Informations.CaseId, data.Informations.Name,
                            data.Informations.IsStreet ? "ul. " + data.Informations.Address : data.Informations.Address,
                            data.Informations.City, data.Date.Received, data.Date.Response,
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
            Exporter ex = new Exporter();
            ex.ExportToExcel(dataGridView1);
            MessageBox.Show("Koniec");
        }
    }
}
