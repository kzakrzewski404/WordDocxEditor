using System.Text.RegularExpressions;

using WordDocxEditor.Common;


namespace WordDocxEditor.CustomCity
{
    public class CityVerifier
    {
        public VerifierResult Verify(string postalCode, string cityName)
        {
            if (!VerifyPostalCodeLength(postalCode))
            {
                return new VerifierResult("Nieprawidłowa długość kodu pocztowego.");
            }
            if (!VerifyPostalCodePattern(postalCode))
            {
                return new VerifierResult("Kod pocztowy nie jest w formacie \"XX-XXX\".");
            }
            if (!VerifyCity(cityName))
            {
                return new VerifierResult("Niepoprawna nazwa miasta.");
            }

            return new VerifierResult();
        }


        private bool VerifyPostalCodeLength(string postalCode) => (NotNull(postalCode) && postalCode.Length == 6);

        private bool VerifyPostalCodePattern(string postalCode) => (NotNull(postalCode) && Regex.IsMatch(postalCode, @"\d{2}-\d{3}"));

        private bool VerifyCity(string city) => NotNull(city);

        private bool NotNull(string str) => !string.IsNullOrEmpty(str) && !string.IsNullOrWhiteSpace(str);
    }
}