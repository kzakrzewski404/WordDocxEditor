using System.Windows.Forms;


namespace WordDocxEditor.Shared.UI
{
    public class UiMessages
    {
        public void ShowError(string msg, string caption = "Błąd")
        {
            MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}