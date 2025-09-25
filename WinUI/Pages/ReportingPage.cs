using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinUI.Models;
using WinUI.Services;

namespace WinUI.Pages
{
    public partial class ReportingPage : UserControl
    {
        private readonly ILogService _logService;
        private readonly IReportExportService _exportService;
        private readonly IMeasurementReportService _measurementService;
        private readonly ISaisApiService _saisApiService;
        private readonly IStationService _stationService;
        private List<LogDto> _currentLogs = new();
        private List<ApiDataResultDto> _currentMeasurements = new();
        private List<MissingDateRow> _currentMissingDates = new();
        private DateTime _lastStartDate;
        private DateTime _lastEndDate;

        public ReportingPage(
            ILogService logService,
            IReportExportService exportService,
            IMeasurementReportService measurementService,
            ISaisApiService saisApiService,
            IStationService stationService)
        {
            _logService = logService;
            _exportService = exportService;
            _measurementService = measurementService;
            _saisApiService = saisApiService;
            _stationService = stationService;
            InitializeComponent();
        }

        private void ReportingPage_Load(object sender, EventArgs e)
        {
            ComboBoxReportType.Items.AddRange(new object[] { "Ölçüm Verileri", "Kalibrasyon Verileri", "Numune Verileri", "Log Kayıtları", "Eksik Veriler" });
            ComboBoxReportType.SelectedIndex = 0;
            RadioButtonDaily.Checked = true;
        }

        private void RadioButtonCustom_CheckedChanged(object sender, EventArgs e)
        {
            GroupBoxDate.Enabled = RadioButtonCustom.Checked;
        }

        private void RadioButtonMonthly_CheckedChanged(object sender, EventArgs e)
        {
            if (!RadioButtonMonthly.Checked) return;
            GroupBoxDate.Enabled = false;
            DateTime start = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            DateTime end = start.AddMonths(1);
            SetDateTimePickers(start, end);
        }

        private void RadioButtonWeekly_CheckedChanged(object sender, EventArgs e)
        {
            if (!RadioButtonWeekly.Checked) return;
            GroupBoxDate.Enabled = false;
            int diff = (7 + (int)DateTime.Today.DayOfWeek - (int)DayOfWeek.Monday) % 7;
            DateTime start = DateTime.Today.AddDays(-diff);
            DateTime end = start.AddDays(7);
            SetDateTimePickers(start, end);
        }

        private void RadioButtonDaily_CheckedChanged(object sender, EventArgs e)
        {
            if (!RadioButtonDaily.Checked) return;
            GroupBoxDate.Enabled = false;
            DateTime start = DateTime.Today;
            DateTime end = start.AddDays(1);
            SetDateTimePickers(start, end);
        }

        private void SetDateTimePickers(DateTime start, DateTime end)
        {
            DateTimePickerFirstDate.Value = start;
            DateTimePickerFirstTime.Value = start;
            DateTimePickerLastDate.Value = end;
            DateTimePickerLastTime.Value = end;
        }

        private async void ButtonGenerate_Click(object sender, EventArgs e)
        {
            string? reportType = ComboBoxReportType.SelectedItem?.ToString();
            bool descending = RadioButtonSortByLast.Checked;

            DateTime start;
            DateTime end;

            if (RadioButtonDaily.Checked)
            {
                start = DateTime.Today;
                end = start.AddDays(1);
            }
            else if (RadioButtonWeekly.Checked)
            {
                int diff = (7 + (int)DateTime.Today.DayOfWeek - (int)DayOfWeek.Monday) % 7;
                start = DateTime.Today.AddDays(-diff);
                end = start.AddDays(7);
            }
            else if (RadioButtonMonthly.Checked)
            {
                start = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                end = start.AddMonths(1);
            }
            else
            {
                start = DateTimePickerFirstDate.Value.Date + DateTimePickerFirstTime.Value.TimeOfDay;
                end = DateTimePickerLastDate.Value.Date + DateTimePickerLastTime.Value.TimeOfDay;
            }

            _lastStartDate = start;
            _lastEndDate = end;

            if (reportType == "Log Kayıtları")
            {
                _currentLogs = await _logService.GetAsync(start, end, descending) ?? new List<LogDto>();
                DataGridViewDatas.DataSource = _currentLogs;
                ConfigureLogColumns();
            }
            else if (reportType == "Ölçüm Verileri")
            {
                _currentMeasurements = await _measurementService.GetMeasurementsAsync(start, end, descending);
                DataGridViewDatas.DataSource = _currentMeasurements;
                ConfigureMeasurementColumns();
            }
            else if (reportType == "Eksik Veriler")
            {
                await LoadMissingDatesAsync(start, end);
            }
        }

        private void ButtonSaveAsExcel_Click(object sender, EventArgs e)
        {
            string? reportType = ComboBoxReportType.SelectedItem?.ToString();
            if (reportType == "Log Kayıtları")
            {
                if (_currentLogs.Count == 0)
                    return;

                using SaveFileDialog dialog = new()
                {
                    Filter = "Excel Files|*.xlsx",
                    FileName = GenerateFileName("logs", "xlsx")
                };

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _exportService.ExportLogsToExcel(_currentLogs, dialog.FileName);
                }
            }
            else if (reportType == "Ölçüm Verileri")
            {
                if (_currentMeasurements.Count == 0)
                    return;

                using SaveFileDialog dialog = new()
                {
                    Filter = "Excel Files|*.xlsx",
                    FileName = GenerateFileName("measurements", "xlsx")
                };

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _exportService.ExportMeasurementsToExcel(_currentMeasurements, dialog.FileName);
                }
            }
        }

        private void ButtonSaveAsPdf_Click(object sender, EventArgs e)
        {
            string? reportType = ComboBoxReportType.SelectedItem?.ToString();
            if (reportType != "Log Kayıtları" || _currentLogs.Count == 0)
                return;

            using SaveFileDialog dialog = new()
            {
                Filter = "PDF Files|*.pdf",
                FileName = GenerateFileName("logs", "pdf")
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _exportService.ExportLogsToPdf(_currentLogs, dialog.FileName);
            }
        }

        private string GenerateFileName(string prefix, string extension)
        {
            string start = _lastStartDate.ToString("d");
            string end = _lastEndDate.ToString("d");
            return $"{prefix}_{start}-{end}.{extension}";
        }

        private void ConfigureLogColumns()
        {
            ConfigureColumns(new[]
            {
                new ColumnConfiguration(nameof(LogDto.LoggedAt), "Log Tarihi", DataGridViewAutoSizeColumnMode.AllCells),
                new ColumnConfiguration(nameof(LogDto.Level), "Level", DataGridViewAutoSizeColumnMode.AllCells),
                new ColumnConfiguration(nameof(LogDto.Message), "Mesaj", DataGridViewAutoSizeColumnMode.Fill)
                {
                    FillWeight = 60f
                },
                new ColumnConfiguration(nameof(LogDto.Exception), "Exception", DataGridViewAutoSizeColumnMode.Fill)
                {
                    FillWeight = 40f
                }
            });
        }

        private void ConfigureMeasurementColumns()
        {
            ConfigureColumns(new[]
            {
                new ColumnConfiguration(nameof(ApiDataResultDto.ReadTime), "Tarih", DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader),
                new ColumnConfiguration(nameof(ApiDataResultDto.AKM), "AKM", DataGridViewAutoSizeColumnMode.Fill),
                new ColumnConfiguration(nameof(ApiDataResultDto.Debi), "Debi", DataGridViewAutoSizeColumnMode.Fill),
                new ColumnConfiguration(nameof(ApiDataResultDto.KOi), "KOi", DataGridViewAutoSizeColumnMode.Fill),
                new ColumnConfiguration(nameof(ApiDataResultDto.pH), "pH", DataGridViewAutoSizeColumnMode.Fill),
                new ColumnConfiguration(nameof(ApiDataResultDto.CozunmusOksijen), "Çözünmüş Oksijen", DataGridViewAutoSizeColumnMode.Fill),
                new ColumnConfiguration(nameof(ApiDataResultDto.AkisHizi), "Akış Hızı", DataGridViewAutoSizeColumnMode.Fill),
                new ColumnConfiguration(nameof(ApiDataResultDto.Sicaklik), "Sıcaklık", DataGridViewAutoSizeColumnMode.Fill)
            });
        }

        private void DataGridViewDatas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var row = DataGridViewDatas.Rows[e.RowIndex];
            switch (row.DataBoundItem)
            {
                case LogDto log:
                    if (log.Level == "Warning")
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                    else if (log.Level == "Error")
                        row.DefaultCellStyle.BackColor = Color.Red;
                    else
                        row.DefaultCellStyle.BackColor = Color.White;
                    break;
                case ApiDataResultDto data:
                    int? status = data.AKM_Status ?? data.Debi_Status ?? data.KOi_Status ?? data.pH_Status ??
                                  data.CozunmusOksijen_Status ?? data.AkisHizi_Status ?? data.Sicaklik_Status;
                    if (status == 1)
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    else if (status.HasValue && status.Value != 0)
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                    else
                        row.DefaultCellStyle.BackColor = Color.White;
                    break;
                case MissingDateRow:
                    row.DefaultCellStyle.BackColor = Color.White;
                    break;
                default:
                    row.DefaultCellStyle.BackColor = Color.White;
                    break;
            }
        }

        private async Task LoadMissingDatesAsync(DateTime start, DateTime end)
        {
            var station = await _stationService.GetFirstAsync();
            if (station == null)
            {
                MessageBox.Show("İstasyon bilgisi bulunamadı.", "Eksik Veriler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var response = await _saisApiService.GetMissingDatesAsync(station.StationId);
            if (response == null || !response.result)
            {
                string message = response?.message ?? "Eksik veriler alınırken hata oluştu.";
                MessageBox.Show(message, "Eksik Veriler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dates = response.objects?.MissingDates ?? new List<DateTime>();
            _currentMissingDates = dates
                .Where(date => date >= start && date <= end)
                .OrderBy(date => date)
                .Select(date => new MissingDateRow(date))
                .ToList();

            DataGridViewDatas.DataSource = _currentMissingDates;
            ConfigureMissingDateColumns();
        }

        private void ConfigureMissingDateColumns()
        {
            ConfigureColumns(new[]
            {
                new ColumnConfiguration(nameof(MissingDateRow.MissingDate), "Eksik Veri Zamanı", DataGridViewAutoSizeColumnMode.Fill)
                {
                    Format = "g"
                }
            });
        }

        private sealed class MissingDateRow
        {
            public MissingDateRow(DateTime missingDate)
            {
                MissingDate = missingDate;
            }

            public DateTime MissingDate { get; }
        }

        private void ConfigureColumns(IEnumerable<ColumnConfiguration> configurations)
        {
            DataGridViewDatas.AutoGenerateColumns = false;
            DataGridViewDatas.Columns.Clear();
            DataGridViewDatas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            foreach (var configuration in configurations)
            {
                var column = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = configuration.DataPropertyName,
                    HeaderText = configuration.HeaderText,
                    AutoSizeMode = configuration.AutoSizeMode
                };

                if (!string.IsNullOrWhiteSpace(configuration.Format))
                {
                    column.DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Format = configuration.Format
                    };
                }

                if (configuration.FillWeight.HasValue)
                {
                    column.FillWeight = configuration.FillWeight.Value;
                }

                DataGridViewDatas.Columns.Add(column);
            }
        }

        private sealed class ColumnConfiguration
        {
            public ColumnConfiguration(string dataPropertyName, string headerText, DataGridViewAutoSizeColumnMode autoSizeMode)
            {
                DataPropertyName = dataPropertyName;
                HeaderText = headerText;
                AutoSizeMode = autoSizeMode;
            }

            public string DataPropertyName { get; }
            public string HeaderText { get; }
            public DataGridViewAutoSizeColumnMode AutoSizeMode { get; }
            public float? FillWeight { get; init; }
            public string? Format { get; init; }
        }
    }
}
