using System;
using System.Windows.Forms;


namespace WordDocxEditor.Ui
{
    public class UiDate : UiDateData
    {
        private DateTimePicker _receivedDate;
        private DateTimePicker _responseDate;
        private UiCommon _common = new UiCommon();


        public override DateTime Received => _receivedDate.Value;
        public override DateTime Response => _responseDate.Value;


        public void Bind(DateTimePicker received, DateTimePicker response)
        {
            _receivedDate = received;
            _responseDate = response;
        }


        private void OnInputDateChanged(object sender, System.EventArgs e)
        {
            if (_receivedDate.Value > _responseDate.Value)
            {
                _common.ShowError($"Data otrzymania dokumentu nie może być większa od daty odpowiedzi!\n" +
                          $"Data otrzymania: {_receivedDate.Value.Date.ToString("dd.MM.yyyy")}\n" +
                          $"Data odpowiedzi: {_responseDate.Value.Date.ToString("dd.MM.yyyy")}");

                _receivedDate.Value = _responseDate.Value;
            }
        }
    }
}