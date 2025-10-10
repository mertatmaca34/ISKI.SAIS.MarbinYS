using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinUI.Models;
using WinUI.Services;
using WinUI.Services.Exceptions;

namespace WinUI.Pages
{
    public partial class ReportingPage : UserControl
    {
        private readonly ILogService _logService;
        private readonly IReportExportService _exportService;
        private readonly IMeasurementReportService _measurementService;
        private readonly ISaisApiService _saisApiService;
        private readonly IStationService _stationService;
        private readonly ISendDataService _sendDataService;
        private readonly IDigitalSensorDataService _digitalSensorDataService;
        private List<LogDto> _currentLogs = new();
        private List<ApiDataResultDto> _currentMeasurements = new();
        private List<CalibrationRecordDto> _currentCalibrations = new();
        private List<MissingDateRow> _currentMissingDates = new();
        private List<DataValidityReportRow> _currentDataValidityRows = new();
        private DateTime _lastStartDate;
        private DateTime _lastEndDate;
        private static readonly CultureInfo TurkishCulture = CultureInfo.GetCultureInfo("tr-TR");
        private static readonly TimeSpan HourlyWashThreshold = TimeSpan.FromMinutes(440);
        private static readonly TimeSpan WeeklyWashThreshold = TimeSpan.FromDays(8) + TimeSpan.FromHours(6);
        private static readonly TimeSpan CalibrationThreshold = TimeSpan.FromDays(36);
        private const int RepeatWindowSize = 30;
        private const double DuplicateTolerance = 1e-6;

        public ReportingPage(
            ILogService logService,
            IReportExportService exportService,
            IMeasurementReportService measurementService,
            ISaisApiService saisApiService,
            IStationService stationService,
            ISendDataService sendDataService,
            IDigitalSensorDataService digitalSensorDataService)
        {
            _logService = logService;
            _exportService = exportService;
            _measurementService = measurementService;
            _saisApiService = saisApiService;
            _stationService = stationService;
            _sendDataService = sendDataService;
            _digitalSensorDataService = digitalSensorDataService;
            InitializeComponent();
        }

        private void ReportingPage_Load(object sender, EventArgs e)
        {
            ComboBoxReportType.Items.AddRange(new object[]
            {
                "Ölçüm Verileri",
                "Kalibrasyon Verileri",
                "Numune Verileri",
                "Log Kayıtları",
                "Eksik Veriler",
                "Veri Geçerlilik Raporu"
            });
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
            TextBoxReportSummary.Clear();
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

            try
            {
                if (reportType == "Log Kayıtları")
                {
                    _currentLogs = await _logService.GetAsync(start, end, descending);
                    DataGridViewDatas.DataSource = _currentLogs;
                    ConfigureLogColumns();
                }
                else if (reportType == "Ölçüm Verileri")
                {
                    _currentMeasurements = await _measurementService.GetMeasurementsAsync(start, end, descending);
                    DataGridViewDatas.DataSource = _currentMeasurements;
                    ConfigureMeasurementColumns();
                }
                else if (reportType == "Kalibrasyon Verileri")
                {
                    await LoadCalibrationDataAsync(start, end, descending);
                }
                else if (reportType == "Eksik Veriler")
                {
                    await LoadMissingDatesAsync(start, end);
                }
                else if (reportType == "Veri Geçerlilik Raporu")
                {
                    await LoadDataValidityReportAsync(start, end, descending);
                }
            }
            catch (ApiUnavailableException)
            {
                ShowApiUnavailableMessage();
            }
            catch (HttpRequestException)
            {
                ShowApiUnavailableMessage();
            }
            catch (TaskCanceledException ex) when (!ex.CancellationToken.IsCancellationRequested)
            {
                ShowApiUnavailableMessage();
            }
        }

        private void ShowApiUnavailableMessage()
        {
            MessageBox.Show("Sistem local API'ye bağlı değil.", "Raporlama", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void ConfigureDataValidityColumns()
        {
            ConfigureColumns(new[]
            {
                new ColumnConfiguration(nameof(DataValidityReportRow.ReadTime), "Tarih", DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader)
                {
                    Format = "g"
                },
                new ColumnConfiguration(nameof(DataValidityReportRow.AKM), "AKM", DataGridViewAutoSizeColumnMode.AllCells),
                new ColumnConfiguration(nameof(DataValidityReportRow.Debi), "Debi", DataGridViewAutoSizeColumnMode.AllCells),
                new ColumnConfiguration(nameof(DataValidityReportRow.KOi), "KOi", DataGridViewAutoSizeColumnMode.AllCells),
                new ColumnConfiguration(nameof(DataValidityReportRow.PH), "pH", DataGridViewAutoSizeColumnMode.AllCells),
                new ColumnConfiguration(nameof(DataValidityReportRow.Iletkenlik), "İletkenlik", DataGridViewAutoSizeColumnMode.AllCells),
                new ColumnConfiguration(nameof(DataValidityReportRow.AkisHizi), "Akış Hızı", DataGridViewAutoSizeColumnMode.AllCells),
                new ColumnConfiguration(nameof(DataValidityReportRow.StatusDescription), "Durum", DataGridViewAutoSizeColumnMode.Fill)
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
                case CalibrationRecordDto calibration:
                    row.DefaultCellStyle.BackColor = calibration.Result ? Color.LightGreen : Color.LightCoral;
                    break;
                case DataValidityReportRow validity:
                    if (!validity.HasData)
                        row.DefaultCellStyle.BackColor = Color.LightYellow;
                    else
                        row.DefaultCellStyle.BackColor = validity.IsValid ? Color.LightGreen : Color.LightCoral;
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

        private async Task LoadDataValidityReportAsync(DateTime start, DateTime end, bool descending)
        {
            if (end <= start)
            {
                MessageBox.Show("Bitiş tarihi başlangıç tarihinden büyük olmalıdır.", "Veri Geçerlilik Raporu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var station = await _stationService.GetFirstAsync();
            if (station == null)
            {
                MessageBox.Show("İstasyon bilgisi bulunamadı.", "Veri Geçerlilik Raporu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime sendDataFetchStart = start.AddMinutes(-RepeatWindowSize);
            DateTime digitalFetchStart = start.AddDays(-9);
            DateTime calibrationFetchStart = start.AddDays(-60);

            var sendDataRecords = await _sendDataService.GetByRangeAsync(sendDataFetchStart, end);
            var calibrationResponse = await _saisApiService.GetCalibrationAsync(station.StationId, calibrationFetchStart, end);

            if (calibrationResponse == null || !calibrationResponse.result)
            {
                string message = calibrationResponse?.message ?? "Kalibrasyon verileri alınırken hata oluştu.";
                MessageBox.Show(message, "Veri Geçerlilik Raporu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            var calibrationRecords = calibrationResponse?.objects ?? new List<CalibrationRecordDto>();

            var earliestRecords = sendDataRecords
                .Where(record => record.Readtime < end)
                .GroupBy(record => NormalizeToMinute(record.Readtime))
                .ToDictionary(
                    group => group.Key,
                    group => group
                        .OrderBy(x => x.CreatedAt)
                        .ThenBy(x => x.Id)
                        .First());

            var sortedRecords = earliestRecords
                .OrderBy(kvp => kvp.Key)
                .ToList();

            var hourlyWashEvents = ExtractTransitionTimes(sendDataRecords, x => x.Debi_Status == 23);
            var weeklyWashEvents = ExtractTransitionTimes(sendDataRecords, x => x.Debi_Status == 24);

            var validCalibrations = calibrationRecords
                .Where(x => x.Result)
                .OrderBy(x => x.CalibrationDate)
                .ToList();

            var phCalibrations = validCalibrations
                .Where(x => x.DBColumnName == "Ph" || x.DBColumnName == "pH")
                .ToList();
            var conductivityCalibrations = validCalibrations
                .Where(x => x.DBColumnName == "Iletkenlik")
                .ToList();

            var parameterSelectors = new Dictionary<string, Func<SendDataRecord, double>>
            {
                ["AKM"] = x => x.AKM,
                ["KOi"] = x => x.KOi,
                ["pH"] = x => x.pH,
                ["Debi"] = x => x.Debi,
                ["AkisHizi"] = x => x.AkisHizi
            };

            var history = parameterSelectors.ToDictionary(
                selector => selector.Key,
                _ => new Queue<double>());

            int phCalibrationIndex = 0;
            int conductivityCalibrationIndex = 0;
            DateTime? lastPhCalibration = null;
            DateTime? lastConductivityCalibration = null;
            int hourlyWashIndex = 0;
            int weeklyWashIndex = 0;
            DateTime? lastHourlyWash = null;
            DateTime? lastWeeklyWash = null;

            var computationMap = new Dictionary<DateTime, (SendDataRecord Record, bool IsValid, string Description)>();

            foreach (var kvp in sortedRecords)
            {
                DateTime minute = kvp.Key;
                SendDataRecord record = kvp.Value;

                while (phCalibrationIndex < phCalibrations.Count && phCalibrations[phCalibrationIndex].CalibrationDate <= minute)
                {
                    lastPhCalibration = phCalibrations[phCalibrationIndex].CalibrationDate;
                    phCalibrationIndex++;
                }

                while (conductivityCalibrationIndex < conductivityCalibrations.Count && conductivityCalibrations[conductivityCalibrationIndex].CalibrationDate <= minute)
                {
                    lastConductivityCalibration = conductivityCalibrations[conductivityCalibrationIndex].CalibrationDate;
                    conductivityCalibrationIndex++;
                }

                while (hourlyWashIndex < hourlyWashEvents.Count && hourlyWashEvents[hourlyWashIndex] <= minute)
                {
                    lastHourlyWash = hourlyWashEvents[hourlyWashIndex];
                    hourlyWashIndex++;
                }

                while (weeklyWashIndex < weeklyWashEvents.Count && weeklyWashEvents[weeklyWashIndex] <= minute)
                {
                    lastWeeklyWash = weeklyWashEvents[weeklyWashIndex];
                    weeklyWashIndex++;
                }

                foreach (var selector in parameterSelectors)
                {
                    var queue = history[selector.Key];
                    queue.Enqueue(selector.Value(record));
                    if (queue.Count > RepeatWindowSize)
                        queue.Dequeue();
                }

                if (minute < start)
                    continue;

                var reasons = new List<string>();

                if (IsCalibrationInvalid(minute, lastPhCalibration, lastConductivityCalibration))
                    reasons.Add("Geçersiz Kalibrasyon");

                if (IsWashInvalid(minute, lastHourlyWash, HourlyWashThreshold))
                    reasons.Add("Geçersiz Yıkama");

                if (IsWashInvalid(minute, lastWeeklyWash, WeeklyWashThreshold))
                    reasons.Add("Geçersiz Haftalık Yıkama");

                if (HasRepeatedValues(history))
                    reasons.Add("Tekrar Veri");

                bool isValid = reasons.Count == 0;
                string description = isValid ? "Geçerli" : string.Join(", ", reasons);

                computationMap[minute] = (record, isValid, description);
            }

            var rows = new List<DataValidityReportRow>();
            DateTime currentMinute = NormalizeToMinute(start);
            if (currentMinute < start)
                currentMinute = currentMinute.AddMinutes(1);

            int validRowCount = 0;
            int availableCount = 0;

            while (currentMinute < end)
            {
                if (computationMap.TryGetValue(currentMinute, out var computed))
                {
                    var row = new DataValidityReportRow
                    {
                        ReadTime = currentMinute,
                        AKM = computed.Record.AKM,
                        Debi = computed.Record.Debi,
                        KOi = computed.Record.KOi,
                        PH = computed.Record.pH,
                        Iletkenlik = computed.Record.Iletkenlik,
                        AkisHizi = computed.Record.AkisHizi,
                        HasData = true,
                        IsValid = computed.IsValid,
                        StatusDescription = computed.Description
                    };

                    rows.Add(row);
                    availableCount++;
                    if (computed.IsValid)
                        validRowCount++;
                }
                else
                {
                    rows.Add(new DataValidityReportRow
                    {
                        ReadTime = currentMinute,
                        HasData = false,
                        IsValid = false,
                        StatusDescription = "Veri Yok"
                    });
                }

                currentMinute = currentMinute.AddMinutes(1);
            }

            if (descending)
                _currentDataValidityRows = rows.OrderByDescending(x => x.ReadTime).ToList();
            else
                _currentDataValidityRows = rows;

            int expectedCount = rows.Count;
            int invalidRowCount = expectedCount - validRowCount;
            double availabilityPercent = expectedCount == 0 ? 0 : availableCount * 100.0 / expectedCount;
            double validPercent = expectedCount == 0 ? 0 : validRowCount * 100.0 / expectedCount;

            var builder = new StringBuilder();
            builder.AppendLine($"Mevcut Veri Sayısı: {availableCount}/{expectedCount}");
            builder.AppendLine($"Geçerli Veri Sayısı/Toplam Veri Sayısı: {validRowCount}/{expectedCount}");
            builder.AppendLine($"Geçersiz Veri Sayısı/Toplam Veri Sayısı: {invalidRowCount}/{expectedCount}");
            builder.AppendLine($"Veri Yüzdesi: %{FormatPercentage(availabilityPercent)}");
            builder.AppendLine($"Geçerli Veri Yüzdesi: %{FormatPercentage(validPercent)}");
            builder.AppendLine();
            builder.AppendLine("Günlük Özet:");

            var dailyGroups = rows
                .GroupBy(x => x.ReadTime.Date)
                .OrderBy(x => x.Key)
                .ToList();

            int validDayCount = 0;

            foreach (var group in dailyGroups)
            {
                int dayExpected = group.Count();
                int dayAvailable = group.Count(x => x.HasData);
                int dayValid = group.Count(x => x.HasData && x.IsValid);
                double dayAvailabilityPercent = dayExpected == 0 ? 0 : dayAvailable * 100.0 / dayExpected;
                double dayValidPercent = dayExpected == 0 ? 0 : dayValid * 100.0 / dayExpected;
                int requiredValid = (int)Math.Ceiling(dayExpected * 0.8);
                bool dayIsValid = dayValid >= requiredValid;

                if (dayIsValid)
                    validDayCount++;

                var dayReasons = new List<string>();
                if (dayAvailable < dayExpected)
                    dayReasons.Add($"Eksik veri ({dayAvailable}/{dayExpected})");
                if (dayValid < requiredValid)
                    dayReasons.Add($"Geçerli veri yetersiz ({dayValid}/{requiredValid})");

                string reasonText = dayReasons.Count > 0 ? $" - Neden: {string.Join(", ", dayReasons)}" : string.Empty;

                builder.AppendLine(
                    $"{group.Key:dd.MM.yyyy} - {(dayIsValid ? "Geçerli" : "Geçersiz")} - Veri: {dayAvailable}/{dayExpected} (%{FormatPercentage(dayAvailabilityPercent)}) - Geçerli Veri: {dayValid}/{dayExpected} (%{FormatPercentage(dayValidPercent)}){reasonText}");
            }

            builder.AppendLine();
            builder.AppendLine($"Toplam Geçerli Gün Sayısı: {validDayCount}/{dailyGroups.Count}");
            builder.AppendLine($"Toplam Veri Sayısı: {availableCount}/{expectedCount}");
            builder.AppendLine($"Toplam Veri Yüzdesi: %{FormatPercentage(availabilityPercent)}");
            builder.AppendLine($"Toplam Geçerli Veri Yüzdesi: %{FormatPercentage(validPercent)}");

            DataGridViewDatas.DataSource = _currentDataValidityRows;
            ConfigureDataValidityColumns();

            TextBoxReportSummary.Text = builder.ToString();
            TextBoxReportSummary.SelectionStart = 0;
            TextBoxReportSummary.SelectionLength = 0;
        }

        private async Task LoadCalibrationDataAsync(DateTime start, DateTime end, bool descending)
        {
            var station = await _stationService.GetFirstAsync();
            if (station == null)
            {
                MessageBox.Show("İstasyon bilgisi bulunamadı.", "Kalibrasyon Verileri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var response = await _saisApiService.GetCalibrationAsync(station.StationId, start, end);
            if (response == null || !response.result)
            {
                string message = response?.message ?? "Kalibrasyon verileri alınırken hata oluştu.";
                MessageBox.Show(message, "Kalibrasyon Verileri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var calibrations = response.objects ?? new List<CalibrationRecordDto>();
            _currentCalibrations = descending
                ? calibrations.OrderByDescending(x => x.CalibrationDate).ToList()
                : calibrations.OrderBy(x => x.CalibrationDate).ToList();

            DataGridViewDatas.DataSource = _currentCalibrations;
            ConfigureCalibrationColumns();
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

        private void ConfigureCalibrationColumns()
        {
            ConfigureColumns(new[]
            {
                new ColumnConfiguration(nameof(CalibrationRecordDto.CalibrationDate), "Kalibrasyon Tarihi", DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader)
                {
                    Format = "g"
                },
                new ColumnConfiguration(nameof(CalibrationRecordDto.DBColumnName), "Parametre", DataGridViewAutoSizeColumnMode.AllCells),
                new ColumnConfiguration(nameof(CalibrationRecordDto.ZeroRef), "Zero Referans", DataGridViewAutoSizeColumnMode.AllCells),
                new ColumnConfiguration(nameof(CalibrationRecordDto.ZeroMeas), "Zero Ölçüm", DataGridViewAutoSizeColumnMode.AllCells),
                new ColumnConfiguration(nameof(CalibrationRecordDto.ZeroDiff), "Zero Fark", DataGridViewAutoSizeColumnMode.AllCells),
                new ColumnConfiguration(nameof(CalibrationRecordDto.ZeroSTD), "Zero STD", DataGridViewAutoSizeColumnMode.AllCells),
                new ColumnConfiguration(nameof(CalibrationRecordDto.SpanRef), "Span Referans", DataGridViewAutoSizeColumnMode.AllCells),
                new ColumnConfiguration(nameof(CalibrationRecordDto.SpanMeas), "Span Ölçüm", DataGridViewAutoSizeColumnMode.AllCells),
                new ColumnConfiguration(nameof(CalibrationRecordDto.SpanDiff), "Span Fark", DataGridViewAutoSizeColumnMode.AllCells),
                new ColumnConfiguration(nameof(CalibrationRecordDto.SpanSTD), "Span STD", DataGridViewAutoSizeColumnMode.AllCells),
                new ColumnConfiguration(nameof(CalibrationRecordDto.ResultFactor), "Sonuç Faktörü", DataGridViewAutoSizeColumnMode.AllCells),
                new ColumnConfiguration(nameof(CalibrationRecordDto.ResultZero), "Zero Sonucu", DataGridViewAutoSizeColumnMode.AllCells),
                new ColumnConfiguration(nameof(CalibrationRecordDto.ResultSpan), "Span Sonucu", DataGridViewAutoSizeColumnMode.AllCells),
                new ColumnConfiguration(nameof(CalibrationRecordDto.Result), "Kalibrasyon Sonucu", DataGridViewAutoSizeColumnMode.AllCells)
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

        private static DateTime NormalizeToMinute(DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, 0, dateTime.Kind);
        }

        private static List<DateTime> ExtractTransitionTimes(IEnumerable<SendDataRecord> records, Func<SendDataRecord, bool> selector)
        {
            var events = new List<DateTime>();
            bool previousState = false;

            foreach (var record in records)
            {
                bool currentState = selector(record);
                if (currentState && !previousState)
                    events.Add(record.Readtime);
                previousState = currentState;
            }

            return events;
        }

        private static string GetCalibrationParameterKey(string? columnName)
        {
            if (string.IsNullOrWhiteSpace(columnName))
                return string.Empty;

            return columnName switch
            {
                "Ph" => "ph",
                "pH" => "ph",
                "iletkenlik" => "iletkenlik",
                "Iletkenlik" => "iletkenlik",
                "conductivity" => "iletkenlik",
                _ => columnName
            };
        }

        private static bool IsCalibrationInvalid(DateTime current, DateTime? lastPhCalibration, DateTime? lastConductivityCalibration)
        {
            bool IsValidCalibration(DateTime? calibration) =>
                calibration.HasValue && current - calibration.Value <= CalibrationThreshold;

            return !(IsValidCalibration(lastPhCalibration) && IsValidCalibration(lastConductivityCalibration));
        }

        private static bool IsWashInvalid(DateTime current, DateTime? lastWash, TimeSpan threshold)
        {
            if (!lastWash.HasValue)
                return true;

            return current - lastWash.Value > threshold;
        }

        private static bool HasRepeatedValues(Dictionary<string, Queue<double>> history)
        {
            foreach (var queue in history.Values)
            {
                if (queue.Count < RepeatWindowSize)
                    continue;

                double first = queue.Peek();
                if (queue.All(value => Math.Abs(value - first) <= DuplicateTolerance))
                    return true;
            }

            return false;
        }

        private static string FormatPercentage(double value) =>
            value.ToString("F2", TurkishCulture);

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
