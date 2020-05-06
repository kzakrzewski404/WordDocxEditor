using System;
using System.Linq;
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

            string allowedStartupDisks = "CDE";
            char diskLetter = Application.ExecutablePath[0];
            if (allowedStartupDisks.Contains(diskLetter))
            {
                Application.Run(new MainForm());
            }
            else
            {
                MessageBox.Show("Aplikacja nie może zostać uruchomiona ze ścieżki sieciowej!", "Błąd",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
