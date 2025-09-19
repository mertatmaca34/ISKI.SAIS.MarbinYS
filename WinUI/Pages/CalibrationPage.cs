using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.Extensions.DependencyInjection;
using WinUI.Models;
using WinUI.Services;
using Timer = System.Windows.Forms.Timer;

namespace WinUI.Pages
{
    public partial class CalibrationPage: UserControl
    {
        private readonly ISaisApiService _saisApiService;
        private readonly ICalibrationMeasurementService _calibrationMeasurementService;
        private readonly ICalibrationLimitService _calibrationLimitService;
        private readonly IStationService _stationService;
        private readonly IPlcDataService _plcService;
        private CalibrationLimitDto? _phLimit;
        private CalibrationLimitDto? _conductivityLimit;
        private CalibrationRequest? _currentRequest;
        private Timer? _timer;
        private int _elapsed;
        private bool _isZero;
        private bool _zeroCompleted;
        private bool _spanCompleted;
        private string _activeParameter = string.Empty;

        public CalibrationPage()
        {
            InitializeComponent();

            _saisApiService = Program.Services.GetRequiredService<ISaisApiService>();
            _calibrationMeasurementService = Program.Services.GetRequiredService<ICalibrationMeasurementService>();
            _calibrationLimitService = Program.Services.GetRequiredService<ICalibrationLimitService>();
            _stationService = Program.Services.GetRequiredService<IStationService>();
            _plcService = Program.Services.GetRequiredService<IPlcDataService>();

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
        private void ButtonIletkenlikZero_Click(object? sender, EventArgs e) => StartCalibration("Iletkenlik", true, _conductivityLimit);
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

            double zeroRef = limit.ZeroRef;
            double spanRef = limit.SpanRef;

            bool isSameParameter = _currentRequest != null &&
                                   _currentRequest.DBColumnName.Equals(parameter, StringComparison.OrdinalIgnoreCase);
            if (!isSameParameter)
            {
                _currentRequest = null;
                _zeroCompleted = false;
                _spanCompleted = false;
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

            ChartCalibration.Series.Clear();
            var series = new Series(zero ? "Zero" : "Span") { ChartType = SeriesChartType.Line };
            ChartCalibration.Series.Add(series);

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
            double percent = Math.Abs(diff) / reference * 100.0;

            series.Color = percent <= 10 ? System.Drawing.Color.Green : System.Drawing.Color.Red;
            series.Points.AddY(measurement);

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
            _timer?.Stop();
            _timer = new Timer { Interval = 1000 };
            _timer.Tick += async (s, e) => await TimerTickAsync(limit);
            _timer.Start();
        }

        private async Task TimerTickAsync(CalibrationLimitDto limit)
        {
            _elapsed++;
            PlcDataDto? plcData;
            try
            {
                plcData = await _plcService.GetLatestAsync();
            }
            catch (InvalidOperationException ex) when (ex.Message == "PLC_NOT_CONFIGURED")
            {
                _timer?.Stop();
                MessageBox.Show("PLC konfigüre edilmemiş.", "Kalibrasyon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            catch (Exception ex)
            {
                _timer?.Stop();
                MessageBox.Show($"PLC verileri alınırken hata oluştu: {ex.Message}", "Kalibrasyon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (plcData == null)
                return;

            double reference = _isZero ? limit.ZeroRef : limit.SpanRef;
            double measurement = _activeParameter.Equals("pH", StringComparison.OrdinalIgnoreCase)
                ? plcData.Analog.Ph
                : plcData.Analog.Iletkenlik;
            double diff = measurement - reference;
            double percent = Math.Abs(diff) / reference * 100.0;

            var series = ChartCalibration.Series[0];
            series.Color = percent <= 10 ? System.Drawing.Color.Green : System.Drawing.Color.Red;
            series.Points.AddY(measurement);

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

            if (_elapsed >= (_isZero ? limit.ZeroTimeStamp : limit.SpanTimeStamp))
            {
                _timer!.Stop();
                if (_isZero)
                {
                    _zeroCompleted = true;
                    if (!_spanCompleted)
                        StartCalibration(_activeParameter, false, limit);
                    else
                        FinishCalibration();
                }
                else
                {
                    _spanCompleted = true;
                    if (!_zeroCompleted)
                        StartCalibration(_activeParameter, true, limit);
                    else
                        FinishCalibration();
                }
            }
        }

        private async void FinishCalibration()
        {
            if (_currentRequest == null)
                return;

            _currentRequest.ResultFactor = _currentRequest.SpanMeas == 0 ? 0 : _currentRequest.SpanRef / _currentRequest.SpanMeas;
            _currentRequest.ResultZero = Math.Abs(_currentRequest.ZeroDiff) / _currentRequest.ZeroRef * 100 <= 10;
            _currentRequest.ResultSpan = Math.Abs(_currentRequest.SpanDiff) / _currentRequest.SpanRef * 100 <= 10;

            var station = await _stationService.GetFirstAsync();
            if (station != null)
            {
                _currentRequest.StationId = station.StationId;
            }

            await _saisApiService.SendCalibrationAsync(_currentRequest);
            await _calibrationMeasurementService.CreateAsync(new CreateCalibrationMeasurementCommand(
                _currentRequest.CalibrationDate,
                _currentRequest.DBColumnName,
                _currentRequest.ZeroRef,
                _currentRequest.ZeroMeas,
                _currentRequest.ZeroDiff,
                _currentRequest.ZeroSTD,
                _currentRequest.SpanRef,
                _currentRequest.SpanMeas,
                _currentRequest.SpanDiff,
                _currentRequest.SpanSTD,
                _currentRequest.ResultFactor,
                _currentRequest.ResultZero && _currentRequest.ResultSpan));

            _currentRequest = null;
            _zeroCompleted = false;
            _spanCompleted = false;
            _activeParameter = string.Empty;
        }
    }
}
