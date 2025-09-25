using Serilog;
using System.Text.Json.Nodes;
using WinUI.Constants;
using WinUI.Controls.IBKS;
using WinUI.Helpers;
using WinUI.Models;
using WinUI.Services;

namespace WinUI.Pages
{
    public partial class HomePage : UserControl
    {
        private readonly IPlcDataService _plcService;
        private readonly IApiEndpointService _apiEndpointService;
        private readonly ITicketService _ticketService;
        private readonly IConnectionStatusService _connectionStatusService;
        private readonly List<ChannelControl> _channels;
        private readonly List<DigitalSensorControl> _digitalSensors;
        private DateTime? _lastConnectedTime;
        private ConnectionState _currentApiState = ConnectionState.Unknown;
        private ConnectionState _currentPlcState = ConnectionState.Unknown;

        public HomePage(IPlcDataService plcService, IApiEndpointService apiEndpointService, ITicketService ticketService, IConnectionStatusService connectionStatusService)
        {
            InitializeComponent();
            _plcService = plcService;
            _apiEndpointService = apiEndpointService;
            _ticketService = ticketService;
            _connectionStatusService = connectionStatusService;
            _channels = new()
            {
                ChannelAkm,
                ChannelCozunmusOksijen,
                ChannelSicaklik,
                ChannelPh,
                ChannelIletkenlik,
                ChannelKoi,
                ChannelAkisHizi,
                ChannelDebi
            };
            _digitalSensors = new()
            {
                DigitalSensorKapi,
                DigitalSensorDuman,
                DigitalSensorSuBaskini,
                DigitalSensorPompa2Termik,
                DigitalSensorPompa1Termik,
                DigitalSensorAcilStop,
                DigitalSensorTSuPompaTermik,
                DigitalSensorYikamaTanki,
                DigitalSensorEnerji
            };

            _connectionStatusService.StatusChanged += ConnectionStatusService_StatusChanged;
            Disposed += HomePage_Disposed;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (IsPlcConfigured())
            {
                TimerAssignUI_Tick(this, EventArgs.Empty);
            }
            else
            {
                ApplyPlcUnavailableState(false);
                digitalSensorBar1.DataStateDescription = "KURULMADI";
                digitalSensorBar1.DataStateDescriptionColor = StateColors.NotConfigured;
                Log.Warning(LogMessages.HomePage.PlcConfigurationMissing);
            }
        }

        public Task<PlcDataDto?> ReadPlcDataAsync()
        {
            return _plcService.GetLatestAsync();
        }

        private static string FormatAverage(double? value, string unit)
        {
            return value.HasValue ? $"{value.Value:0.##}{unit}" : "-";
        }

        private void HomePage_Disposed(object? sender, EventArgs e)
        {
            _connectionStatusService.StatusChanged -= ConnectionStatusService_StatusChanged;
        }

        private void ConnectionStatusService_StatusChanged(object? sender, ConnectionStatusChangedEventArgs e)
        {
            if (IsDisposed)
            {
                return;
            }

            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => ConnectionStatusService_StatusChanged(sender, e)));
                return;
            }

            switch (e.Component)
            {
                case ConnectionComponent.SaisApi:
                    UpdateApiStatus(e.State);
                    break;
                case ConnectionComponent.Plc:
                    UpdatePlcStatus(e.State);
                    break;
            }
        }

        private void UpdateApiStatus(ConnectionState state)
        {
            if (_currentApiState == state)
            {
                return;
            }

            _currentApiState = state;

            switch (state)
            {
                case ConnectionState.Connected:
                    digitalSensorBar1.DataStateDescription = "BAĞLI";
                    digitalSensorBar1.DataStateDescriptionColor = StateColors.Ok;
                    Log.Information("SAIS API bağlantısı sağlandı.");
                    break;
                case ConnectionState.NotConfigured:
                    digitalSensorBar1.DataStateDescription = "KURULMADI";
                    digitalSensorBar1.DataStateDescriptionColor = StateColors.NotConfigured;
                    Log.Warning("SAIS API ayarları bulunamadı.");
                    break;
                case ConnectionState.NoAccess:
                    digitalSensorBar1.DataStateDescription = "ERİŞİM YOK";
                    digitalSensorBar1.DataStateDescriptionColor = StateColors.Error;
                    Log.Warning("SAIS API erişimi sağlanamadı.");
                    break;
                case ConnectionState.Unreachable:
                    digitalSensorBar1.DataStateDescription = "ERİŞİM YOK";
                    digitalSensorBar1.DataStateDescriptionColor = StateColors.NoAccess;
                    Log.Warning("SAIS API erişimi sağlanamadı.");
                    break;
                default:
                    digitalSensorBar1.DataStateDescription = "BEKLENİYOR";
                    digitalSensorBar1.DataStateDescriptionColor = StateColors.Waiting;
                    break;
            }
        }

        private void UpdatePlcStatus(ConnectionState state)
        {
            if (_currentPlcState == state)
            {
                return;
            }

            _currentPlcState = state;

            switch (state)
            {
                case ConnectionState.Connected:
                    digitalSensorBar1.SystemStateDescription = "BAĞLI";
                    digitalSensorBar1.SystemStateDescriptionColor = StateColors.Ok;
                    StatusBarControl.ConnectionStatement = "Bağlantı Durumu: Bağlı";
                    if (!_lastConnectedTime.HasValue)
                    {
                        _lastConnectedTime = DateTime.Now;
                    }
                    break;
                case ConnectionState.NotConfigured:
                    digitalSensorBar1.SystemStateDescription = "KURULMADI";
                    digitalSensorBar1.SystemStateDescriptionColor = StateColors.NotConfigured;
                    StatusBarControl.ConnectionStatement = "Bağlantı Durumu: Kurulmadı";
                    _lastConnectedTime = null;
                    break;
                case ConnectionState.NoAccess:
                case ConnectionState.Unreachable:
                    digitalSensorBar1.SystemStateDescription = "ERİŞİM YOK";
                    digitalSensorBar1.SystemStateDescriptionColor = StateColors.NoAccess;
                    StatusBarControl.ConnectionStatement = "Bağlantı Durumu: Erişim Yok";
                    _lastConnectedTime = null;
                    break;
                default:
                    digitalSensorBar1.SystemStateDescription = "BEKLENİYOR";
                    digitalSensorBar1.SystemStateDescriptionColor = StateColors.Waiting;
                    StatusBarControl.ConnectionStatement = "Bağlantı Durumu: Bekleniyor";
                    _lastConnectedTime = null;
                    break;
            }
        }

        private async Task<bool> UpdateSaisConnectionStatusAsync()
        {
            try
            {
                var endpoint = await _apiEndpointService.GetFirstAsync();
                if (endpoint == null)
                {
                    if (_currentApiState != ConnectionState.NotConfigured)
                    {
                        Log.Warning("SAIS API ayarları bulunamadı.");
                    }
                    _connectionStatusService.ReportStatus(ConnectionComponent.SaisApi, ConnectionState.NotConfigured);
                    return false;
                }

                try
                {
                    await _ticketService.EnsureTicketAsync();
                }
                catch (HttpRequestException ex)
                {
                    if (_currentApiState != ConnectionState.Unreachable)
                    {
                        Log.Warning(ex, "SAIS bileti alınamadı.");
                    }
                    _connectionStatusService.ReportStatus(ConnectionComponent.SaisApi, ConnectionState.Unreachable, ex.Message);
                    return false;
                }
                catch (TaskCanceledException ex)
                {
                    if (_currentApiState != ConnectionState.Unreachable)
                    {
                        Log.Warning(ex, "SAIS bileti isteği zaman aşımına uğradı.");
                    }
                    _connectionStatusService.ReportStatus(ConnectionComponent.SaisApi, ConnectionState.Unreachable, ex.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    if (_currentApiState != ConnectionState.NoAccess)
                    {
                        Log.Error(ex, "SAIS bileti alınırken beklenmeyen bir hata oluştu.");
                    }
                    _connectionStatusService.ReportStatus(ConnectionComponent.SaisApi, ConnectionState.NoAccess, ex.Message);
                    return false;
                }

                if (_ticketService.HasValidTicket())
                {
                    _connectionStatusService.ReportStatus(ConnectionComponent.SaisApi, ConnectionState.Connected);
                    return true;
                }

                _connectionStatusService.ReportStatus(ConnectionComponent.SaisApi, ConnectionState.NoAccess);
                return false;
            }
            catch (HttpRequestException ex)
            {
                if (_currentApiState != ConnectionState.Unreachable)
                {
                    Log.Warning(ex, "SAIS API ayarları alınamadı.");
                }
                _connectionStatusService.ReportStatus(ConnectionComponent.SaisApi, ConnectionState.Unreachable, ex.Message);
                return false;
            }
            catch (TaskCanceledException ex)
            {
                if (_currentApiState != ConnectionState.Unreachable)
                {
                    Log.Warning(ex, "SAIS API ayarları isteği zaman aşımına uğradı.");
                }
                _connectionStatusService.ReportStatus(ConnectionComponent.SaisApi, ConnectionState.Unreachable, ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                if (_currentApiState != ConnectionState.NoAccess)
                {
                    Log.Error(ex, "SAIS API ayarları alınırken beklenmeyen bir hata oluştu.");
                }
                _connectionStatusService.ReportStatus(ConnectionComponent.SaisApi, ConnectionState.NoAccess, ex.Message);
                return false;
            }
        }

        private static bool IsPlcConfigured()
        {
            try
            {
                var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                    "..", "..", "..", "..", "Api", "appsettings.json");
                if (!File.Exists(path))
                    return false;

                var json = File.ReadAllText(path);
                var node = JsonNode.Parse(json);
                var ip = node?["PlcSettings"]?["IpAddress"]?.GetValue<string>();
                return !string.IsNullOrWhiteSpace(ip);
            }
            catch
            {
                return false;
            }
        }

        private void ApplyPlcUnavailableState(bool hasConfiguration)
        {
            var state = hasConfiguration ? ConnectionState.Unreachable : ConnectionState.NotConfigured;
            _connectionStatusService.ReportStatus(ConnectionComponent.Plc, state);
        }

        private async void TimerAssignUI_Tick(object sender, EventArgs e)
        {
            var hasPlcConfiguration = IsPlcConfigured();
            try
            {
                var apiConnected = await UpdateSaisConnectionStatusAsync();

                if (!apiConnected)
                {
                    foreach (var ch in _channels)
                        ch.ChannelStatement = _lastConnectedTime.HasValue ? StateColors.Error : StateColors.Waiting;
                    foreach (var sensor in _digitalSensors)
                        sensor.SensorState = _lastConnectedTime.HasValue ? StateColors.Error : StateColors.Waiting;

                    ApplyPlcUnavailableState(hasPlcConfiguration);

                    if (!_ticketService.HasValidTicket())
                    {
                        Log.Warning(LogMessages.HomePage.TicketMissingOrExpired);
                    }

                    if (_currentApiState == ConnectionState.Connected)
                    {
                        digitalSensorBar1.DataStateDescription = "ERİŞİM YOK";
                        digitalSensorBar1.DataStateDescriptionColor = StateColors.NoAccess;
                    }

                    return;
                }

                digitalSensorBar1.DataStateDescription = "GÖNDERİYOR";
                digitalSensorBar1.DataStateDescriptionColor = StateColors.Ok;

                var value = await ReadPlcDataAsync();
                if (value == null)
                    return;

                var averages = value.AnalogHourlyAverage ?? new AnalogSensorAverageDto();

                ChannelAkm.InstantData = $"{value.Analog.Akm} mg/l";
                ChannelAkm.AvgDataOf60Min = FormatAverage(averages.Akm, " mg/l");

                ChannelCozunmusOksijen.InstantData = $"{value.Analog.CozunmusOksijen} mg/l";
                ChannelCozunmusOksijen.AvgDataOf60Min = FormatAverage(averages.CozunmusOksijen, " mg/l");

                ChannelSicaklik.InstantData = $"{value.Analog.Sicaklik} mg/l";
                ChannelSicaklik.AvgDataOf60Min = FormatAverage(averages.Sicaklik, " mg/l");

                ChannelPh.InstantData = $"{value.Analog.Ph} mg/l";
                ChannelPh.AvgDataOf60Min = FormatAverage(averages.Ph, " mg/l");

                ChannelIletkenlik.InstantData = $"{value.Analog.Iletkenlik} mg/l";
                ChannelIletkenlik.AvgDataOf60Min = FormatAverage(averages.Iletkenlik, " mg/l");

                ChannelKoi.InstantData = $"{value.Analog.Koi} mg/l";
                ChannelKoi.AvgDataOf60Min = FormatAverage(averages.Koi, " mg/l");

                ChannelAkisHizi.InstantData = $"{value.Analog.AkisHizi} mg/l";
                ChannelAkisHizi.AvgDataOf60Min = FormatAverage(averages.AkisHizi, " mg/l");

                ChannelDebi.InstantData = $"{value.Analog.Debi} mg/l";
                ChannelDebi.AvgDataOf60Min = FormatAverage(averages.Debi, " mg/l");

                DigitalSensorKapi.SensorState = value.Digital.KabinKapiAcildi ? StateColors.Error : StateColors.Ok;
                DigitalSensorDuman.SensorState = value.Digital.KabinDuman ? StateColors.Error : StateColors.Ok;
                DigitalSensorSuBaskini.SensorState = value.Digital.KabinSuBaskini ? StateColors.Error : StateColors.Ok;
                DigitalSensorPompa2Termik.SensorState = value.Digital.Pompa2Termik ? StateColors.Error : StateColors.Ok;
                DigitalSensorPompa1Termik.SensorState = value.Digital.Pompa1Termik ? StateColors.Error : StateColors.Ok;
                DigitalSensorAcilStop.SensorState = value.Digital.KabinAcilStopBasili ? StateColors.Error : StateColors.Ok;
                DigitalSensorTSuPompaTermik.SensorState = value.Digital.Pompa3Termik ? StateColors.Error : StateColors.Ok;
                DigitalSensorYikamaTanki.SensorState = value.Digital.TankDolu ? StateColors.Error : StateColors.Ok;
                DigitalSensorEnerji.SensorState = value.Digital.KabinEnerjiYok ? StateColors.Error : StateColors.Ok;
                StatusBarControl.SistemSaati = $"Sistem Saati: {value.TimeParameter.SystemTime:g}";
                StatusBarControl.GunlukYikamaKalan =
                    $"G. Yıkamaya Kalan: {value.TimeParameter.DailyWashHour:D2}:{value.TimeParameter.Minute:D2}:{value.TimeParameter.Second:D2}";
                StatusBarControl.HaftalikYikamaKalan =
                    $"H. Yıkamaya Kalan: {value.TimeParameter.WeeklyWashDay:D2}:{value.TimeParameter.WeeklyWashHour:D2}:{value.TimeParameter.Minute:D2}:{value.TimeParameter.Second:D2}";

                foreach (var ch in _channels)
                    ch.ChannelStatement = StateColors.Ok;

                _connectionStatusService.ReportStatus(ConnectionComponent.Plc, ConnectionState.Connected);

                if (_lastConnectedTime.HasValue)
                {
                    var elapsed = DateTime.Now - _lastConnectedTime.Value;
                    StatusBarControl.ConnectionTime = $"Bağlantı Zamanı: {elapsed:hh\\:mm\\:ss}";
                }

                Log.Information(LogMessages.HomePage.PlcDataRead);
            }
            catch (InvalidOperationException)
            {
                foreach (var ch in _channels)
                    ch.ChannelStatement = StateColors.Waiting;
                foreach (var sensor in _digitalSensors)
                    sensor.SensorState = StateColors.Waiting;

                ApplyPlcUnavailableState(false);
                digitalSensorBar1.DataStateDescription = "KURULMADI";
                digitalSensorBar1.DataStateDescriptionColor = StateColors.NotConfigured;
                Log.Warning(LogMessages.HomePage.PlcInfoNotYetConfigured);
            }
            catch (HttpRequestException ex)
            {
                HandlePlcFailure(hasPlcConfiguration, LogMessages.HomePage.ApiAccessError, ex);
            }
            catch (TaskCanceledException ex)
            {
                HandlePlcFailure(hasPlcConfiguration, LogMessages.HomePage.ApiAccessError, ex);
            }
            catch (Exception ex)
            {
                HandlePlcFailure(hasPlcConfiguration, LogMessages.HomePage.PlcDataReadFailed, ex);
            }
        }

        private void HandlePlcFailure(bool hasPlcConfiguration, string logMessage, Exception exception)
        {
            foreach (var ch in _channels)
                ch.ChannelStatement = _lastConnectedTime.HasValue ? StateColors.Error : StateColors.Waiting;
            foreach (var sensor in _digitalSensors)
                sensor.SensorState = _lastConnectedTime.HasValue ? StateColors.Error : StateColors.Waiting;

            ApplyPlcUnavailableState(hasPlcConfiguration);
            digitalSensorBar1.DataStateDescription = "ERİŞİM YOK";
            digitalSensorBar1.DataStateDescriptionColor = StateColors.NoAccess;
            Log.Error(exception, logMessage);
        }
    }
}
