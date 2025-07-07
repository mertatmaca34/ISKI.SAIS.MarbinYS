using System;
using System.Collections.Generic;
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

        public Task<PlcDataDto?> ReadPlcDataAsync()
        {
            return _plcService.ReadAndSaveAsync();
        }
    }
}
