using WinUI.Models;
using WinUI.Services;

namespace WinUI.Pages
{
    public partial class ReportingPage : UserControl
    {
        private readonly ILogService _logService;
        private readonly IReportExportService _exportService;
        private List<LogDto> _currentLogs = new();
        private DateTime _lastStartDate;
        private DateTime _lastEndDate;

        public ReportingPage(ILogService logService, IReportExportService exportService)
        {
            _logService = logService;
            _exportService = exportService;
            InitializeComponent();
        }

        private void ReportingPage_Load(object sender, EventArgs e)
        {
            ComboBoxReportType.Items.AddRange(new object[] { "Analog", "Dijital", "Kayıt" });
            ComboBoxReportType.SelectedIndex = 0;
            RadioButtonDaily.Checked = true;
        }

        private void RadioButtonCustom_CheckedChanged(object sender, EventArgs e)
        {
            GroupBoxDate.Enabled = RadioButtonCustom.Checked;
        }

        private void RadioButtonMonthly_CheckedChanged(object sender, EventArgs e)
        {
            GroupBoxDate.Enabled = false;
        }

        private void RadioButtonWeekly_CheckedChanged(object sender, EventArgs e)
        {
            GroupBoxDate.Enabled = false;
        }

        private void RadioButtonDaily_CheckedChanged(object sender, EventArgs e)
        {
            GroupBoxDate.Enabled = false;
        }

        private async void ButtonGenerate_Click(object sender, EventArgs e)
        {
            if (ComboBoxReportType.SelectedItem?.ToString() != "Kayıt")
                return;

            DateTime start;
            DateTime end;

            if (RadioButtonDaily.Checked)
            {
                end = DateTime.Now;
                start = end.AddDays(-1);
            }
            else if (RadioButtonWeekly.Checked)
            {
                end = DateTime.Now;
                start = end.AddDays(-7);
            }
            else if (RadioButtonMonthly.Checked)
            {
                end = DateTime.Now;
                start = end.AddMonths(-1);
            }
            else
            {
                start = DateTimePickerFirstDate.Value.Date + DateTimePickerFirstTime.Value.TimeOfDay;
                end = DateTimePickerLastDate.Value.Date + DateTimePickerLastTime.Value.TimeOfDay;
            }

            _lastStartDate = start;
            _lastEndDate = end;

            bool descending = RadioButtonSortByLast.Checked;
            _currentLogs = await _logService.GetAsync(start, end, descending) ?? new List<LogDto>();
            DataGridViewDatas.AutoGenerateColumns = true;
            DataGridViewDatas.DataSource = _currentLogs;
        }

        private void ButtonSaveAsExcel_Click(object sender, EventArgs e)
        {
            if (_currentLogs.Count == 0)
                return;

            using SaveFileDialog dialog = new()
            {
                Filter = "Excel Files|*.xlsx",
                FileName = GenerateFileName("xlsx")
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _exportService.ExportLogsToExcel(_currentLogs, dialog.FileName);
            }
        }

        private void ButtonSaveAsPdf_Click(object sender, EventArgs e)
        {
            if (_currentLogs.Count == 0)
                return;

            using SaveFileDialog dialog = new()
            {
                Filter = "PDF Files|*.pdf",
                FileName = GenerateFileName("pdf")
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _exportService.ExportLogsToPdf(_currentLogs, dialog.FileName);
            }
        }

        private string GenerateFileName(string extension)
        {
            string start = _lastStartDate.ToString("d");
            string end = _lastEndDate.ToString("d");
            return $"logs_{start}-{end}.{extension}";
        }
    }
}
