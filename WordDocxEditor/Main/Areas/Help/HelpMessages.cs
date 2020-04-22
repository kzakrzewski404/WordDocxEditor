using System.Windows.Forms;


namespace WordDocxEditor.Main.Areas.Help
{
    public class HelpMessages
    {
        public void templatesReuiremets()
        {
            ShowInfo("Wymagania szablonów",
                     "W folderze z szablonem muszą znajdować się dokładnie trzy pliki.\n" +
                     "Nazwa poszczególnych plików musi rozpoczynać się od słów:\n" +
                     "_pan_ResztaNazwySzablonu\n" +
                     "_pani_ResztaNazwySzablonu\n" +
                     "_firma_ResztaNazwySzablonu\n\n" +
                     "Najlepiej gdyby nazwa szablonu pojawiała się zarówno w nazwie plików, " +
                     "jak i w nazwie folderu z szablonami.");
        }

        public void informationsStreet()
        {
            ShowInfo("Checkbox ulica",
                     "Gdy pole jest zaznaczone:\n" +
                     "W miejsce tagu <str> pojawi się \"ul. \".\n\n" +
                     "Gdy pole jest odzaznaczone:\n" +
                     "Tag <str> zostanie usunięty.");
        }

        public void informationsAddNumberToFileName()
        {
            ShowInfo("Dodaj numer do nazwy pliku",
                     "Zakładając generowanie dokumenu na dane Jan Kowalski o nr. 25:\n\n" +
                     "Gdy pole jest zaznaczone:\n" +
                     "Wygenerowany plik będzie miał nazwę: 25 - Jan Kowalski.docx\n\n" +
                     "Gdy pole jest odzaznaczone:\n" +
                     "Wygenerowany plik będzie miał nazwę: Jan Kowalski.docx.");
        }

        public void printDoPrint()
        {
            ShowInfo("Wydruk",
                     "Dokument zostanie wydrukowany na domyślnej systemowej drukarce. " +
                     "Najczęściej jest to ta, która była ostatnio używana.");
        }

        public void generatorTags()
        {
            ShowInfo("Tagi",
                     "Aby generator odpowiednio modyfikował pliki, " +
                     "należy w dokumencie umieścić odpowiednie znaczniki. " +
                     "Nie ma ograniczeń co do ilości ich wystąpień. " +
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

        public void generatorOutputDirectory()
        {
            ShowInfo("Folder wyjściowy",
                     "Folder wyjściowy dla plików znajduje się zawsze na pulpicie.\n" +
                     "Jego nazwa to \"Dokumenty - <Dzisiejsza_Data>\".\n\n" +
                     "Aby szybko przejść do folderu skorzystaj z przycisku \"Folder\"");
        }


        private void ShowInfo(string caption, string msg)
        {
            MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}