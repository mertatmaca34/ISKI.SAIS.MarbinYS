using WinUI.Constants;

namespace WinUI.Pages.Settings
{
    partial class StationSettingsPage
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
            StationIdSettingLabel = new Label();
            ConnectionUserLabel = new Label();
            ConnectionPasswordLabel = new Label();
            ConnectionDomainAddressLabel = new Label();
            StationIdSettingTextBox = new TextBox();
            ConnectionPasswordTextBox = new TextBox();
            ConnectionDomainAddressTextBox = new TextBox();
            ConnectionUserTextBox = new TextBox();
            ConnectionPortLabel = new Label();
            ConnectionPortTextBox = new TextBox();
            StationSettingsHeaderTableLayoutPanel = new TableLayoutPanel();
            StationSettingsLabel = new Label();
            SaveStationSettingsButton = new Button();
            StationInfoHeaderTableLayoutPanel = new TableLayoutPanel();
            StationInfoLabel = new Label();
            FetchStationButton = new Button();
            StationInfoBgTableLayoutPanel = new TableLayoutPanel();
            StationInfoContentTableLayoutPanel = new TableLayoutPanel();
            StationIdLabel = new Label();
            CodeLabel = new Label();
            StationNameLabel = new Label();
            DataPeriodLabel = new Label();
            LastDataDateLabel = new Label();
            CabinSoftwareAddressLabel = new Label();
            CabinSoftwarePortLabel = new Label();
            CabinSoftwareUsernameLabel = new Label();
            CabinSoftwarePasswordLabel = new Label();
            OrganizationLabel = new Label();
            StationSetupDateLabel = new Label();
            SoftwareSetupDateLabel = new Label();
            StationAddressLabel = new Label();
            SoftwareLabel = new Label();
            StationIdTextBox = new TextBox();
            StationNameTextBox = new TextBox();
            DataPeriodTextBox = new TextBox();
            LastDataDateTextBox = new TextBox();
            CabinSoftwareAddressTextBox = new TextBox();
            CodeTextBox = new TextBox();
            CabinSoftwarePortTextBox = new TextBox();
            CabinSoftwareUsernameTextBox = new TextBox();
            CabinSoftwarePasswordTextBox = new TextBox();
            OrganizationTextBox = new TextBox();
            StationSetupDateTextBox = new TextBox();
            SoftwareSetupDateTextBox = new TextBox();
            StationAddressTextBox = new TextBox();
            SoftwareTextBox = new TextBox();
            StationSettingsBgTableLayoutPanel.SuspendLayout();
            StationSettingsContentTableLayoutPanel.SuspendLayout();
            StationSettingsHeaderTableLayoutPanel.SuspendLayout();
            StationInfoHeaderTableLayoutPanel.SuspendLayout();
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
            StationSettingsBgTableLayoutPanel.Controls.Add(StationSettingsHeaderTableLayoutPanel, 1, 0);
            StationSettingsBgTableLayoutPanel.Controls.Add(StationInfoHeaderTableLayoutPanel, 0, 0);
            StationSettingsBgTableLayoutPanel.Controls.Add(StationInfoBgTableLayoutPanel, 0, 1);
            StationSettingsBgTableLayoutPanel.Dock = DockStyle.Fill;
            StationSettingsBgTableLayoutPanel.Location = new Point(0, 15);
            StationSettingsBgTableLayoutPanel.Name = "StationSettingsBgTableLayoutPanel";
            StationSettingsBgTableLayoutPanel.RowCount = 2;
            StationSettingsBgTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            StationSettingsBgTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            StationSettingsBgTableLayoutPanel.Size = new Size(1094, 503);
            StationSettingsBgTableLayoutPanel.TabIndex = 0;
            // 
            // StationSettingsContentTableLayoutPanel
            // 
            StationSettingsContentTableLayoutPanel.BackColor = Color.White;
            StationSettingsContentTableLayoutPanel.ColumnCount = 2;
            StationSettingsContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.35294F));
            StationSettingsContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.6470566F));
            StationSettingsContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            StationSettingsContentTableLayoutPanel.Controls.Add(StationIdSettingLabel, 0, 0);
            StationSettingsContentTableLayoutPanel.Controls.Add(ConnectionUserLabel, 0, 1);
            StationSettingsContentTableLayoutPanel.Controls.Add(ConnectionPasswordLabel, 0, 2);
            StationSettingsContentTableLayoutPanel.Controls.Add(ConnectionDomainAddressLabel, 0, 3);
            StationSettingsContentTableLayoutPanel.Controls.Add(StationIdSettingTextBox, 1, 0);
            StationSettingsContentTableLayoutPanel.Controls.Add(ConnectionPasswordTextBox, 1, 2);
            StationSettingsContentTableLayoutPanel.Controls.Add(ConnectionDomainAddressTextBox, 1, 3);
            StationSettingsContentTableLayoutPanel.Controls.Add(ConnectionUserTextBox, 1, 1);
            StationSettingsContentTableLayoutPanel.Controls.Add(ConnectionPortLabel, 0, 4);
            StationSettingsContentTableLayoutPanel.Controls.Add(ConnectionPortTextBox, 1, 4);
            StationSettingsContentTableLayoutPanel.Dock = DockStyle.Fill;
            StationSettingsContentTableLayoutPanel.Location = new Point(548, 41);
            StationSettingsContentTableLayoutPanel.Margin = new Padding(1, 1, 5, 1);
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
            StationSettingsContentTableLayoutPanel.Size = new Size(541, 461);
            StationSettingsContentTableLayoutPanel.TabIndex = 6;
            // 
            // StationIdSettingLabel
            // 
            StationIdSettingLabel.Anchor = AnchorStyles.Left;
            StationIdSettingLabel.AutoSize = true;
            StationIdSettingLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            StationIdSettingLabel.ForeColor = Color.FromArgb(64, 64, 64);
            StationIdSettingLabel.Location = new Point(18, 22);
            StationIdSettingLabel.Name = "StationIdSettingLabel";
            StationIdSettingLabel.Size = new Size(64, 16);
            StationIdSettingLabel.TabIndex = 1;
            StationIdSettingLabel.Text = "StationId";
            // 
            // ConnectionUserLabel
            // 
            ConnectionUserLabel.Anchor = AnchorStyles.Left;
            ConnectionUserLabel.AutoSize = true;
            ConnectionUserLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ConnectionUserLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ConnectionUserLabel.Location = new Point(18, 53);
            ConnectionUserLabel.Name = "ConnectionUserLabel";
            ConnectionUserLabel.Size = new Size(107, 16);
            ConnectionUserLabel.TabIndex = 1;
            ConnectionUserLabel.Text = "ConnectionUser";
            // 
            // ConnectionPasswordLabel
            // 
            ConnectionPasswordLabel.Anchor = AnchorStyles.Left;
            ConnectionPasswordLabel.AutoSize = true;
            ConnectionPasswordLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ConnectionPasswordLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ConnectionPasswordLabel.Location = new Point(18, 84);
            ConnectionPasswordLabel.Name = "ConnectionPasswordLabel";
            ConnectionPasswordLabel.Size = new Size(140, 16);
            ConnectionPasswordLabel.TabIndex = 1;
            ConnectionPasswordLabel.Text = "ConnectionPassword";
            // 
            // ConnectionDomainAddressLabel
            // 
            ConnectionDomainAddressLabel.Anchor = AnchorStyles.Left;
            ConnectionDomainAddressLabel.AutoSize = true;
            ConnectionDomainAddressLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ConnectionDomainAddressLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ConnectionDomainAddressLabel.Location = new Point(18, 115);
            ConnectionDomainAddressLabel.Name = "ConnectionDomainAddressLabel";
            ConnectionDomainAddressLabel.Size = new Size(178, 16);
            ConnectionDomainAddressLabel.TabIndex = 1;
            ConnectionDomainAddressLabel.Text = "ConnectionDomainAddress";
            // 
            // StationIdSettingTextBox
            // 
            StationIdSettingTextBox.Anchor = AnchorStyles.None;
            StationIdSettingTextBox.Location = new Point(234, 19);
            StationIdSettingTextBox.Name = "StationIdSettingTextBox";
            StationIdSettingTextBox.PlaceholderText = StationConstants.StationIdPlaceholder;
            StationIdSettingTextBox.Size = new Size(288, 23);
            StationIdSettingTextBox.TabIndex = 2;
            // 
            // ConnectionPasswordTextBox
            // 
            ConnectionPasswordTextBox.Anchor = AnchorStyles.None;
            ConnectionPasswordTextBox.Location = new Point(234, 81);
            ConnectionPasswordTextBox.Name = "ConnectionPasswordTextBox";
            ConnectionPasswordTextBox.PlaceholderText = "Kabin Yazılımı Kullanıcı Şifresi";
            ConnectionPasswordTextBox.Size = new Size(288, 23);
            ConnectionPasswordTextBox.TabIndex = 2;
            // 
            // ConnectionDomainAddressTextBox
            // 
            ConnectionDomainAddressTextBox.Anchor = AnchorStyles.None;
            ConnectionDomainAddressTextBox.Location = new Point(234, 112);
            ConnectionDomainAddressTextBox.Name = "ConnectionDomainAddressTextBox";
            ConnectionDomainAddressTextBox.PlaceholderText = "Kabin Yazılımı Erişim Host veya IP Numarası";
            ConnectionDomainAddressTextBox.Size = new Size(288, 23);
            ConnectionDomainAddressTextBox.TabIndex = 2;
            // 
            // ConnectionUserTextBox
            // 
            ConnectionUserTextBox.Anchor = AnchorStyles.None;
            ConnectionUserTextBox.Location = new Point(234, 50);
            ConnectionUserTextBox.Name = "ConnectionUserTextBox";
            ConnectionUserTextBox.PlaceholderText = "Kabin Yazılımı Kullanıcı Adı";
            ConnectionUserTextBox.Size = new Size(288, 23);
            ConnectionUserTextBox.TabIndex = 2;
            // 
            // ConnectionPortLabel
            // 
            ConnectionPortLabel.Anchor = AnchorStyles.Left;
            ConnectionPortLabel.AutoSize = true;
            ConnectionPortLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ConnectionPortLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ConnectionPortLabel.Location = new Point(18, 146);
            ConnectionPortLabel.Name = "ConnectionPortLabel";
            ConnectionPortLabel.Size = new Size(105, 16);
            ConnectionPortLabel.TabIndex = 1;
            ConnectionPortLabel.Text = "ConnectionPort";
            // 
            // ConnectionPortTextBox
            // 
            ConnectionPortTextBox.Anchor = AnchorStyles.None;
            ConnectionPortTextBox.Location = new Point(234, 143);
            ConnectionPortTextBox.Name = "ConnectionPortTextBox";
            ConnectionPortTextBox.PlaceholderText = "Kabin Yazılımı Erişim için kullanılan PORT bilgisi";
            ConnectionPortTextBox.Size = new Size(288, 23);
            ConnectionPortTextBox.TabIndex = 2;
            // 
            // StationSettingsHeaderTableLayoutPanel
            // 
            StationSettingsHeaderTableLayoutPanel.ColumnCount = 2;
            StationSettingsHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            StationSettingsHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            StationSettingsHeaderTableLayoutPanel.Controls.Add(StationSettingsLabel, 0, 0);
            StationSettingsHeaderTableLayoutPanel.Controls.Add(SaveStationSettingsButton, 1, 0);
            StationSettingsHeaderTableLayoutPanel.Dock = DockStyle.Fill;
            StationSettingsHeaderTableLayoutPanel.Location = new Point(547, 0);
            StationSettingsHeaderTableLayoutPanel.Margin = new Padding(0);
            StationSettingsHeaderTableLayoutPanel.Name = "StationSettingsHeaderTableLayoutPanel";
            StationSettingsHeaderTableLayoutPanel.RowCount = 1;
            StationSettingsHeaderTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            StationSettingsHeaderTableLayoutPanel.Size = new Size(547, 40);
            StationSettingsHeaderTableLayoutPanel.TabIndex = 4;
            // 
            // StationSettingsLabel
            // 
            StationSettingsLabel.AutoSize = true;
            StationSettingsLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            StationSettingsLabel.ForeColor = Color.FromArgb(64, 64, 64);
            StationSettingsLabel.Location = new Point(3, 0);
            StationSettingsLabel.Name = "StationSettingsLabel";
            StationSettingsLabel.Size = new Size(164, 22);
            StationSettingsLabel.TabIndex = 0;
            StationSettingsLabel.Text = "İstasyon Ayarları";
            // 
            // SaveStationSettingsButton
            // 
            SaveStationSettingsButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SaveStationSettingsButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveStationSettingsButton.Location = new Point(452, 3);
            SaveStationSettingsButton.Name = "SaveStationSettingsButton";
            SaveStationSettingsButton.Size = new Size(92, 32);
            SaveStationSettingsButton.TabIndex = 2;
            SaveStationSettingsButton.Text = "Kaydet";
            SaveStationSettingsButton.UseVisualStyleBackColor = true;
            SaveStationSettingsButton.Click += SaveStationSettingsButton_Click;
            // 
            // StationInfoHeaderTableLayoutPanel
            // 
            StationInfoHeaderTableLayoutPanel.ColumnCount = 2;
            StationInfoHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            StationInfoHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            StationInfoHeaderTableLayoutPanel.Controls.Add(StationInfoLabel, 0, 0);
            StationInfoHeaderTableLayoutPanel.Controls.Add(FetchStationButton, 1, 0);
            StationInfoHeaderTableLayoutPanel.Dock = DockStyle.Fill;
            StationInfoHeaderTableLayoutPanel.Location = new Point(0, 0);
            StationInfoHeaderTableLayoutPanel.Margin = new Padding(0);
            StationInfoHeaderTableLayoutPanel.Name = "StationInfoHeaderTableLayoutPanel";
            StationInfoHeaderTableLayoutPanel.RowCount = 1;
            StationInfoHeaderTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            StationInfoHeaderTableLayoutPanel.Size = new Size(547, 40);
            StationInfoHeaderTableLayoutPanel.TabIndex = 3;
            // 
            // StationInfoLabel
            // 
            StationInfoLabel.AutoSize = true;
            StationInfoLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            StationInfoLabel.ForeColor = Color.FromArgb(64, 64, 64);
            StationInfoLabel.Location = new Point(3, 0);
            StationInfoLabel.Name = "StationInfoLabel";
            StationInfoLabel.Size = new Size(164, 22);
            StationInfoLabel.TabIndex = 0;
            StationInfoLabel.Text = "İstasyon Bilgileri";
            // 
            // FetchStationButton
            // 
            FetchStationButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FetchStationButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FetchStationButton.Location = new Point(452, 3);
            FetchStationButton.Name = "FetchStationButton";
            FetchStationButton.Size = new Size(92, 32);
            FetchStationButton.TabIndex = 2;
            FetchStationButton.Text = "Getir";
            FetchStationButton.UseVisualStyleBackColor = true;
            // 
            // StationInfoBgTableLayoutPanel
            // 
            StationInfoBgTableLayoutPanel.BackColor = Color.FromArgb(235, 235, 235);
            StationInfoBgTableLayoutPanel.ColumnCount = 1;
            StationInfoBgTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            StationInfoBgTableLayoutPanel.Controls.Add(StationInfoContentTableLayoutPanel, 0, 0);
            StationInfoBgTableLayoutPanel.Dock = DockStyle.Fill;
            StationInfoBgTableLayoutPanel.Location = new Point(0, 40);
            StationInfoBgTableLayoutPanel.Margin = new Padding(0);
            StationInfoBgTableLayoutPanel.Name = "StationInfoBgTableLayoutPanel";
            StationInfoBgTableLayoutPanel.Padding = new Padding(0, 0, 5, 0);
            StationInfoBgTableLayoutPanel.RowCount = 1;
            StationInfoBgTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            StationInfoBgTableLayoutPanel.Size = new Size(547, 463);
            StationInfoBgTableLayoutPanel.TabIndex = 5;
            // 
            // StationInfoContentTableLayoutPanel
            // 
            StationInfoContentTableLayoutPanel.BackColor = Color.White;
            StationInfoContentTableLayoutPanel.ColumnCount = 2;
            StationInfoContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.35294F));
            StationInfoContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.6470566F));
            StationInfoContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            StationInfoContentTableLayoutPanel.Controls.Add(StationIdLabel, 0, 0);
            StationInfoContentTableLayoutPanel.Controls.Add(CodeLabel, 0, 1);
            StationInfoContentTableLayoutPanel.Controls.Add(StationNameLabel, 0, 2);
            StationInfoContentTableLayoutPanel.Controls.Add(DataPeriodLabel, 0, 3);
            StationInfoContentTableLayoutPanel.Controls.Add(LastDataDateLabel, 0, 4);
            StationInfoContentTableLayoutPanel.Controls.Add(CabinSoftwareAddressLabel, 0, 5);
            StationInfoContentTableLayoutPanel.Controls.Add(CabinSoftwarePortLabel, 0, 6);
            StationInfoContentTableLayoutPanel.Controls.Add(CabinSoftwareUsernameLabel, 0, 7);
            StationInfoContentTableLayoutPanel.Controls.Add(CabinSoftwarePasswordLabel, 0, 8);
            StationInfoContentTableLayoutPanel.Controls.Add(OrganizationLabel, 0, 9);
            StationInfoContentTableLayoutPanel.Controls.Add(StationSetupDateLabel, 0, 10);
            StationInfoContentTableLayoutPanel.Controls.Add(SoftwareSetupDateLabel, 0, 11);
            StationInfoContentTableLayoutPanel.Controls.Add(StationAddressLabel, 0, 12);
            StationInfoContentTableLayoutPanel.Controls.Add(SoftwareLabel, 0, 13);
            StationInfoContentTableLayoutPanel.Controls.Add(StationIdTextBox, 1, 0);
            StationInfoContentTableLayoutPanel.Controls.Add(StationNameTextBox, 1, 2);
            StationInfoContentTableLayoutPanel.Controls.Add(DataPeriodTextBox, 1, 3);
            StationInfoContentTableLayoutPanel.Controls.Add(LastDataDateTextBox, 1, 4);
            StationInfoContentTableLayoutPanel.Controls.Add(CabinSoftwareAddressTextBox, 1, 5);
            StationInfoContentTableLayoutPanel.Controls.Add(CodeTextBox, 1, 1);
            StationInfoContentTableLayoutPanel.Controls.Add(CabinSoftwarePortTextBox, 1, 6);
            StationInfoContentTableLayoutPanel.Controls.Add(CabinSoftwareUsernameTextBox, 1, 7);
            StationInfoContentTableLayoutPanel.Controls.Add(CabinSoftwarePasswordTextBox, 1, 8);
            StationInfoContentTableLayoutPanel.Controls.Add(OrganizationTextBox, 1, 9);
            StationInfoContentTableLayoutPanel.Controls.Add(StationSetupDateTextBox, 1, 10);
            StationInfoContentTableLayoutPanel.Controls.Add(SoftwareSetupDateTextBox, 1, 11);
            StationInfoContentTableLayoutPanel.Controls.Add(StationAddressTextBox, 1, 12);
            StationInfoContentTableLayoutPanel.Controls.Add(SoftwareTextBox, 1, 13);
            StationInfoContentTableLayoutPanel.Dock = DockStyle.Fill;
            StationInfoContentTableLayoutPanel.Location = new Point(1, 1);
            StationInfoContentTableLayoutPanel.Margin = new Padding(1);
            StationInfoContentTableLayoutPanel.Name = "StationInfoContentTableLayoutPanel";
            StationInfoContentTableLayoutPanel.Padding = new Padding(15);
            StationInfoContentTableLayoutPanel.RowCount = 15;
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
            StationInfoContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            StationInfoContentTableLayoutPanel.Size = new Size(540, 461);
            StationInfoContentTableLayoutPanel.TabIndex = 2;
            // 
            // StationIdLabel
            // 
            StationIdLabel.Anchor = AnchorStyles.Left;
            StationIdLabel.AutoSize = true;
            StationIdLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            StationIdLabel.ForeColor = Color.FromArgb(64, 64, 64);
            StationIdLabel.Location = new Point(18, 22);
            StationIdLabel.Name = "StationIdLabel";
            StationIdLabel.Size = new Size(75, 16);
            StationIdLabel.TabIndex = 1;
            StationIdLabel.Text = "İstasyon ID";
            // 
            // CodeLabel
            // 
            CodeLabel.Anchor = AnchorStyles.Left;
            CodeLabel.AutoSize = true;
            CodeLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            CodeLabel.ForeColor = Color.FromArgb(64, 64, 64);
            CodeLabel.Location = new Point(18, 53);
            CodeLabel.Name = "CodeLabel";
            CodeLabel.Size = new Size(40, 16);
            CodeLabel.TabIndex = 1;
            CodeLabel.Text = "Code";
            // 
            // StationNameLabel
            // 
            StationNameLabel.Anchor = AnchorStyles.Left;
            StationNameLabel.AutoSize = true;
            StationNameLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            StationNameLabel.ForeColor = Color.FromArgb(64, 64, 64);
            StationNameLabel.Location = new Point(18, 84);
            StationNameLabel.Name = "StationNameLabel";
            StationNameLabel.Size = new Size(83, 16);
            StationNameLabel.TabIndex = 1;
            StationNameLabel.Text = "İstasyon Adı";
            // 
            // DataPeriodLabel
            // 
            DataPeriodLabel.Anchor = AnchorStyles.Left;
            DataPeriodLabel.AutoSize = true;
            DataPeriodLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            DataPeriodLabel.ForeColor = Color.FromArgb(64, 64, 64);
            DataPeriodLabel.Location = new Point(18, 115);
            DataPeriodLabel.Name = "DataPeriodLabel";
            DataPeriodLabel.Size = new Size(97, 16);
            DataPeriodLabel.TabIndex = 1;
            DataPeriodLabel.Text = "Veri Periyodu ";
            // 
            // LastDataDateLabel
            // 
            LastDataDateLabel.Anchor = AnchorStyles.Left;
            LastDataDateLabel.AutoSize = true;
            LastDataDateLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LastDataDateLabel.ForeColor = Color.FromArgb(64, 64, 64);
            LastDataDateLabel.Location = new Point(18, 146);
            LastDataDateLabel.Name = "LastDataDateLabel";
            LastDataDateLabel.Size = new Size(101, 16);
            LastDataDateLabel.TabIndex = 1;
            LastDataDateLabel.Text = "Son Veri Tarihi";
            // 
            // CabinSoftwareAddressLabel
            // 
            CabinSoftwareAddressLabel.Anchor = AnchorStyles.Left;
            CabinSoftwareAddressLabel.AutoSize = true;
            CabinSoftwareAddressLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            CabinSoftwareAddressLabel.ForeColor = Color.FromArgb(64, 64, 64);
            CabinSoftwareAddressLabel.Location = new Point(18, 177);
            CabinSoftwareAddressLabel.Name = "CabinSoftwareAddressLabel";
            CabinSoftwareAddressLabel.Size = new Size(199, 16);
            CabinSoftwareAddressLabel.TabIndex = 1;
            CabinSoftwareAddressLabel.Text = "Kabin Yazılımı Bağlantı Adresi";
            // 
            // CabinSoftwarePortLabel
            // 
            CabinSoftwarePortLabel.Anchor = AnchorStyles.Left;
            CabinSoftwarePortLabel.AutoSize = true;
            CabinSoftwarePortLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            CabinSoftwarePortLabel.ForeColor = Color.FromArgb(64, 64, 64);
            CabinSoftwarePortLabel.Location = new Point(18, 208);
            CabinSoftwarePortLabel.Name = "CabinSoftwarePortLabel";
            CabinSoftwarePortLabel.Size = new Size(193, 16);
            CabinSoftwarePortLabel.TabIndex = 1;
            CabinSoftwarePortLabel.Text = "Kabin Yazılımı Bağlantı Portu";
            // 
            // CabinSoftwareUsernameLabel
            // 
            CabinSoftwareUsernameLabel.Anchor = AnchorStyles.Left;
            CabinSoftwareUsernameLabel.AutoSize = true;
            CabinSoftwareUsernameLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            CabinSoftwareUsernameLabel.ForeColor = Color.FromArgb(64, 64, 64);
            CabinSoftwareUsernameLabel.Location = new Point(18, 239);
            CabinSoftwareUsernameLabel.Name = "CabinSoftwareUsernameLabel";
            CabinSoftwareUsernameLabel.Size = new Size(183, 16);
            CabinSoftwareUsernameLabel.TabIndex = 1;
            CabinSoftwareUsernameLabel.Text = "Kabin Yazılımı Kullanıcı Adı";
            // 
            // CabinSoftwarePasswordLabel
            // 
            CabinSoftwarePasswordLabel.Anchor = AnchorStyles.Left;
            CabinSoftwarePasswordLabel.AutoSize = true;
            CabinSoftwarePasswordLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            CabinSoftwarePasswordLabel.ForeColor = Color.FromArgb(64, 64, 64);
            CabinSoftwarePasswordLabel.Location = new Point(18, 270);
            CabinSoftwarePasswordLabel.Name = "CabinSoftwarePasswordLabel";
            CabinSoftwarePasswordLabel.Size = new Size(202, 16);
            CabinSoftwarePasswordLabel.TabIndex = 1;
            CabinSoftwarePasswordLabel.Text = "Kabin Yazılımı Kullanıcı Şifresi";
            // 
            // OrganizationLabel
            // 
            OrganizationLabel.Anchor = AnchorStyles.Left;
            OrganizationLabel.AutoSize = true;
            OrganizationLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            OrganizationLabel.ForeColor = Color.FromArgb(64, 64, 64);
            OrganizationLabel.Location = new Point(18, 301);
            OrganizationLabel.Name = "OrganizationLabel";
            OrganizationLabel.Size = new Size(49, 16);
            OrganizationLabel.TabIndex = 1;
            OrganizationLabel.Text = "Kurum";
            // 
            // StationSetupDateLabel
            // 
            StationSetupDateLabel.Anchor = AnchorStyles.Left;
            StationSetupDateLabel.AutoSize = true;
            StationSetupDateLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            StationSetupDateLabel.ForeColor = Color.FromArgb(64, 64, 64);
            StationSetupDateLabel.Location = new Point(18, 332);
            StationSetupDateLabel.Name = "StationSetupDateLabel";
            StationSetupDateLabel.Size = new Size(156, 16);
            StationSetupDateLabel.TabIndex = 1;
            StationSetupDateLabel.Text = "İstasyon Kurulum Tarihi";
            // 
            // SoftwareSetupDateLabel
            // 
            SoftwareSetupDateLabel.Anchor = AnchorStyles.Left;
            SoftwareSetupDateLabel.AutoSize = true;
            SoftwareSetupDateLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            SoftwareSetupDateLabel.ForeColor = Color.FromArgb(64, 64, 64);
            SoftwareSetupDateLabel.Location = new Point(18, 363);
            SoftwareSetupDateLabel.Name = "SoftwareSetupDateLabel";
            SoftwareSetupDateLabel.Size = new Size(151, 16);
            SoftwareSetupDateLabel.TabIndex = 1;
            SoftwareSetupDateLabel.Text = "Yazılım Kurulum Tarihi";
            // 
            // StationAddressLabel
            // 
            StationAddressLabel.Anchor = AnchorStyles.Left;
            StationAddressLabel.AutoSize = true;
            StationAddressLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            StationAddressLabel.ForeColor = Color.FromArgb(64, 64, 64);
            StationAddressLabel.Location = new Point(18, 394);
            StationAddressLabel.Name = "StationAddressLabel";
            StationAddressLabel.Size = new Size(102, 16);
            StationAddressLabel.TabIndex = 1;
            StationAddressLabel.Text = "İstasyon Adresi";
            // 
            // SoftwareLabel
            // 
            SoftwareLabel.Anchor = AnchorStyles.Left;
            SoftwareLabel.AutoSize = true;
            SoftwareLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            SoftwareLabel.ForeColor = Color.FromArgb(64, 64, 64);
            SoftwareLabel.Location = new Point(18, 425);
            SoftwareLabel.Name = "SoftwareLabel";
            SoftwareLabel.Size = new Size(53, 16);
            SoftwareLabel.TabIndex = 1;
            SoftwareLabel.Text = "Yazılım";
            // 
            // StationIdTextBox
            // 
            StationIdTextBox.Anchor = AnchorStyles.None;
            StationIdTextBox.Enabled = false;
            StationIdTextBox.Location = new Point(235, 19);
            StationIdTextBox.Name = "StationIdTextBox";
            StationIdTextBox.PlaceholderText = StationConstants.StationIdPlaceholder;
            StationIdTextBox.Size = new Size(285, 23);
            StationIdTextBox.TabIndex = 2;
            StationIdTextBox.TextChanged += StationInfoTextChanged;
            // 
            // StationNameTextBox
            // 
            StationNameTextBox.Anchor = AnchorStyles.None;
            StationNameTextBox.Enabled = false;
            StationNameTextBox.Location = new Point(235, 81);
            StationNameTextBox.Name = "StationNameTextBox";
            StationNameTextBox.PlaceholderText = "Test Sais İstasyonu";
            StationNameTextBox.Size = new Size(285, 23);
            StationNameTextBox.TabIndex = 2;
            StationNameTextBox.TextChanged += StationInfoTextChanged;
            // 
            // DataPeriodTextBox
            // 
            DataPeriodTextBox.Anchor = AnchorStyles.None;
            DataPeriodTextBox.Enabled = false;
            DataPeriodTextBox.Location = new Point(235, 112);
            DataPeriodTextBox.Name = "DataPeriodTextBox";
            DataPeriodTextBox.PlaceholderText = "1";
            DataPeriodTextBox.Size = new Size(285, 23);
            DataPeriodTextBox.TabIndex = 2;
            DataPeriodTextBox.TextChanged += StationInfoTextChanged;
            // 
            // LastDataDateTextBox
            // 
            LastDataDateTextBox.Anchor = AnchorStyles.None;
            LastDataDateTextBox.Enabled = false;
            LastDataDateTextBox.Location = new Point(235, 143);
            LastDataDateTextBox.Name = "LastDataDateTextBox";
            LastDataDateTextBox.PlaceholderText = "2019-12-01T00:00:00";
            LastDataDateTextBox.Size = new Size(285, 23);
            LastDataDateTextBox.TabIndex = 2;
            LastDataDateTextBox.TextChanged += StationInfoTextChanged;
            // 
            // CabinSoftwareAddressTextBox
            // 
            CabinSoftwareAddressTextBox.Anchor = AnchorStyles.None;
            CabinSoftwareAddressTextBox.Enabled = false;
            CabinSoftwareAddressTextBox.Location = new Point(235, 174);
            CabinSoftwareAddressTextBox.Name = "CabinSoftwareAddressTextBox";
            CabinSoftwareAddressTextBox.PlaceholderText = "istanbul.ssl";
            CabinSoftwareAddressTextBox.Size = new Size(285, 23);
            CabinSoftwareAddressTextBox.TabIndex = 2;
            CabinSoftwareAddressTextBox.TextChanged += StationInfoTextChanged;
            // 
            // CodeTextBox
            // 
            CodeTextBox.Anchor = AnchorStyles.None;
            CodeTextBox.Enabled = false;
            CodeTextBox.Location = new Point(235, 50);
            CodeTextBox.Name = "CodeTextBox";
            CodeTextBox.PlaceholderText = "0337000";
            CodeTextBox.Size = new Size(285, 23);
            CodeTextBox.TabIndex = 2;
            CodeTextBox.TextChanged += StationInfoTextChanged;
            // 
            // CabinSoftwarePortTextBox
            // 
            CabinSoftwarePortTextBox.Anchor = AnchorStyles.None;
            CabinSoftwarePortTextBox.Enabled = false;
            CabinSoftwarePortTextBox.Location = new Point(235, 205);
            CabinSoftwarePortTextBox.Name = "CabinSoftwarePortTextBox";
            CabinSoftwarePortTextBox.PlaceholderText = "443";
            CabinSoftwarePortTextBox.Size = new Size(285, 23);
            CabinSoftwarePortTextBox.TabIndex = 2;
            CabinSoftwarePortTextBox.TextChanged += StationInfoTextChanged;
            // 
            // CabinSoftwareUsernameTextBox
            // 
            CabinSoftwareUsernameTextBox.Anchor = AnchorStyles.None;
            CabinSoftwareUsernameTextBox.Enabled = false;
            CabinSoftwareUsernameTextBox.Location = new Point(235, 236);
            CabinSoftwareUsernameTextBox.Name = "CabinSoftwareUsernameTextBox";
            CabinSoftwareUsernameTextBox.PlaceholderText = "iski";
            CabinSoftwareUsernameTextBox.Size = new Size(285, 23);
            CabinSoftwareUsernameTextBox.TabIndex = 2;
            CabinSoftwareUsernameTextBox.TextChanged += StationInfoTextChanged;
            // 
            // CabinSoftwarePasswordTextBox
            // 
            CabinSoftwarePasswordTextBox.Anchor = AnchorStyles.None;
            CabinSoftwarePasswordTextBox.Enabled = false;
            CabinSoftwarePasswordTextBox.Location = new Point(235, 267);
            CabinSoftwarePasswordTextBox.Name = "CabinSoftwarePasswordTextBox";
            CabinSoftwarePasswordTextBox.PlaceholderText = "iski123";
            CabinSoftwarePasswordTextBox.Size = new Size(285, 23);
            CabinSoftwarePasswordTextBox.TabIndex = 2;
            CabinSoftwarePasswordTextBox.TextChanged += StationInfoTextChanged;
            // 
            // OrganizationTextBox
            // 
            OrganizationTextBox.Anchor = AnchorStyles.None;
            OrganizationTextBox.Enabled = false;
            OrganizationTextBox.Location = new Point(235, 298);
            OrganizationTextBox.Name = "OrganizationTextBox";
            OrganizationTextBox.PlaceholderText = "Test Tesisi";
            OrganizationTextBox.Size = new Size(285, 23);
            OrganizationTextBox.TabIndex = 2;
            OrganizationTextBox.TextChanged += StationInfoTextChanged;
            // 
            // StationSetupDateTextBox
            // 
            StationSetupDateTextBox.Anchor = AnchorStyles.None;
            StationSetupDateTextBox.Enabled = false;
            StationSetupDateTextBox.Location = new Point(235, 329);
            StationSetupDateTextBox.Name = "StationSetupDateTextBox";
            StationSetupDateTextBox.PlaceholderText = "2019-12-01T00:00:00";
            StationSetupDateTextBox.Size = new Size(285, 23);
            StationSetupDateTextBox.TabIndex = 2;
            StationSetupDateTextBox.TextChanged += StationInfoTextChanged;
            // 
            // SoftwareSetupDateTextBox
            // 
            SoftwareSetupDateTextBox.Anchor = AnchorStyles.None;
            SoftwareSetupDateTextBox.Enabled = false;
            SoftwareSetupDateTextBox.Location = new Point(235, 360);
            SoftwareSetupDateTextBox.Name = "SoftwareSetupDateTextBox";
            SoftwareSetupDateTextBox.PlaceholderText = "2019-12-01T00:00:00";
            SoftwareSetupDateTextBox.Size = new Size(285, 23);
            SoftwareSetupDateTextBox.TabIndex = 2;
            SoftwareSetupDateTextBox.TextChanged += StationInfoTextChanged;
            // 
            // StationAddressTextBox
            // 
            StationAddressTextBox.Anchor = AnchorStyles.None;
            StationAddressTextBox.Enabled = false;
            StationAddressTextBox.Location = new Point(235, 391);
            StationAddressTextBox.Name = "StationAddressTextBox";
            StationAddressTextBox.PlaceholderText = "İstanbul";
            StationAddressTextBox.Size = new Size(285, 23);
            StationAddressTextBox.TabIndex = 2;
            StationAddressTextBox.TextChanged += StationInfoTextChanged;
            // 
            // SoftwareTextBox
            // 
            SoftwareTextBox.Anchor = AnchorStyles.None;
            SoftwareTextBox.Enabled = false;
            SoftwareTextBox.Location = new Point(235, 422);
            SoftwareTextBox.Name = "SoftwareTextBox";
            SoftwareTextBox.PlaceholderText = "IBKS";
            SoftwareTextBox.Size = new Size(285, 23);
            SoftwareTextBox.TabIndex = 2;
            SoftwareTextBox.TextChanged += StationInfoTextChanged;
            // 
            // StationSettingsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(StationSettingsBgTableLayoutPanel);
            Name = "StationSettingsPage";
            Padding = new Padding(0, 15, 0, 15);
            Size = new Size(1094, 533);
            StationSettingsBgTableLayoutPanel.ResumeLayout(false);
            StationSettingsContentTableLayoutPanel.ResumeLayout(false);
            StationSettingsContentTableLayoutPanel.PerformLayout();
            StationSettingsHeaderTableLayoutPanel.ResumeLayout(false);
            StationSettingsHeaderTableLayoutPanel.PerformLayout();
            StationInfoHeaderTableLayoutPanel.ResumeLayout(false);
            StationInfoHeaderTableLayoutPanel.PerformLayout();
            StationInfoBgTableLayoutPanel.ResumeLayout(false);
            StationInfoContentTableLayoutPanel.ResumeLayout(false);
            StationInfoContentTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel StationSettingsBgTableLayoutPanel;
        private Label StationInfoLabel;
        private Button FetchStationButton;
        private TableLayoutPanel StationInfoHeaderTableLayoutPanel;
        private TableLayoutPanel StationSettingsHeaderTableLayoutPanel;
        private Label StationSettingsLabel;
        private Button SaveStationSettingsButton;
        private TableLayoutPanel StationInfoBgTableLayoutPanel;
        private TableLayoutPanel StationInfoContentTableLayoutPanel;
        private Label StationIdLabel;
        private Label CodeLabel;
        private Label StationNameLabel;
        private Label DataPeriodLabel;
        private Label LastDataDateLabel;
        private Label CabinSoftwareAddressLabel;
        private Label CabinSoftwarePortLabel;
        private Label CabinSoftwareUsernameLabel;
        private Label CabinSoftwarePasswordLabel;
        private Label OrganizationLabel;
        private Label StationSetupDateLabel;
        private Label SoftwareSetupDateLabel;
        private Label StationAddressLabel;
        private Label SoftwareLabel;
        private TextBox StationIdTextBox;
        private TextBox DataPeriodTextBox;
        private TextBox StationNameTextBox;
        private TextBox LastDataDateTextBox;
        private TextBox CabinSoftwareAddressTextBox;
        private TextBox CodeTextBox;
        private TextBox CabinSoftwarePortTextBox;
        private TextBox CabinSoftwareUsernameTextBox;
        private TextBox CabinSoftwarePasswordTextBox;
        private TextBox OrganizationTextBox;
        private TextBox StationSetupDateTextBox;
        private TextBox SoftwareSetupDateTextBox;
        private TextBox StationAddressTextBox;
        private TextBox SoftwareTextBox;
        private TableLayoutPanel StationSettingsContentTableLayoutPanel;
        private Label StationIdSettingLabel;
        private Label ConnectionUserLabel;
        private Label ConnectionPasswordLabel;
        private Label ConnectionDomainAddressLabel;
        private TextBox StationIdSettingTextBox;
        private TextBox ConnectionPasswordTextBox;
        private TextBox ConnectionDomainAddressTextBox;
        private TextBox ConnectionUserTextBox;
        private Label ConnectionPortLabel;
        private TextBox ConnectionPortTextBox;
    }
}
