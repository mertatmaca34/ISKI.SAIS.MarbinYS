using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using WinUI.Models;
using WinUI.Services;

namespace WinUI.Pages.Settings
{
    public partial class CalibrationSettingsPage : UserControl
    {
        private readonly ICalibrationLimitService _calibrationLimitService;
        private CalibrationLimitDto? _phLimit;
        private CalibrationLimitDto? _conductivityLimit;

        public CalibrationSettingsPage()
        {
            InitializeComponent();

            _calibrationLimitService = Program.Services.GetRequiredService<ICalibrationLimitService>();

            Load += CalibrationSettingsPage_Load;
            SaveCalibrationButton.Click += SaveCalibrationButton_Click;
        }

        private async void CalibrationSettingsPage_Load(object? sender, EventArgs e)
        {
            var list = await _calibrationLimitService.GetListAsync();
            _phLimit = list?.FirstOrDefault(x => x.Parameter.Equals("pH", StringComparison.OrdinalIgnoreCase));
            _conductivityLimit = list?.FirstOrDefault(x => x.Parameter.Equals("Iletkenlik", StringComparison.OrdinalIgnoreCase));

            if (_phLimit != null)
            {
                PhZeroTextBox.Text = _phLimit.ZeroRef.ToString();
                PhSpanComboBox.Text = _phLimit.SpanRef.ToString();

                var phTime = _phLimit.ZeroTimeStamp.ToString();
                if (!comboBox1.Items.Contains(phTime))
                    comboBox1.Items.Add(phTime);
                comboBox1.SelectedItem = phTime;
            }

            if (_conductivityLimit != null)
            {
                ConductivityZeroTextBox.Text = _conductivityLimit.ZeroRef.ToString();
                ConductivitySpanTextBox.Text = _conductivityLimit.SpanRef.ToString();

                var conductivityTime = _conductivityLimit.ZeroTimeStamp.ToString();
                if (!comboBox2.Items.Contains(conductivityTime))
                    comboBox2.Items.Add(conductivityTime);
                comboBox2.SelectedItem = conductivityTime;
            }
        }

        private async void SaveCalibrationButton_Click(object? sender, EventArgs e)
        {
            if (_phLimit != null)
            {
                _phLimit.ZeroRef = int.Parse(PhZeroTextBox.Text);
                _phLimit.SpanRef = int.Parse(PhSpanComboBox.Text);
                var phTime = int.Parse(comboBox1.SelectedItem?.ToString() ?? "0");
                _phLimit.ZeroTimeStamp = phTime;
                _phLimit.SpanTimeStamp = phTime;
                await _calibrationLimitService.UpdateAsync(new UpdateCalibrationLimitCommand(_phLimit.Id, _phLimit.Parameter, _phLimit.ZeroRef, _phLimit.ZeroTimeStamp, _phLimit.SpanRef, _phLimit.SpanTimeStamp));
            }
            else
            {
                var phTime = int.Parse(comboBox1.SelectedItem?.ToString() ?? "0");
                var cmd = new CreateCalibrationLimitCommand("pH", int.Parse(PhZeroTextBox.Text), phTime, int.Parse(PhSpanComboBox.Text), phTime);
                _phLimit = await _calibrationLimitService.CreateAsync(cmd);
            }

            if (_conductivityLimit != null)
            {
                _conductivityLimit.ZeroRef = int.Parse(ConductivityZeroTextBox.Text);
                _conductivityLimit.SpanRef = int.Parse(ConductivitySpanTextBox.Text);
                var conductivityTime = int.Parse(comboBox2.SelectedItem?.ToString() ?? "0");
                _conductivityLimit.ZeroTimeStamp = conductivityTime;
                _conductivityLimit.SpanTimeStamp = conductivityTime;
                await _calibrationLimitService.UpdateAsync(new UpdateCalibrationLimitCommand(_conductivityLimit.Id, _conductivityLimit.Parameter, _conductivityLimit.ZeroRef, _conductivityLimit.ZeroTimeStamp, _conductivityLimit.SpanRef, _conductivityLimit.SpanTimeStamp));
            }
            else
            {
                var conductivityTime = int.Parse(comboBox2.SelectedItem?.ToString() ?? "0");
                var cmd2 = new CreateCalibrationLimitCommand("Iletkenlik", int.Parse(ConductivityZeroTextBox.Text), conductivityTime, int.Parse(ConductivitySpanTextBox.Text), conductivityTime);
                _conductivityLimit = await _calibrationLimitService.CreateAsync(cmd2);
            }

            MessageBox.Show("Kalibrasyon değerleri kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
