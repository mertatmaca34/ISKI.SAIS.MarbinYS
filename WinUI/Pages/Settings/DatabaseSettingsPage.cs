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
            var settings = _selectionService.Settings;
            if (settings != null)
            {
                ServerAddressComboBox.Text = settings.Server;
                AuthMethodComboBox.SelectedItem = settings.Authentication;
                UsernameTextBox.Text = settings.Username ?? string.Empty;
                PasswordTextBox.Text = settings.Password ?? string.Empty;
                LogLevelComboBox.SelectedItem = settings.LogLevel switch
                {
                    "Warning" => "Uyarı",
                    "Error" => "Hata",
                    _ => "Bilgi"
                };

                await LoadDatabaseInfoAsync(settings.Server);
            }
            else
            {
                AuthMethodComboBox.SelectedIndex = 0;
                LogLevelComboBox.SelectedIndex = 0;
            }

            UpdateAuthFields();
            await LoadSqlInstancesAsync(settings?.Server);
        }

        private async Task LoadSqlInstancesAsync(string? selectedServer)
        {
            string? currentText = selectedServer ?? ServerAddressComboBox.Text;
            ServerAddressComboBox.Items.Clear();
            if (string.IsNullOrEmpty(currentText))
            {
                ServerAddressComboBox.Items.Add("Veritabanları aranıyor...");
                ServerAddressComboBox.SelectedIndex = 0;
            }
            else
            {
                ServerAddressComboBox.Text = currentText;
            }
            ServerAddressComboBox.Enabled = false;
            SaveDatabaseButton.Enabled = false;
            SaveDatabaseButton.Text = "Lütfen bekleyin";

            try
            {
                var servers = await _searchEngine.SearchServersAsync();
                ServerAddressComboBox.Items.Clear();

                foreach (var server in servers)
                {
                    ServerAddressComboBox.Items.Add(server);
                }

                if (!string.IsNullOrEmpty(currentText))
                {
                    int index = ServerAddressComboBox.Items.IndexOf(currentText);
                    if (index >= 0)
                    {
                        ServerAddressComboBox.SelectedIndex = index;
                    }
                    else
                    {
                        ServerAddressComboBox.Text = currentText;
                    }
                }
            }
            catch
            {
                // ignore enumerator errors
            }
            finally
            {
                ServerAddressComboBox.Enabled = true;
                SaveDatabaseButton.Text = "Kaydet";
                SaveDatabaseButton.Enabled = true;
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

        private async Task LoadDatabaseInfoAsync(string? server = null)
        {
            server ??= ServerAddressComboBox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(server))
                return;

            DatabaseInfo? info = await _searchEngine.GetDatabaseInfoAsync(server);
            if (info != null)
            {
                ConnectedServerTextBox.Text = info.Server;
                DatabaseNameTextBox.Text = info.DatabaseName ?? string.Empty;
                StorageUsageTextBox.Text = FormatStorage(info.StorageUsedMb, info.StorageAllocatedMb);
            }
            else
            {
                ConnectedServerTextBox.Text = string.Empty;
                DatabaseNameTextBox.Text = string.Empty;
                StorageUsageTextBox.Text = string.Empty;
            }
        }

        private static string FormatStorage(long? usedMb, long? allocatedMb)
        {
            if (!usedMb.HasValue && !allocatedMb.HasValue)
                return string.Empty;

            string used = usedMb.HasValue ? FormatSize(usedMb.Value) : "-";
            string allocated = allocatedMb.HasValue ? FormatSize(allocatedMb.Value) : "Sınırsız";
            return $"{used} / {allocated}";
        }

        private static string FormatSize(long valueMb)
        {
            double size = valueMb;
            string suffix = "MB";

            if (size >= 1024)
            {
                size /= 1024;
                suffix = "GB";
            }

            if (size >= 1024)
            {
                size /= 1024;
                suffix = "TB";
            }

            return $"{size:0.##} {suffix}";
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
