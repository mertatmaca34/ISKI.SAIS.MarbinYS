namespace WinUI.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            SideBarTableLayoutPanel = new TableLayoutPanel();
            HomePageButton = new Button();
            SimulationPageButton = new Button();
            CalibrationPageButton = new Button();
            ReportingPageButton = new Button();
            MailPageButton = new Button();
            SettingsPageButton = new Button();
            LoginButton = new Button();
            MainContentPanel = new Panel();
            SideBarTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SideBarTableLayoutPanel
            // 
            SideBarTableLayoutPanel.BackColor = Color.White;
            SideBarTableLayoutPanel.ColumnCount = 1;
            SideBarTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            SideBarTableLayoutPanel.Controls.Add(HomePageButton, 0, 0);
            SideBarTableLayoutPanel.Controls.Add(SimulationPageButton, 0, 1);
            SideBarTableLayoutPanel.Controls.Add(CalibrationPageButton, 0, 2);
            SideBarTableLayoutPanel.Controls.Add(ReportingPageButton, 0, 4);
            SideBarTableLayoutPanel.Controls.Add(MailPageButton, 0, 3);
            SideBarTableLayoutPanel.Controls.Add(SettingsPageButton, 0, 5);
            SideBarTableLayoutPanel.Controls.Add(LoginButton, 0, 7);
            SideBarTableLayoutPanel.Dock = DockStyle.Left;
            SideBarTableLayoutPanel.Location = new Point(0, 0);
            SideBarTableLayoutPanel.Name = "SideBarTableLayoutPanel";
            SideBarTableLayoutPanel.RowCount = 8;
            SideBarTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            SideBarTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            SideBarTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            SideBarTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            SideBarTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            SideBarTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            SideBarTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            SideBarTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            SideBarTableLayoutPanel.Size = new Size(90, 681);
            SideBarTableLayoutPanel.TabIndex = 1;
            // 
            // HomePageButton
            // 
            HomePageButton.Anchor = AnchorStyles.None;
            HomePageButton.BackColor = Color.FromArgb(230, 230, 230);
            HomePageButton.FlatAppearance.BorderSize = 0;
            HomePageButton.FlatStyle = FlatStyle.Flat;
            HomePageButton.Font = new Font("Calibri", 8.25F);
            HomePageButton.ForeColor = Color.DimGray;
            HomePageButton.Image = Properties.Resources.filled_home_24px;
            HomePageButton.Location = new Point(8, 8);
            HomePageButton.Name = "HomePageButton";
            HomePageButton.Size = new Size(74, 68);
            HomePageButton.TabIndex = 0;
            HomePageButton.Text = "Anasayfa";
            HomePageButton.TextAlign = ContentAlignment.BottomCenter;
            HomePageButton.UseVisualStyleBackColor = false;
            HomePageButton.Click += HomePageButton_Click;
            // 
            // SimulationPageButton
            // 
            SimulationPageButton.Anchor = AnchorStyles.None;
            SimulationPageButton.FlatAppearance.BorderSize = 0;
            SimulationPageButton.FlatStyle = FlatStyle.Flat;
            SimulationPageButton.Font = new Font("Calibri", 8.25F);
            SimulationPageButton.ForeColor = Color.DimGray;
            SimulationPageButton.Image = Properties.Resources.monitor_24px;
            SimulationPageButton.Location = new Point(8, 92);
            SimulationPageButton.Name = "SimulationPageButton";
            SimulationPageButton.Size = new Size(74, 68);
            SimulationPageButton.TabIndex = 0;
            SimulationPageButton.Text = "Simülasyon";
            SimulationPageButton.TextAlign = ContentAlignment.BottomCenter;
            SimulationPageButton.UseVisualStyleBackColor = false;
            SimulationPageButton.Click += SimulationPageButton_Click;
            // 
            // CalibrationPageButton
            // 
            CalibrationPageButton.Anchor = AnchorStyles.None;
            CalibrationPageButton.FlatAppearance.BorderSize = 0;
            CalibrationPageButton.FlatStyle = FlatStyle.Flat;
            CalibrationPageButton.Font = new Font("Calibri", 8.25F);
            CalibrationPageButton.ForeColor = Color.DimGray;
            CalibrationPageButton.Image = (Image)resources.GetObject("CalibrationPageButton.Image");
            CalibrationPageButton.Location = new Point(8, 176);
            CalibrationPageButton.Name = "CalibrationPageButton";
            CalibrationPageButton.Size = new Size(74, 68);
            CalibrationPageButton.TabIndex = 0;
            CalibrationPageButton.Text = "Kalibrasyon";
            CalibrationPageButton.TextAlign = ContentAlignment.BottomCenter;
            CalibrationPageButton.UseVisualStyleBackColor = false;
            CalibrationPageButton.Click += CalibrationPageButton_Click;
            // 
            // ReportingPageButton
            // 
            ReportingPageButton.Anchor = AnchorStyles.None;
            ReportingPageButton.FlatAppearance.BorderSize = 0;
            ReportingPageButton.FlatStyle = FlatStyle.Flat;
            ReportingPageButton.Font = new Font("Calibri", 8.25F);
            ReportingPageButton.ForeColor = Color.DimGray;
            ReportingPageButton.Image = Properties.Resources.save_24px;
            ReportingPageButton.Location = new Point(8, 344);
            ReportingPageButton.Name = "ReportingPageButton";
            ReportingPageButton.Size = new Size(74, 68);
            ReportingPageButton.TabIndex = 0;
            ReportingPageButton.Text = "Raporlama";
            ReportingPageButton.TextAlign = ContentAlignment.BottomCenter;
            ReportingPageButton.UseVisualStyleBackColor = false;
            ReportingPageButton.Click += ReportingPageButton_Click;
            // 
            // MailPageButton
            // 
            MailPageButton.Anchor = AnchorStyles.None;
            MailPageButton.FlatAppearance.BorderSize = 0;
            MailPageButton.FlatStyle = FlatStyle.Flat;
            MailPageButton.Font = new Font("Calibri", 8.25F);
            MailPageButton.ForeColor = Color.DimGray;
            MailPageButton.Image = Properties.Resources.alarm_24px;
            MailPageButton.Location = new Point(8, 260);
            MailPageButton.Name = "MailPageButton";
            MailPageButton.Size = new Size(74, 68);
            MailPageButton.TabIndex = 0;
            MailPageButton.Text = "Mail";
            MailPageButton.TextAlign = ContentAlignment.BottomCenter;
            MailPageButton.UseVisualStyleBackColor = false;
            // 
            // SettingsPageButton
            // 
            SettingsPageButton.Anchor = AnchorStyles.None;
            SettingsPageButton.FlatAppearance.BorderSize = 0;
            SettingsPageButton.FlatStyle = FlatStyle.Flat;
            SettingsPageButton.Font = new Font("Calibri", 8.25F);
            SettingsPageButton.ForeColor = Color.DimGray;
            SettingsPageButton.Image = Properties.Resources.settings_24px;
            SettingsPageButton.Location = new Point(8, 428);
            SettingsPageButton.Name = "SettingsPageButton";
            SettingsPageButton.Size = new Size(74, 68);
            SettingsPageButton.TabIndex = 0;
            SettingsPageButton.Text = "Ayarlar";
            SettingsPageButton.TextAlign = ContentAlignment.BottomCenter;
            SettingsPageButton.UseVisualStyleBackColor = false;
            SettingsPageButton.Click += SettingsPageButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.None;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Calibri", 8.25F);
            LoginButton.ForeColor = Color.DimGray;
            LoginButton.Image = Properties.Resources.user_24px;
            LoginButton.Location = new Point(8, 605);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(74, 68);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Giriş Yap";
            LoginButton.TextAlign = ContentAlignment.BottomCenter;
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // MainContentPanel
            // 
            MainContentPanel.Dock = DockStyle.Fill;
            MainContentPanel.Location = new Point(90, 0);
            MainContentPanel.Name = "MainContentPanel";
            MainContentPanel.Size = new Size(1174, 681);
            MainContentPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(MainContentPanel);
            Controls.Add(SideBarTableLayoutPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "İSKİ Marbin Yönetim Sistemi";
            Load += MainForm_Load;
            SideBarTableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel SideBarTableLayoutPanel;
        private Panel MainContentPanel;
        private Button HomePageButton;
        private Button SimulationPageButton;
        private Button CalibrationPageButton;
        private Button MailPageButton;
        private Button ReportingPageButton;
        private Button SettingsPageButton;
        private Button LoginButton;
    }
}