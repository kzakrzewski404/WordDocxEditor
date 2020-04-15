using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordDocxEditor
{
    public partial class HistoryView : Form
    {
        public HistoryView()
        {
            InitializeComponent();
            for (int i = 0; i < 20; i++)
            {
                AddRow(i, "imie", "sloneczna 22", "brzeziny 95-060", DateTime.Now.Date, DateTime.Now.Date, "portal - umowa i formularz", false, 0);
            }
            
        }


        private void AddRow(int id, string name, string address, string city, 
                            DateTime received, DateTime response, string templateName, 
                            bool wasPrinted, int numberOfCopies)
        {
            dataGridView1.Rows.Add(id, name, address, city, received.Date.ToShortDateString(), response.Date.ToShortDateString(),
                                   templateName, wasPrinted ? "Tak" : "", wasPrinted ? numberOfCopies.ToString() : "", DateTime.Now);
        }
    }
}
