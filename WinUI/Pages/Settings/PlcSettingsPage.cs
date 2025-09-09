using System;
using System.IO;
using System.Net.NetworkInformation;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Windows.Forms;

namespace WinUI.Pages.Settings
{
    public partial class PlcSettingsPage : UserControl
    {
        private readonly string _apiSettingsPath;

        public PlcSettingsPage()
        {
            InitializeComponent();
            _apiSettingsPath = GetApiSettingsPath();
            LoadIpAddress();
        }

        private static string GetApiSettingsPath()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "..", "Api", "appsettings.json");
            return Path.GetFullPath(path);
        }

        private void LoadIpAddress()
        {
            if (!File.Exists(_apiSettingsPath))
                return;

            try
            {
                var json = File.ReadAllText(_apiSettingsPath);
                var node = JsonNode.Parse(json);
                var ip = node?["PlcSettings"]?["IpAddress"]?.GetValue<string>();
                if (!string.IsNullOrWhiteSpace(ip))
                {
                    textBox1.Text = ip;
                }
            }
            catch
            {
                // ignore parsing errors
            }
        }

        private void SaveButton_Click(object? sender, EventArgs e)
        {
            var ip = textBox1.Text.Trim();
            JsonNode root;

            if (File.Exists(_apiSettingsPath))
            {
                root = JsonNode.Parse(File.ReadAllText(_apiSettingsPath)) ?? new JsonObject();
            }
            else
            {
                root = new JsonObject();
            }

            var plcSettings = root["PlcSettings"] as JsonObject ?? new JsonObject();
            plcSettings["IpAddress"] = ip;
            root["PlcSettings"] = plcSettings;

            File.WriteAllText(_apiSettingsPath, root.ToJsonString(new JsonSerializerOptions { WriteIndented = true }));
            MessageBox.Show("IP adresi kaydedildi.");
        }

        private async void PingButton_Click(object? sender, EventArgs e)
        {
            if (!File.Exists(_apiSettingsPath))
            {
                MessageBox.Show("Lütfen önce bir ip adresi tanımlayın.");
                return;
            }

            string? ip = null;
            try
            {
                var json = File.ReadAllText(_apiSettingsPath);
                var node = JsonNode.Parse(json);
                ip = node?["PlcSettings"]?["IpAddress"]?.GetValue<string>();
            }
            catch
            {
                // ignore parsing errors
            }

            if (string.IsNullOrWhiteSpace(ip))
            {
                MessageBox.Show("Lütfen önce bir ip adresi tanımlayın.");
                return;
            }

            using var ping = new Ping();
            try
            {
                var reply = await ping.SendPingAsync(ip);
                ResponseTextBox.Text = $"Durum: {reply.Status}\r\nZaman: {reply.RoundtripTime}ms";
            }
            catch (Exception ex)
            {
                ResponseTextBox.Text = ex.Message;
            }
        }
    }
}

