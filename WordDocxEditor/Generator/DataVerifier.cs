using System.IO;
using System.Linq;

using WordDocxEditor.Ui;


namespace WordDocxEditor.Generator
{

    public class DataVerifier
    {
        public DataVerifierResult Verify(UiInputSummary summary)
        {
            if (!VerifyIfTemplateFilePathIsLoaded(summary.Templates.GetFilePath(summary.Informations.SelectedTemplate)))
            {
                return new DataVerifierResult("Błędnie wczytany szablon.");
            }
            if (!VerifyIfTemplateExists(summary.Templates.GetFilePath(summary.Informations.SelectedTemplate)))
            {
                return new DataVerifierResult("Nie odnaleziono pliku z szablonem.");
            }
            if (!VerifyName(summary.Informations.Name))
            {
                return new DataVerifierResult("Niepoprawne imię lub nazwa.");
            }
            if (!VerifyAddress(summary.Informations.Address))
            {
                return new DataVerifierResult("Niepoprawny adres lub brak numeru budynku.");
            }

            return new DataVerifierResult();
        }


        private bool VerifyName(string name) => !string.IsNullOrEmpty(name);

        private bool VerifyAddress(string address) => !string.IsNullOrEmpty(address) && address.Any(char.IsDigit);

        private bool VerifyIfTemplateFilePathIsLoaded(string filePath) => !string.IsNullOrEmpty(filePath);

        private bool VerifyIfTemplateExists(string filePath) => File.Exists(filePath);
    }
}