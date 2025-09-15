using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Domain.Entities;
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
        private TextBox nameTextBox = null!;
        private ComboBox channelComboBox = null!;
        private NumericUpDown limitNumericUpDown = null!;
        private TextBox subjectTextBox = null!;
        private TextBox bodyTextBox = null!;
        private Button saveButton = null!;

        public EditMailAlarmForm(MailAlarmDto alarm)
        {
            _alarm = alarm;
            _alarmService = Program.Services.GetRequiredService<IMailAlarmService>();
            InitializeComponent();
            nameTextBox.Text = _alarm.Name;
            channelComboBox.SelectedItem = _alarm.Channel;
            limitNumericUpDown.Value = (decimal)_alarm.Limit;
            subjectTextBox.Text = _alarm.MailSubject;
            bodyTextBox.Text = _alarm.MailBody;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMailAlarmForm));
            var nameLabel = new Label();
            var channelLabel = new Label();
            var limitLabel = new Label();
            var subjectLabel = new Label();
            var bodyLabel = new Label();
            nameTextBox = new TextBox();
            channelComboBox = new ComboBox();
            limitNumericUpDown = new NumericUpDown();
            subjectTextBox = new TextBox();
            bodyTextBox = new TextBox();
            saveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)limitNumericUpDown).BeginInit();
            SuspendLayout();
            //
            // nameLabel
            //
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 15);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(62, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Alarm Adı";
            //
            // nameTextBox
            //
            nameTextBox.Location = new Point(110, 12);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(250, 23);
            nameTextBox.TabIndex = 1;
            //
            // channelLabel
            //
            channelLabel.AutoSize = true;
            channelLabel.Location = new Point(12, 45);
            channelLabel.Name = "channelLabel";
            channelLabel.Size = new Size(41, 15);
            channelLabel.TabIndex = 2;
            channelLabel.Text = "Kanal";
            //
            // channelComboBox
            //
            channelComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            channelComboBox.Location = new Point(110, 42);
            channelComboBox.Name = "channelComboBox";
            channelComboBox.Size = new Size(250, 23);
            channelComboBox.TabIndex = 3;
            var analogChannels = typeof(AnalogSensorData).GetProperties()
                .Where(p => p.PropertyType == typeof(double) || p.PropertyType == typeof(double?))
                .Select(p => p.Name);
            var digitalChannels = typeof(DigitalSensorData).GetProperties()
                .Where(p => p.PropertyType == typeof(bool) || p.PropertyType == typeof(bool?))
                .Select(p => p.Name);
            channelComboBox.Items.AddRange(analogChannels.Concat(digitalChannels).ToArray());
            //
            // limitLabel
            //
            limitLabel.AutoSize = true;
            limitLabel.Location = new Point(12, 75);
            limitLabel.Name = "limitLabel";
            limitLabel.Size = new Size(32, 15);
            limitLabel.TabIndex = 4;
            limitLabel.Text = "Limit";
            //
            // limitNumericUpDown
            //
            limitNumericUpDown.Location = new Point(110, 72);
            limitNumericUpDown.Name = "limitNumericUpDown";
            limitNumericUpDown.Size = new Size(120, 23);
            limitNumericUpDown.TabIndex = 5;
            limitNumericUpDown.Maximum = 1000000;
            limitNumericUpDown.DecimalPlaces = 2;
            //
            // subjectLabel
            //
            subjectLabel.AutoSize = true;
            subjectLabel.Location = new Point(12, 105);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new Size(75, 15);
            subjectLabel.TabIndex = 6;
            subjectLabel.Text = "Mail Konusu";
            //
            // subjectTextBox
            //
            subjectTextBox.Location = new Point(110, 102);
            subjectTextBox.Name = "subjectTextBox";
            subjectTextBox.Size = new Size(250, 23);
            subjectTextBox.TabIndex = 7;
            //
            // bodyLabel
            //
            bodyLabel.AutoSize = true;
            bodyLabel.Location = new Point(12, 135);
            bodyLabel.Name = "bodyLabel";
            bodyLabel.Size = new Size(67, 15);
            bodyLabel.TabIndex = 8;
            bodyLabel.Text = "Mail İçeriği";
            //
            // bodyTextBox
            //
            bodyTextBox.Location = new Point(110, 132);
            bodyTextBox.Multiline = true;
            bodyTextBox.Name = "bodyTextBox";
            bodyTextBox.Size = new Size(250, 80);
            bodyTextBox.TabIndex = 9;
            //
            // saveButton
            //
            saveButton.Location = new Point(285, 220);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 10;
            saveButton.Text = "Kaydet";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButton_Click;
            //
            // EditMailAlarmForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 260);
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(channelLabel);
            Controls.Add(channelComboBox);
            Controls.Add(limitLabel);
            Controls.Add(limitNumericUpDown);
            Controls.Add(subjectLabel);
            Controls.Add(subjectTextBox);
            Controls.Add(bodyLabel);
            Controls.Add(bodyTextBox);
            Controls.Add(saveButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditMailAlarmForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alarm Düzenle";
            ((System.ComponentModel.ISupportInitialize)limitNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
