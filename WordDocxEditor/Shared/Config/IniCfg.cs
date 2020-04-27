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

        public string MrTemplateHeader => GetValue(IniEntryId.MrHeader);
        public string MrsTemplateHeader => GetValue(IniEntryId.MrsHeader);
        public string CompanyTemplateHeader => GetValue(IniEntryId.CompanyHeader);
        public string ArchivableTemplateNameHeader => GetValue(IniEntryId.ArchivableTemplateName);
        public string TemplatesDirectory => GetValue(IniEntryId.TemplatesDir);
        public string ArchiveDirectory => GetValue(IniEntryId.ArchiveDir);
        public string AutoUpdaterApp => GetValue(IniEntryId.AutoUpdaterApp);


        public IniCfg()
        {
            if (!_isLoaded)
            {
                _isLoaded = true;
                InitializeDefaults();
                LoadIni();
            }
        }

        private string GetValue(IniEntryId id) => _entries.Where(x => x.Id == id).Select(x => x.Value).FirstOrDefault();

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