﻿using System.Collections.Generic;
using System.IO;
using System.Linq;

using WordDocxEditor.Shared.Config;


namespace WordDocxEditor.Main.Areas.Templates
{
    public class LoadedTemplates
    {
        private Dictionary<TemplateId, string> _filePaths = new Dictionary<TemplateId, string>();
        private IniCfg _cfg = new IniCfg();


        public string Name { get; private set; }


        public LoadedTemplates(string templateDirectoryPath)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(templateDirectoryPath);
            FileInfo[] files = directoryInfo.GetFiles();

            _filePaths.Add(TemplateId.Mr, FindTemplateFile(files, _cfg.GetEntry(IniEntryId.MrHeader)));
            _filePaths.Add(TemplateId.Mrs, FindTemplateFile(files, _cfg.GetEntry(IniEntryId.MrsHeader)));
            _filePaths.Add(TemplateId.Company, FindTemplateFile(files, _cfg.GetEntry(IniEntryId.CompanyHeader)));

            Name = directoryInfo.Name;
        }


        public string GetFilePath(TemplateId id) => _filePaths.Where(x => x.Key == id).Select(x => x.Value).FirstOrDefault();


        private string FindTemplateFile(FileInfo[] files, string searchPattern)
        {
            return files.Where(x => x.Name.Contains(searchPattern)).Select(x => x.FullName).FirstOrDefault();
        }
    }
}