using System.Windows.Forms;


namespace WordDocxEditor.Ui
{
    public class UiCommon
    {
        public void ShowError(string msg, string caption = "Błąd")
        {
            MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}