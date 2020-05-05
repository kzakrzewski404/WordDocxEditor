using System.IO;
using System.Linq;

using WordDocxEditor.Shared.Data;


namespace WordDocxEditor.Main.Data
{

    public class DataVerifier
    {
        public VerifierResult Verify(UiEntriesSummary summary)
        {
            if (!VerifyIfTemplateFilePathIsLoaded(summary.Templates.GetFilePath(summary.BasicInformations.SelectedTemplate)))
            {
                return new VerifierResult("Błędnie wczytany szablon.");
            }
            if (CheckIfNameContainsSpecialCharacter(summary.BasicInformations.Name))
            {
                return new VerifierResult("Nazwa zawiera niedozwolone znaki!");
            }
            if (!VerifyIfTemplateExists(summary.Templates.GetFilePath(summary.BasicInformations.SelectedTemplate)))
            {
                return new VerifierResult("Nie odnaleziono pliku z szablonem.");
            }
            if (!VerifyName(summary.BasicInformations.Name))
            {
                return new VerifierResult("Niepoprawne imię lub nazwa.");
            }
            if (!VerifyAddress(summary.BasicInformations.Address))
            {
                return new VerifierResult("Niepoprawny adres lub brak numeru budynku.");
            }

            return new VerifierResult();
        }


        private bool VerifyName(string name) => !string.IsNullOrEmpty(name);

        private bool CheckIfNameContainsSpecialCharacter(string str)
        {
            const string SPECIAL_CHARS = @"!@#$%^&*()_+={}|[]\:"";'<>?,./";
            return SPECIAL_CHARS.Any(c => str.Contains(c));
        }

        private bool VerifyAddress(string address) => !string.IsNullOrEmpty(address) && address.Any(char.IsDigit);

        private bool VerifyIfTemplateFilePathIsLoaded(string filePath) => !string.IsNullOrEmpty(filePath);

        private bool VerifyIfTemplateExists(string filePath) => File.Exists(filePath);
    }
}