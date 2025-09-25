using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.Extensions.DependencyInjection;
using WinUI.Models;
using WinUI.Services;
using Timer = System.Windows.Forms.Timer;

namespace WinUI.Pages
{
    public partial class CalibrationPage : UserControl
    {
        private const string CalibrationSeriesName = "Kalibrasyon Değeri";
        private const string ReferenceSeriesName = "Referans Değeri";

        private readonly ISaisApiService _saisApiService;
        private readonly ICalibrationMeasurementService _calibrationMeasurementService;
        private readonly ICalibrationLimitService _calibrationLimitService;
        private readonly IStationService _stationService;
        private readonly IPlcDataService _plcService;

        private CalibrationLimitDto? _phLimit;
        private CalibrationLimitDto? _conductivityLimit;
        private CalibrationLimitDto? _activeLimit;
        private CalibrationRequest? _currentRequest;
        private Timer? _timer;
        private int _elapsed;
        private bool _isZero;
        private bool _zeroSupported;
        private bool _zeroCompleted;
        private bool _spanCompleted;
        private bool _isTickRunning;
        private string _activeParameter = string.Empty;

        public CalibrationPage()
        {
            InitializeComponent();

            _saisApiService = Program.Services.GetRequiredService<ISaisApiService>();
            _calibrationMeasurementService = Program.Services.GetRequiredService<ICalibrationMeasurementService>();
            _calibrationLimitService = Program.Services.GetRequiredService<ICalibrationLimitService>();
            _stationService = Program.Services.GetRequiredService<IStationService>();
            _plcService = Program.Services.GetRequiredService<IPlcDataService>();

            ButtonIletkenlikZero.Visible = false;
            ButtonIletkenlikZero.Enabled = false;

            Load += CalibrationPage_Load;
        }

        private async void CalibrationPage_Load(object? sender, EventArgs e)
        {
            var limits = await _calibrationLimitService.GetListAsync();
            _phLimit = limits?.FirstOrDefault(x => x.Parameter.Equals("pH", StringComparison.OrdinalIgnoreCase));
            _conductivityLimit = limits?.FirstOrDefault(x => x.Parameter.Equals("Iletkenlik", StringComparison.OrdinalIgnoreCase));
        }

        private void ButtonPhZero_Click(object? sender, EventArgs e) => StartCalibration("pH", true, _phLimit);

        private void ButtonPhSpan_Click(object? sender, EventArgs e) => StartCalibration("pH", false, _phLimit);

        private void ButtonIletkenlikZero_Click(object? sender, EventArgs e)
        {
            MessageBox.Show(
                "İletkenlik için ZERO kalibrasyonu devre dışı bırakılmıştır.",
                "Kalibrasyon",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ButtonIletkenlikSpan_Click(object? sender, EventArgs e) => StartCalibration("Iletkenlik", false, _conductivityLimit);

        private async void StartCalibration(string parameter, bool zero, CalibrationLimitDto? limit)
        {
            if (limit == null)
            {
                MessageBox.Show(
                    $"{parameter} kalibrasyon değerleri ayarlardan tanımlanmamış.",
                    "Kalibrasyon",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            StopTimer();

            _activeLimit = limit;
            _zeroSupported = IsZeroSupported(parameter);

            double zeroRef = limit.ZeroRef;
            double spanRef = limit.SpanRef;

            bool isSameParameter = _currentRequest != null &&
                                   _currentRequest.DBColumnName.Equals(parameter, StringComparison.OrdinalIgnoreCase);
            if (!isSameParameter)
            {
                _currentRequest = null;
                _zeroCompleted = !_zeroSupported;
                _spanCompleted = false;
                _activeParameter = string.Empty;
                ResetStatusBars();
            }

            if (zero && !_zeroSupported)
            {
                MessageBox.Show(
                    "İletkenlik için ZERO kalibrasyonu devre dışı bırakılmıştır.",
                    "Kalibrasyon",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            if (!_zeroSupported)
            {
                SetZeroStatusUnavailable();
            }

            if (spanRef < zeroRef && zero && !_spanCompleted)
            {
                MessageBox.Show("Span değeri daha düşük. Lütfen önce span kalibrasyonunu yapın.", "Kalibrasyon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (zeroRef < spanRef && !zero && !_zeroCompleted)
            {
                MessageBox.Show("Zero değeri daha düşük. Lütfen önce zero kalibrasyonunu yapın.", "Kalibrasyon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _activeParameter = parameter;
            _isZero = zero;
            _currentRequest ??= new CalibrationRequest
            {
                CalibrationDate = DateTime.Now,
                DBColumnName = parameter,
                StationId = Guid.Empty
            };

            ConfigureChart();

            PlcDataDto? plcData;
            try
            {
                plcData = await _plcService.GetLatestAsync();
            }
            catch (InvalidOperationException ex) when (ex.Message == "PLC_NOT_CONFIGURED")
            {
                MessageBox.Show("PLC konfigüre edilmemiş.", "Kalibrasyon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"PLC verileri alınırken hata oluştu: {ex.Message}", "Kalibrasyon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (plcData == null)
                return;

            double reference = zero ? limit.ZeroRef : limit.SpanRef;
            double measurement = parameter.Equals("pH", StringComparison.OrdinalIgnoreCase)
                ? plcData.Analog.Ph
                : plcData.Analog.Iletkenlik;
            double diff = measurement - reference;
            double percent = CalculatePercentDifference(reference, diff);

            UpdateChart(reference, measurement, percent);

            if (_isZero)
            {
                CalibrationStatusBarZero.ZeroRef = reference.ToString("F2");
                CalibrationStatusBarZero.ZeroMeas = measurement.ToString("F2");
                CalibrationStatusBarZero.ZeroDiff = diff.ToString("F2");
                CalibrationStatusBarZero.ZeroStd = "0";

                _currentRequest!.ZeroRef = reference;
                _currentRequest.ZeroMeas = measurement;
                _currentRequest.ZeroDiff = diff;
                _currentRequest.ZeroSTD = 0;
            }
            else
            {
                CalibrationStatusBarSpan.SpanRef = reference.ToString("F2");
                CalibrationStatusBarSpan.SpanMeas = measurement.ToString("F2");
                CalibrationStatusBarSpan.SpanDiff = diff.ToString("F2");
                CalibrationStatusBarSpan.SpanStd = "0";

                _currentRequest!.SpanRef = reference;
                _currentRequest.SpanMeas = measurement;
                _currentRequest.SpanDiff = diff;
                _currentRequest.SpanSTD = 0;
            }

            _elapsed = 0;
            UpdateRemainingTimeDisplay();
            UpdateActiveCalibrationTitle();
            StartTimer();
        }

        private async Task TimerTickAsync()
        {
            if (_isTickRunning)
            {
                return;
            }

            _isTickRunning = true;

            try
            {
                _elapsed++;
                UpdateRemainingTimeDisplay();

                if (_activeLimit == null)
                    return;

                PlcDataDto? plcData;
                try
                {
                    plcData = await _plcService.GetLatestAsync();
                }
                catch (InvalidOperationException ex) when (ex.Message == "PLC_NOT_CONFIGURED")
                {
                    StopTimer();
                    MessageBox.Show("PLC konfigüre edilmemiş.", "Kalibrasyon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                catch (Exception ex)
                {
                    StopTimer();
                    MessageBox.Show($"PLC verileri alınırken hata oluştu: {ex.Message}", "Kalibrasyon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (plcData == null)
                    return;

                double reference = _isZero ? _activeLimit.ZeroRef : _activeLimit.SpanRef;
                double measurement = _activeParameter.Equals("pH", StringComparison.OrdinalIgnoreCase)
                    ? plcData.Analog.Ph
                    : plcData.Analog.Iletkenlik;
                double diff = measurement - reference;
                double percent = CalculatePercentDifference(reference, diff);

                UpdateChart(reference, measurement, percent);

                if (_isZero)
                {
                    CalibrationStatusBarZero.ZeroRef = reference.ToString("F2");
                    CalibrationStatusBarZero.ZeroMeas = measurement.ToString("F2");
                    CalibrationStatusBarZero.ZeroDiff = diff.ToString("F2");
                    CalibrationStatusBarZero.ZeroStd = "0";

                    _currentRequest!.ZeroRef = reference;
                    _currentRequest.ZeroMeas = measurement;
                    _currentRequest.ZeroDiff = diff;
                    _currentRequest.ZeroSTD = 0;
                }
                else
                {
                    CalibrationStatusBarSpan.SpanRef = reference.ToString("F2");
                    CalibrationStatusBarSpan.SpanMeas = measurement.ToString("F2");
                    CalibrationStatusBarSpan.SpanDiff = diff.ToString("F2");
                    CalibrationStatusBarSpan.SpanStd = "0";

                    _currentRequest!.SpanRef = reference;
                    _currentRequest.SpanMeas = measurement;
                    _currentRequest.SpanDiff = diff;
                    _currentRequest.SpanSTD = 0;
                }

                int target = _isZero ? _activeLimit.ZeroTimeStamp : _activeLimit.SpanTimeStamp;
                if (_elapsed >= target)
                {
                    StopTimer();
                    if (_isZero)
                    {
                        _zeroCompleted = true;
                        if (!_spanCompleted)
                        {
                            if (ShouldWaitForManualPhaseStart(_currentRequest?.DBColumnName))
                            {
                                PauseCalibrationForNextPhase(_currentRequest?.DBColumnName, false);
                                return;
                            }

                            StartCalibration(_currentRequest?.DBColumnName ?? _activeParameter, false, _activeLimit);
                        }
                        else
                        {
                            FinishCalibration();
                        }
                    }
                    else
                    {
                        _spanCompleted = true;
                        if (_zeroSupported && !_zeroCompleted)
                        {
                            if (ShouldWaitForManualPhaseStart(_currentRequest?.DBColumnName))
                            {
                                PauseCalibrationForNextPhase(_currentRequest?.DBColumnName, true);
                                return;
                            }

                            StartCalibration(_currentRequest?.DBColumnName ?? _activeParameter, true, _activeLimit);
                        }
                        else
                        {
                            FinishCalibration();
                        }
                    }
                }
            }
            finally
            {
                _isTickRunning = false;
            }
        }

        private async void FinishCalibration()
        {
            if (_currentRequest == null)
                return;

            StopTimer();

            var request = _currentRequest;

            request.ResultFactor = request.SpanMeas == 0
                ? 0
                : request.SpanRef / request.SpanMeas;

            request.ResultZero = !_zeroSupported || request.ZeroRef == 0
                ? true
                : CalculatePercentDifference(request.ZeroRef, request.ZeroDiff) <= 10;
            request.ResultSpan = request.SpanRef == 0
                ? true
                : CalculatePercentDifference(request.SpanRef, request.SpanDiff) <= 10;

            bool calibrationSuccessful = request.ResultZero && request.ResultSpan;

            var station = await _stationService.GetFirstAsync();
            if (station != null)
            {
                request.StationId = station.StationId;
            }

            var databaseResult = await TrySaveCalibrationMeasurementAsync(new CreateCalibrationMeasurementCommand(
                request.CalibrationDate,
                request.DBColumnName,
                request.ZeroRef,
                request.ZeroMeas,
                request.ZeroDiff,
                request.ZeroSTD,
                request.SpanRef,
                request.SpanMeas,
                request.SpanDiff,
                request.SpanSTD,
                request.ResultFactor,
                calibrationSuccessful));

            var saisResult = await TrySendCalibrationToSaisAsync(request);

            ShowCalibrationSummary(calibrationSuccessful, databaseResult, saisResult);

            ResetCalibrationState();
        }

        private static bool IsZeroSupported(string parameter) => !parameter.Equals("Iletkenlik", StringComparison.OrdinalIgnoreCase);

        private void ResetStatusBars()
        {
            CalibrationStatusBarZero.ZeroRef = "-";
            CalibrationStatusBarZero.ZeroMeas = "-";
            CalibrationStatusBarZero.ZeroDiff = "-";
            CalibrationStatusBarZero.ZeroStd = "-";

            CalibrationStatusBarSpan.SpanRef = "-";
            CalibrationStatusBarSpan.SpanMeas = "-";
            CalibrationStatusBarSpan.SpanDiff = "-";
            CalibrationStatusBarSpan.SpanStd = "-";
        }

        private void SetZeroStatusUnavailable()
        {
            CalibrationStatusBarZero.ZeroRef = "Desteklenmiyor";
            CalibrationStatusBarZero.ZeroMeas = "Desteklenmiyor";
            CalibrationStatusBarZero.ZeroDiff = "Desteklenmiyor";
            CalibrationStatusBarZero.ZeroStd = "Desteklenmiyor";
        }

        private void ConfigureChart()
        {
            ChartCalibration.Series.Clear();

            ChartCalibration.Series.Add(new Series(CalibrationSeriesName)
            {
                ChartArea = "ChartArea1",
                Legend = "Legend1",
                ChartType = SeriesChartType.Spline,
                BorderWidth = 2,
                Color = Color.Lime,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 6,
                XValueType = ChartValueType.DateTime,
                YValueType = ChartValueType.Double
            });

            ChartCalibration.Series.Add(new Series(ReferenceSeriesName)
            {
                ChartArea = "ChartArea1",
                Legend = "Legend1",
                ChartType = SeriesChartType.Spline,
                BorderWidth = 2,
                Color = Color.Blue,
                XValueType = ChartValueType.DateTime,
                YValueType = ChartValueType.Double
            });

            ChartCalibration.Invalidate();
        }

        private void UpdateChart(double reference, double measurement, double percent)
        {
            if (ChartCalibration.Series.IndexOf(CalibrationSeriesName) >= 0)
            {
                ChartCalibration.Series[CalibrationSeriesName].Color = percent <= 10 ? Color.Green : Color.Red;
            }

            var timestamp = DateTime.Now;
            AddPoint(CalibrationSeriesName, timestamp, measurement);
            AddPoint(ReferenceSeriesName, timestamp, reference);
            ChartCalibration.Invalidate();
        }

        private void AddPoint(string seriesName, DateTime timestamp, double value)
        {
            if (ChartCalibration.Series.IndexOf(seriesName) < 0)
                return;

            ChartCalibration.Series[seriesName].Points.AddXY(timestamp, value);
        }

        private static double CalculatePercentDifference(double reference, double diff)
        {
            if (Math.Abs(reference) < double.Epsilon)
            {
                return 0;
            }

            return Math.Abs(diff) / Math.Abs(reference) * 100.0;
        }

        private void StartTimer()
        {
            StopTimer();
            _timer = new Timer { Interval = 1000 };
            _timer.Tick += TimerOnTick;
            _timer.Start();
        }

        private void StopTimer()
        {
            if (_timer == null)
                return;

            _timer.Tick -= TimerOnTick;
            _timer.Stop();
            _timer.Dispose();
            _timer = null;
        }

        private void TimerOnTick(object? sender, EventArgs e) => _ = TimerTickAsync();

        private void UpdateRemainingTimeDisplay()
        {
            if (_activeLimit == null)
            {
                TitleBarControlTimeRemain.TitleBarText = "Kalan Süre: -";
                return;
            }

            int target = _isZero ? _activeLimit.ZeroTimeStamp : _activeLimit.SpanTimeStamp;
            if (target <= 0)
            {
                TitleBarControlTimeRemain.TitleBarText = "Kalan Süre: -";
                return;
            }

            int remaining = Math.Max(0, target - _elapsed);
            var time = TimeSpan.FromSeconds(remaining);
            TitleBarControlTimeRemain.TitleBarText = $"Kalan Süre: {time:mm\\:ss}";
        }

        private void UpdateActiveCalibrationTitle()
        {
            if (string.IsNullOrWhiteSpace(_activeParameter))
            {
                TitleBarControlActiveCalibration.TitleBarText = "Aktif Kalibrasyon: -";
                return;
            }

            var phase = _isZero ? "ZERO" : "SPAN";
            TitleBarControlActiveCalibration.TitleBarText = $"Aktif Kalibrasyon: {_activeParameter} {phase}";
        }

        private static bool ShouldWaitForManualPhaseStart(string? parameter) =>
            !string.IsNullOrWhiteSpace(parameter) && parameter.Equals("pH", StringComparison.OrdinalIgnoreCase);

        private void PauseCalibrationForNextPhase(string? parameter, bool nextIsZero)
        {
            var parameterName = string.IsNullOrWhiteSpace(parameter) ? "pH" : parameter;
            var completedPhaseName = nextIsZero ? "SPAN" : "ZERO";
            var nextPhaseName = nextIsZero ? "ZERO" : "SPAN";

            TitleBarControlActiveCalibration.TitleBarText = "Aktif Kalibrasyon: -";
            TitleBarControlTimeRemain.TitleBarText = "Kalan Süre: -";

            MessageBox.Show(
                $"{parameterName} kalibrasyonunun {completedPhaseName} aşaması tamamlandı. {nextPhaseName} aşamasını başlatmak için ilgili butona basınız.",
                "Kalibrasyon",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            _activeParameter = string.Empty;
        }

        private async Task<OperationResult> TrySaveCalibrationMeasurementAsync(CreateCalibrationMeasurementCommand command)
        {
            try
            {
                var response = await _calibrationMeasurementService.CreateAsync(command);
                return response != null
                    ? new OperationResult(true, "Kalibrasyon verileri veritabanına kaydedildi.")
                    : new OperationResult(false, "Veritabanından geçerli bir yanıt alınamadı.");
            }
            catch (Exception ex)
            {
                return new OperationResult(false, ex.Message);
            }
        }

        private async Task<OperationResult> TrySendCalibrationToSaisAsync(CalibrationRequest request)
        {
            try
            {
                var response = await _saisApiService.SendCalibrationAsync(request);
                if (response == null)
                {
                    return new OperationResult(false, "SAİS servisi yanıt vermedi.");
                }

                var message = string.IsNullOrWhiteSpace(response.message)
                    ? string.Empty
                    : response.message;

                return response.result
                    ? new OperationResult(true, message)
                    : new OperationResult(false, message);
            }
            catch (Exception ex)
            {
                return new OperationResult(false, ex.Message);
            }
        }

        private void ShowCalibrationSummary(bool calibrationSuccessful, OperationResult databaseResult, OperationResult saisResult)
        {
            var builder = new StringBuilder();
            builder.AppendLine($"Kalibrasyon Sonucu: {(calibrationSuccessful ? "Başarılı" : "Başarısız")}");
            builder.AppendLine(FormatOperationResult("Veritabanı Kaydı", databaseResult));
            builder.AppendLine(FormatOperationResult("SAİS Gönderimi", saisResult));

            var icon = calibrationSuccessful && databaseResult.IsSuccessful && saisResult.IsSuccessful
                ? MessageBoxIcon.Information
                : MessageBoxIcon.Warning;

            MessageBox.Show(builder.ToString(), "Kalibrasyon", MessageBoxButtons.OK, icon);
        }

        private static string FormatOperationResult(string title, OperationResult result)
        {
            var status = result.IsSuccessful ? "Başarılı" : "Başarısız";
            if (string.IsNullOrWhiteSpace(result.Message))
            {
                return $"{title}: {status}";
            }

            return $"{title}: {status} ({result.Message})";
        }

        private void ResetCalibrationState()
        {
            StopTimer();
            _currentRequest = null;
            _zeroCompleted = false;
            _spanCompleted = false;
            _zeroSupported = false;
            _activeParameter = string.Empty;
            _activeLimit = null;
            ResetStatusBars();
            TitleBarControlActiveCalibration.TitleBarText = "Aktif Kalibrasyon: -";
            TitleBarControlTimeRemain.TitleBarText = "Kalan Süre: -";
            ChartCalibration.Series.Clear();
        }

        private sealed record OperationResult(bool IsSuccessful, string Message);
    }
}
