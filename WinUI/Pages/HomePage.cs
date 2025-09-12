using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json.Nodes;
using System.Windows.Forms;
using Serilog;
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
        private readonly List<ChannelControl> _channels;
        private readonly List<DigitalSensorControl> _digitalSensors;
        private DateTime? _connectedSince;

        public HomePage(IPlcDataService plcService)
        {
            InitializeComponent();
            _plcService = plcService;
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
        }

        public Task<PlcDataDto?> ReadPlcDataAsync()
        {
            return _plcService.GetLatestAsync();
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
                if (StationConstants.TicketExpiry != DateTime.MinValue &&
                    DateTime.Now >= StationConstants.TicketExpiry)
                {
                    digitalSensorBar1.DataStateDescription = "HATA";
                    digitalSensorBar1.DataStateDescriptionColor = StateColors.Error;
                    digitalSensorBar1.SystemStateDescription = "KOPUK";
                    digitalSensorBar1.SystemStateDescriptionColor = StateColors.Error;
                    StatusBarControl.ConnectionStatement = "Bağlantı Durumu: Bağlı Değil";
                    StatusBarControl.ConnectionTime = "Bağlantı Zamanı: 00:00:00";
                    _connectedSince = null;
                    Log.Warning("Ticket süresi doldu");
                    return;
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

                DigitalSensorKapi.SensorState = value.Digital.Kapi ? StateColors.Error : StateColors.Ok;
                DigitalSensorDuman.SensorState = value.Digital.Duman ? StateColors.Error : StateColors.Ok;
                DigitalSensorSuBaskini.SensorState = value.Digital.SuBaskini ? StateColors.Error : StateColors.Ok;
                DigitalSensorPompa2Termik.SensorState = value.Digital.Pompa2Termik ? StateColors.Error : StateColors.Ok;
                DigitalSensorPompa1Termik.SensorState = value.Digital.Pompa1Termik ? StateColors.Error : StateColors.Ok;
                DigitalSensorAcilStop.SensorState = value.Digital.AcilStop ? StateColors.Error : StateColors.Ok;
                DigitalSensorTSuPompaTermik.SensorState = value.Digital.TemizSuTermik ? StateColors.Error : StateColors.Ok;
                DigitalSensorYikamaTanki.SensorState = value.Digital.YikamaTanki ? StateColors.Error : StateColors.Ok;
                DigitalSensorEnerji.SensorState = value.Digital.Enerji ? StateColors.Error : StateColors.Ok;
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
                digitalSensorBar1.DataStateDescription = "BAĞLI";
                digitalSensorBar1.DataStateDescriptionColor = StateColors.Ok;
                StatusBarControl.ConnectionStatement = "Bağlantı Durumu: Bağlı";

                _connectedSince ??= DateTime.Now;
                var elapsed = DateTime.Now - _connectedSince.Value;
                StatusBarControl.ConnectionTime = $"Bağlantı Zamanı: {elapsed:hh\\:mm\\:ss}";
                Log.Information("PLC verisi okundu");
            }
            catch (InvalidOperationException)
            {
                foreach (var ch in _channels)
                    ch.ChannelStatement = StateColors.Waiting;
                foreach (var sensor in _digitalSensors)
                    sensor.SensorState = StateColors.Waiting;

                digitalSensorBar1.SystemStateDescription = "KURULMADI";
                digitalSensorBar1.SystemStateDescriptionColor = StateColors.Error;
                digitalSensorBar1.SystemStateTitleColor = StateColors.Error;
                digitalSensorBar1.DataStateDescription = "BAĞLI";
                digitalSensorBar1.DataStateDescriptionColor = StateColors.Ok;
                StatusBarControl.ConnectionStatement = "Bağlantı Durumu: Bağlı Değil";
                StatusBarControl.ConnectionTime = "-";
                _connectedSince = null;
                Log.Warning("PLC bilgileri henüz kurulmadı");
            }
            catch (HttpRequestException ex)
            {
                foreach (var ch in _channels)
                    ch.ChannelStatement = _connectedSince.HasValue ? StateColors.Error : StateColors.Waiting;
                foreach (var sensor in _digitalSensors)
                    sensor.SensorState = _connectedSince.HasValue ? StateColors.Error : StateColors.Waiting;

                digitalSensorBar1.SystemStateDescription = "KOPUK";
                digitalSensorBar1.SystemStateDescriptionColor = StateColors.Error;
                digitalSensorBar1.SystemStateTitleColor = StateColors.Error;
                digitalSensorBar1.DataStateDescription = "HATA";
                digitalSensorBar1.DataStateDescriptionColor = StateColors.Error;
                StatusBarControl.ConnectionStatement = "Bağlantı Durumu: Bağlı Değil";
                StatusBarControl.ConnectionTime = "-";
                _connectedSince = null;
                Log.Error(ex, "API erişim hatası");
            }
            catch (Exception ex)
            {
                foreach (var ch in _channels)
                    ch.ChannelStatement = _connectedSince.HasValue ? StateColors.Error : StateColors.Waiting;
                foreach (var sensor in _digitalSensors)
                    sensor.SensorState = _connectedSince.HasValue ? StateColors.Error : StateColors.Waiting;

                digitalSensorBar1.SystemStateDescription = "KOPUK";
                digitalSensorBar1.SystemStateDescriptionColor = StateColors.Error;
                digitalSensorBar1.SystemStateTitleColor = StateColors.Error;
                digitalSensorBar1.DataStateDescription = "HATA";
                digitalSensorBar1.DataStateDescriptionColor = StateColors.Error;
                StatusBarControl.ConnectionStatement = "Bağlantı Durumu: Bağlı Değil";
                StatusBarControl.ConnectionTime = "-";
                _connectedSince = null;
                Log.Error(ex, "PLC verisi okunamadı");
            }
        }
    }
}
