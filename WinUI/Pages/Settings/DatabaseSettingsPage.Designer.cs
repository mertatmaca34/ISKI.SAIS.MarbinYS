namespace WinUI.Pages.Settings
{
    partial class DatabaseSettingsPage
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            StationSettingsBgTableLayoutPanel = new TableLayoutPanel();
            StationSettingsContentTableLayoutPanel = new TableLayoutPanel();
            ConnectedServerLabel = new Label();
            ConnectedServerTextBox = new TextBox();
            StorageUsageTextBox = new TextBox();
            DatabaseNameTextBox = new TextBox();
            StorageUsageLabel = new Label();
            DatabaseNameLabel = new Label();
            DatabaseInfoHeaderTableLayoutPanel = new TableLayoutPanel();
            DatabaseInfoLabel = new Label();
            RefreshDatabaseInfoButton = new Button();
            DatabaseSettingsHeaderTableLayoutPanel = new TableLayoutPanel();
            DatabaseSettingsLabel = new Label();
            SaveDatabaseButton = new Button();
            StationInfoBgTableLayoutPanel = new TableLayoutPanel();
            StationInfoContentTableLayoutPanel = new TableLayoutPanel();
            ServerAddressLabel = new Label();
            ServerAddressComboBox = new ComboBox();
            LogLevelLabel = new Label();
            LogLevelComboBox = new ComboBox();
            AuthMethodLabel = new Label();
            AuthMethodComboBox = new ComboBox();
            UsernameLabel = new Label();
            UsernameTextBox = new TextBox();
            PasswordLabel = new Label();
            PasswordTextBox = new TextBox();
            StationSettingsBgTableLayoutPanel.SuspendLayout();
            StationSettingsContentTableLayoutPanel.SuspendLayout();
            DatabaseInfoHeaderTableLayoutPanel.SuspendLayout();
            DatabaseSettingsHeaderTableLayoutPanel.SuspendLayout();
            StationInfoBgTableLayoutPanel.SuspendLayout();
            StationInfoContentTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // StationSettingsBgTableLayoutPanel
            // 
            StationSettingsBgTableLayoutPanel.ColumnCount = 2;
            StationSettingsBgTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            StationSettingsBgTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            StationSettingsBgTableLayoutPanel.Controls.Add(StationSettingsContentTableLayoutPanel, 1, 1);
            StationSettingsBgTableLayoutPanel.Controls.Add(DatabaseInfoHeaderTableLayoutPanel, 1, 0);
            StationSettingsBgTableLayoutPanel.Controls.Add(DatabaseSettingsHeaderTableLayoutPanel, 0, 0);
            StationSettingsBgTableLayoutPanel.Controls.Add(StationInfoBgTableLayoutPanel, 0, 1);
            StationSettingsBgTableLayoutPanel.Dock = DockStyle.Fill;
            StationSettingsBgTableLayoutPanel.Location = new Point(0, 15);
            StationSettingsBgTableLayoutPanel.Name = "StationSettingsBgTableLayoutPanel";
            StationSettingsBgTableLayoutPanel.RowCount = 2;
            StationSettingsBgTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            StationSettingsBgTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            StationSettingsBgTableLayoutPanel.Size = new Size(1094, 503);
            StationSettingsBgTableLayoutPanel.TabIndex = 1;
            // 
            // StationSettingsContentTableLayoutPanel
            // 
            StationSettingsContentTableLayoutPanel.BackColor = Color.White;
            StationSettingsContentTableLayoutPanel.ColumnCount = 2;
            StationSettingsContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.35294F));
            StationSettingsContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.6470566F));
            StationSettingsContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            StationSettingsContentTableLayoutPanel.Controls.Add(ConnectedServerLabel, 0, 0);
            StationSettingsContentTableLayoutPanel.Controls.Add(ConnectedServerTextBox, 1, 0);
            StationSettingsContentTableLayoutPanel.Controls.Add(StorageUsageTextBox, 1, 2);
            StationSettingsContentTableLayoutPanel.Controls.Add(DatabaseNameTextBox, 1, 1);
            StationSettingsContentTableLayoutPanel.Controls.Add(StorageUsageLabel, 0, 2);
            StationSettingsContentTableLayoutPanel.Controls.Add(DatabaseNameLabel, 0, 1);
            StationSettingsContentTableLayoutPanel.Dock = DockStyle.Fill;
            StationSettingsContentTableLayoutPanel.Location = new Point(547, 40);
            StationSettingsContentTableLayoutPanel.Margin = new Padding(0, 0, 5, 0);
            StationSettingsContentTableLayoutPanel.Name = "StationSettingsContentTableLayoutPanel";
            StationSettingsContentTableLayoutPanel.Padding = new Padding(15);
            StationSettingsContentTableLayoutPanel.RowCount = 14;
            StationSettingsContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            StationSettingsContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            StationSettingsContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            StationSettingsContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            StationSettingsContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            StationSettingsContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            StationSettingsContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            StationSettingsContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            StationSettingsContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            StationSettingsContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            StationSettingsContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            StationSettingsContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            StationSettingsContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            StationSettingsContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            StationSettingsContentTableLayoutPanel.Size = new Size(542, 463);
            StationSettingsContentTableLayoutPanel.TabIndex = 6;
            // 
            // ConnectedServerLabel
            // 
            ConnectedServerLabel.Anchor = AnchorStyles.Left;
            ConnectedServerLabel.AutoSize = true;
            ConnectedServerLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ConnectedServerLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ConnectedServerLabel.Location = new Point(18, 22);
            ConnectedServerLabel.Name = "ConnectedServerLabel";
            ConnectedServerLabel.Size = new Size(92, 16);
            ConnectedServerLabel.TabIndex = 1;
            ConnectedServerLabel.Text = "Bağlı Sunucu";
            // 
            // ConnectedServerTextBox
            // 
            ConnectedServerTextBox.Anchor = AnchorStyles.Left;
            ConnectedServerTextBox.Enabled = false;
            ConnectedServerTextBox.Location = new Point(234, 19);
            ConnectedServerTextBox.Name = "ConnectedServerTextBox";
            ConnectedServerTextBox.PlaceholderText = "SQLExpress";
            ConnectedServerTextBox.Size = new Size(288, 23);
            ConnectedServerTextBox.TabIndex = 2;
            // 
            // StorageUsageTextBox
            // 
            StorageUsageTextBox.Anchor = AnchorStyles.Left;
            StorageUsageTextBox.Enabled = false;
            StorageUsageTextBox.Location = new Point(234, 81);
            StorageUsageTextBox.Name = "StorageUsageTextBox";
            StorageUsageTextBox.PlaceholderText = "1.3 GB / 10 GB";
            StorageUsageTextBox.Size = new Size(288, 23);
            StorageUsageTextBox.TabIndex = 2;
            // 
            // DatabaseNameTextBox
            // 
            DatabaseNameTextBox.Anchor = AnchorStyles.Left;
            DatabaseNameTextBox.Enabled = false;
            DatabaseNameTextBox.Location = new Point(234, 50);
            DatabaseNameTextBox.Name = "DatabaseNameTextBox";
            DatabaseNameTextBox.PlaceholderText = "IBKSContext";
            DatabaseNameTextBox.Size = new Size(288, 23);
            DatabaseNameTextBox.TabIndex = 2;
            // 
            // StorageUsageLabel
            // 
            StorageUsageLabel.Anchor = AnchorStyles.Left;
            StorageUsageLabel.AutoSize = true;
            StorageUsageLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            StorageUsageLabel.ForeColor = Color.FromArgb(64, 64, 64);
            StorageUsageLabel.Location = new Point(18, 84);
            StorageUsageLabel.Name = "StorageUsageLabel";
            StorageUsageLabel.Size = new Size(109, 16);
            StorageUsageLabel.TabIndex = 1;
            StorageUsageLabel.Text = "Depolama Alanı";
            // 
            // DatabaseNameLabel
            // 
            DatabaseNameLabel.Anchor = AnchorStyles.Left;
            DatabaseNameLabel.AutoSize = true;
            DatabaseNameLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            DatabaseNameLabel.ForeColor = Color.FromArgb(64, 64, 64);
            DatabaseNameLabel.Location = new Point(18, 53);
            DatabaseNameLabel.Name = "DatabaseNameLabel";
            DatabaseNameLabel.Size = new Size(97, 16);
            DatabaseNameLabel.TabIndex = 1;
            DatabaseNameLabel.Text = "Veritabanı Adı";
            // 
            // DatabaseInfoHeaderTableLayoutPanel
            // 
            DatabaseInfoHeaderTableLayoutPanel.ColumnCount = 2;
            DatabaseInfoHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            DatabaseInfoHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            DatabaseInfoHeaderTableLayoutPanel.Controls.Add(DatabaseInfoLabel, 0, 0);
            DatabaseInfoHeaderTableLayoutPanel.Controls.Add(RefreshDatabaseInfoButton, 1, 0);
            DatabaseInfoHeaderTableLayoutPanel.Dock = DockStyle.Fill;
            DatabaseInfoHeaderTableLayoutPanel.Location = new Point(547, 0);
            DatabaseInfoHeaderTableLayoutPanel.Margin = new Padding(0);
            DatabaseInfoHeaderTableLayoutPanel.Name = "DatabaseInfoHeaderTableLayoutPanel";
            DatabaseInfoHeaderTableLayoutPanel.RowCount = 1;
            DatabaseInfoHeaderTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            DatabaseInfoHeaderTableLayoutPanel.Size = new Size(547, 40);
            DatabaseInfoHeaderTableLayoutPanel.TabIndex = 4;
            // 
            // DatabaseInfoLabel
            // 
            DatabaseInfoLabel.AutoSize = true;
            DatabaseInfoLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            DatabaseInfoLabel.ForeColor = Color.FromArgb(64, 64, 64);
            DatabaseInfoLabel.Location = new Point(3, 0);
            DatabaseInfoLabel.Name = "DatabaseInfoLabel";
            DatabaseInfoLabel.Size = new Size(178, 22);
            DatabaseInfoLabel.TabIndex = 0;
            DatabaseInfoLabel.Text = "Veritabanı Bilgileri";
            // 
            // RefreshDatabaseInfoButton
            // 
            RefreshDatabaseInfoButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RefreshDatabaseInfoButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RefreshDatabaseInfoButton.Location = new Point(452, 3);
            RefreshDatabaseInfoButton.Name = "RefreshDatabaseInfoButton";
            RefreshDatabaseInfoButton.Size = new Size(92, 32);
            RefreshDatabaseInfoButton.TabIndex = 2;
            RefreshDatabaseInfoButton.Text = "Yenile";
            RefreshDatabaseInfoButton.UseVisualStyleBackColor = true;
            RefreshDatabaseInfoButton.Click += RefreshDatabaseInfoButton_Click;
            // 
            // DatabaseSettingsHeaderTableLayoutPanel
            // 
            DatabaseSettingsHeaderTableLayoutPanel.ColumnCount = 2;
            DatabaseSettingsHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            DatabaseSettingsHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            DatabaseSettingsHeaderTableLayoutPanel.Controls.Add(DatabaseSettingsLabel, 0, 0);
            DatabaseSettingsHeaderTableLayoutPanel.Controls.Add(SaveDatabaseButton, 1, 0);
            DatabaseSettingsHeaderTableLayoutPanel.Dock = DockStyle.Fill;
            DatabaseSettingsHeaderTableLayoutPanel.Location = new Point(0, 0);
            DatabaseSettingsHeaderTableLayoutPanel.Margin = new Padding(0);
            DatabaseSettingsHeaderTableLayoutPanel.Name = "DatabaseSettingsHeaderTableLayoutPanel";
            DatabaseSettingsHeaderTableLayoutPanel.RowCount = 1;
            DatabaseSettingsHeaderTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            DatabaseSettingsHeaderTableLayoutPanel.Size = new Size(547, 40);
            DatabaseSettingsHeaderTableLayoutPanel.TabIndex = 3;
            // 
            // DatabaseSettingsLabel
            // 
            DatabaseSettingsLabel.AutoSize = true;
            DatabaseSettingsLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            DatabaseSettingsLabel.ForeColor = Color.FromArgb(64, 64, 64);
            DatabaseSettingsLabel.Location = new Point(3, 0);
            DatabaseSettingsLabel.Name = "DatabaseSettingsLabel";
            DatabaseSettingsLabel.Size = new Size(178, 22);
            DatabaseSettingsLabel.TabIndex = 0;
            DatabaseSettingsLabel.Text = "Veritabanı Ayarları";
            // 
            // SaveDatabaseButton
            // 
            SaveDatabaseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SaveDatabaseButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveDatabaseButton.Location = new Point(452, 3);
            SaveDatabaseButton.Name = "SaveDatabaseButton";
            SaveDatabaseButton.Size = new Size(92, 32);
            SaveDatabaseButton.TabIndex = 2;
            SaveDatabaseButton.Text = "Kaydet";
            SaveDatabaseButton.UseVisualStyleBackColor = true;
            // 
            // StationInfoBgTableLayoutPanel
            // 
            StationInfoBgTableLayoutPanel.BackColor = Color.FromArgb(235, 235, 235);
            StationInfoBgTableLayoutPanel.ColumnCount = 1;
            StationInfoBgTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            StationInfoBgTableLayoutPanel.Controls.Add(StationInfoContentTableLayoutPanel, 0, 0);
            StationInfoBgTableLayoutPanel.Dock = DockStyle.Fill;
            StationInfoBgTableLayoutPanel.Location = new Point(0, 40);
            StationInfoBgTableLayoutPanel.Margin = new Padding(0, 0, 5, 0);
            StationInfoBgTableLayoutPanel.Name = "StationInfoBgTableLayoutPanel";
            StationInfoBgTableLayoutPanel.RowCount = 1;
            StationInfoBgTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            StationInfoBgTableLayoutPanel.Size = new Size(542, 463);
            StationInfoBgTableLayoutPanel.TabIndex = 5;
            // 
            // StationInfoContentTableLayoutPanel
            // 
            StationInfoContentTableLayoutPanel.BackColor = Color.White;
            StationInfoContentTableLayoutPanel.ColumnCount = 2;
            StationInfoContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.35294F));
            StationInfoContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.6470566F));
            StationInfoContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            StationInfoContentTableLayoutPanel.Controls.Add(ServerAddressLabel, 0, 0);
            StationInfoContentTableLayoutPanel.Controls.Add(ServerAddressComboBox, 1, 0);
            StationInfoContentTableLayoutPanel.Controls.Add(LogLevelLabel, 0, 1);
            StationInfoContentTableLayoutPanel.Controls.Add(LogLevelComboBox, 1, 1);
            StationInfoContentTableLayoutPanel.Controls.Add(AuthMethodLabel, 0, 2);
            StationInfoContentTableLayoutPanel.Controls.Add(AuthMethodComboBox, 1, 2);
            StationInfoContentTableLayoutPanel.Controls.Add(UsernameLabel, 0, 3);
            StationInfoContentTableLayoutPanel.Controls.Add(UsernameTextBox, 1, 3);
            StationInfoContentTableLayoutPanel.Controls.Add(PasswordLabel, 0, 4);
            StationInfoContentTableLayoutPanel.Controls.Add(PasswordTextBox, 1, 4);
            StationInfoContentTableLayoutPanel.Dock = DockStyle.Fill;
            StationInfoContentTableLayoutPanel.Location = new Point(1, 1);
            StationInfoContentTableLayoutPanel.Margin = new Padding(1);
            StationInfoContentTableLayoutPanel.Name = "StationInfoContentTableLayoutPanel";
            StationInfoContentTableLayoutPanel.Padding = new Padding(15);
            StationInfoContentTableLayoutPanel.RowCount = 14;
            StationInfoContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            StationInfoContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            StationInfoContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            StationInfoContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            StationInfoContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            StationInfoContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            StationInfoContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            StationInfoContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            StationInfoContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            StationInfoContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            StationInfoContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            StationInfoContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            StationInfoContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            StationInfoContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            StationInfoContentTableLayoutPanel.Size = new Size(540, 461);
            StationInfoContentTableLayoutPanel.TabIndex = 2;
            // 
            // ServerAddressLabel
            // 
            ServerAddressLabel.Anchor = AnchorStyles.Left;
            ServerAddressLabel.AutoSize = true;
            ServerAddressLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ServerAddressLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ServerAddressLabel.Location = new Point(18, 22);
            ServerAddressLabel.Name = "ServerAddressLabel";
            ServerAddressLabel.Size = new Size(99, 16);
            ServerAddressLabel.TabIndex = 1;
            ServerAddressLabel.Text = "Sunucu Adresi";
            // 
            // ServerAddressComboBox
            //
            ServerAddressComboBox.Anchor = AnchorStyles.Left;
            ServerAddressComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ServerAddressComboBox.Location = new Point(234, 19);
            ServerAddressComboBox.Name = "ServerAddressComboBox";
            ServerAddressComboBox.Size = new Size(288, 23);
            ServerAddressComboBox.TabIndex = 2;
            ServerAddressComboBox.SelectedIndexChanged += ServerAddressComboBox_SelectedIndexChanged;
            // 
            // LogLevelLabel
            // 
            LogLevelLabel.Anchor = AnchorStyles.Left;
            LogLevelLabel.AutoSize = true;
            LogLevelLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LogLevelLabel.ForeColor = Color.FromArgb(64, 64, 64);
            LogLevelLabel.Location = new Point(18, 53);
            LogLevelLabel.Name = "LogLevelLabel";
            LogLevelLabel.Size = new Size(88, 16);
            LogLevelLabel.TabIndex = 1;
            LogLevelLabel.Text = "Log Seviyesi";
            // 
            // LogLevelComboBox
            //
            LogLevelComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            LogLevelComboBox.FormattingEnabled = true;
            LogLevelComboBox.Items.AddRange(new object[] { "Bilgi", "Uyarı", "Hata" });
            LogLevelComboBox.Location = new Point(234, 49);
            LogLevelComboBox.Name = "LogLevelComboBox";
            LogLevelComboBox.Size = new Size(288, 23);
            LogLevelComboBox.TabIndex = 3;
            //
            // AuthMethodLabel
            //
            AuthMethodLabel.Anchor = AnchorStyles.Left;
            AuthMethodLabel.AutoSize = true;
            AuthMethodLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            AuthMethodLabel.ForeColor = Color.FromArgb(64, 64, 64);
            AuthMethodLabel.Location = new Point(18, 84);
            AuthMethodLabel.Name = "AuthMethodLabel";
            AuthMethodLabel.Size = new Size(119, 16);
            AuthMethodLabel.TabIndex = 4;
            AuthMethodLabel.Text = "Oturum Açma";
            //
            // AuthMethodComboBox
            //
            AuthMethodComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            AuthMethodComboBox.FormattingEnabled = true;
            AuthMethodComboBox.Items.AddRange(new object[] { "Windows Authentication", "SQL Server Authentication" });
            AuthMethodComboBox.Location = new Point(234, 80);
            AuthMethodComboBox.Name = "AuthMethodComboBox";
            AuthMethodComboBox.Size = new Size(288, 23);
            AuthMethodComboBox.TabIndex = 5;
            AuthMethodComboBox.SelectedIndexChanged += AuthMethodComboBox_SelectedIndexChanged;
            //
            // UsernameLabel
            //
            UsernameLabel.Anchor = AnchorStyles.Left;
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            UsernameLabel.ForeColor = Color.FromArgb(64, 64, 64);
            UsernameLabel.Location = new Point(18, 115);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(86, 16);
            UsernameLabel.TabIndex = 6;
            UsernameLabel.Text = "Kullanıcı Adı";
            //
            // UsernameTextBox
            //
            UsernameTextBox.Enabled = false;
            UsernameTextBox.Location = new Point(234, 112);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(288, 23);
            UsernameTextBox.TabIndex = 7;
            //
            // PasswordLabel
            //
            PasswordLabel.Anchor = AnchorStyles.Left;
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            PasswordLabel.ForeColor = Color.FromArgb(64, 64, 64);
            PasswordLabel.Location = new Point(18, 146);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(44, 16);
            PasswordLabel.TabIndex = 8;
            PasswordLabel.Text = "Şifre";
            //
            // PasswordTextBox
            //
            PasswordTextBox.Enabled = false;
            PasswordTextBox.Location = new Point(234, 143);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(288, 23);
            PasswordTextBox.TabIndex = 9;
            // 
            // DatabaseSettingsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(StationSettingsBgTableLayoutPanel);
            Name = "DatabaseSettingsPage";
            Padding = new Padding(0, 15, 0, 15);
            Size = new Size(1094, 533);
            StationSettingsBgTableLayoutPanel.ResumeLayout(false);
            StationSettingsContentTableLayoutPanel.ResumeLayout(false);
            StationSettingsContentTableLayoutPanel.PerformLayout();
            DatabaseInfoHeaderTableLayoutPanel.ResumeLayout(false);
            DatabaseInfoHeaderTableLayoutPanel.PerformLayout();
            DatabaseSettingsHeaderTableLayoutPanel.ResumeLayout(false);
            DatabaseSettingsHeaderTableLayoutPanel.PerformLayout();
            StationInfoBgTableLayoutPanel.ResumeLayout(false);
            StationInfoContentTableLayoutPanel.ResumeLayout(false);
            StationInfoContentTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel StationSettingsBgTableLayoutPanel;
        private TableLayoutPanel StationSettingsContentTableLayoutPanel;
        private Label ConnectedServerLabel;
        private Label StorageUsageLabel;
        private TextBox ConnectedServerTextBox;
        private TextBox StorageUsageTextBox;
        private TextBox DatabaseNameTextBox;
        private TableLayoutPanel DatabaseInfoHeaderTableLayoutPanel;
        private Label DatabaseInfoLabel;
        private TableLayoutPanel DatabaseSettingsHeaderTableLayoutPanel;
        private Label DatabaseSettingsLabel;
        private Button SaveDatabaseButton;
        private TableLayoutPanel StationInfoBgTableLayoutPanel;
        private Label DatabaseNameLabel;
        private Button RefreshDatabaseInfoButton;
        private TableLayoutPanel StationInfoContentTableLayoutPanel;
        private Label ServerAddressLabel;
        private ComboBox ServerAddressComboBox;
        private Label LogLevelLabel;
        private ComboBox LogLevelComboBox;
        private Label AuthMethodLabel;
        private ComboBox AuthMethodComboBox;
        private Label UsernameLabel;
        private TextBox UsernameTextBox;
        private Label PasswordLabel;
        private TextBox PasswordTextBox;
    }
}
