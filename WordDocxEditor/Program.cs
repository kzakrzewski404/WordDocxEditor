using System;
using System.Windows.Forms;

using WordDocxEditor.Main;


namespace WordDocxEditor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Application.ExecutablePath[0] == '\\')
            {
                MessageBox.Show("Aplikacja nie może zostać uruchomiona ze ścieżki sieciowej!", "Nie można uruchomić",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Application.Run(new MainForm());
            }
        }
    }
}
