namespace WordDocxEditor.Main.Areas.Print
{
    public abstract class PrintData
    {
        public abstract bool DoPrint { get; }
        public abstract int NumberOfCopies { get; }
    }
}