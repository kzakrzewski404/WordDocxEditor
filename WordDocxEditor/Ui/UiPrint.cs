using System.Windows.Forms;


namespace WordDocxEditor.Ui
{
    public class UiPrint : UiPrintData
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