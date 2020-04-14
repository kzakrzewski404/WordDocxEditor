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
}