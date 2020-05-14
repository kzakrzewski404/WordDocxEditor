using System.IO;
using System.Linq;
using System.Collections.Generic;


namespace WordDocxEditor.Shared.Config
{
    public class IniCfg
    {
        private static string INI_FILE = "config.ini";
        private static bool _isLoaded;
        private static List<IniEntry> _entries;


        public IniCfg()
        {
            if (!_isLoaded)
            {
                _isLoaded = true;
                InitializeDefaults();
                LoadIni();
            }
        }


        public string GetEntry(IniEntryId id) => _entries.Where(x => x.Id == id).Select(x => x.Value).FirstOrDefault();


        private void InitializeDefaults()
        {
            _entries = new List<IniEntry>();
            _entries.Add(new IniEntry(IniEntryId.MrHeader, "sMrFileHeader", "mr_"));
            _entries.Add(new IniEntry(IniEntryId.MrsHeader, "sMrsFileHeader", "mrs_"));
            _entries.Add(new IniEntry(IniEntryId.CompanyHeader, "sCompanyFileHeader", "company_"));
            _entries.Add(new IniEntry(IniEntryId.TemplatesDir, "sTemplatesDirectory", "Templates"));
            _entries.Add(new IniEntry(IniEntryId.ArchiveDir, "sArchiveDirectory", "C:\\Archive"));
            _entries.Add(new IniEntry(IniEntryId.ArchivableTemplateName, "sArchivableTemplateHeader", "praca.gov.pl"));
            _entries.Add(new IniEntry(IniEntryId.AutoUpdaterApp, "sAutoUpdaterApp", "AutoUpdate.exe"));
            _entries.Add(new IniEntry(IniEntryId.UrlKRS, "sUrlKRS", "www.google.com/search?q=krs"));
            _entries.Add(new IniEntry(IniEntryId.UrlCEIDG, "sUrlCEIDG", "www.google.com/search?q=ceidg"));
            _entries.Add(new IniEntry(IniEntryId.OptionalId2DefaultValue, "iOptionalId2FieldDefaultValue", "3"));
            _entries.Add(new IniEntry(IniEntryId.OptionalId2LabelName, "sOptionalId2LabelName", "Id_2"));
        }

        private void LoadIni()
        {
            if (File.Exists(INI_FILE))
            {
                string[] allLines = File.ReadAllLines(INI_FILE);

                if(allLines.Length > 0)
                {
                    foreach (var item in _entries)
                    {
                        string fromIni = allLines.Where(x => x.StartsWith(item.Entry)).FirstOrDefault()?
                                                 .Split('=')?.Skip(1).FirstOrDefault();
                        
                        if (fromIni != null)
                        {
                            item.ChangeValue(fromIni);
                        }
                        else
                        {
                            using (StreamWriter sw = File.AppendText(INI_FILE))
                            {
                                sw.WriteLine($"{item.Entry}={item.Value}");
                            }
                        }
                    }
                }
                else
                {
                    CreateDefaultIni();
                }
            }
            else
            {
                CreateDefaultIni();
            }
        }

        private void CreateDefaultIni()
        {
            using (StreamWriter sw = File.AppendText(INI_FILE))
            {
                foreach (var item in _entries)
                {
                    sw.WriteLine($"{item.Entry}={item.Value}");
                }
            }
        }
    }
}