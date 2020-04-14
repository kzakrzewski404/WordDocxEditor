using System.Windows.Forms;


namespace WordDocxEditor
{
    public class UiHelp
    {
        public void ShowTags()
        {
            ShowInfo("Tagi",
                     "Aby generator odpowiednio modyfikował pliki,\n" +
                     "należy w dokumencie umieścić odpowiednie znaczniki.\n" +
                     "Nie ma ograniczeń co do ilości ich wystąpień.\n" +
                     "Niektóre można pominąć.\n\n" +
                     "Tagi które są wyszukiwane w dokumencie:\n\n" +
                     "<name> - Imię i nazwisko / nazwa.\n" +
                     "<str> - w przypadku ulicy wstawi skrót \"ul. \"\n" +
                     "             w innym przypadku usunie całkowicie tag.\n" +
                     "<addr> - Adres (ulica i numer budynku).\n" +
                     "<city> - kod pocztowy i miejscowość.\n" +
                     "<id> - numer sprawy.\n" +
                     "<dateIn> - data przyjęcia pisma.\n" +
                     "<dateOut> - data odpowiedzi na pismo.");
        }

        public void ShowPrint()
        {
            ShowInfo("Wydruk",
                     "Dokument zostanie wydrukowany na domyślnej systemowej drukarce.\n" +
                     "Najczęściej jest to ta, która była ostatnio używana.");
        }


        private void ShowInfo(string caption, string msg)
        {
            MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}