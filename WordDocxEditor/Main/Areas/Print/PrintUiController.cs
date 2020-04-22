using System.Windows.Forms;


namespace WordDocxEditor.Main.Areas.Print
{
    public class PrintUiController : PrintData
    {
        private CheckBox _doPrint;
        private NumericUpDown _numberOfCopies;


        public override bool DoPrint => _doPrint.Checked;
        public override int NumberOfCopies => (int)_numberOfCopies.Value;


        public void Bind(CheckBox doPrint, NumericUpDown numberOfCopies)
        {
            _doPrint = doPrint;
            _numberOfCopies = numberOfCopies;
        }
    }
}