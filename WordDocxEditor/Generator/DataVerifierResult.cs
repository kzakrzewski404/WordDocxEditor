namespace WordDocxEditor.Generator
{
    public class DataVerifierResult
    {
        public bool IsSuccess { get; private set; }
        public string ErrorMessage { get; private set; }


        public DataVerifierResult() => IsSuccess = true;

        public DataVerifierResult(string errorMessage)
        {
            IsSuccess = false;
            ErrorMessage = errorMessage;
        }
    }
}