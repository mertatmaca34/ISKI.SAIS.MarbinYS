using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinUI.Helpers;
using WinUI.Services;
using WinUI.Models;
using Microsoft.Extensions.DependencyInjection;

namespace WinUI.Pages.Settings
{
    public partial class StationSettingsPage : UserControl
    {
        private readonly IStationService _stationService;

        public StationSettingsPage()
        {
            InitializeComponent();
            _stationService = Program.Services.GetRequiredService<IStationService>();
        }

        private void StationInfoTextChanged(object sender, EventArgs e)
        {

        }

        private async void SaveStationSettingsButton_Click(object? sender, EventArgs e)
        {
            if (!Guid.TryParse(StationIdSettingTextBox.Text, out var stationId))
            {
                MessageBox.Show("Geçersiz istasyon Id", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var command = new CreateStationCommand(StationNameTextBox.Text, stationId);
            var result = await _stationService.CreateAsync(command);
            if (result != null)
            {
                MessageBox.Show($"İstasyon '{result.StationName}' kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}