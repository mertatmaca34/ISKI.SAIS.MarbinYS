using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinUI.Pages.Settings
{
    public partial class DatabaseSettingsPage : UserControl
    {
        public DatabaseSettingsPage()
        {
            InitializeComponent();
            LoadSqlInstances();
            RefreshDatabaseInfoButton.Click += RefreshDatabaseInfoButton_Click;
        }

        private void LoadSqlInstances()
        {
            try
            {
                DataTable servers = SqlDataSourceEnumerator.Instance.GetDataSources();
                foreach (DataRow row in servers.Rows)
                {
                    string server = row["ServerName"].ToString();
                    string instance = row["InstanceName"].ToString();
                    string fullName = string.IsNullOrEmpty(instance) ? server : $"{server}\\{instance}";
                    ServerAddressComboBox.Items.Add(fullName);
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
        }

        private void ServerAddressComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            LoadDatabaseInfo();
        }

        private void RefreshDatabaseInfoButton_Click(object? sender, EventArgs e)
        {
            LoadDatabaseInfo();
        }

        private void LoadDatabaseInfo()
        {
            if (ServerAddressComboBox.SelectedItem == null)
                return;

            string server = ServerAddressComboBox.SelectedItem.ToString()!;

            try
            {
                using SqlConnection connection = new($"Server={server};Integrated Security=true;");
                connection.Open();
                ConnectedServerTextBox.Text = server;

                using SqlCommand command = new("SELECT DB_NAME(); SELECT SUM(size)*8/1024 FROM sys.database_files", connection);
                using SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    DatabaseNameTextBox.Text = reader.GetString(0);
                }

                if (reader.NextResult() && reader.Read())
                {
                    StorageUsageTextBox.Text = reader.GetInt32(0) + " MB";
                }
            }
            catch
            {
                ConnectedServerTextBox.Text = string.Empty;
                DatabaseNameTextBox.Text = string.Empty;
                StorageUsageTextBox.Text = string.Empty;
            }
        }
    }
}
