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

            var settings = _selectionService.Settings;
            if (settings != null)
            {
                int index = ServerAddressComboBox.Items.IndexOf(settings.Server);
                if (index >= 0)
                {
                    ServerAddressComboBox.SelectedIndex = index;
                }
                AuthMethodComboBox.SelectedItem = settings.Authentication;
                UsernameTextBox.Text = settings.Username ?? string.Empty;
                PasswordTextBox.Text = settings.Password ?? string.Empty;
                LogLevelComboBox.SelectedItem = settings.LogLevel switch
                {
                    "Warning" => "Uyarı",
                    "Error" => "Hata",
                    _ => "Bilgi"
                };
            }
            else
            {
                AuthMethodComboBox.SelectedIndex = 0;
                LogLevelComboBox.SelectedIndex = 0;
            }

            UpdateAuthFields();
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

        private void AuthMethodComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            UpdateAuthFields();
        }

        private void UpdateAuthFields()
        {
            bool sqlAuth = AuthMethodComboBox.SelectedItem?.ToString() == "SQL Server Authentication";
            UsernameTextBox.Enabled = sqlAuth;
            PasswordTextBox.Enabled = sqlAuth;
        }

        private async void SaveDatabaseButton_Click(object? sender, EventArgs e)
        {
            if (ServerAddressComboBox.SelectedItem is string server)
            {
                var settings = new DatabaseSettings
                {
                    Server = server,
                    Authentication = AuthMethodComboBox.SelectedItem?.ToString() ?? "Windows Authentication",
                    Username = UsernameTextBox.Text,
                    Password = PasswordTextBox.Text,
                    LogLevel = LogLevelComboBox.SelectedItem?.ToString() switch
                    {
                        "Uyarı" => "Warning",
                        "Hata" => "Error",
                        _ => "Information"
                    }
                };
                await _selectionService.SaveDatabaseSettingsAsync(settings);
                MessageBox.Show("Veritabanı ayarları kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
