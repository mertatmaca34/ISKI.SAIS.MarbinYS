using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using WinUI.Constants;
using WinUI.Models;
using WinUI.Services;

namespace WinUI.Forms
{
    public class EditMailAlarmForm : Form
    {
        private readonly IMailAlarmService _alarmService;
        private readonly MailAlarmDto _alarm;
        private Label nameLabel = null!;
        private NumericUpDown limitNumericUpDown = null!;
        private Button saveButton = null!;

        public EditMailAlarmForm(MailAlarmDto alarm)
        {
            _alarm = alarm;
            _alarmService = Program.Services.GetRequiredService<IMailAlarmService>();
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            nameLabel = new Label { Text = _alarm.Name, AutoSize = true, Top = 20, Left = 20 };
            limitNumericUpDown = new NumericUpDown
            {
                Minimum = -100000,
                Maximum = 100000,
                DecimalPlaces = 2,
                Value = (decimal)_alarm.Limit,
                Top = 60,
                Left = 20,
                Width = 200
            };
            saveButton = new Button { Text = "Kaydet", Top = 100, Left = 20, Width = 80 };
            saveButton.Click += SaveButton_Click;

            Controls.Add(nameLabel);
            Controls.Add(limitNumericUpDown);
            Controls.Add(saveButton);

            Text = "Alarm Düzenle";
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(260, 150);
        }

        private async void SaveButton_Click(object? sender, EventArgs e)
        {
            double newLimit = (double)limitNumericUpDown.Value;
            try
            {
                var command = new UpdateMailAlarmCommand(_alarm.Id, newLimit);
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
