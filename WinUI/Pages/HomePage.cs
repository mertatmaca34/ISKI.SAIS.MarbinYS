using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json.Nodes;
using System.Windows.Forms;
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
            return _plcService.ReadAndSaveAsync();
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
    }
}
