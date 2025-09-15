using System;
using System.Linq;
using System.Windows.Forms;
using WinUI.Constants;
using WinUI.Models;
using WinUI.Services;

namespace WinUI.Forms
{
    public partial class EditMailAlarmForm : Form
    {
        private readonly IMailAlarmService _alarmService;
        private readonly MailAlarmDto _alarm;

        public EditMailAlarmForm(MailAlarmDto alarm, IMailAlarmService alarmService, IChannelNameProvider channelProvider)
        {
            InitializeComponent();

            _alarmService = alarmService;
            _alarm = alarm;

            channelComboBox.Items.AddRange(channelProvider.GetChannelNames().ToArray());

            nameTextBox.Text = _alarm.Name;
            channelComboBox.SelectedItem = _alarm.Channel;
            limitNumericUpDown.Value = (decimal)_alarm.Limit;
            subjectTextBox.Text = _alarm.MailSubject;
            bodyTextBox.Text = _alarm.MailBody;

            saveButton.Click += SaveButton_Click;
        }

        private async void SaveButton_Click(object? sender, EventArgs e)
        {
            var command = new UpdateMailAlarmCommand(
                _alarm.Id,
                nameTextBox.Text,
                channelComboBox.SelectedItem?.ToString() ?? string.Empty,
                (double)limitNumericUpDown.Value,
                subjectTextBox.Text,
                bodyTextBox.Text);

            try
            {
                var updated = await _alarmService.UpdateAlarmAsync(command);
                if (updated != null)
                {
                    MessageBox.Show(MailAlarmConstants.UpdateSuccessMessage, UserConstants.InfoTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format(MailAlarmConstants.UpdateErrorMessage, ex.Message), UserConstants.ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
