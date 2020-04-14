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


        public void BindComponents(TextBox name, TextBox address, CheckBox isStreet, ComboBox city,
                                   NumericUpDown id, DateTimePicker receivedDate, DateTimePicker responseTime)
        {
            _name = name;
            _address = address;
            _isStreet = isStreet;
            _city = city;
            _caseId = id;
            _receivedDate = receivedDate;
            _responseDate = responseTime;
        }

        public UiInputData GetInputData()
        {
            return new UiInputData(name: _name.Text,
                                   address: _address.Text,
                                   isStreet: _isStreet.Checked,
                                   city: _city.SelectedItem.ToString(),
                                   caseId: (int)_caseId.Value,
                                   received: _receivedDate.Value,
                                   response: _responseDate.Value);
        }
    }
}