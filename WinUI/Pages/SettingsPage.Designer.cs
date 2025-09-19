namespace WinUI.Pages
{
    partial class SettingsPage
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
            nameColumn = new DataGridViewTextBoxColumn();
            valueColumn = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            titleBarControl1 = new WinUI.Controls.IBKS.TitleBarControl();
            PanelContent = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            PlcButton = new Button();
            CalibrationButton = new Button();
            ApiButton = new Button();
            DatabaseButton = new Button();
            StationButton = new Button();
            MailSettingsButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            PanelContent.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // nameColumn
            // 
            nameColumn.Name = "nameColumn";
            // 
            // valueColumn
            // 
            valueColumn.Name = "valueColumn";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(titleBarControl1, 0, 0);
            tableLayoutPanel1.Controls.Add(PanelContent, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(8);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1170, 677);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // titleBarControl1
            // 
            titleBarControl1.BackColor = Color.FromArgb(235, 235, 235);
            tableLayoutPanel1.SetColumnSpan(titleBarControl1, 2);
            titleBarControl1.Dock = DockStyle.Fill;
            titleBarControl1.Location = new Point(11, 11);
            titleBarControl1.Name = "titleBarControl1";
            titleBarControl1.Padding = new Padding(1);
            titleBarControl1.Size = new Size(1148, 32);
            titleBarControl1.TabIndex = 0;
            titleBarControl1.TitleBarText = "Ayarlar";
            // 
            // PanelContent
            // 
            tableLayoutPanel1.SetColumnSpan(PanelContent, 2);
            PanelContent.Controls.Add(tableLayoutPanel2);
            PanelContent.Dock = DockStyle.Fill;
            PanelContent.Location = new Point(8, 46);
            PanelContent.Margin = new Padding(0);
            PanelContent.Name = "PanelContent";
            PanelContent.Padding = new Padding(60, 30, 0, 60);
            tableLayoutPanel1.SetRowSpan(PanelContent, 2);
            PanelContent.Size = new Size(1154, 623);
            PanelContent.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(MailSettingsButton, 1, 1);
            tableLayoutPanel2.Controls.Add(PlcButton, 2, 0);
            tableLayoutPanel2.Controls.Add(CalibrationButton, 0, 1);
            tableLayoutPanel2.Controls.Add(ApiButton, 3, 0);
            tableLayoutPanel2.Controls.Add(DatabaseButton, 1, 0);
            tableLayoutPanel2.Controls.Add(StationButton, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(60, 30);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1094, 533);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // PlcButton
            // 
            PlcButton.Dock = DockStyle.Fill;
            PlcButton.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            PlcButton.Image = Properties.Resources.plc;
            PlcButton.Location = new Point(549, 3);
            PlcButton.Name = "PlcButton";
            PlcButton.Size = new Size(267, 260);
            PlcButton.TabIndex = 7;
            PlcButton.Text = "PLC";
            PlcButton.TextAlign = ContentAlignment.BottomCenter;
            PlcButton.TextImageRelation = TextImageRelation.ImageAboveText;
            PlcButton.UseVisualStyleBackColor = true;
            PlcButton.Click += PlcButton_Click;
            // 
            // CalibrationButton
            // 
            CalibrationButton.Dock = DockStyle.Fill;
            CalibrationButton.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            CalibrationButton.Image = Properties.Resources.azimuth_96px;
            CalibrationButton.Location = new Point(3, 269);
            CalibrationButton.Name = "CalibrationButton";
            CalibrationButton.Size = new Size(267, 261);
            CalibrationButton.TabIndex = 3;
            CalibrationButton.Text = "Kalibrasyon";
            CalibrationButton.TextAlign = ContentAlignment.BottomCenter;
            CalibrationButton.TextImageRelation = TextImageRelation.ImageAboveText;
            CalibrationButton.UseVisualStyleBackColor = true;
            CalibrationButton.Click += ButtonCalibration_Click;
            // 
            // ApiButton
            // 
            ApiButton.Dock = DockStyle.Fill;
            ApiButton.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ApiButton.Image = Properties.Resources.api_96px;
            ApiButton.Location = new Point(822, 3);
            ApiButton.Name = "ApiButton";
            ApiButton.Size = new Size(269, 260);
            ApiButton.TabIndex = 2;
            ApiButton.Text = "API";
            ApiButton.TextAlign = ContentAlignment.BottomCenter;
            ApiButton.TextImageRelation = TextImageRelation.ImageAboveText;
            ApiButton.UseVisualStyleBackColor = true;
            ApiButton.Click += ApiButton_Click;
            // 
            // DatabaseButton
            // 
            DatabaseButton.Dock = DockStyle.Fill;
            DatabaseButton.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            DatabaseButton.Image = Properties.Resources.database_96px;
            DatabaseButton.Location = new Point(276, 3);
            DatabaseButton.Name = "DatabaseButton";
            DatabaseButton.Size = new Size(267, 260);
            DatabaseButton.TabIndex = 1;
            DatabaseButton.Text = "Veritabanı";
            DatabaseButton.TextAlign = ContentAlignment.BottomCenter;
            DatabaseButton.TextImageRelation = TextImageRelation.ImageAboveText;
            DatabaseButton.UseVisualStyleBackColor = true;
            DatabaseButton.Click += DatabaseButton_Click;
            // 
            // StationButton
            // 
            StationButton.Dock = DockStyle.Fill;
            StationButton.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            StationButton.Image = Properties.Resources.location_96px;
            StationButton.Location = new Point(3, 3);
            StationButton.Name = "StationButton";
            StationButton.Size = new Size(267, 260);
            StationButton.TabIndex = 0;
            StationButton.Text = "İstasyon";
            StationButton.TextAlign = ContentAlignment.BottomCenter;
            StationButton.TextImageRelation = TextImageRelation.ImageAboveText;
            StationButton.UseVisualStyleBackColor = true;
            StationButton.Click += StationButton_Click;
            // 
            // MailSettingsButton
            // 
            MailSettingsButton.Dock = DockStyle.Fill;
            MailSettingsButton.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            MailSettingsButton.Image = Properties.Resources.mail_configuration_96px;
            MailSettingsButton.Location = new Point(276, 269);
            MailSettingsButton.Name = "MailSettingsButton";
            MailSettingsButton.Size = new Size(267, 261);
            MailSettingsButton.TabIndex = 8;
            MailSettingsButton.Text = "Mail Ayarları";
            MailSettingsButton.TextAlign = ContentAlignment.BottomCenter;
            MailSettingsButton.TextImageRelation = TextImageRelation.ImageAboveText;
            MailSettingsButton.UseVisualStyleBackColor = true;
            MailSettingsButton.Click += MailSettingsButton_Click;
            // 
            // SettingsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "SettingsPage";
            Size = new Size(1170, 677);
            tableLayoutPanel1.ResumeLayout(false);
            PanelContent.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn valueColumn;
        private TableLayoutPanel tableLayoutPanel1;
        private Controls.IBKS.TitleBarControl titleBarControl1;
        private Panel PanelContent;
        private TableLayoutPanel tableLayoutPanel2;
        private Button CalibrationButton;
        private Button ApiButton;
        private Button DatabaseButton;
        private Button StationButton;
        private Button PlcButton;
        private Button MailSettingsButton;
    }
}
