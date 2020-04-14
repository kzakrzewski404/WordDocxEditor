using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace WordDocxEditor.Ui
{
    public class UiInformations
    {
        private TextBox _name;
        private TextBox _address;
        private CheckBox _isStreet;
        private ComboBox _city;
        private NumericUpDown _caseId;
        private Dictionary<E_TemplateId, RadioButton> _templateChoice;


        public void Bind(TextBox name, TextBox address, CheckBox isStreet, ComboBox city,
                                   NumericUpDown id, Dictionary<E_TemplateId, RadioButton> templateChoice)
        {
            _name = name;
            _name.Leave += OnInputNameLeave;
            _address = address;
            _isStreet = isStreet;
            _city = city;
            _caseId = id;
            _templateChoice = templateChoice;
            _templateChoice.First().Value.Checked = true;
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
            UiTemplateRecognition recognition = new UiTemplateRecognition();
            E_TemplateId id = recognition.RecognizeByName(_name.Text);
            _templateChoice.Where(x => x.Key == id).Select(x => x.Value.Checked = true);
        }

        public UiInputSummary GetInputData()
        {
            return new UiInputSummary(name: _name.Text,
                                   address: _address.Text,
                                   isStreet: _isStreet.Checked,
                                   city: _city.SelectedItem.ToString(),
                                   caseId: (int)_caseId.Value,
                                   received: _receivedDate.Value,
                                   response: _responseDate.Value,
                                   templateId: _templateChoice.Where(x => x.Value.Checked).Select(x => x.Key).FirstOrDefault(),
                                   doPrint: _doPrint.Checked,
                                   numberOfCopies: (int)_printNumberOfCopies.Value);
        }
    }
}