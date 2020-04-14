using System.Linq;
using System.Windows.Forms;


namespace WordDocxEditor.Generator
{
    public class DataVerifier
    {
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