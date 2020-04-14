namespace WordDocxEditor.Ui
{
    public abstract class UiPrintData
    {
        public abstract bool DoPrint { get; }
        public abstract int NumberOfCopies { get; }
    }
}