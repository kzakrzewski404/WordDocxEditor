using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using WordDocxEditor.Main.Areas.Templates;
using WordDocxEditor.CustomCity;

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

        public override string Name => _name.Text;
        public override string Address => _address.Text;
        public override bool IsStreet => _isStreet.Checked;
        public override string City => _city.SelectedItem.ToString();
        public override int CaseId => (int)_caseId.Value;
        public override TemplateId SelectedTemplate => _templateChoice.Where(x => x.Value.Checked).Select(x => x.Key).First();
        public override bool DoAddCaseIdToFileName => _doAddCaseIdToFileName.Checked;


        public void Bind(TextBox name, TextBox address, CheckBox isStreet, ComboBox city,
                         NumericUpDown id, Dictionary<TemplateId, RadioButton> templateChoice,
                         CheckBox doAddCaseIdToFileName, CheckBox autoIncrementCaseId)
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
    }
}