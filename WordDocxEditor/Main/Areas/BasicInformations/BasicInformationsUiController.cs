using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using WordDocxEditor.Main.Areas.Templates;
using WordDocxEditor.CustomCity;
using WordDocxEditor.Shared.Config;


namespace WordDocxEditor.Main.Areas.BasicInformations
{
    public class BasicInformationsUiController : BasicInformationsData
    {
        private TextBox _name;
        private TextBox _address;
        private CheckBox _isStreet;
        private ComboBox _city;
        private NumericUpDown _caseId;
        private Dictionary<TemplateId, RadioButton> _templateChoice;
        private CheckBox _doAddCaseIdToFileName;
        private CheckBox _autoIncrementCaseId;
        private ToolStripMenuItem _toolStripToogleFieldId2;
        private NumericUpDown _numericOptionalId2;
        private Label _labelOptionalId2;
        private ToolStripMenuItem _toolStripMenuItemToggleName2;
        private TextBox _optionalName2;
        private IniCfg _ini = new IniCfg();


        public override string Name => _name.Text;
        public override string Address => _address.Text;
        public override bool IsStreet => _isStreet.Checked;
        public override string City => _city.SelectedItem.ToString();
        public override int CaseId => (int)_caseId.Value;
        public override TemplateId SelectedTemplate => _templateChoice.Where(x => x.Value.Checked).Select(x => x.Key).First();
        public override bool DoAddCaseIdToFileName => _doAddCaseIdToFileName.Checked;
        public override int OptionalId2 => (int)_numericOptionalId2.Value;
        public override string OptionalName2 => _optionalName2.Text;


        public void Bind(TextBox name, TextBox address, CheckBox isStreet, ComboBox city,
                         NumericUpDown id, Dictionary<TemplateId, RadioButton> templateChoice,
                         CheckBox doAddCaseIdToFileName, CheckBox autoIncrementCaseId, 
                         ToolStripMenuItem toolStripItemToogleFieldId2, NumericUpDown numericId2, Label labelId2,
                         ToolStripMenuItem toolStripMenuItemToggleName2, TextBox optionalName2)
        {
            _name = name;
            _name.Leave += OnInputNameLeave;
            _address = address;
            _isStreet = isStreet;
            _city = city;
            _city.SelectedIndexChanged += OnCitySelected;
            _caseId = id;
            _templateChoice = templateChoice;
            _templateChoice.First().Value.Checked = true;
            _doAddCaseIdToFileName = doAddCaseIdToFileName;
            _autoIncrementCaseId = autoIncrementCaseId;
            _toolStripToogleFieldId2 = toolStripItemToogleFieldId2;
            _toolStripToogleFieldId2.Click += OnToggleId2FieldClick;
            _numericOptionalId2 = numericId2;
            _labelOptionalId2 = labelId2;
            _labelOptionalId2.Text = $"{_ini.GetEntry(IniEntryId.OptionalId2LabelName)}:";
            _optionalName2 = optionalName2;
            _toolStripMenuItemToggleName2 = toolStripMenuItemToggleName2;
            _toolStripMenuItemToggleName2.Click += OnToggleName2Click;

            ToggleOptionalName2TextBox(true);
            ToggleOptionalId2Field(true);

            Clear();
        }

        public void Clear()
        {
            _address.Clear();
            _name.Clear();
            _isStreet.Checked = true;
            _city.SelectedIndex = 0;

            if (_autoIncrementCaseId.Checked)
            {
                _caseId.Value++;
            }
        }


        private void OnInputNameLeave(object sender, System.EventArgs e)
        {
            TemplateRecognition recognition = new TemplateRecognition();
            TemplateId id = recognition.RecognizeByName(_name.Text);
            _templateChoice.Where(x => x.Key == id).Select(x => x.Value).First().Checked = true;
        }

        private void OnCitySelected(object sender, System.EventArgs e)
        {
            if (_city.SelectedIndex == _city.Items.Count - 1)
            {
                CustomCityDialog cityDialog = new CustomCityDialog();
                cityDialog.ShowDialog();

                if (cityDialog.Result.IsCreatedSuccessful)
                {
                    _city.Items.Add(_city.Items[_city.SelectedIndex]);
                    _city.Items[_city.SelectedIndex] = cityDialog.Result.City;
                }
                else
                {
                    _city.SelectedIndex = 0;
                }
            }
        }

        private void OnToggleId2FieldClick(object sender, System.EventArgs e) => ToggleOptionalId2Field();

        private void ToggleOptionalId2Field(bool forceHide = false)
        {
            _numericOptionalId2.Value = Decimal.Parse(_ini.GetEntry(IniEntryId.OptionalId2DefaultValue));

            if (forceHide)
            {
                _labelOptionalId2.Visible = false;
                _numericOptionalId2.Visible = false;
            }
            else
            {
                _numericOptionalId2.Visible = !_numericOptionalId2.Visible;
                _labelOptionalId2.Visible = !_labelOptionalId2.Visible;
            }
        }

        private void OnToggleName2Click(object sender, System.EventArgs e) => ToggleOptionalName2TextBox();

        private void ToggleOptionalName2TextBox(bool forceHide = false)
        {
            _optionalName2.Clear();
            if (_optionalName2.Visible || forceHide)
            {
                _name.Width = 435;
                _optionalName2.Visible = false;
            }
            else
            {
                _name.Width = 200;
                _optionalName2.Visible = true;
            }
        }
    }
}