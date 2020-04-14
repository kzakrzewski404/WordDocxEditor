using System.Linq;
using System.Windows.Forms;

using WordDocxEditor.Ui;


namespace WordDocxEditor.Generator
{
    public class DataVerifierResponse
    {
        public bool IsSuccess { get; private set; }
        public string ErrorMessage { get; private set; }


        public DataVerifierResponse() => IsSuccess = true;

        public DataVerifierResponse(string errorMessage)
        {
            IsSuccess = false;
            ErrorMessage = errorMessage;
        }
    }

    public class DataVerifier
    {
        public DataVerifierResponse Verify(UiInputSummary summary)
        {

        }




        public bool VerifyName(string name) => !string.IsNullOrEmpty(name);

        public bool VerifyAddress(string address) => !string.IsNullOrEmpty(address) && address.Any(char.IsDigit);

        public bool VerifyIfSelectedTemplate(RadioButton[] radiobuttons)
        {
            int numberOfselected = 0;
            foreach (var client in radiobuttons)
            {
                if (client.Checked)
                {
                    numberOfselected++;
                }
            }

            return numberOfselected == 1;
        }

        public bool VerifyIfTemplatesAreLoaded(TemplatesFilePaths loadedTemplates)
        {
            if (loadedTemplates != null)
            {
                return loadedTemplates.IsSuccess;
            }

            return false;
        }

        public void ShowErrorName() => ShowCommonError("Niepoprawne imię lub nazwa.");

        public void ShowErrorSelectedTemplate() => ShowCommonError("Nie wybrano typu szablonu (Pan/Pani/Firma).");

        public void ShowErrorAddress() => ShowCommonError("Niepoprawny adres lub brak numeru budynku.");

        public void ShowErrorNoLoadedTemplates() => ShowCommonError("Szablony nie zostały wczytane.");


        private void ShowCommonError(string error)
        {
            MessageBox.Show(error, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}