using System;
using System.Windows.Forms;

using WordDocxEditor.Shared.UI;


namespace WordDocxEditor.Main.Areas.Date
{
    public class DateUiController : DateData
    {
        private DateTimePicker _receivedDate;
        private DateTimePicker _responseDate;
        private UiMessages _common = new UiMessages();


        public override DateTime Received => _receivedDate.Value;
        public override DateTime Response => _responseDate.Value;


        public void Bind(DateTimePicker received, DateTimePicker response)
        {
            _receivedDate = received;
            _receivedDate.ValueChanged += OnInputDateChanged;
            _responseDate = response;
            _responseDate.ValueChanged += OnInputDateChanged;
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