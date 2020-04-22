using System;
using System.Windows.Forms;

using WordDocxEditor.Shared.Data;
using WordDocxEditor.Shared.UI;


namespace WordDocxEditor.CustomCity
{
    public partial class CustomCityDialog : Form
    {
        private CityVerifier _verifier = new CityVerifier();
        private UiMessages _common = new UiMessages();


        public CustomCityResult Result { get; private set; }

        private string PostalCodeValue => textBox_PostalCode.Text;
        private string CityNameValue => textBox_City.Text;


        public CustomCityDialog()
        {
            InitializeComponent();
            Result = new CustomCityResult();
        }



        private void button_Add_Click(object sender, EventArgs e)
        {
            VerifierResult verify = _verifier.Verify(PostalCodeValue, CityNameValue);
            if (verify.IsSuccess)
            {
                Result = new CustomCityResult(PostalCodeValue, CityNameValue);
                this.Close();
            }
            else
            {
                _common.ShowError(verify.ErrorMessage);
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Result = new CustomCityResult();
            this.Close();
        }
    }
}