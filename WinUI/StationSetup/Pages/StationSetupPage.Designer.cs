namespace WinUI.StationSetup.Pages
{
    partial class StationSetupPage
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
            button2 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            StationSettingsBgTableLayoutPanel = new TableLayoutPanel();
            ApiSettingsHeaderTableLayoutPanel = new TableLayoutPanel();
            ApiSettingsLabel = new Label();
            SaveApiSettingsButton = new Button();
            StationInfoBgTableLayoutPanel = new TableLayoutPanel();
            StationInfoContentTableLayoutPanel = new TableLayoutPanel();
            ApiUrlLabel = new Label();
            ApiUrlTextBox = new TextBox();
            ApiUsernameLabel = new Label();
            ApiUsernameTextBox = new TextBox();
            ConnectionUserLabel = new Label();
            ConnectionPasswordLabel = new Label();
            ConnectionDomainAddressLabel = new Label();
            ConnectionPortLabel = new Label();
            StationIdSettingLabel = new Label();
            StationIdSettingTextBox = new TextBox();
            ConnectionUserTextBox = new TextBox();
            ConnectionPasswordTextBox = new TextBox();
            ConnectionDomainAddressTextBox = new TextBox();
            ConnectionPortTextBox = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            StationSettingsBgTableLayoutPanel.SuspendLayout();
            ApiSettingsHeaderTableLayoutPanel.SuspendLayout();
            StationInfoBgTableLayoutPanel.SuspendLayout();
            StationInfoContentTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Enabled = false;
            button2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(379, 3);
            button2.Name = "button2";
            button2.Size = new Size(92, 32);
            button2.TabIndex = 2;
            button2.Text = "Güncelle";
            button2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(474, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(474, 40);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(164, 22);
            label1.TabIndex = 0;
            label1.Text = "İstasyon Ayarları";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.35294F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.6470566F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(ConnectionPortTextBox, 1, 4);
            tableLayoutPanel2.Controls.Add(ConnectionDomainAddressTextBox, 1, 3);
            tableLayoutPanel2.Controls.Add(ConnectionPasswordTextBox, 1, 2);
            tableLayoutPanel2.Controls.Add(ConnectionUserTextBox, 1, 1);
            tableLayoutPanel2.Controls.Add(StationIdSettingTextBox, 1, 0);
            tableLayoutPanel2.Controls.Add(StationIdSettingLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(ConnectionPortLabel, 0, 4);
            tableLayoutPanel2.Controls.Add(ConnectionDomainAddressLabel, 0, 3);
            tableLayoutPanel2.Controls.Add(ConnectionPasswordLabel, 0, 2);
            tableLayoutPanel2.Controls.Add(ConnectionUserLabel, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(475, 41);
            tableLayoutPanel2.Margin = new Padding(1);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(15);
            tableLayoutPanel2.RowCount = 8;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel2.Size = new Size(472, 289);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // StationSettingsBgTableLayoutPanel
            // 
            StationSettingsBgTableLayoutPanel.ColumnCount = 2;
            StationSettingsBgTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            StationSettingsBgTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            StationSettingsBgTableLayoutPanel.Controls.Add(tableLayoutPanel2, 1, 1);
            StationSettingsBgTableLayoutPanel.Controls.Add(tableLayoutPanel1, 1, 0);
            StationSettingsBgTableLayoutPanel.Controls.Add(ApiSettingsHeaderTableLayoutPanel, 0, 0);
            StationSettingsBgTableLayoutPanel.Controls.Add(StationInfoBgTableLayoutPanel, 0, 1);
            StationSettingsBgTableLayoutPanel.Dock = DockStyle.Fill;
            StationSettingsBgTableLayoutPanel.Location = new Point(15, 15);
            StationSettingsBgTableLayoutPanel.Name = "StationSettingsBgTableLayoutPanel";
            StationSettingsBgTableLayoutPanel.RowCount = 2;
            StationSettingsBgTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            StationSettingsBgTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            StationSettingsBgTableLayoutPanel.Size = new Size(948, 331);
            StationSettingsBgTableLayoutPanel.TabIndex = 4;
            // 
            // ApiSettingsHeaderTableLayoutPanel
            // 
            ApiSettingsHeaderTableLayoutPanel.ColumnCount = 2;
            ApiSettingsHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ApiSettingsHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ApiSettingsHeaderTableLayoutPanel.Controls.Add(ApiSettingsLabel, 0, 0);
            ApiSettingsHeaderTableLayoutPanel.Dock = DockStyle.Fill;
            ApiSettingsHeaderTableLayoutPanel.Location = new Point(0, 0);
            ApiSettingsHeaderTableLayoutPanel.Margin = new Padding(0);
            ApiSettingsHeaderTableLayoutPanel.Name = "ApiSettingsHeaderTableLayoutPanel";
            ApiSettingsHeaderTableLayoutPanel.RowCount = 1;
            ApiSettingsHeaderTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ApiSettingsHeaderTableLayoutPanel.Size = new Size(474, 40);
            ApiSettingsHeaderTableLayoutPanel.TabIndex = 3;
            // 
            // ApiSettingsLabel
            // 
            ApiSettingsLabel.AutoSize = true;
            ApiSettingsLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ApiSettingsLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ApiSettingsLabel.Location = new Point(3, 0);
            ApiSettingsLabel.Name = "ApiSettingsLabel";
            ApiSettingsLabel.Size = new Size(164, 22);
            ApiSettingsLabel.TabIndex = 0;
            ApiSettingsLabel.Text = "İstasyon Bilgileri";
            // 
            // SaveApiSettingsButton
            // 
            SaveApiSettingsButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SaveApiSettingsButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveApiSettingsButton.Location = new Point(357, 49);
            SaveApiSettingsButton.Name = "SaveApiSettingsButton";
            SaveApiSettingsButton.Size = new Size(92, 25);
            SaveApiSettingsButton.TabIndex = 2;
            SaveApiSettingsButton.Text = "Getir";
            SaveApiSettingsButton.UseVisualStyleBackColor = true;
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
            StationInfoBgTableLayoutPanel.Size = new Size(469, 291);
            StationInfoBgTableLayoutPanel.TabIndex = 5;
            // 
            // StationInfoContentTableLayoutPanel
            // 
            StationInfoContentTableLayoutPanel.BackColor = Color.White;
            StationInfoContentTableLayoutPanel.ColumnCount = 2;
            StationInfoContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.35294F));
            StationInfoContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.6470566F));
            StationInfoContentTableLayoutPanel.Controls.Add(ApiUrlLabel, 0, 0);
            StationInfoContentTableLayoutPanel.Controls.Add(SaveApiSettingsButton, 1, 1);
            StationInfoContentTableLayoutPanel.Controls.Add(ApiUrlTextBox, 1, 0);
            StationInfoContentTableLayoutPanel.Controls.Add(ApiUsernameLabel, 0, 2);
            StationInfoContentTableLayoutPanel.Controls.Add(ApiUsernameTextBox, 1, 2);
            StationInfoContentTableLayoutPanel.Dock = DockStyle.Fill;
            StationInfoContentTableLayoutPanel.Location = new Point(1, 1);
            StationInfoContentTableLayoutPanel.Margin = new Padding(1);
            StationInfoContentTableLayoutPanel.Name = "StationInfoContentTableLayoutPanel";
            StationInfoContentTableLayoutPanel.Padding = new Padding(15);
            StationInfoContentTableLayoutPanel.RowCount = 8;
            StationInfoContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            StationInfoContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            StationInfoContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            StationInfoContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            StationInfoContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            StationInfoContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            StationInfoContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            StationInfoContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            StationInfoContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            StationInfoContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            StationInfoContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            StationInfoContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            StationInfoContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            StationInfoContentTableLayoutPanel.Size = new Size(467, 289);
            StationInfoContentTableLayoutPanel.TabIndex = 2;
            // 
            // ApiUrlLabel
            // 
            ApiUrlLabel.Anchor = AnchorStyles.Left;
            ApiUrlLabel.AutoSize = true;
            ApiUrlLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ApiUrlLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ApiUrlLabel.Location = new Point(18, 22);
            ApiUrlLabel.Name = "ApiUrlLabel";
            ApiUrlLabel.Size = new Size(74, 16);
            ApiUrlLabel.TabIndex = 1;
            ApiUrlLabel.Text = "İstasyon Id";
            // 
            // ApiUrlTextBox
            // 
            ApiUrlTextBox.Anchor = AnchorStyles.Left;
            ApiUrlTextBox.Location = new Point(203, 19);
            ApiUrlTextBox.Name = "ApiUrlTextBox";
            ApiUrlTextBox.PlaceholderText = "istasyon_id";
            ApiUrlTextBox.Size = new Size(246, 23);
            ApiUrlTextBox.TabIndex = 2;
            // 
            // ApiUsernameLabel
            // 
            ApiUsernameLabel.Anchor = AnchorStyles.Left;
            ApiUsernameLabel.AutoSize = true;
            ApiUsernameLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ApiUsernameLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ApiUsernameLabel.Location = new Point(18, 84);
            ApiUsernameLabel.Name = "ApiUsernameLabel";
            ApiUsernameLabel.Size = new Size(83, 16);
            ApiUsernameLabel.TabIndex = 1;
            ApiUsernameLabel.Text = "İstasyon Adı";
            // 
            // ApiUsernameTextBox
            // 
            ApiUsernameTextBox.Anchor = AnchorStyles.Left;
            ApiUsernameTextBox.Location = new Point(203, 81);
            ApiUsernameTextBox.Name = "ApiUsernameTextBox";
            ApiUsernameTextBox.PlaceholderText = "istasyon_adi";
            ApiUsernameTextBox.Size = new Size(246, 23);
            ApiUsernameTextBox.TabIndex = 2;
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
            ConnectionUserLabel.TabIndex = 2;
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
            ConnectionPasswordLabel.TabIndex = 3;
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
            ConnectionDomainAddressLabel.TabIndex = 4;
            ConnectionDomainAddressLabel.Text = "ConnectionDomainAddress";
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
            ConnectionPortLabel.TabIndex = 5;
            ConnectionPortLabel.Text = "ConnectionPort";
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
            StationIdSettingLabel.TabIndex = 6;
            StationIdSettingLabel.Text = "StationId";
            // 
            // StationIdSettingTextBox
            // 
            StationIdSettingTextBox.Dock = DockStyle.Fill;
            StationIdSettingTextBox.Location = new Point(205, 18);
            StationIdSettingTextBox.Name = "StationIdSettingTextBox";
            StationIdSettingTextBox.PlaceholderText = "edf10dfd-5fab-460b-b2fd-66b67da7a489";
            StationIdSettingTextBox.Size = new Size(249, 23);
            StationIdSettingTextBox.TabIndex = 7;
            // 
            // ConnectionUserTextBox
            // 
            ConnectionUserTextBox.Dock = DockStyle.Fill;
            ConnectionUserTextBox.Location = new Point(205, 49);
            ConnectionUserTextBox.Name = "ConnectionUserTextBox";
            ConnectionUserTextBox.PlaceholderText = "Kabin Yazılımı Kullanıcı Adı";
            ConnectionUserTextBox.Size = new Size(249, 23);
            ConnectionUserTextBox.TabIndex = 8;
            // 
            // ConnectionPasswordTextBox
            // 
            ConnectionPasswordTextBox.Dock = DockStyle.Fill;
            ConnectionPasswordTextBox.Location = new Point(205, 80);
            ConnectionPasswordTextBox.Name = "ConnectionPasswordTextBox";
            ConnectionPasswordTextBox.PlaceholderText = "Kabin Yazılımı Kullanıcı Şifresi";
            ConnectionPasswordTextBox.Size = new Size(249, 23);
            ConnectionPasswordTextBox.TabIndex = 9;
            // 
            // ConnectionDomainAddressTextBox
            // 
            ConnectionDomainAddressTextBox.Dock = DockStyle.Fill;
            ConnectionDomainAddressTextBox.Location = new Point(205, 111);
            ConnectionDomainAddressTextBox.Name = "ConnectionDomainAddressTextBox";
            ConnectionDomainAddressTextBox.PlaceholderText = "Kabin Yazılımı Erişim Host veya IP Numarası";
            ConnectionDomainAddressTextBox.Size = new Size(249, 23);
            ConnectionDomainAddressTextBox.TabIndex = 10;
            // 
            // ConnectionPortTextBox
            // 
            ConnectionPortTextBox.Dock = DockStyle.Fill;
            ConnectionPortTextBox.Location = new Point(205, 142);
            ConnectionPortTextBox.Name = "ConnectionPortTextBox";
            ConnectionPortTextBox.PlaceholderText = "Kabin Yazılımı Erişim için kullanılan PORT bilgisi";
            ConnectionPortTextBox.Size = new Size(249, 23);
            ConnectionPortTextBox.TabIndex = 11;
            // 
            // StationSetupPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(StationSettingsBgTableLayoutPanel);
            Name = "StationSetupPage";
            Padding = new Padding(15);
            Size = new Size(978, 361);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            StationSettingsBgTableLayoutPanel.ResumeLayout(false);
            ApiSettingsHeaderTableLayoutPanel.ResumeLayout(false);
            ApiSettingsHeaderTableLayoutPanel.PerformLayout();
            StationInfoBgTableLayoutPanel.ResumeLayout(false);
            StationInfoContentTableLayoutPanel.ResumeLayout(false);
            StationInfoContentTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel StationSettingsBgTableLayoutPanel;
        private TableLayoutPanel ApiSettingsHeaderTableLayoutPanel;
        private Label ApiSettingsLabel;
        private Button SaveApiSettingsButton;
        private TableLayoutPanel StationInfoBgTableLayoutPanel;
        private TableLayoutPanel StationInfoContentTableLayoutPanel;
        private Label ApiUrlLabel;
        private TextBox ApiUrlTextBox;
        private Label ApiUsernameLabel;
        private TextBox ApiUsernameTextBox;
        private Label ConnectionUserLabel;
        private Label ConnectionPasswordLabel;
        private Label ConnectionDomainAddressLabel;
        private Label ConnectionPortLabel;
        private Label StationIdSettingLabel;
        private TextBox StationIdSettingTextBox;
        private TextBox ConnectionUserTextBox;
        private TextBox ConnectionPasswordTextBox;
        private TextBox ConnectionDomainAddressTextBox;
        private TextBox ConnectionPortTextBox;
    }
}
