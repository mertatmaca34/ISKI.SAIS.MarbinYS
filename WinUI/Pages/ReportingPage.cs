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
                bool descending = RadioButtonSortByLast.Checked;
                _currentLogs = await _logService.GetAsync(start, end, descending) ?? new List<LogDto>();
                DataGridViewDatas.DataSource = _currentLogs;
                ConfigureLogColumns();
            }
            else if (reportType == "Ölçüm Verileri")
            {
                _currentMeasurements = await _measurementService.GetMeasurementsAsync(start, end);
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
            DataGridViewDatas.AutoGenerateColumns = false;
            DataGridViewDatas.Columns.Clear();

            DataGridViewDatas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(LogDto.LoggedAt),
                HeaderText = "Log Tarihi"
            });

            DataGridViewDatas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(LogDto.Level),
                HeaderText = "Level"
            });

            DataGridViewDatas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(LogDto.Message),
                HeaderText = "Mesaj"
            });

            DataGridViewDatas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(LogDto.Exception),
                HeaderText = "Exception"
            });
        }

        private void ConfigureMeasurementColumns()
        {
            DataGridViewDatas.AutoGenerateColumns = false;
            DataGridViewDatas.Columns.Clear();

            DataGridViewDatas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(ApiDataResultDto.ReadTime),
                HeaderText = "Tarih",
            });

            DataGridViewDatas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(ApiDataResultDto.AKM),
                HeaderText = "AKM",
            });

            DataGridViewDatas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(ApiDataResultDto.Debi),
                HeaderText = "Debi",
            });

            DataGridViewDatas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(ApiDataResultDto.KOi),
                HeaderText = "KOi",
            });

            DataGridViewDatas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(ApiDataResultDto.pH),
                HeaderText = "pH",
            });

            DataGridViewDatas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(ApiDataResultDto.CozunmusOksijen),
                HeaderText = "Çözünmüş Oksijen",
            });

            DataGridViewDatas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(ApiDataResultDto.AkisHizi),
                HeaderText = "Akış Hızı",
            });

            DataGridViewDatas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(ApiDataResultDto.Sicaklik),
                HeaderText = "Sıcaklık",
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
                    if (status == 3)
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
            DataGridViewDatas.AutoGenerateColumns = false;
            DataGridViewDatas.Columns.Clear();

            DataGridViewDatas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(MissingDateRow.MissingDate),
                HeaderText = "Eksik Veri Zamanı",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "g" }
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
    }
}
