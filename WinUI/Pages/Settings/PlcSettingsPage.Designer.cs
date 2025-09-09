namespace WinUI.Pages.Settings
{
    partial class PlcSettingsPage
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
            MailUsersLabel = new Label();
            MailUsersHeaderTableLayoutPanel = new TableLayoutPanel();
            EditUserLabel = new Label();
            StationSettingsContentTableLayoutPanel = new TableLayoutPanel();
            ResponseGroupBox = new GroupBox();
            ResponseTextBox = new TextBox();
            button1 = new Button();
            EditUserHeaderTableLayoutPanel = new TableLayoutPanel();
            StationSettingsBgTableLayoutPanel = new TableLayoutPanel();
            StationInfoBgTableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            textBox1 = new TextBox();
            SaveButton = new Button();
            MailUsersHeaderTableLayoutPanel.SuspendLayout();
            StationSettingsContentTableLayoutPanel.SuspendLayout();
            ResponseGroupBox.SuspendLayout();
            EditUserHeaderTableLayoutPanel.SuspendLayout();
            StationSettingsBgTableLayoutPanel.SuspendLayout();
            StationInfoBgTableLayoutPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // MailUsersLabel
            // 
            MailUsersLabel.AutoSize = true;
            MailUsersLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            MailUsersLabel.ForeColor = Color.FromArgb(64, 64, 64);
            MailUsersLabel.Location = new Point(3, 0);
            MailUsersLabel.Name = "MailUsersLabel";
            MailUsersLabel.Size = new Size(124, 22);
            MailUsersLabel.TabIndex = 0;
            MailUsersLabel.Text = "PLC Ayarları";
            // 
            // MailUsersHeaderTableLayoutPanel
            // 
            MailUsersHeaderTableLayoutPanel.ColumnCount = 2;
            MailUsersHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            MailUsersHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            MailUsersHeaderTableLayoutPanel.Controls.Add(SaveButton, 1, 0);
            MailUsersHeaderTableLayoutPanel.Controls.Add(MailUsersLabel, 0, 0);
            MailUsersHeaderTableLayoutPanel.Dock = DockStyle.Fill;
            MailUsersHeaderTableLayoutPanel.Location = new Point(0, 15);
            MailUsersHeaderTableLayoutPanel.Margin = new Padding(0);
            MailUsersHeaderTableLayoutPanel.Name = "MailUsersHeaderTableLayoutPanel";
            MailUsersHeaderTableLayoutPanel.RowCount = 1;
            MailUsersHeaderTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            MailUsersHeaderTableLayoutPanel.Size = new Size(547, 40);
            MailUsersHeaderTableLayoutPanel.TabIndex = 3;
            // 
            // EditUserLabel
            // 
            EditUserLabel.AutoSize = true;
            EditUserLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            EditUserLabel.ForeColor = Color.FromArgb(64, 64, 64);
            EditUserLabel.Location = new Point(3, 0);
            EditUserLabel.Name = "EditUserLabel";
            EditUserLabel.Size = new Size(99, 22);
            EditUserLabel.TabIndex = 0;
            EditUserLabel.Text = "PLC Test ";
            // 
            // StationSettingsContentTableLayoutPanel
            // 
            StationSettingsContentTableLayoutPanel.BackColor = Color.White;
            StationSettingsContentTableLayoutPanel.ColumnCount = 2;
            StationSettingsContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.3125F));
            StationSettingsContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.6875F));
            StationSettingsContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            StationSettingsContentTableLayoutPanel.Controls.Add(ResponseGroupBox, 1, 0);
            StationSettingsContentTableLayoutPanel.Controls.Add(button1, 0, 0);
            StationSettingsContentTableLayoutPanel.Dock = DockStyle.Fill;
            StationSettingsContentTableLayoutPanel.Location = new Point(547, 55);
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
            // ResponseGroupBox
            // 
            ResponseGroupBox.Controls.Add(ResponseTextBox);
            ResponseGroupBox.Dock = DockStyle.Fill;
            ResponseGroupBox.Location = new Point(122, 18);
            ResponseGroupBox.Name = "ResponseGroupBox";
            ResponseGroupBox.Padding = new Padding(10);
            StationSettingsContentTableLayoutPanel.SetRowSpan(ResponseGroupBox, 14);
            ResponseGroupBox.Size = new Size(402, 428);
            ResponseGroupBox.TabIndex = 4;
            ResponseGroupBox.TabStop = false;
            ResponseGroupBox.Text = "Cevap";
            // 
            // ResponseTextBox
            // 
            ResponseTextBox.BorderStyle = BorderStyle.None;
            ResponseTextBox.Dock = DockStyle.Fill;
            ResponseTextBox.ForeColor = Color.FromArgb(64, 64, 64);
            ResponseTextBox.Location = new Point(10, 26);
            ResponseTextBox.Margin = new Padding(15, 3, 3, 3);
            ResponseTextBox.Multiline = true;
            ResponseTextBox.Name = "ResponseTextBox";
            ResponseTextBox.Size = new Size(382, 392);
            ResponseTextBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(18, 18);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Ping At";
            button1.UseVisualStyleBackColor = true;
            button1.Click += PingButton_Click;
            // 
            // EditUserHeaderTableLayoutPanel
            // 
            EditUserHeaderTableLayoutPanel.ColumnCount = 2;
            EditUserHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            EditUserHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            EditUserHeaderTableLayoutPanel.Controls.Add(EditUserLabel, 0, 0);
            EditUserHeaderTableLayoutPanel.Dock = DockStyle.Fill;
            EditUserHeaderTableLayoutPanel.Location = new Point(547, 15);
            EditUserHeaderTableLayoutPanel.Margin = new Padding(0);
            EditUserHeaderTableLayoutPanel.Name = "EditUserHeaderTableLayoutPanel";
            EditUserHeaderTableLayoutPanel.RowCount = 1;
            EditUserHeaderTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            EditUserHeaderTableLayoutPanel.Size = new Size(547, 40);
            EditUserHeaderTableLayoutPanel.TabIndex = 4;
            // 
            // StationSettingsBgTableLayoutPanel
            // 
            StationSettingsBgTableLayoutPanel.ColumnCount = 2;
            StationSettingsBgTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            StationSettingsBgTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            StationSettingsBgTableLayoutPanel.Controls.Add(StationSettingsContentTableLayoutPanel, 1, 1);
            StationSettingsBgTableLayoutPanel.Controls.Add(EditUserHeaderTableLayoutPanel, 1, 0);
            StationSettingsBgTableLayoutPanel.Controls.Add(MailUsersHeaderTableLayoutPanel, 0, 0);
            StationSettingsBgTableLayoutPanel.Controls.Add(StationInfoBgTableLayoutPanel, 0, 1);
            StationSettingsBgTableLayoutPanel.Dock = DockStyle.Fill;
            StationSettingsBgTableLayoutPanel.Location = new Point(0, 0);
            StationSettingsBgTableLayoutPanel.Name = "StationSettingsBgTableLayoutPanel";
            StationSettingsBgTableLayoutPanel.Padding = new Padding(0, 15, 0, 15);
            StationSettingsBgTableLayoutPanel.RowCount = 2;
            StationSettingsBgTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            StationSettingsBgTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            StationSettingsBgTableLayoutPanel.Size = new Size(1094, 533);
            StationSettingsBgTableLayoutPanel.TabIndex = 3;
            // 
            // StationInfoBgTableLayoutPanel
            // 
            StationInfoBgTableLayoutPanel.BackColor = Color.FromArgb(235, 235, 235);
            StationInfoBgTableLayoutPanel.ColumnCount = 1;
            StationInfoBgTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            StationInfoBgTableLayoutPanel.Controls.Add(tableLayoutPanel1, 0, 0);
            StationInfoBgTableLayoutPanel.Dock = DockStyle.Fill;
            StationInfoBgTableLayoutPanel.Location = new Point(0, 55);
            StationInfoBgTableLayoutPanel.Margin = new Padding(0, 0, 5, 0);
            StationInfoBgTableLayoutPanel.Name = "StationInfoBgTableLayoutPanel";
            StationInfoBgTableLayoutPanel.RowCount = 1;
            StationInfoBgTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            StationInfoBgTableLayoutPanel.Size = new Size(542, 463);
            StationInfoBgTableLayoutPanel.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.35294F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.6470566F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0, 0, 5, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(15);
            tableLayoutPanel1.RowCount = 14;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.Size = new Size(537, 463);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(18, 22);
            label1.Name = "label1";
            label1.Size = new Size(64, 16);
            label1.TabIndex = 1;
            label1.Text = "IP Adresi";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left;
            textBox1.Location = new Point(232, 19);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "0.0.0.0";
            textBox1.Size = new Size(287, 23);
            textBox1.TabIndex = 2;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SaveButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveButton.Location = new Point(452, 3);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(92, 32);
            SaveButton.TabIndex = 3;
            SaveButton.Text = "Kaydet";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // PlcSettingsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(StationSettingsBgTableLayoutPanel);
            Name = "PlcSettingsPage";
            Size = new Size(1094, 533);
            MailUsersHeaderTableLayoutPanel.ResumeLayout(false);
            MailUsersHeaderTableLayoutPanel.PerformLayout();
            StationSettingsContentTableLayoutPanel.ResumeLayout(false);
            ResponseGroupBox.ResumeLayout(false);
            ResponseGroupBox.PerformLayout();
            EditUserHeaderTableLayoutPanel.ResumeLayout(false);
            EditUserHeaderTableLayoutPanel.PerformLayout();
            StationSettingsBgTableLayoutPanel.ResumeLayout(false);
            StationInfoBgTableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label MailUsersLabel;
        private TableLayoutPanel MailUsersHeaderTableLayoutPanel;
        private Label EditUserLabel;
        private TableLayoutPanel StationSettingsContentTableLayoutPanel;
        private TableLayoutPanel EditUserHeaderTableLayoutPanel;
        private TableLayoutPanel StationSettingsBgTableLayoutPanel;
        private TableLayoutPanel StationInfoBgTableLayoutPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private GroupBox ResponseGroupBox;
        private TextBox ResponseTextBox;
        private Button SaveButton;
    }
}
