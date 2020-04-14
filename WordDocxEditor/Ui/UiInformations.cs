using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using WordDocxEditor.Generator;


namespace WordDocxEditor.Ui
{
    public class UiInformations : UiInformationsData
    {
        private TextBox _name;
        private TextBox _address;
        private CheckBox _isStreet;
        private ComboBox _city;
        private NumericUpDown _caseId;
        private Dictionary<TemplateId, RadioButton> _templateChoice;
        private CheckBox _doAddCaseIdToFileName;

        public override string Name => _name.Text;
        public override string Address => _address.Text;
        public override bool IsStreet => _isStreet.Checked;
        public override string City => _city.SelectedItem.ToString();
        public override int CaseId => (int)_caseId.Value;
        public override TemplateId SelectedTemplate => _templateChoice.Where(x => x.Value.Checked).Select(x => x.Key).First();
        public override bool DoAddCaseIdToFileName => _doAddCaseIdToFileName.Checked;


        public void Bind(TextBox name, TextBox address, CheckBox isStreet, ComboBox city,
                         NumericUpDown id, Dictionary<TemplateId, RadioButton> templateChoice,
                         CheckBox doAddCaseIdToFileName)
        {
            _name = name;
            _name.Leave += OnInputNameLeave;
            _address = address;
            _isStreet = isStreet;
            _city = city;
            _caseId = id;
            _templateChoice = templateChoice;
            _templateChoice.First().Value.Checked = true;
            _doAddCaseIdToFileName = doAddCaseIdToFileName;

            Clear();
        }

        public void Clear()
        {
            _address.Clear();
            _name.Clear();
            _isStreet.Checked = true;
            _city.SelectedIndex = 0;
        }


        private void OnInputNameLeave(object sender, System.EventArgs e)
        {
            UiInformationsTemplateRecognition recognition = new UiInformationsTemplateRecognition();
            TemplateId id = recognition.RecognizeByName(_name.Text);
            _templateChoice.Where(x => x.Key == id).Select(x => x.Value).First().Checked = true;
        }
    }
}