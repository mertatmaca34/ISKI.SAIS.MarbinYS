namespace WinUI.StationSetup.Pages
{
    partial class ApiSetupPage
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
            StationInfoBgTableLayoutPanel = new TableLayoutPanel();
            StationInfoContentTableLayoutPanel = new TableLayoutPanel();
            ApiUrlLabel = new Label();
            button1 = new Button();
            ApiUrlTextBox = new TextBox();
            ApiUsernameLabel = new Label();
            ApiPasswordLabel = new Label();
            SendPeriodLabel = new Label();
            ResendPeriodLabel = new Label();
            ApiUsernameTextBox = new TextBox();
            ApiPasswordTextBox = new TextBox();
            DataSendPeriodNumericUpDown = new NumericUpDown();
            ResendPeriodComboBox = new ComboBox();
            ApiSettingsHeaderTableLayoutPanel = new TableLayoutPanel();
            ApiSettingsLabel = new Label();
            SaveApiSettingsButton = new Button();
            StationSettingsBgTableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label2 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            button2 = new Button();
            StationInfoBgTableLayoutPanel.SuspendLayout();
            StationInfoContentTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataSendPeriodNumericUpDown).BeginInit();
            ApiSettingsHeaderTableLayoutPanel.SuspendLayout();
            StationSettingsBgTableLayoutPanel.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            StationInfoContentTableLayoutPanel.Controls.Add(button1, 1, 6);
            StationInfoContentTableLayoutPanel.Controls.Add(ApiUrlTextBox, 1, 0);
            StationInfoContentTableLayoutPanel.Controls.Add(ApiUsernameLabel, 0, 1);
            StationInfoContentTableLayoutPanel.Controls.Add(ApiPasswordLabel, 0, 2);
            StationInfoContentTableLayoutPanel.Controls.Add(SendPeriodLabel, 0, 3);
            StationInfoContentTableLayoutPanel.Controls.Add(ResendPeriodLabel, 0, 4);
            StationInfoContentTableLayoutPanel.Controls.Add(ApiUsernameTextBox, 1, 1);
            StationInfoContentTableLayoutPanel.Controls.Add(ApiPasswordTextBox, 1, 2);
            StationInfoContentTableLayoutPanel.Controls.Add(DataSendPeriodNumericUpDown, 1, 3);
            StationInfoContentTableLayoutPanel.Controls.Add(ResendPeriodComboBox, 1, 4);
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
            ApiUrlLabel.Size = new Size(59, 16);
            ApiUrlLabel.TabIndex = 1;
            ApiUrlLabel.Text = "API URL";
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(203, 204);
            button1.Name = "button1";
            button1.Size = new Size(246, 25);
            button1.TabIndex = 2;
            button1.Text = "Bağlantıyı Test Et";
            button1.UseVisualStyleBackColor = true;
            // 
            // ApiUrlTextBox
            // 
            ApiUrlTextBox.Anchor = AnchorStyles.Left;
            ApiUrlTextBox.Location = new Point(203, 19);
            ApiUrlTextBox.Name = "ApiUrlTextBox";
            ApiUrlTextBox.PlaceholderText = "localhost";
            ApiUrlTextBox.Size = new Size(246, 23);
            ApiUrlTextBox.TabIndex = 2;
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
            // ApiUsernameTextBox
            // 
            ApiUsernameTextBox.Anchor = AnchorStyles.Left;
            ApiUsernameTextBox.Location = new Point(203, 50);
            ApiUsernameTextBox.Name = "ApiUsernameTextBox";
            ApiUsernameTextBox.PlaceholderText = "api_user";
            ApiUsernameTextBox.Size = new Size(246, 23);
            ApiUsernameTextBox.TabIndex = 2;
            // 
            // ApiPasswordTextBox
            // 
            ApiPasswordTextBox.Anchor = AnchorStyles.Left;
            ApiPasswordTextBox.Location = new Point(203, 81);
            ApiPasswordTextBox.Name = "ApiPasswordTextBox";
            ApiPasswordTextBox.PlaceholderText = "api_pass";
            ApiPasswordTextBox.Size = new Size(246, 23);
            ApiPasswordTextBox.TabIndex = 2;
            // 
            // DataSendPeriodNumericUpDown
            // 
            DataSendPeriodNumericUpDown.Anchor = AnchorStyles.Left;
            DataSendPeriodNumericUpDown.Location = new Point(203, 112);
            DataSendPeriodNumericUpDown.Maximum = new decimal(new int[] { 1440, 0, 0, 0 });
            DataSendPeriodNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            DataSendPeriodNumericUpDown.Name = "DataSendPeriodNumericUpDown";
            DataSendPeriodNumericUpDown.Size = new Size(246, 23);
            DataSendPeriodNumericUpDown.TabIndex = 3;
            DataSendPeriodNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ResendPeriodComboBox
            // 
            ResendPeriodComboBox.Anchor = AnchorStyles.Left;
            ResendPeriodComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ResendPeriodComboBox.FormattingEnabled = true;
            ResendPeriodComboBox.Location = new Point(203, 143);
            ResendPeriodComboBox.Name = "ResendPeriodComboBox";
            ResendPeriodComboBox.Size = new Size(246, 23);
            ResendPeriodComboBox.TabIndex = 4;
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
            ApiSettingsLabel.Size = new Size(224, 22);
            ApiSettingsLabel.TabIndex = 0;
            ApiSettingsLabel.Text = "API Ayarları ve Bağlantı";
            // 
            // SaveApiSettingsButton
            // 
            SaveApiSettingsButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SaveApiSettingsButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveApiSettingsButton.Location = new Point(379, 3);
            SaveApiSettingsButton.Name = "SaveApiSettingsButton";
            SaveApiSettingsButton.Size = new Size(92, 32);
            SaveApiSettingsButton.TabIndex = 2;
            SaveApiSettingsButton.Text = "Kaydet";
            SaveApiSettingsButton.UseVisualStyleBackColor = true;
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
            StationSettingsBgTableLayoutPanel.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.35294F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.6470566F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(label4, 1, 0);
            tableLayoutPanel2.Controls.Add(label5, 0, 1);
            tableLayoutPanel2.Controls.Add(label6, 1, 1);
            tableLayoutPanel2.Controls.Add(label2, 0, 3);
            tableLayoutPanel2.Controls.Add(label7, 0, 2);
            tableLayoutPanel2.Controls.Add(label8, 1, 2);
            tableLayoutPanel2.Controls.Add(label9, 1, 3);
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
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(18, 22);
            label3.Name = "label3";
            label3.Size = new Size(114, 16);
            label3.TabIndex = 1;
            label3.Text = "Bağlantı Durumu";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(205, 22);
            label4.Name = "label4";
            label4.Size = new Size(11, 16);
            label4.TabIndex = 1;
            label4.Text = "-";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(18, 53);
            label5.Name = "label5";
            label5.Size = new Size(157, 16);
            label5.TabIndex = 1;
            label5.Text = "Oturum Başlangıç Saati";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(205, 53);
            label6.Name = "label6";
            label6.Size = new Size(11, 16);
            label6.TabIndex = 1;
            label6.Text = "-";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(18, 115);
            label2.Name = "label2";
            label2.Size = new Size(117, 16);
            label2.TabIndex = 1;
            label2.Text = "Api Sunucu Saati";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(18, 84);
            label7.Name = "label7";
            label7.Size = new Size(178, 16);
            label7.TabIndex = 1;
            label7.Text = "Oturumun Sona Eriş Süresi";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(205, 84);
            label8.Name = "label8";
            label8.Size = new Size(11, 16);
            label8.TabIndex = 1;
            label8.Text = "-";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.ForeColor = Color.FromArgb(64, 64, 64);
            label9.Location = new Point(205, 115);
            label9.Name = "label9";
            label9.Size = new Size(11, 16);
            label9.TabIndex = 1;
            label9.Text = "-";
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
            label1.Size = new Size(222, 22);
            label1.TabIndex = 0;
            label1.Text = "Api Endpoint Cevapları";
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
            // ApiSetupPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(StationSettingsBgTableLayoutPanel);
            Name = "ApiSetupPage";
            Padding = new Padding(15);
            Size = new Size(978, 361);
            StationInfoBgTableLayoutPanel.ResumeLayout(false);
            StationInfoContentTableLayoutPanel.ResumeLayout(false);
            StationInfoContentTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataSendPeriodNumericUpDown).EndInit();
            ApiSettingsHeaderTableLayoutPanel.ResumeLayout(false);
            ApiSettingsHeaderTableLayoutPanel.PerformLayout();
            StationSettingsBgTableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel StationInfoBgTableLayoutPanel;
        private TableLayoutPanel StationInfoContentTableLayoutPanel;
        private Label ApiUrlLabel;
        private Button button1;
        private TextBox ApiUrlTextBox;
        private Label ApiUsernameLabel;
        private Label ApiPasswordLabel;
        private Label SendPeriodLabel;
        private Label ResendPeriodLabel;
        private TextBox ApiUsernameTextBox;
        private TextBox ApiPasswordTextBox;
        private NumericUpDown DataSendPeriodNumericUpDown;
        private ComboBox ResendPeriodComboBox;
        private TableLayoutPanel ApiSettingsHeaderTableLayoutPanel;
        private Label ApiSettingsLabel;
        private Button SaveApiSettingsButton;
        private TableLayoutPanel StationSettingsBgTableLayoutPanel;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Button button2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}
