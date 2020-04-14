using System.IO;
using System.Linq;

using WordDocxEditor.Ui;


namespace WordDocxEditor.Generator
{

    public class DataVerifier
    {
        public DataVerifierResult Verify(UiInputSummary summary)
        {
            if (!VerifyName(summary.Name))
            {
                return new DataVerifierResult("Niepoprawne imię lub nazwa.");
            }
            if (!VerifyAddress(summary.Address))
            {
                return new DataVerifierResult("Niepoprawny adres lub brak numeru budynku.");
            }
            if (!VerifyIfTemplateFilePathIsLoaded(summary.TemplateFilePath))
            {
                return new DataVerifierResult("Błędnie wczytany szablon.");
            }
            if (!VerifyIfTemplateExists(summary.TemplateFilePath))
            {
                return new DataVerifierResult("Nie odnaleziono pliku z szablonem.");
            }

            return new DataVerifierResult();
        }


        private bool VerifyName(string name) => !string.IsNullOrEmpty(name);

        private bool VerifyAddress(string address) => !string.IsNullOrEmpty(address) && address.Any(char.IsDigit);

        private bool VerifyIfTemplateFilePathIsLoaded(string filePath) => !string.IsNullOrEmpty(filePath);

        private bool VerifyIfTemplateExists(string filePath) => File.Exists(filePath);
    }
}