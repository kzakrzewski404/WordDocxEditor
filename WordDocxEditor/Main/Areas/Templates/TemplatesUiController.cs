using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using WordDocxEditor.Shared.Config;
using WordDocxEditor.Shared.UI;


namespace WordDocxEditor.Main.Areas.Templates
{
    public class TemplatesUiController : TemplatesData
    {
        private ComboBox _comboBoxTemplates;
        private List<LoadedTemplates> _loadedTemplates = new List<LoadedTemplates>();
        private UiMessages _uiMessages = new UiMessages();
        private IniCfg _cfg = new IniCfg();


        private int SelectedId => _comboBoxTemplates.SelectedIndex;


        public void Bind(ComboBox templatesComboBox)
        {
            _comboBoxTemplates = templatesComboBox;

            AutoLoadTemplates();
            if (_comboBoxTemplates.Items.Count > 0)
            {
                _comboBoxTemplates.SelectedIndex = 0;
            }
        }

        public override string GetFilePath(TemplateId id)
        {
            return SelectedId >= 0 ? _loadedTemplates[SelectedId].GetFilePath(id) : null;
        }


        private bool CheckIfDirectoryContainsValidTemplates(string fullPath)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(fullPath);
            FileInfo[] files = directoryInfo.GetFiles();

            return (files.Any(x => x.Name.Contains(_cfg.GetEntry(IniEntryId.MrHeader))) &&
                    files.Any(x => x.Name.Contains(_cfg.GetEntry(IniEntryId.MrsHeader))) &&
                    files.Any(x => x.Name.Contains(_cfg.GetEntry(IniEntryId.CompanyHeader))));
        }

        private void AutoLoadTemplates()
        {
            if (Directory.Exists(_cfg.GetEntry(IniEntryId.TemplatesDir)))
            {
                DirectoryInfo[] templatesDirs = new DirectoryInfo(_cfg.GetEntry(IniEntryId.TemplatesDir)).GetDirectories();
                if (templatesDirs.Length != 0)
                {
                    _comboBoxTemplates.Items.Clear();
                    _loadedTemplates.Clear();

                    foreach (var dir in templatesDirs)
                    {
                        if (CheckIfDirectoryContainsValidTemplates(dir.FullName))
                        {
                            _loadedTemplates.Add(new LoadedTemplates(dir.FullName));
                            _comboBoxTemplates.Items.Add(dir.Name);
                        }
                        else
                        {
                            _uiMessages.ShowError($"W szablonie \"{dir.Name}\" nie odnaleziono {(int)TemplateId.ENUM_LENGTH} " +
                                $"wymaganych plików z szablonami zaczynających się od:\n" +
                                $"{_cfg.GetEntry(IniEntryId.MrHeader)}*\n{_cfg.GetEntry(IniEntryId.MrsHeader)}*\n{_cfg.GetEntry(IniEntryId.CompanyHeader)}*");
                        }
                    }
                }
                else
                {
                    _uiMessages.ShowError($"W folderze \"{_cfg.GetEntry(IniEntryId.TemplatesDir)}\" nie znaleziono żadnych folderów.");
                }
            }
            else
            {
                _uiMessages.ShowError($"Nie znaleziono folderu \"{_cfg.GetEntry(IniEntryId.TemplatesDir)}\".");
            }
        }
    }
}