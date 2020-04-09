using System.Windows.Forms;


namespace WordDocxEditor
{
    public class UiHelp
    {
        public void ShowTags()
        {
            MessageBox.Show("Tagi które są wyszukiwane w dokumencie:\n\n" +
                            "<name> - Imie i nazwisko / nazwa\n" +
                            "<addr> - Adres (ulica i numer budynku)\n" +
                            "<city> - kod pocztowy i miejscowość\n" +
                            "<id> - numer sprawy\n" +
                            "<dateIn> - data przyjęcia pisma\n" +
                            "<dateOut> - data odpowiedzi na pismo",
                            "Tagi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowPrint()
        {
            MessageBox.Show("Wydruk dokumentu jest wykonywany na domyślnej w systemie drukarce.",
                            "Wydruk", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}