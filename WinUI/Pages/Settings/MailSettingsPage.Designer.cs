namespace WinUI.Pages.Settings
{
    partial class MailSettingsPage
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
            ResendPeriodLabel = new Label();
            StationInfoBgTableLayoutPanel = new TableLayoutPanel();
            ApiSettingsLabel = new Label();
            SaveApiSettingsButton = new Button();
            ApiSettingsHeaderTableLayoutPanel = new TableLayoutPanel();
            StationSettingsBgTableLayoutPanel = new TableLayoutPanel();
            ApiTestBgTableLayoutPanel = new TableLayoutPanel();
            ApiTestContentTableLayoutPanel = new TableLayoutPanel();
            SendServerRequestButton = new Button();
            ResponseGroupBox = new GroupBox();
            ResponseTextBox = new TextBox();
            SendDiagnosticButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            checkBox2 = new CheckBox();
            ApiTestLabel = new Label();
            textBox4 = new TextBox();
            StationInfoContentTableLayoutPanel.SuspendLayout();
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
            ApiUrlLabel.Size = new Size(75, 16);
            ApiUrlLabel.TabIndex = 1;
            ApiUrlLabel.Text = "SMTP Host";
            // 
            // ApiUrlTextBox
            // 
            ApiUrlTextBox.Anchor = AnchorStyles.Left;
            ApiUrlTextBox.Location = new Point(323, 19);
            ApiUrlTextBox.Name = "ApiUrlTextBox";
            ApiUrlTextBox.PlaceholderText = "localhost";
            ApiUrlTextBox.Size = new Size(199, 23);
            ApiUrlTextBox.TabIndex = 2;
            // 
            // StationInfoContentTableLayoutPanel
            // 
            StationInfoContentTableLayoutPanel.BackColor = Color.White;
            StationInfoContentTableLayoutPanel.ColumnCount = 2;
            StationInfoContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.80392F));
            StationInfoContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.19608F));
            StationInfoContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            StationInfoContentTableLayoutPanel.Controls.Add(ApiUrlLabel, 0, 0);
            StationInfoContentTableLayoutPanel.Controls.Add(ApiUrlTextBox, 1, 0);
            StationInfoContentTableLayoutPanel.Controls.Add(ApiUsernameTextBox, 1, 1);
            StationInfoContentTableLayoutPanel.Controls.Add(ApiPasswordTextBox, 1, 2);
            StationInfoContentTableLayoutPanel.Controls.Add(ResendPeriodLabel, 0, 4);
            StationInfoContentTableLayoutPanel.Controls.Add(label1, 0, 5);
            StationInfoContentTableLayoutPanel.Controls.Add(label2, 0, 6);
            StationInfoContentTableLayoutPanel.Controls.Add(label3, 0, 7);
            StationInfoContentTableLayoutPanel.Controls.Add(SendPeriodLabel, 0, 1);
            StationInfoContentTableLayoutPanel.Controls.Add(ApiPasswordLabel, 0, 3);
            StationInfoContentTableLayoutPanel.Controls.Add(ApiUsernameLabel, 0, 2);
            StationInfoContentTableLayoutPanel.Controls.Add(checkBox1, 1, 4);
            StationInfoContentTableLayoutPanel.Controls.Add(textBox1, 1, 5);
            StationInfoContentTableLayoutPanel.Controls.Add(textBox2, 1, 3);
            StationInfoContentTableLayoutPanel.Controls.Add(textBox3, 1, 6);
            StationInfoContentTableLayoutPanel.Controls.Add(checkBox2, 1, 7);
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
            ApiUsernameLabel.Location = new Point(18, 84);
            ApiUsernameLabel.Name = "ApiUsernameLabel";
            ApiUsernameLabel.Size = new Size(129, 16);
            ApiUsernameLabel.TabIndex = 1;
            ApiUsernameLabel.Text = "SMTP Kullanıcı Adı";
            // 
            // ApiPasswordLabel
            // 
            ApiPasswordLabel.Anchor = AnchorStyles.Left;
            ApiPasswordLabel.AutoSize = true;
            ApiPasswordLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ApiPasswordLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ApiPasswordLabel.Location = new Point(18, 115);
            ApiPasswordLabel.Name = "ApiPasswordLabel";
            ApiPasswordLabel.Size = new Size(88, 16);
            ApiPasswordLabel.TabIndex = 1;
            ApiPasswordLabel.Text = "SMTP Şifresi";
            // 
            // ApiUsernameTextBox
            // 
            ApiUsernameTextBox.Anchor = AnchorStyles.Left;
            ApiUsernameTextBox.Location = new Point(323, 50);
            ApiUsernameTextBox.Name = "ApiUsernameTextBox";
            ApiUsernameTextBox.PlaceholderText = "api_user";
            ApiUsernameTextBox.Size = new Size(199, 23);
            ApiUsernameTextBox.TabIndex = 2;
            // 
            // ApiPasswordTextBox
            // 
            ApiPasswordTextBox.Anchor = AnchorStyles.Left;
            ApiPasswordTextBox.Location = new Point(323, 81);
            ApiPasswordTextBox.Name = "ApiPasswordTextBox";
            ApiPasswordTextBox.PlaceholderText = "api_pass";
            ApiPasswordTextBox.Size = new Size(199, 23);
            ApiPasswordTextBox.TabIndex = 2;
            // 
            // SendPeriodLabel
            // 
            SendPeriodLabel.Anchor = AnchorStyles.Left;
            SendPeriodLabel.AutoSize = true;
            SendPeriodLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            SendPeriodLabel.ForeColor = Color.FromArgb(64, 64, 64);
            SendPeriodLabel.Location = new Point(18, 53);
            SendPeriodLabel.Name = "SendPeriodLabel";
            SendPeriodLabel.Size = new Size(74, 16);
            SendPeriodLabel.TabIndex = 1;
            SendPeriodLabel.Text = "SMPT Port";
            // 
            // ResendPeriodLabel
            // 
            ResendPeriodLabel.Anchor = AnchorStyles.Left;
            ResendPeriodLabel.AutoSize = true;
            ResendPeriodLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ResendPeriodLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ResendPeriodLabel.Location = new Point(18, 146);
            ResendPeriodLabel.Name = "ResendPeriodLabel";
            ResendPeriodLabel.Size = new Size(132, 16);
            ResendPeriodLabel.TabIndex = 1;
            ResendPeriodLabel.Text = "SSL Kullanılsın mı?";
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
            ApiSettingsLabel.Size = new Size(223, 22);
            ApiSettingsLabel.TabIndex = 0;
            ApiSettingsLabel.Text = "Mail Sunucusu Ayarları";
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
            ApiTestContentTableLayoutPanel.Controls.Add(textBox4, 0, 2);
            ApiTestContentTableLayoutPanel.Controls.Add(SendDiagnosticButton, 0, 3);
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
            // SendDiagnosticButton
            // 
            SendDiagnosticButton.Anchor = AnchorStyles.Left;
            SendDiagnosticButton.AutoSize = true;
            SendDiagnosticButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SendDiagnosticButton.Location = new Point(18, 111);
            SendDiagnosticButton.Name = "SendDiagnosticButton";
            SendDiagnosticButton.Size = new Size(176, 25);
            SendDiagnosticButton.TabIndex = 2;
            SendDiagnosticButton.Text = "Deneme E-Posta gönder";
            SendDiagnosticButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(18, 177);
            label1.Name = "label1";
            label1.Size = new Size(121, 16);
            label1.TabIndex = 1;
            label1.Text = "Gönderen E-Posta";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(18, 208);
            label2.Name = "label2";
            label2.Size = new Size(155, 16);
            label2.TabIndex = 1;
            label2.Text = "Gönderen Kullanıcı Adı";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(18, 239);
            label3.Name = "label3";
            label3.Size = new Size(286, 16);
            label3.TabIndex = 1;
            label3.Text = "Varsayılan Kullanıcı Bilgileri Kullanılsın mı?";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(323, 142);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(59, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Kullan";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left;
            textBox1.Location = new Point(323, 174);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "api_pass";
            textBox1.Size = new Size(199, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left;
            textBox2.Location = new Point(323, 112);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "api_pass";
            textBox2.Size = new Size(199, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left;
            textBox3.Location = new Point(323, 205);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "api_pass";
            textBox3.Size = new Size(199, 23);
            textBox3.TabIndex = 2;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(323, 235);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(59, 19);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "Kullan";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // ApiTestLabel
            // 
            ApiTestLabel.AutoSize = true;
            ApiTestLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ApiTestLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ApiTestLabel.Location = new Point(550, 0);
            ApiTestLabel.Name = "ApiTestLabel";
            ApiTestLabel.Size = new Size(198, 22);
            ApiTestLabel.TabIndex = 0;
            ApiTestLabel.Text = "Mail Sunucusu Testi";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Left;
            textBox4.Location = new Point(18, 81);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Gönderilecek Mail Adresi";
            textBox4.Size = new Size(179, 23);
            textBox4.TabIndex = 2;
            // 
            // MailSettingsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(StationSettingsBgTableLayoutPanel);
            Name = "MailSettingsPage";
            Padding = new Padding(0, 15, 0, 15);
            Size = new Size(1094, 533);
            StationInfoContentTableLayoutPanel.ResumeLayout(false);
            StationInfoContentTableLayoutPanel.PerformLayout();
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
        private Label ResendPeriodLabel;
        private TableLayoutPanel ApiTestBgTableLayoutPanel;
        private TableLayoutPanel ApiTestContentTableLayoutPanel;
        private Button SendServerRequestButton;
        private Button SendDiagnosticButton;
        private GroupBox ResponseGroupBox;
        private TextBox ResponseTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private CheckBox checkBox2;
        private Label ApiTestLabel;
        private TextBox textBox4;
    }
}
