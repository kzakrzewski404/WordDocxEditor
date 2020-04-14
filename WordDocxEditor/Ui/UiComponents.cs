using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace WordDocxEditor.Ui
{
    public class UiComponents
    {
        private TextBox _name;
        private TextBox _address;
        private CheckBox _isStreet;
        private ComboBox _city;
        private NumericUpDown _caseId;
        private DateTimePicker _receivedDate;
        private DateTimePicker _responseDate;
        private Dictionary<E_TemplateId, RadioButton> _templateChoice;
        private CheckBox _doPrint;
        private NumericUpDown _printNumberOfCopies;


        public void BindComponents(TextBox name, TextBox address, CheckBox isStreet, ComboBox city,
                                   NumericUpDown id, DateTimePicker receivedDate, DateTimePicker responseTime, 
                                   Dictionary<E_TemplateId, RadioButton> templateChoice,
                                   CheckBox doPrint, NumericUpDown printNumberOfCopies)
        {
            _name = name;
            _name.Leave += OnInputNameLeave;
            _address = address;
            _isStreet = isStreet;
            _city = city;
            _caseId = id;
            _receivedDate = receivedDate;
            _receivedDate.ValueChanged += OnInputDateChanged;
            _responseDate = responseTime;
            _responseDate.ValueChanged += OnInputDateChanged;
            _templateChoice = templateChoice;
            _templateChoice.First().Value.Checked = true;
            _doPrint = doPrint;
            _printNumberOfCopies = printNumberOfCopies;
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

        public UiInputData GetInputData()
        {
            return new UiInputData(name: _name.Text,
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


        private void OnInputDateChanged(object sender, System.EventArgs e)
        {
            if (_receivedDate.Value > _responseDate.Value)
            {
                ShowError($"Data otrzymania dokumentu nie może być większa od daty odpowiedzi!\n" +
                          $"Data otrzymania: {_receivedDate.Value.Date.ToString("dd.MM.yyyy")}\n" +
                          $"Data odpowiedzi: {_responseDate.Value.Date.ToString("dd.MM.yyyy")}");

                _receivedDate.Value = _responseDate.Value;
            }
        }

        private void ShowError(string msg, string caption = "Błąd")
        {
            MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}