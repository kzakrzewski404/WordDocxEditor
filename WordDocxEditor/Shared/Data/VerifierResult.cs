namespace WordDocxEditor.Shared.Data
{
    public class VerifierResult
    {
        public bool IsSuccess { get; private set; }
        public string ErrorMessage { get; private set; }


        public VerifierResult() => IsSuccess = true;

        public VerifierResult(string errorMessage)
        {
            IsSuccess = false;
            ErrorMessage = errorMessage;
        }
    }
}