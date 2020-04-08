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
        private RadioButton[] _templates;


        public Form1()
        {
            InitializeComponent();

            comboBox_City.SelectedIndex = 0;

            _templates = new RadioButton[(int)E_ClientId.ENUM_LENGTH];
            _templates[(int)E_ClientId.Mr] = radioButton_Mr;
            _templates[(int)E_ClientId.Mrs] = radioButton_Mrs;
            _templates[(int)E_ClientId.Company] = radioButton_Company;
        }

        E_ClientId DetectClient(string fullName)
        {
            if (fullName.Contains("."))
            {
                return E_ClientId.Company;
            }
            else
            {
                var separated = fullName.Split(' ');
                string firstName = separated[0];

                return firstName.Last() == 'a' ? E_ClientId.Mrs : E_ClientId.Mr;
            }
        }

        private void On_textBoxNameFinishedEditing(object sender, EventArgs e)
        {
            DataVerifier verifier = new DataVerifier();

            if (verifier.VerifyName(textBox_Name.Text))
            {
                _templates[(int)DetectClient(textBox_Name.Text)].Checked = true;
            }
        }


        private void button_Generate_Click(object sender, EventArgs e)
        {
            DataVerifier verifier = new DataVerifier();

            if (verifier.VerifyName(textBox_Name.Text))
            {
                verifier.ShowErrorName();
            }
            else if (verifier.VerifyAddress(textBox_Address.Text))
            {
                verifier.ShowErrorAddress();
            }
            else if (verifier.VerifySelectedClient(_templates))
            {
                verifier.ShowErrorSelectedClient();
            }
        }
    }
}
