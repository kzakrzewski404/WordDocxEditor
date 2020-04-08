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
    public partial class Form1 : Form
    {
        private RadioButton[] _templatesSelection;


        public Form1()
        {
            InitializeComponent();

            comboBox_City.SelectedIndex = 0;

            _templatesSelection = new RadioButton[(int)E_TemplateId.ENUM_LENGTH];
            _templatesSelection[(int)E_TemplateId.Mr] = radioButton_Mr;
            _templatesSelection[(int)E_TemplateId.Mrs] = radioButton_Mrs;
            _templatesSelection[(int)E_TemplateId.Company] = radioButton_Company;
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
                _templatesSelection[(int)DetectTemplate(textBox_Name.Text)].Checked = true;
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
            else if (!verifier.VerifySelectedClient(_templatesSelection))
            {
                verifier.ShowErrorSelectedClient();
            }
        }

        private void informacjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zakrzewski Kamil\n08.04.2020", "Informacje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
