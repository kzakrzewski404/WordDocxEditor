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

        public string MrHeader => GetValue(IniEntry_Id.MrHeader);
        public string MrsHeader => GetValue(IniEntry_Id.MrsHeader);
        public string CompanyHeader => GetValue(IniEntry_Id.CompanyHeader);
        public string ArchivableTemplateName => GetValue(IniEntry_Id.ArchivableTemplateName);
        public string Templates => GetValue(IniEntry_Id.TemplatesDir);
        public string Archive => GetValue(IniEntry_Id.ArchiveDir);


        public IniCfg()
        {
            if (!_isLoaded)
            {
                _isLoaded = true;
                InitializeDefaults();
                LoadIni();
            }
        }

        private string GetValue(IniEntry_Id id) => _entries.Where(x => x.Id == IniEntry_Id.MrHeader).Select(x => x.Value).FirstOrDefault();

        private void InitializeDefaults()
        {
            _entries = new List<IniEntry>();
            _entries.Add(new IniEntry(IniEntry_Id.MrHeader, "sMrFileHeader", "mr_"));
            _entries.Add(new IniEntry(IniEntry_Id.MrsHeader, "sMrsFileHeader", "mrs_"));
            _entries.Add(new IniEntry(IniEntry_Id.CompanyHeader, "sCompanyFileHeader", "company_"));
            _entries.Add(new IniEntry(IniEntry_Id.TemplatesDir, "sTemplatesDirectory", "Templates"));
            _entries.Add(new IniEntry(IniEntry_Id.ArchiveDir, "sArchiveDirectory", "C:\\Archive"));
            _entries.Add(new IniEntry(IniEntry_Id.ArchivableTemplateName, "sArchivableTemplateHeader", "praca.gov.pl"));
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