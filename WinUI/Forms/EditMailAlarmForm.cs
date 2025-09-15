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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMailAlarmForm));
            nameLabel = new Label();
            limitNumericUpDown = new NumericUpDown();
            saveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)limitNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.Location = new Point(0, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(100, 23);
            nameLabel.TabIndex = 0;
            // 
            // limitNumericUpDown
            // 
            limitNumericUpDown.Location = new Point(0, 0);
            limitNumericUpDown.Name = "limitNumericUpDown";
            limitNumericUpDown.Size = new Size(120, 23);
            limitNumericUpDown.TabIndex = 1;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(0, 0);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 2;
            saveButton.Click += SaveButton_Click;
            // 
            // EditMailAlarmForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 150);
            Controls.Add(nameLabel);
            Controls.Add(limitNumericUpDown);
            Controls.Add(saveButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditMailAlarmForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alarm Düzenle";
            ((System.ComponentModel.ISupportInitialize)limitNumericUpDown).EndInit();
            ResumeLayout(false);
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
