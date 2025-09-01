namespace WinUI.Pages.Settings
{
    partial class CalibrationSettingsPage
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
            CalibrationValuesBgTableLayoutPanel = new TableLayoutPanel();
            CalibrationValuesContentTableLayoutPanel = new TableLayoutPanel();
            AkmReferenceValuesLabel = new Label();
            AkmZeroLabel = new Label();
            KoiZeroLabel = new Label();
            KoiReferenceValuesLabel = new Label();
            StationSettingsBgTableLayoutPanel = new TableLayoutPanel();
            SaveCalibrationButton = new Button();
            CalibrationHeaderTableLayoutPanel = new TableLayoutPanel();
            CalibrationSettingsLabel = new Label();
            StationInfoBgTableLayoutPanel = new TableLayoutPanel();
            StationInfoContentTableLayoutPanel = new TableLayoutPanel();
            PhZeroLabel = new Label();
            PhSpanLabel = new Label();
            PhReferenceValuesLabel = new Label();
            PhSpanComboBox = new ComboBox();
            ConductivityReferenceValuesLabel = new Label();
            ConductivityZeroLabel = new Label();
            ConductivitySpanLabel = new Label();
            PhZeroTextBox = new TextBox();
            ConductivityZeroTextBox = new TextBox();
            ConductivitySpanTextBox = new TextBox();
            AkmZeroTextBox = new TextBox();
            KoiZeroTextBox = new TextBox();
            CalibrationValuesBgTableLayoutPanel.SuspendLayout();
            CalibrationValuesContentTableLayoutPanel.SuspendLayout();
            StationSettingsBgTableLayoutPanel.SuspendLayout();
            CalibrationHeaderTableLayoutPanel.SuspendLayout();
            StationInfoBgTableLayoutPanel.SuspendLayout();
            StationInfoContentTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CalibrationValuesBgTableLayoutPanel
            // 
            CalibrationValuesBgTableLayoutPanel.BackColor = Color.FromArgb(235, 235, 235);
            CalibrationValuesBgTableLayoutPanel.ColumnCount = 1;
            CalibrationValuesBgTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            CalibrationValuesBgTableLayoutPanel.Controls.Add(CalibrationValuesContentTableLayoutPanel, 0, 0);
            CalibrationValuesBgTableLayoutPanel.Dock = DockStyle.Fill;
            CalibrationValuesBgTableLayoutPanel.Location = new Point(547, 40);
            CalibrationValuesBgTableLayoutPanel.Margin = new Padding(0, 0, 5, 0);
            CalibrationValuesBgTableLayoutPanel.Name = "CalibrationValuesBgTableLayoutPanel";
            CalibrationValuesBgTableLayoutPanel.RowCount = 1;
            CalibrationValuesBgTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            CalibrationValuesBgTableLayoutPanel.Size = new Size(542, 463);
            CalibrationValuesBgTableLayoutPanel.TabIndex = 6;
            // 
            // CalibrationValuesContentTableLayoutPanel
            // 
            CalibrationValuesContentTableLayoutPanel.BackColor = Color.White;
            CalibrationValuesContentTableLayoutPanel.ColumnCount = 2;
            CalibrationValuesContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.35294F));
            CalibrationValuesContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.6470566F));
            CalibrationValuesContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            CalibrationValuesContentTableLayoutPanel.Controls.Add(AkmReferenceValuesLabel, 0, 0);
            CalibrationValuesContentTableLayoutPanel.Controls.Add(AkmZeroLabel, 0, 1);
            CalibrationValuesContentTableLayoutPanel.Controls.Add(KoiZeroLabel, 0, 5);
            CalibrationValuesContentTableLayoutPanel.Controls.Add(KoiReferenceValuesLabel, 0, 4);
            CalibrationValuesContentTableLayoutPanel.Controls.Add(AkmZeroTextBox, 1, 1);
            CalibrationValuesContentTableLayoutPanel.Controls.Add(KoiZeroTextBox, 1, 5);
            CalibrationValuesContentTableLayoutPanel.Dock = DockStyle.Fill;
            CalibrationValuesContentTableLayoutPanel.Location = new Point(1, 1);
            CalibrationValuesContentTableLayoutPanel.Margin = new Padding(1);
            CalibrationValuesContentTableLayoutPanel.Name = "CalibrationValuesContentTableLayoutPanel";
            CalibrationValuesContentTableLayoutPanel.Padding = new Padding(15);
            CalibrationValuesContentTableLayoutPanel.RowCount = 14;
            CalibrationValuesContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            CalibrationValuesContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            CalibrationValuesContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            CalibrationValuesContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            CalibrationValuesContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            CalibrationValuesContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            CalibrationValuesContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            CalibrationValuesContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            CalibrationValuesContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            CalibrationValuesContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            CalibrationValuesContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            CalibrationValuesContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            CalibrationValuesContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            CalibrationValuesContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            CalibrationValuesContentTableLayoutPanel.Size = new Size(540, 461);
            CalibrationValuesContentTableLayoutPanel.TabIndex = 3;
            // 
            // AkmReferenceValuesLabel
            // 
            AkmReferenceValuesLabel.Anchor = AnchorStyles.Left;
            AkmReferenceValuesLabel.AutoSize = true;
            AkmReferenceValuesLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            AkmReferenceValuesLabel.ForeColor = Color.FromArgb(64, 64, 64);
            AkmReferenceValuesLabel.Location = new Point(18, 22);
            AkmReferenceValuesLabel.Name = "AkmReferenceValuesLabel";
            AkmReferenceValuesLabel.Size = new Size(159, 16);
            AkmReferenceValuesLabel.TabIndex = 1;
            AkmReferenceValuesLabel.Text = "AKM Referans Değerleri";
            // 
            // AkmZeroLabel
            // 
            AkmZeroLabel.Anchor = AnchorStyles.Left;
            AkmZeroLabel.AutoSize = true;
            AkmZeroLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            AkmZeroLabel.ForeColor = Color.FromArgb(64, 64, 64);
            AkmZeroLabel.Location = new Point(18, 53);
            AkmZeroLabel.Name = "AkmZeroLabel";
            AkmZeroLabel.Size = new Size(68, 16);
            AkmZeroLabel.TabIndex = 1;
            AkmZeroLabel.Text = "AKM Zero";
            // 
            // KoiZeroLabel
            // 
            KoiZeroLabel.Anchor = AnchorStyles.Left;
            KoiZeroLabel.AutoSize = true;
            KoiZeroLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            KoiZeroLabel.ForeColor = Color.FromArgb(64, 64, 64);
            KoiZeroLabel.Location = new Point(18, 177);
            KoiZeroLabel.Name = "KoiZeroLabel";
            KoiZeroLabel.Size = new Size(62, 16);
            KoiZeroLabel.TabIndex = 1;
            KoiZeroLabel.Text = "KOi Zero";
            // 
            // KoiReferenceValuesLabel
            // 
            KoiReferenceValuesLabel.Anchor = AnchorStyles.Left;
            KoiReferenceValuesLabel.AutoSize = true;
            KoiReferenceValuesLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            KoiReferenceValuesLabel.ForeColor = Color.FromArgb(64, 64, 64);
            KoiReferenceValuesLabel.Location = new Point(18, 146);
            KoiReferenceValuesLabel.Name = "KoiReferenceValuesLabel";
            KoiReferenceValuesLabel.Size = new Size(153, 16);
            KoiReferenceValuesLabel.TabIndex = 1;
            KoiReferenceValuesLabel.Text = "KOi Referans Değerleri";
            // 
            // StationSettingsBgTableLayoutPanel
            // 
            StationSettingsBgTableLayoutPanel.ColumnCount = 2;
            StationSettingsBgTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            StationSettingsBgTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            StationSettingsBgTableLayoutPanel.Controls.Add(CalibrationValuesBgTableLayoutPanel, 1, 1);
            StationSettingsBgTableLayoutPanel.Controls.Add(SaveCalibrationButton, 1, 0);
            StationSettingsBgTableLayoutPanel.Controls.Add(CalibrationHeaderTableLayoutPanel, 0, 0);
            StationSettingsBgTableLayoutPanel.Controls.Add(StationInfoBgTableLayoutPanel, 0, 1);
            StationSettingsBgTableLayoutPanel.Dock = DockStyle.Fill;
            StationSettingsBgTableLayoutPanel.Location = new Point(0, 15);
            StationSettingsBgTableLayoutPanel.Name = "StationSettingsBgTableLayoutPanel";
            StationSettingsBgTableLayoutPanel.RowCount = 2;
            StationSettingsBgTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            StationSettingsBgTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            StationSettingsBgTableLayoutPanel.Size = new Size(1094, 503);
            StationSettingsBgTableLayoutPanel.TabIndex = 3;
            // 
            // SaveCalibrationButton
            // 
            SaveCalibrationButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SaveCalibrationButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveCalibrationButton.Location = new Point(999, 3);
            SaveCalibrationButton.Name = "SaveCalibrationButton";
            SaveCalibrationButton.Size = new Size(92, 32);
            SaveCalibrationButton.TabIndex = 2;
            SaveCalibrationButton.Text = "Kaydet";
            SaveCalibrationButton.UseVisualStyleBackColor = true;
            // 
            // CalibrationHeaderTableLayoutPanel
            // 
            CalibrationHeaderTableLayoutPanel.ColumnCount = 2;
            CalibrationHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            CalibrationHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            CalibrationHeaderTableLayoutPanel.Controls.Add(CalibrationSettingsLabel, 0, 0);
            CalibrationHeaderTableLayoutPanel.Dock = DockStyle.Fill;
            CalibrationHeaderTableLayoutPanel.Location = new Point(0, 0);
            CalibrationHeaderTableLayoutPanel.Margin = new Padding(0);
            CalibrationHeaderTableLayoutPanel.Name = "CalibrationHeaderTableLayoutPanel";
            CalibrationHeaderTableLayoutPanel.RowCount = 1;
            CalibrationHeaderTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            CalibrationHeaderTableLayoutPanel.Size = new Size(547, 40);
            CalibrationHeaderTableLayoutPanel.TabIndex = 3;
            // 
            // CalibrationSettingsLabel
            // 
            CalibrationSettingsLabel.AutoSize = true;
            CalibrationSettingsLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            CalibrationSettingsLabel.ForeColor = Color.FromArgb(64, 64, 64);
            CalibrationSettingsLabel.Location = new Point(3, 0);
            CalibrationSettingsLabel.Name = "CalibrationSettingsLabel";
            CalibrationSettingsLabel.Size = new Size(197, 22);
            CalibrationSettingsLabel.TabIndex = 0;
            CalibrationSettingsLabel.Text = "Kalibrasyon Ayarları";
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
            StationInfoContentTableLayoutPanel.Controls.Add(PhZeroLabel, 0, 1);
            StationInfoContentTableLayoutPanel.Controls.Add(PhSpanLabel, 0, 2);
            StationInfoContentTableLayoutPanel.Controls.Add(PhReferenceValuesLabel, 0, 0);
            StationInfoContentTableLayoutPanel.Controls.Add(PhSpanComboBox, 1, 2);
            StationInfoContentTableLayoutPanel.Controls.Add(ConductivityReferenceValuesLabel, 0, 4);
            StationInfoContentTableLayoutPanel.Controls.Add(ConductivityZeroLabel, 0, 5);
            StationInfoContentTableLayoutPanel.Controls.Add(ConductivitySpanLabel, 0, 6);
            StationInfoContentTableLayoutPanel.Controls.Add(PhZeroTextBox, 1, 1);
            StationInfoContentTableLayoutPanel.Controls.Add(ConductivityZeroTextBox, 1, 5);
            StationInfoContentTableLayoutPanel.Controls.Add(ConductivitySpanTextBox, 1, 6);
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
            // PhZeroLabel
            // 
            PhZeroLabel.Anchor = AnchorStyles.Left;
            PhZeroLabel.AutoSize = true;
            PhZeroLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            PhZeroLabel.ForeColor = Color.FromArgb(64, 64, 64);
            PhZeroLabel.Location = new Point(18, 53);
            PhZeroLabel.Name = "PhZeroLabel";
            PhZeroLabel.Size = new Size(56, 16);
            PhZeroLabel.TabIndex = 1;
            PhZeroLabel.Text = "pH Zero";
            // 
            // PhSpanLabel
            // 
            PhSpanLabel.Anchor = AnchorStyles.Left;
            PhSpanLabel.AutoSize = true;
            PhSpanLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            PhSpanLabel.ForeColor = Color.FromArgb(64, 64, 64);
            PhSpanLabel.Location = new Point(18, 84);
            PhSpanLabel.Name = "PhSpanLabel";
            PhSpanLabel.Size = new Size(61, 16);
            PhSpanLabel.TabIndex = 1;
            PhSpanLabel.Text = "pH Span";
            // 
            // PhReferenceValuesLabel
            // 
            PhReferenceValuesLabel.Anchor = AnchorStyles.Left;
            PhReferenceValuesLabel.AutoSize = true;
            PhReferenceValuesLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            PhReferenceValuesLabel.ForeColor = Color.FromArgb(64, 64, 64);
            PhReferenceValuesLabel.Location = new Point(18, 22);
            PhReferenceValuesLabel.Name = "PhReferenceValuesLabel";
            PhReferenceValuesLabel.Size = new Size(147, 16);
            PhReferenceValuesLabel.TabIndex = 1;
            PhReferenceValuesLabel.Text = "pH Referans Değerleri";
            // 
            // PhSpanComboBox
            // 
            PhSpanComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PhSpanComboBox.Font = new Font("Arial", 9.75F);
            PhSpanComboBox.FormattingEnabled = true;
            PhSpanComboBox.Items.AddRange(new object[] { "4", "10" });
            PhSpanComboBox.Location = new Point(234, 80);
            PhSpanComboBox.Name = "PhSpanComboBox";
            PhSpanComboBox.Size = new Size(121, 24);
            PhSpanComboBox.TabIndex = 3;
            // 
            // ConductivityReferenceValuesLabel
            // 
            ConductivityReferenceValuesLabel.Anchor = AnchorStyles.Left;
            ConductivityReferenceValuesLabel.AutoSize = true;
            ConductivityReferenceValuesLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ConductivityReferenceValuesLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ConductivityReferenceValuesLabel.Location = new Point(18, 146);
            ConductivityReferenceValuesLabel.Name = "ConductivityReferenceValuesLabel";
            ConductivityReferenceValuesLabel.Size = new Size(188, 16);
            ConductivityReferenceValuesLabel.TabIndex = 1;
            ConductivityReferenceValuesLabel.Text = "İletkenlik Referans Değerleri";
            // 
            // ConductivityZeroLabel
            // 
            ConductivityZeroLabel.Anchor = AnchorStyles.Left;
            ConductivityZeroLabel.AutoSize = true;
            ConductivityZeroLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ConductivityZeroLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ConductivityZeroLabel.Location = new Point(18, 177);
            ConductivityZeroLabel.Name = "ConductivityZeroLabel";
            ConductivityZeroLabel.Size = new Size(97, 16);
            ConductivityZeroLabel.TabIndex = 1;
            ConductivityZeroLabel.Text = "İletkenlik Zero";
            // 
            // ConductivitySpanLabel
            // 
            ConductivitySpanLabel.Anchor = AnchorStyles.Left;
            ConductivitySpanLabel.AutoSize = true;
            ConductivitySpanLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ConductivitySpanLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ConductivitySpanLabel.Location = new Point(18, 208);
            ConductivitySpanLabel.Name = "ConductivitySpanLabel";
            ConductivitySpanLabel.Size = new Size(102, 16);
            ConductivitySpanLabel.TabIndex = 1;
            ConductivitySpanLabel.Text = "İletkenlik Span";
            // 
            // PhZeroTextBox
            // 
            PhZeroTextBox.Anchor = AnchorStyles.Left;
            PhZeroTextBox.Enabled = false;
            PhZeroTextBox.Font = new Font("Arial", 9.75F);
            PhZeroTextBox.Location = new Point(234, 50);
            PhZeroTextBox.Name = "PhZeroTextBox";
            PhZeroTextBox.Size = new Size(121, 22);
            PhZeroTextBox.TabIndex = 4;
            PhZeroTextBox.Text = "7";
            // 
            // ConductivityZeroTextBox
            // 
            ConductivityZeroTextBox.Anchor = AnchorStyles.Left;
            ConductivityZeroTextBox.Enabled = false;
            ConductivityZeroTextBox.Font = new Font("Arial", 9.75F);
            ConductivityZeroTextBox.Location = new Point(234, 174);
            ConductivityZeroTextBox.Name = "ConductivityZeroTextBox";
            ConductivityZeroTextBox.Size = new Size(121, 22);
            ConductivityZeroTextBox.TabIndex = 4;
            ConductivityZeroTextBox.Text = "0";
            // 
            // ConductivitySpanTextBox
            // 
            ConductivitySpanTextBox.Anchor = AnchorStyles.Left;
            ConductivitySpanTextBox.Enabled = false;
            ConductivitySpanTextBox.Font = new Font("Arial", 9.75F);
            ConductivitySpanTextBox.Location = new Point(234, 205);
            ConductivitySpanTextBox.Name = "ConductivitySpanTextBox";
            ConductivitySpanTextBox.Size = new Size(121, 22);
            ConductivitySpanTextBox.TabIndex = 4;
            ConductivitySpanTextBox.Text = "1413";
            // 
            // AkmZeroTextBox
            // 
            AkmZeroTextBox.Anchor = AnchorStyles.Left;
            AkmZeroTextBox.Enabled = false;
            AkmZeroTextBox.Font = new Font("Arial", 9.75F);
            AkmZeroTextBox.Location = new Point(234, 50);
            AkmZeroTextBox.Name = "AkmZeroTextBox";
            AkmZeroTextBox.Size = new Size(121, 22);
            AkmZeroTextBox.TabIndex = 4;
            AkmZeroTextBox.Text = "0";
            // 
            // KoiZeroTextBox
            // 
            KoiZeroTextBox.Anchor = AnchorStyles.Left;
            KoiZeroTextBox.Enabled = false;
            KoiZeroTextBox.Font = new Font("Arial", 9.75F);
            KoiZeroTextBox.Location = new Point(234, 174);
            KoiZeroTextBox.Name = "KoiZeroTextBox";
            KoiZeroTextBox.Size = new Size(121, 22);
            KoiZeroTextBox.TabIndex = 4;
            KoiZeroTextBox.Text = "0";
            // 
            // CalibrationSettingsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(StationSettingsBgTableLayoutPanel);
            Name = "CalibrationSettingsPage";
            Padding = new Padding(0, 15, 0, 15);
            Size = new Size(1094, 533);
            CalibrationValuesBgTableLayoutPanel.ResumeLayout(false);
            CalibrationValuesContentTableLayoutPanel.ResumeLayout(false);
            CalibrationValuesContentTableLayoutPanel.PerformLayout();
            StationSettingsBgTableLayoutPanel.ResumeLayout(false);
            CalibrationHeaderTableLayoutPanel.ResumeLayout(false);
            CalibrationHeaderTableLayoutPanel.PerformLayout();
            StationInfoBgTableLayoutPanel.ResumeLayout(false);
            StationInfoContentTableLayoutPanel.ResumeLayout(false);
            StationInfoContentTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel CalibrationValuesBgTableLayoutPanel;
        private TableLayoutPanel StationSettingsBgTableLayoutPanel;
        private TableLayoutPanel CalibrationHeaderTableLayoutPanel;
        private Label CalibrationSettingsLabel;
        private Button SaveCalibrationButton;
        private TableLayoutPanel StationInfoBgTableLayoutPanel;
        private TableLayoutPanel CalibrationValuesContentTableLayoutPanel;
        private Label AkmReferenceValuesLabel;
        private Label AkmZeroLabel;
        private Label KoiReferenceValuesLabel;
        private Label KoiZeroLabel;
        private TableLayoutPanel StationInfoContentTableLayoutPanel;
        private Label PhZeroLabel;
        private Label PhSpanLabel;
        private Label PhReferenceValuesLabel;
        private ComboBox PhSpanComboBox;
        private Label ConductivityReferenceValuesLabel;
        private Label ConductivityZeroLabel;
        private Label ConductivitySpanLabel;
        private TextBox PhZeroTextBox;
        private TextBox ConductivityZeroTextBox;
        private TextBox ConductivitySpanTextBox;
        private TextBox AkmZeroTextBox;
        private TextBox KoiZeroTextBox;
    }
}
