namespace WinUI.Pages.Settings
{
    partial class ApiSettingsPage
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
            ApiUrlLabel = new Label();
            ApiUrlTextBox = new TextBox();
            StationInfoContentTableLayoutPanel = new TableLayoutPanel();
            ApiUsernameLabel = new Label();
            ApiPasswordLabel = new Label();
            ApiUsernameTextBox = new TextBox();
            ApiPasswordTextBox = new TextBox();
            SendPeriodLabel = new Label();
            DataSendPeriodNumericUpDown = new NumericUpDown();
            ResendPeriodLabel = new Label();
            ResendPeriodComboBox = new ComboBox();
            StationInfoBgTableLayoutPanel = new TableLayoutPanel();
            ApiSettingsLabel = new Label();
            SaveApiSettingsButton = new Button();
            ApiSettingsHeaderTableLayoutPanel = new TableLayoutPanel();
            StationSettingsBgTableLayoutPanel = new TableLayoutPanel();
            ApiTestLabel = new Label();
            ApiTestBgTableLayoutPanel = new TableLayoutPanel();
            ApiTestContentTableLayoutPanel = new TableLayoutPanel();
            SendServerRequestButton = new Button();
            ResponseGroupBox = new GroupBox();
            ResponseTextBox = new TextBox();
            RequestSampleButton = new Button();
            SendDiagnosticButton = new Button();
            PeriodLabel = new Label();
            PeriodComboBox = new ComboBox();
            GetLastDataButton = new Button();
            GetHistoricalDataButton = new Button();
            StationInfoContentTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataSendPeriodNumericUpDown).BeginInit();
            StationInfoBgTableLayoutPanel.SuspendLayout();
            ApiSettingsHeaderTableLayoutPanel.SuspendLayout();
            StationSettingsBgTableLayoutPanel.SuspendLayout();
            ApiTestBgTableLayoutPanel.SuspendLayout();
            ApiTestContentTableLayoutPanel.SuspendLayout();
            ResponseGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ApiUrlLabel
            // 
            ApiUrlLabel.Anchor = AnchorStyles.Left;
            ApiUrlLabel.AutoSize = true;
            ApiUrlLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ApiUrlLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ApiUrlLabel.Location = new Point(18, 22);
            ApiUrlLabel.Name = "ApiUrlLabel";
            ApiUrlLabel.Size = new Size(59, 16);
            ApiUrlLabel.TabIndex = 1;
            ApiUrlLabel.Text = "API URL";
            // 
            // ApiUrlTextBox
            // 
            ApiUrlTextBox.Anchor = AnchorStyles.Left;
            ApiUrlTextBox.Location = new Point(234, 19);
            ApiUrlTextBox.Name = "ApiUrlTextBox";
            ApiUrlTextBox.PlaceholderText = "localhost";
            ApiUrlTextBox.Size = new Size(288, 23);
            ApiUrlTextBox.TabIndex = 2;
            // 
            // StationInfoContentTableLayoutPanel
            // 
            StationInfoContentTableLayoutPanel.BackColor = Color.White;
            StationInfoContentTableLayoutPanel.ColumnCount = 2;
            StationInfoContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.35294F));
            StationInfoContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.6470566F));
            StationInfoContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            StationInfoContentTableLayoutPanel.Controls.Add(ApiUrlLabel, 0, 0);
            StationInfoContentTableLayoutPanel.Controls.Add(ApiUrlTextBox, 1, 0);
            StationInfoContentTableLayoutPanel.Controls.Add(ApiUsernameLabel, 0, 1);
            StationInfoContentTableLayoutPanel.Controls.Add(ApiPasswordLabel, 0, 2);
            StationInfoContentTableLayoutPanel.Controls.Add(ApiUsernameTextBox, 1, 1);
            StationInfoContentTableLayoutPanel.Controls.Add(ApiPasswordTextBox, 1, 2);
            StationInfoContentTableLayoutPanel.Controls.Add(SendPeriodLabel, 0, 3);
            StationInfoContentTableLayoutPanel.Controls.Add(DataSendPeriodNumericUpDown, 1, 3);
            StationInfoContentTableLayoutPanel.Controls.Add(ResendPeriodLabel, 0, 4);
            StationInfoContentTableLayoutPanel.Controls.Add(ResendPeriodComboBox, 1, 4);
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
            // ApiUsernameLabel
            // 
            ApiUsernameLabel.Anchor = AnchorStyles.Left;
            ApiUsernameLabel.AutoSize = true;
            ApiUsernameLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ApiUsernameLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ApiUsernameLabel.Location = new Point(18, 53);
            ApiUsernameLabel.Name = "ApiUsernameLabel";
            ApiUsernameLabel.Size = new Size(114, 16);
            ApiUsernameLabel.TabIndex = 1;
            ApiUsernameLabel.Text = "API Kullanıcı Adı";
            // 
            // ApiPasswordLabel
            // 
            ApiPasswordLabel.Anchor = AnchorStyles.Left;
            ApiPasswordLabel.AutoSize = true;
            ApiPasswordLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ApiPasswordLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ApiPasswordLabel.Location = new Point(18, 84);
            ApiPasswordLabel.Name = "ApiPasswordLabel";
            ApiPasswordLabel.Size = new Size(133, 16);
            ApiPasswordLabel.TabIndex = 1;
            ApiPasswordLabel.Text = "API Kullanıcı Şifresi";
            // 
            // ApiUsernameTextBox
            // 
            ApiUsernameTextBox.Anchor = AnchorStyles.Left;
            ApiUsernameTextBox.Location = new Point(234, 50);
            ApiUsernameTextBox.Name = "ApiUsernameTextBox";
            ApiUsernameTextBox.PlaceholderText = "api_user";
            ApiUsernameTextBox.Size = new Size(288, 23);
            ApiUsernameTextBox.TabIndex = 2;
            // 
            // ApiPasswordTextBox
            // 
            ApiPasswordTextBox.Anchor = AnchorStyles.Left;
            ApiPasswordTextBox.Location = new Point(234, 81);
            ApiPasswordTextBox.Name = "ApiPasswordTextBox";
            ApiPasswordTextBox.PlaceholderText = "api_pass";
            ApiPasswordTextBox.Size = new Size(288, 23);
            ApiPasswordTextBox.TabIndex = 2;
            // 
            // SendPeriodLabel
            // 
            SendPeriodLabel.Anchor = AnchorStyles.Left;
            SendPeriodLabel.AutoSize = true;
            SendPeriodLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            SendPeriodLabel.ForeColor = Color.FromArgb(64, 64, 64);
            SendPeriodLabel.Location = new Point(18, 115);
            SendPeriodLabel.Name = "SendPeriodLabel";
            SendPeriodLabel.Size = new Size(158, 16);
            SendPeriodLabel.TabIndex = 1;
            SendPeriodLabel.Text = "Gönderim Periyodu (dk)";
            // 
            // DataSendPeriodNumericUpDown
            // 
            DataSendPeriodNumericUpDown.Anchor = AnchorStyles.Left;
            DataSendPeriodNumericUpDown.Location = new Point(234, 112);
            DataSendPeriodNumericUpDown.Maximum = new decimal(new int[] { 1440, 0, 0, 0 });
            DataSendPeriodNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            DataSendPeriodNumericUpDown.Name = "DataSendPeriodNumericUpDown";
            DataSendPeriodNumericUpDown.Size = new Size(288, 23);
            DataSendPeriodNumericUpDown.TabIndex = 3;
            DataSendPeriodNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ResendPeriodLabel
            // 
            ResendPeriodLabel.Anchor = AnchorStyles.Left;
            ResendPeriodLabel.AutoSize = true;
            ResendPeriodLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ResendPeriodLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ResendPeriodLabel.Location = new Point(18, 146);
            ResendPeriodLabel.Name = "ResendPeriodLabel";
            ResendPeriodLabel.Size = new Size(168, 16);
            ResendPeriodLabel.TabIndex = 1;
            ResendPeriodLabel.Text = "Geriye Dönük Veri Aralığı";
            // 
            // ResendPeriodComboBox
            // 
            ResendPeriodComboBox.Anchor = AnchorStyles.Left;
            ResendPeriodComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ResendPeriodComboBox.FormattingEnabled = true;
            ResendPeriodComboBox.Location = new Point(234, 143);
            ResendPeriodComboBox.Name = "ResendPeriodComboBox";
            ResendPeriodComboBox.Size = new Size(288, 23);
            ResendPeriodComboBox.TabIndex = 4;
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
            // ApiSettingsLabel
            // 
            ApiSettingsLabel.AutoSize = true;
            ApiSettingsLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ApiSettingsLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ApiSettingsLabel.Location = new Point(3, 0);
            ApiSettingsLabel.Name = "ApiSettingsLabel";
            ApiSettingsLabel.Size = new Size(116, 22);
            ApiSettingsLabel.TabIndex = 0;
            ApiSettingsLabel.Text = "API Ayarları";
            // 
            // SaveApiSettingsButton
            // 
            SaveApiSettingsButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SaveApiSettingsButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveApiSettingsButton.Location = new Point(452, 3);
            SaveApiSettingsButton.Name = "SaveApiSettingsButton";
            SaveApiSettingsButton.Size = new Size(92, 32);
            SaveApiSettingsButton.TabIndex = 2;
            SaveApiSettingsButton.Text = "Kaydet";
            SaveApiSettingsButton.UseVisualStyleBackColor = true;
            // 
            // ApiSettingsHeaderTableLayoutPanel
            // 
            ApiSettingsHeaderTableLayoutPanel.ColumnCount = 2;
            ApiSettingsHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ApiSettingsHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ApiSettingsHeaderTableLayoutPanel.Controls.Add(ApiSettingsLabel, 0, 0);
            ApiSettingsHeaderTableLayoutPanel.Controls.Add(SaveApiSettingsButton, 1, 0);
            ApiSettingsHeaderTableLayoutPanel.Dock = DockStyle.Fill;
            ApiSettingsHeaderTableLayoutPanel.Location = new Point(0, 0);
            ApiSettingsHeaderTableLayoutPanel.Margin = new Padding(0);
            ApiSettingsHeaderTableLayoutPanel.Name = "ApiSettingsHeaderTableLayoutPanel";
            ApiSettingsHeaderTableLayoutPanel.RowCount = 1;
            ApiSettingsHeaderTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ApiSettingsHeaderTableLayoutPanel.Size = new Size(547, 40);
            ApiSettingsHeaderTableLayoutPanel.TabIndex = 3;
            // 
            // StationSettingsBgTableLayoutPanel
            // 
            StationSettingsBgTableLayoutPanel.ColumnCount = 2;
            StationSettingsBgTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            StationSettingsBgTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            StationSettingsBgTableLayoutPanel.Controls.Add(ApiTestLabel, 1, 0);
            StationSettingsBgTableLayoutPanel.Controls.Add(ApiTestBgTableLayoutPanel, 1, 1);
            StationSettingsBgTableLayoutPanel.Controls.Add(ApiSettingsHeaderTableLayoutPanel, 0, 0);
            StationSettingsBgTableLayoutPanel.Controls.Add(StationInfoBgTableLayoutPanel, 0, 1);
            StationSettingsBgTableLayoutPanel.Dock = DockStyle.Fill;
            StationSettingsBgTableLayoutPanel.Location = new Point(0, 15);
            StationSettingsBgTableLayoutPanel.Name = "StationSettingsBgTableLayoutPanel";
            StationSettingsBgTableLayoutPanel.RowCount = 2;
            StationSettingsBgTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            StationSettingsBgTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            StationSettingsBgTableLayoutPanel.Size = new Size(1094, 503);
            StationSettingsBgTableLayoutPanel.TabIndex = 2;
            // 
            // ApiTestLabel
            // 
            ApiTestLabel.AutoSize = true;
            ApiTestLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ApiTestLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ApiTestLabel.Location = new Point(550, 0);
            ApiTestLabel.Name = "ApiTestLabel";
            ApiTestLabel.Size = new Size(91, 22);
            ApiTestLabel.TabIndex = 0;
            ApiTestLabel.Text = "API Testi";
            // 
            // ApiTestBgTableLayoutPanel
            // 
            ApiTestBgTableLayoutPanel.BackColor = Color.FromArgb(235, 235, 235);
            ApiTestBgTableLayoutPanel.ColumnCount = 1;
            ApiTestBgTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ApiTestBgTableLayoutPanel.Controls.Add(ApiTestContentTableLayoutPanel, 0, 0);
            ApiTestBgTableLayoutPanel.Dock = DockStyle.Fill;
            ApiTestBgTableLayoutPanel.Location = new Point(547, 40);
            ApiTestBgTableLayoutPanel.Margin = new Padding(0, 0, 5, 0);
            ApiTestBgTableLayoutPanel.Name = "ApiTestBgTableLayoutPanel";
            ApiTestBgTableLayoutPanel.RowCount = 1;
            ApiTestBgTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ApiTestBgTableLayoutPanel.Size = new Size(542, 463);
            ApiTestBgTableLayoutPanel.TabIndex = 6;
            // 
            // ApiTestContentTableLayoutPanel
            // 
            ApiTestContentTableLayoutPanel.BackColor = Color.White;
            ApiTestContentTableLayoutPanel.ColumnCount = 2;
            ApiTestContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.27451F));
            ApiTestContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.72549F));
            ApiTestContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            ApiTestContentTableLayoutPanel.Controls.Add(SendServerRequestButton, 0, 0);
            ApiTestContentTableLayoutPanel.Controls.Add(ResponseGroupBox, 1, 0);
            ApiTestContentTableLayoutPanel.Controls.Add(RequestSampleButton, 0, 1);
            ApiTestContentTableLayoutPanel.Controls.Add(SendDiagnosticButton, 0, 2);
            ApiTestContentTableLayoutPanel.Controls.Add(PeriodLabel, 0, 3);
            ApiTestContentTableLayoutPanel.Controls.Add(PeriodComboBox, 0, 4);
            ApiTestContentTableLayoutPanel.Controls.Add(GetLastDataButton, 0, 5);
            ApiTestContentTableLayoutPanel.Controls.Add(GetHistoricalDataButton, 0, 6);
            ApiTestContentTableLayoutPanel.Dock = DockStyle.Fill;
            ApiTestContentTableLayoutPanel.Location = new Point(1, 1);
            ApiTestContentTableLayoutPanel.Margin = new Padding(1);
            ApiTestContentTableLayoutPanel.Name = "ApiTestContentTableLayoutPanel";
            ApiTestContentTableLayoutPanel.Padding = new Padding(15);
            ApiTestContentTableLayoutPanel.RowCount = 14;
            ApiTestContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            ApiTestContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            ApiTestContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            ApiTestContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            ApiTestContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            ApiTestContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            ApiTestContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            ApiTestContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            ApiTestContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            ApiTestContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            ApiTestContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            ApiTestContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            ApiTestContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            ApiTestContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            ApiTestContentTableLayoutPanel.Size = new Size(540, 461);
            ApiTestContentTableLayoutPanel.TabIndex = 2;
            // 
            // SendServerRequestButton
            // 
            SendServerRequestButton.Anchor = AnchorStyles.Left;
            SendServerRequestButton.AutoSize = true;
            SendServerRequestButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SendServerRequestButton.Location = new Point(18, 18);
            SendServerRequestButton.Name = "SendServerRequestButton";
            SendServerRequestButton.Size = new Size(176, 25);
            SendServerRequestButton.TabIndex = 2;
            SendServerRequestButton.Text = "Sunucuya İstek At";
            SendServerRequestButton.UseVisualStyleBackColor = true;
            // 
            // ResponseGroupBox
            // 
            ResponseGroupBox.Controls.Add(ResponseTextBox);
            ResponseGroupBox.Dock = DockStyle.Fill;
            ResponseGroupBox.Location = new Point(203, 18);
            ResponseGroupBox.Name = "ResponseGroupBox";
            ResponseGroupBox.Padding = new Padding(10);
            ApiTestContentTableLayoutPanel.SetRowSpan(ResponseGroupBox, 14);
            ResponseGroupBox.Size = new Size(319, 428);
            ResponseGroupBox.TabIndex = 3;
            ResponseGroupBox.TabStop = false;
            ResponseGroupBox.Text = "Cevap";
            // 
            // ResponseTextBox
            // 
            ResponseTextBox.BackColor = Color.White;
            ResponseTextBox.BorderStyle = BorderStyle.None;
            ResponseTextBox.Dock = DockStyle.Fill;
            ResponseTextBox.ForeColor = Color.FromArgb(64, 64, 64);
            ResponseTextBox.Location = new Point(10, 26);
            ResponseTextBox.Margin = new Padding(15, 3, 3, 3);
            ResponseTextBox.Multiline = true;
            ResponseTextBox.Name = "ResponseTextBox";
            ResponseTextBox.ReadOnly = true;
            ResponseTextBox.Size = new Size(299, 392);
            ResponseTextBox.TabIndex = 0;
            // 
            // RequestSampleButton
            // 
            RequestSampleButton.Anchor = AnchorStyles.Left;
            RequestSampleButton.AutoSize = true;
            RequestSampleButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RequestSampleButton.Location = new Point(18, 49);
            RequestSampleButton.Name = "RequestSampleButton";
            RequestSampleButton.Size = new Size(176, 25);
            RequestSampleButton.TabIndex = 2;
            RequestSampleButton.Text = "Numune Aldır";
            RequestSampleButton.UseVisualStyleBackColor = true;
            // 
            // SendDiagnosticButton
            // 
            SendDiagnosticButton.Anchor = AnchorStyles.Left;
            SendDiagnosticButton.AutoSize = true;
            SendDiagnosticButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SendDiagnosticButton.Location = new Point(18, 80);
            SendDiagnosticButton.Name = "SendDiagnosticButton";
            SendDiagnosticButton.Size = new Size(176, 25);
            SendDiagnosticButton.TabIndex = 2;
            SendDiagnosticButton.Text = "Deneme Diagnostik Gönder";
            SendDiagnosticButton.UseVisualStyleBackColor = true;
            // 
            // PeriodLabel
            //
            PeriodLabel.Anchor = AnchorStyles.Left;
            PeriodLabel.AutoSize = true;
            PeriodLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            PeriodLabel.ForeColor = Color.FromArgb(64, 64, 64);
            PeriodLabel.Location = new Point(18, 111);
            PeriodLabel.Name = "PeriodLabel";
            PeriodLabel.Size = new Size(55, 16);
            PeriodLabel.TabIndex = 4;
            PeriodLabel.Text = "Periyot";
            //
            // PeriodComboBox
            //
            PeriodComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PeriodComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PeriodComboBox.FormattingEnabled = true;
            PeriodComboBox.Location = new Point(18, 142);
            PeriodComboBox.Name = "PeriodComboBox";
            PeriodComboBox.Size = new Size(176, 23);
            PeriodComboBox.TabIndex = 5;
            //
            // GetLastDataButton
            //
            GetLastDataButton.Anchor = AnchorStyles.Left;
            GetLastDataButton.AutoSize = true;
            GetLastDataButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GetLastDataButton.Location = new Point(18, 173);
            GetLastDataButton.Name = "GetLastDataButton";
            GetLastDataButton.Size = new Size(176, 25);
            GetLastDataButton.TabIndex = 6;
            GetLastDataButton.Text = "Son Veriyi Getir";
            GetLastDataButton.UseVisualStyleBackColor = true;
            //
            // GetHistoricalDataButton
            //
            GetHistoricalDataButton.Anchor = AnchorStyles.Left;
            GetHistoricalDataButton.AutoSize = true;
            GetHistoricalDataButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GetHistoricalDataButton.Location = new Point(18, 204);
            GetHistoricalDataButton.Name = "GetHistoricalDataButton";
            GetHistoricalDataButton.Size = new Size(176, 25);
            GetHistoricalDataButton.TabIndex = 7;
            GetHistoricalDataButton.Text = "Geçmiş Tüm Veriyi Getir";
            GetHistoricalDataButton.UseVisualStyleBackColor = true;
            // 
            // ApiSettingsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(StationSettingsBgTableLayoutPanel);
            Name = "ApiSettingsPage";
            Padding = new Padding(0, 15, 0, 15);
            Size = new Size(1094, 533);
            StationInfoContentTableLayoutPanel.ResumeLayout(false);
            StationInfoContentTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataSendPeriodNumericUpDown).EndInit();
            StationInfoBgTableLayoutPanel.ResumeLayout(false);
            ApiSettingsHeaderTableLayoutPanel.ResumeLayout(false);
            ApiSettingsHeaderTableLayoutPanel.PerformLayout();
            StationSettingsBgTableLayoutPanel.ResumeLayout(false);
            StationSettingsBgTableLayoutPanel.PerformLayout();
            ApiTestBgTableLayoutPanel.ResumeLayout(false);
            ApiTestContentTableLayoutPanel.ResumeLayout(false);
            ApiTestContentTableLayoutPanel.PerformLayout();
            ResponseGroupBox.ResumeLayout(false);
            ResponseGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label ApiUrlLabel;
        private TextBox ApiUrlTextBox;
        private TableLayoutPanel StationInfoContentTableLayoutPanel;
        private Label ApiUsernameLabel;
        private TableLayoutPanel StationInfoBgTableLayoutPanel;
        private Label ApiSettingsLabel;
        private Button SaveApiSettingsButton;
        private TableLayoutPanel ApiSettingsHeaderTableLayoutPanel;
        private TableLayoutPanel StationSettingsBgTableLayoutPanel;
        private Label ApiPasswordLabel;
        private TextBox ApiUsernameTextBox;
        private TextBox ApiPasswordTextBox;
        private Label SendPeriodLabel;
        private NumericUpDown DataSendPeriodNumericUpDown;
        private Label ResendPeriodLabel;
        private ComboBox ResendPeriodComboBox;
        private TableLayoutPanel ApiTestBgTableLayoutPanel;
        private TableLayoutPanel ApiTestContentTableLayoutPanel;
        private Label ApiTestLabel;
        private Button SendServerRequestButton;
        private Button RequestSampleButton;
        private Button SendDiagnosticButton;
        private Label PeriodLabel;
        private ComboBox PeriodComboBox;
        private Button GetLastDataButton;
        private Button GetHistoricalDataButton;
        private GroupBox ResponseGroupBox;
        private TextBox ResponseTextBox;
    }
}
