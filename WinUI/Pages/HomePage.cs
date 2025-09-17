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
        private readonly List<ChannelControl> _channels;
        private readonly List<DigitalSensorControl> _digitalSensors;
        private DateTime? _lastConnectedTime;
        private bool _isConnected;
        private ApiConnectionStatus _apiConnectionStatus = ApiConnectionStatus.Unknown;

        public HomePage(IPlcDataService plcService, IApiEndpointService apiEndpointService, ITicketService ticketService)
        {
            InitializeComponent();
            _plcService = plcService;
            _apiEndpointService = apiEndpointService;
            _ticketService = ticketService;
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
                digitalSensorBar1.SystemStateDescription = "KURULMADI";
                digitalSensorBar1.SystemStateDescriptionColor = StateColors.NotConfigured;
                digitalSensorBar1.SystemStateTitleColor = StateColors.NotConfigured;
                digitalSensorBar1.DataStateDescription = "KURULMADI";
                digitalSensorBar1.DataStateDescriptionColor = StateColors.NotConfigured;
                StatusBarControl.ConnectionStatement = "Bağlantı Durumu: Kurulmadı";
                _isConnected = false;
                Log.Warning(LogMessages.HomePage.PlcConfigurationMissing);
            }
        }

        public Task<PlcDataDto?> ReadPlcDataAsync()
        {
            return _plcService.GetLatestAsync();
        }

        private async Task<ApiConnectionStatus> UpdateSaisConnectionStatusAsync()
        {
            try
            {
                var endpoint = await _apiEndpointService.GetFirstAsync();
                if (endpoint == null)
                {
                    ApplyApiConnectionStatus(ApiConnectionStatus.NotConfigured);
                    return ApiConnectionStatus.NotConfigured;
                }

                try
                {
                    await _ticketService.EnsureTicketAsync();
                }
                catch (HttpRequestException ex)
                {
                    if (_apiConnectionStatus != ApiConnectionStatus.NoAccess)
                    {
                        Log.Warning(ex, "SAIS bileti alınamadı.");
                    }
                    ApplyApiConnectionStatus(ApiConnectionStatus.NoAccess);
                    return ApiConnectionStatus.NoAccess;
                }
                catch (TaskCanceledException ex)
                {
                    if (_apiConnectionStatus != ApiConnectionStatus.NoAccess)
                    {
                        Log.Warning(ex, "SAIS bileti isteği zaman aşımına uğradı.");
                    }
                    ApplyApiConnectionStatus(ApiConnectionStatus.NoAccess);
                    return ApiConnectionStatus.NoAccess;
                }
                catch (Exception ex)
                {
                    if (_apiConnectionStatus != ApiConnectionStatus.NoAccess)
                    {
                        Log.Error(ex, "SAIS bileti alınırken beklenmeyen bir hata oluştu.");
                    }
                    ApplyApiConnectionStatus(ApiConnectionStatus.NoAccess);
                    return ApiConnectionStatus.NoAccess;
                }

                if (_ticketService.HasValidTicket())
                {
                    ApplyApiConnectionStatus(ApiConnectionStatus.Connected);
                    return ApiConnectionStatus.Connected;
                }

                ApplyApiConnectionStatus(ApiConnectionStatus.NoAccess);
                return ApiConnectionStatus.NoAccess;
            }
            catch (HttpRequestException ex)
            {
                if (_apiConnectionStatus != ApiConnectionStatus.NoAccess)
                {
                    Log.Warning(ex, "SAIS API ayarları alınamadı.");
                }
                ApplyApiConnectionStatus(ApiConnectionStatus.NoAccess);
                return ApiConnectionStatus.NoAccess;
            }
            catch (TaskCanceledException ex)
            {
                if (_apiConnectionStatus != ApiConnectionStatus.NoAccess)
                {
                    Log.Warning(ex, "SAIS API ayarları isteği zaman aşımına uğradı.");
                }
                ApplyApiConnectionStatus(ApiConnectionStatus.NoAccess);
                return ApiConnectionStatus.NoAccess;
            }
            catch (Exception ex)
            {
                if (_apiConnectionStatus != ApiConnectionStatus.NoAccess)
                {
                    Log.Error(ex, "SAIS API ayarları alınırken beklenmeyen bir hata oluştu.");
                }
                ApplyApiConnectionStatus(ApiConnectionStatus.NoAccess);
                return ApiConnectionStatus.NoAccess;
            }
        }

        private void ApplyApiConnectionStatus(ApiConnectionStatus status)
        {
            if (_apiConnectionStatus == status)
            {
                return;
            }

            _apiConnectionStatus = status;
            switch (status)
            {
                case ApiConnectionStatus.Connected:
                    digitalSensorBar1.DataStateDescription = "BAĞLI";
                    digitalSensorBar1.DataStateDescriptionColor = StateColors.Ok;
                    Log.Information("SAIS API bağlantısı sağlandı.");
                    break;
                case ApiConnectionStatus.NotConfigured:
                    digitalSensorBar1.DataStateDescription = "KURULMADI";
                    digitalSensorBar1.DataStateDescriptionColor = StateColors.Warning;
                    Log.Warning("SAIS API ayarları bulunamadı.");
                    break;
                default:
                    digitalSensorBar1.DataStateDescription = "ERİŞİM YOK";
                    digitalSensorBar1.DataStateDescriptionColor = StateColors.Error;
                    Log.Warning("SAIS API erişimi sağlanamadı.");
                    break;
            }
        }

        private enum ApiConnectionStatus
        {
            Unknown,
            Connected,
            NoAccess,
            NotConfigured
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

        private async void TimerAssignUI_Tick(object sender, EventArgs e)
        {
            try
            {
                var apiStatus = await UpdateSaisConnectionStatusAsync();

                if (apiStatus != ApiConnectionStatus.Connected)
                {
                    digitalSensorBar1.SystemStateDescription = "KOPUK";
                    digitalSensorBar1.SystemStateDescriptionColor = StateColors.Error;
                    StatusBarControl.ConnectionStatement = "Bağlantı Durumu: Bağlı Değil";
                    _isConnected = false;
                    if (!_ticketService.HasValidTicket())
                    {
                        Log.Warning(LogMessages.HomePage.TicketMissingOrExpired);
                    }
                }
                else
                {
                    digitalSensorBar1.DataStateDescription = "GÖNDERİYOR";
                    digitalSensorBar1.DataStateDescriptionColor = StateColors.Ok;
                }

                var value = await ReadPlcDataAsync();
                if (value == null)
                    return;

                ChannelAkm.InstantData = $"{value.Analog.Akm} mg/l";
                ChannelCozunmusOksijen.InstantData = $"{value.Analog.CozunmusOksijen} mg/l";
                ChannelSicaklik.InstantData = $"{value.Analog.Sicaklik} mg/l";
                ChannelPh.InstantData = $"{value.Analog.Ph} mg/l";
                ChannelIletkenlik.InstantData = $"{value.Analog.Iletkenlik} mg/l";
                ChannelKoi.InstantData = $"{value.Analog.Koi} mg/l";
                ChannelAkisHizi.InstantData = $"{value.Analog.AkisHizi} mg/l";
                ChannelDebi.InstantData = $"{value.Analog.Debi} mg/l";

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

                digitalSensorBar1.SystemStateDescription = "BAĞLI";
                digitalSensorBar1.SystemStateDescriptionColor = StateColors.Ok;
                digitalSensorBar1.SystemStateTitleColor = StateColors.Ok;
                StatusBarControl.ConnectionStatement = "Bağlantı Durumu: Bağlı";

                if (!_isConnected)
                {
                    _lastConnectedTime = DateTime.Now;
                    _isConnected = true;
                }

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

                digitalSensorBar1.SystemStateDescription = "KURULMADI";
                digitalSensorBar1.SystemStateDescriptionColor = StateColors.NotConfigured;
                digitalSensorBar1.SystemStateTitleColor = StateColors.NotConfigured;
                digitalSensorBar1.DataStateDescription = "KURULMADI";
                digitalSensorBar1.DataStateDescriptionColor = StateColors.NotConfigured;

                StatusBarControl.ConnectionStatement = "Bağlantı Durumu: Kurulmadı";
                _isConnected = false;
                Log.Warning(LogMessages.HomePage.PlcInfoNotYetConfigured);
            }
            catch (HttpRequestException ex)
            {
                foreach (var ch in _channels)
                    ch.ChannelStatement = _lastConnectedTime.HasValue ? StateColors.Error : StateColors.Waiting;
                foreach (var sensor in _digitalSensors)
                    sensor.SensorState = _lastConnectedTime.HasValue ? StateColors.Error : StateColors.Waiting;

                digitalSensorBar1.SystemStateDescription = "ERİŞİM YOK";
                digitalSensorBar1.SystemStateDescriptionColor = StateColors.NoAccess;
                digitalSensorBar1.SystemStateTitleColor = StateColors.NoAccess;

                _isConnected = false;
                Log.Error(ex, LogMessages.HomePage.ApiAccessError);
            }
            catch (Exception ex)
            {
                foreach (var ch in _channels)
                    ch.ChannelStatement = _lastConnectedTime.HasValue ? StateColors.Error : StateColors.Waiting;
                foreach (var sensor in _digitalSensors)
                    sensor.SensorState = _lastConnectedTime.HasValue ? StateColors.Error : StateColors.Waiting;

                digitalSensorBar1.SystemStateDescription = "KOPUK";
                digitalSensorBar1.SystemStateDescriptionColor = StateColors.Error;
                digitalSensorBar1.SystemStateTitleColor = StateColors.Error;

                StatusBarControl.ConnectionStatement = "Bağlantı Durumu: Bağlı Değil";
                _isConnected = false;
                Log.Error(ex, LogMessages.HomePage.PlcDataReadFailed);
            }
        }
    }
}
