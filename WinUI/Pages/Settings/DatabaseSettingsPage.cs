using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinUI.Models;
using WinUI.Services;

namespace WinUI.Pages.Settings
{
    public partial class DatabaseSettingsPage : UserControl
    {
        private readonly IDatabaseSearchEngine _searchEngine;
        private readonly IDatabaseSelectionService _selectionService;

        public DatabaseSettingsPage(IDatabaseSearchEngine searchEngine, IDatabaseSelectionService selectionService)
        {
            _searchEngine = searchEngine;
            _selectionService = selectionService;

            InitializeComponent();
            this.Load += DatabaseSettingsPage_Load;
            RefreshDatabaseInfoButton.Click += RefreshDatabaseInfoButton_Click;
            SaveDatabaseButton.Click += SaveDatabaseButton_Click;
        }

        private async void DatabaseSettingsPage_Load(object? sender, EventArgs e)
        {
            await LoadSqlInstancesAsync();

            if (_selectionService.SelectedServer != null)
            {
                int index = ServerAddressComboBox.Items.IndexOf(_selectionService.SelectedServer);
                if (index >= 0)
                {
                    ServerAddressComboBox.SelectedIndex = index;
                }
            }
        }

        private async Task LoadSqlInstancesAsync()
        {
            ServerAddressComboBox.Items.Clear();
            ServerAddressComboBox.Enabled = false;
            ServerAddressComboBox.Items.Add("Veritabanları aranıyor...");

            try
            {
                var servers = await _searchEngine.SearchServersAsync();
                ServerAddressComboBox.Items.Clear();

                foreach (var server in servers)
                {
                    ServerAddressComboBox.Items.Add(server);
                }

                if (ServerAddressComboBox.Items.Count > 0)
                {
                    ServerAddressComboBox.SelectedIndex = 0;
                }
            }
            catch
            {
                // ignore enumerator errors
            }
            finally
            {
                ServerAddressComboBox.Enabled = true;
            }
        }

        private async void ServerAddressComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            await LoadDatabaseInfoAsync();
        }

        private async void RefreshDatabaseInfoButton_Click(object? sender, EventArgs e)
        {
            await LoadDatabaseInfoAsync();
        }

        private async Task LoadDatabaseInfoAsync()
        {
            if (ServerAddressComboBox.SelectedItem == null)
                return;

            string server = ServerAddressComboBox.SelectedItem.ToString()!;

            DatabaseInfo? info = await _searchEngine.GetDatabaseInfoAsync(server);
            if (info != null)
            {
                ConnectedServerTextBox.Text = info.Server;
                DatabaseNameTextBox.Text = info.DatabaseName ?? string.Empty;
                StorageUsageTextBox.Text = info.StorageUsageMb.HasValue ? $"{info.StorageUsageMb} MB" : string.Empty;
            }
            else
            {
                ConnectedServerTextBox.Text = string.Empty;
                DatabaseNameTextBox.Text = string.Empty;
                StorageUsageTextBox.Text = string.Empty;
            }
        }

        private async void SaveDatabaseButton_Click(object? sender, EventArgs e)
        {
            if (ServerAddressComboBox.SelectedItem is string server)
            {
                await _selectionService.SaveSelectedServerAsync(server);
                MessageBox.Show("Veritabanı ayarları kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
