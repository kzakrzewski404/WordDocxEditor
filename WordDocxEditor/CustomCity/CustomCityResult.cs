namespace WordDocxEditor.CustomCity
{
    public class CustomCityResult
    {
        public bool IsCreatedSuccessful { get; private set; }
        public string City { get; private set; }


        public CustomCityResult(string postalCode, string cityName)
        {
            IsCreatedSuccessful = true;
            City = $"{postalCode} {cityName}";
        }
    }
}