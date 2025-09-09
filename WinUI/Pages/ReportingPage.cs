using WinUI.Models;
using WinUI.Services;

namespace WinUI.Pages
{
    public partial class ReportingPage : UserControl
    {
        private readonly ILogService _logService;

        public ReportingPage(ILogService logService)
        {
            _logService = logService;
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
                start = end.Date;
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

            bool descending = RadioButtonSortByLast.Checked;
            var logs = await _logService.GetAsync(start, end, descending) ?? new List<LogDto>();
            DataGridViewDatas.AutoGenerateColumns = true;
            DataGridViewDatas.DataSource = logs;
        }

        private void ButtonSaveAsExcel_Click(object sender, EventArgs e)
        {
        }

        private void ButtonSaveAsPdf_Click(object sender, EventArgs e)
        {
        }
    }
}
