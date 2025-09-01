namespace WinUI.Pages.Settings
{
    partial class ChannelSettingsPage
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
            UpdateChannelBgTableLayoutPanel = new TableLayoutPanel();
            StationSettingsBgTableLayoutPanel = new TableLayoutPanel();
            FetchChannelHeaderTableLayoutPanel = new TableLayoutPanel();
            FetchChannelTitleLabel = new Label();
            FetchChannelButton = new Button();
            StationInfoBgTableLayoutPanel = new TableLayoutPanel();
            StationInfoContentTableLayoutPanel = new TableLayoutPanel();
            BrandLabel = new Label();
            BrandModelLabel = new Label();
            FullNameLabel = new Label();
            ChannelComboBox = new ComboBox();
            ChannelLabel = new Label();
            ParameterLabel = new Label();
            ParameterTextLabel = new Label();
            UnitLabel = new Label();
            UnitTextLabel = new Label();
            IsActiveLabel = new Label();
            ChannelMinValueLabel = new Label();
            ChannelMaxValueLabel = new Label();
            ChannelNumberLabel = new Label();
            CalibrationFormulaALabel = new Label();
            CalibrationFormulaBLabel = new Label();
            SerialNumberLabel = new Label();
            FullNameTextBox = new TextBox();
            BrandTextBox = new TextBox();
            BrandModelTextBox = new TextBox();
            ParameterTextBox = new TextBox();
            ParameterTextTextBox = new TextBox();
            UnitTextBox = new TextBox();
            UnitTextTextBox = new TextBox();
            IsActiveTextBox = new TextBox();
            ChannelMinValueTextBox = new TextBox();
            ChannelMaxValueTextBox = new TextBox();
            ChannelNumberTextBox = new TextBox();
            CalibrationFormulaATextBox = new TextBox();
            CalibrationFormulaBTextBox = new TextBox();
            SerialNumberTextBox = new TextBox();
            UpdateChannelContentTableLayoutPanel = new TableLayoutPanel();
            UnitUpdateLabel = new Label();
            IsActiveUpdateLabel = new Label();
            ChannelMinValueUpdateLabel = new Label();
            ChannelMaxValueUpdateLabel = new Label();
            ChannelNumberUpdateLabel = new Label();
            CalibrationFormulaAUpdateLabel = new Label();
            CalibrationFormulaBUpdateLabel = new Label();
            ChannelMinValueUpdateTextBox = new TextBox();
            UnitUpdateTextBox = new TextBox();
            IsActiveUpdateTextBox = new TextBox();
            ChannelMaxValueUpdateTextBox = new TextBox();
            ChannelNumberUpdateTextBox = new TextBox();
            CalibrationFormulaAUpdateTextBox = new TextBox();
            CalibrationFormulaBUpdateTextBox = new TextBox();
            UpdateChannelHeaderTableLayoutPanel = new TableLayoutPanel();
            UpdateChannelTitleLabel = new Label();
            SaveChannelButton = new Button();
            UpdateChannelBgTableLayoutPanel.SuspendLayout();
            StationSettingsBgTableLayoutPanel.SuspendLayout();
            FetchChannelHeaderTableLayoutPanel.SuspendLayout();
            StationInfoBgTableLayoutPanel.SuspendLayout();
            StationInfoContentTableLayoutPanel.SuspendLayout();
            UpdateChannelContentTableLayoutPanel.SuspendLayout();
            UpdateChannelHeaderTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // UpdateChannelBgTableLayoutPanel
            // 
            UpdateChannelBgTableLayoutPanel.BackColor = Color.FromArgb(235, 235, 235);
            UpdateChannelBgTableLayoutPanel.ColumnCount = 1;
            UpdateChannelBgTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            UpdateChannelBgTableLayoutPanel.Controls.Add(UpdateChannelContentTableLayoutPanel, 0, 0);
            UpdateChannelBgTableLayoutPanel.Dock = DockStyle.Fill;
            UpdateChannelBgTableLayoutPanel.Location = new Point(547, 40);
            UpdateChannelBgTableLayoutPanel.Margin = new Padding(0, 0, 5, 0);
            UpdateChannelBgTableLayoutPanel.Name = "UpdateChannelBgTableLayoutPanel";
            UpdateChannelBgTableLayoutPanel.RowCount = 1;
            UpdateChannelBgTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            UpdateChannelBgTableLayoutPanel.Size = new Size(542, 463);
            UpdateChannelBgTableLayoutPanel.TabIndex = 6;
            // 
            // StationSettingsBgTableLayoutPanel
            // 
            StationSettingsBgTableLayoutPanel.ColumnCount = 2;
            StationSettingsBgTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            StationSettingsBgTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            StationSettingsBgTableLayoutPanel.Controls.Add(UpdateChannelHeaderTableLayoutPanel, 1, 0);
            StationSettingsBgTableLayoutPanel.Controls.Add(UpdateChannelBgTableLayoutPanel, 1, 1);
            StationSettingsBgTableLayoutPanel.Controls.Add(FetchChannelHeaderTableLayoutPanel, 0, 0);
            StationSettingsBgTableLayoutPanel.Controls.Add(StationInfoBgTableLayoutPanel, 0, 1);
            StationSettingsBgTableLayoutPanel.Dock = DockStyle.Fill;
            StationSettingsBgTableLayoutPanel.Location = new Point(0, 15);
            StationSettingsBgTableLayoutPanel.Name = "StationSettingsBgTableLayoutPanel";
            StationSettingsBgTableLayoutPanel.RowCount = 2;
            StationSettingsBgTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            StationSettingsBgTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            StationSettingsBgTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            StationSettingsBgTableLayoutPanel.Size = new Size(1094, 503);
            StationSettingsBgTableLayoutPanel.TabIndex = 3;
            // 
            // FetchChannelHeaderTableLayoutPanel
            // 
            FetchChannelHeaderTableLayoutPanel.ColumnCount = 4;
            FetchChannelHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            FetchChannelHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            FetchChannelHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 141F));
            FetchChannelHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            FetchChannelHeaderTableLayoutPanel.Controls.Add(ChannelLabel, 1, 0);
            FetchChannelHeaderTableLayoutPanel.Controls.Add(FetchChannelTitleLabel, 0, 0);
            FetchChannelHeaderTableLayoutPanel.Controls.Add(FetchChannelButton, 3, 0);
            FetchChannelHeaderTableLayoutPanel.Controls.Add(ChannelComboBox, 2, 0);
            FetchChannelHeaderTableLayoutPanel.Dock = DockStyle.Fill;
            FetchChannelHeaderTableLayoutPanel.Location = new Point(0, 0);
            FetchChannelHeaderTableLayoutPanel.Margin = new Padding(0);
            FetchChannelHeaderTableLayoutPanel.Name = "FetchChannelHeaderTableLayoutPanel";
            FetchChannelHeaderTableLayoutPanel.RowCount = 1;
            FetchChannelHeaderTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            FetchChannelHeaderTableLayoutPanel.Size = new Size(547, 40);
            FetchChannelHeaderTableLayoutPanel.TabIndex = 3;
            // 
            // FetchChannelTitleLabel
            // 
            FetchChannelTitleLabel.AutoSize = true;
            FetchChannelTitleLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FetchChannelTitleLabel.ForeColor = Color.FromArgb(64, 64, 64);
            FetchChannelTitleLabel.Location = new Point(3, 0);
            FetchChannelTitleLabel.Name = "FetchChannelTitleLabel";
            FetchChannelTitleLabel.Size = new Size(188, 22);
            FetchChannelTitleLabel.TabIndex = 0;
            FetchChannelTitleLabel.Text = "Kanal Bilgileri Getir";
            // 
            // FetchChannelButton
            // 
            FetchChannelButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FetchChannelButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FetchChannelButton.Location = new Point(452, 3);
            FetchChannelButton.Name = "FetchChannelButton";
            FetchChannelButton.Size = new Size(92, 32);
            FetchChannelButton.TabIndex = 2;
            FetchChannelButton.Text = "Getir";
            FetchChannelButton.UseVisualStyleBackColor = true;
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
            StationInfoContentTableLayoutPanel.Controls.Add(BrandLabel, 0, 0);
            StationInfoContentTableLayoutPanel.Controls.Add(BrandModelLabel, 0, 1);
            StationInfoContentTableLayoutPanel.Controls.Add(FullNameLabel, 0, 2);
            StationInfoContentTableLayoutPanel.Controls.Add(ParameterLabel, 0, 3);
            StationInfoContentTableLayoutPanel.Controls.Add(ParameterTextLabel, 0, 4);
            StationInfoContentTableLayoutPanel.Controls.Add(UnitLabel, 0, 5);
            StationInfoContentTableLayoutPanel.Controls.Add(UnitTextLabel, 0, 6);
            StationInfoContentTableLayoutPanel.Controls.Add(IsActiveLabel, 0, 7);
            StationInfoContentTableLayoutPanel.Controls.Add(ChannelMinValueLabel, 0, 8);
            StationInfoContentTableLayoutPanel.Controls.Add(ChannelMaxValueLabel, 0, 9);
            StationInfoContentTableLayoutPanel.Controls.Add(ChannelNumberLabel, 0, 10);
            StationInfoContentTableLayoutPanel.Controls.Add(CalibrationFormulaALabel, 0, 11);
            StationInfoContentTableLayoutPanel.Controls.Add(CalibrationFormulaBLabel, 0, 12);
            StationInfoContentTableLayoutPanel.Controls.Add(SerialNumberLabel, 0, 13);
            StationInfoContentTableLayoutPanel.Controls.Add(FullNameTextBox, 1, 2);
            StationInfoContentTableLayoutPanel.Controls.Add(BrandTextBox, 1, 0);
            StationInfoContentTableLayoutPanel.Controls.Add(BrandModelTextBox, 1, 1);
            StationInfoContentTableLayoutPanel.Controls.Add(ParameterTextBox, 1, 3);
            StationInfoContentTableLayoutPanel.Controls.Add(ParameterTextTextBox, 1, 4);
            StationInfoContentTableLayoutPanel.Controls.Add(UnitTextBox, 1, 5);
            StationInfoContentTableLayoutPanel.Controls.Add(UnitTextTextBox, 1, 6);
            StationInfoContentTableLayoutPanel.Controls.Add(IsActiveTextBox, 1, 7);
            StationInfoContentTableLayoutPanel.Controls.Add(ChannelMinValueTextBox, 1, 8);
            StationInfoContentTableLayoutPanel.Controls.Add(ChannelMaxValueTextBox, 1, 9);
            StationInfoContentTableLayoutPanel.Controls.Add(ChannelNumberTextBox, 1, 10);
            StationInfoContentTableLayoutPanel.Controls.Add(CalibrationFormulaATextBox, 1, 11);
            StationInfoContentTableLayoutPanel.Controls.Add(CalibrationFormulaBTextBox, 1, 12);
            StationInfoContentTableLayoutPanel.Controls.Add(SerialNumberTextBox, 1, 13);
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
            // BrandLabel
            // 
            BrandLabel.Anchor = AnchorStyles.Left;
            BrandLabel.AutoSize = true;
            BrandLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BrandLabel.ForeColor = Color.FromArgb(64, 64, 64);
            BrandLabel.Location = new Point(18, 22);
            BrandLabel.Name = "BrandLabel";
            BrandLabel.Size = new Size(45, 16);
            BrandLabel.TabIndex = 1;
            BrandLabel.Text = "Brand";
            // 
            // BrandModelLabel
            // 
            BrandModelLabel.Anchor = AnchorStyles.Left;
            BrandModelLabel.AutoSize = true;
            BrandModelLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BrandModelLabel.ForeColor = Color.FromArgb(64, 64, 64);
            BrandModelLabel.Location = new Point(18, 53);
            BrandModelLabel.Name = "BrandModelLabel";
            BrandModelLabel.Size = new Size(84, 16);
            BrandModelLabel.TabIndex = 1;
            BrandModelLabel.Text = "BrandModel";
            // 
            // FullNameLabel
            // 
            FullNameLabel.Anchor = AnchorStyles.Left;
            FullNameLabel.AutoSize = true;
            FullNameLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FullNameLabel.ForeColor = Color.FromArgb(64, 64, 64);
            FullNameLabel.Location = new Point(18, 84);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(68, 16);
            FullNameLabel.TabIndex = 1;
            FullNameLabel.Text = "FullName";
            // 
            // ChannelComboBox
            // 
            ChannelComboBox.Anchor = AnchorStyles.Left;
            ChannelComboBox.FormattingEnabled = true;
            ChannelComboBox.Location = new Point(263, 8);
            ChannelComboBox.Name = "ChannelComboBox";
            ChannelComboBox.Size = new Size(121, 23);
            ChannelComboBox.TabIndex = 3;
            // 
            // ChannelLabel
            // 
            ChannelLabel.Anchor = AnchorStyles.Left;
            ChannelLabel.AutoSize = true;
            ChannelLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ChannelLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ChannelLabel.Location = new Point(203, 12);
            ChannelLabel.Name = "ChannelLabel";
            ChannelLabel.Size = new Size(48, 16);
            ChannelLabel.TabIndex = 1;
            ChannelLabel.Text = "Kanal:";
            // 
            // ParameterLabel
            // 
            ParameterLabel.Anchor = AnchorStyles.Left;
            ParameterLabel.AutoSize = true;
            ParameterLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ParameterLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ParameterLabel.Location = new Point(18, 115);
            ParameterLabel.Name = "ParameterLabel";
            ParameterLabel.Size = new Size(74, 16);
            ParameterLabel.TabIndex = 1;
            ParameterLabel.Text = "Parameter";
            // 
            // ParameterTextLabel
            // 
            ParameterTextLabel.Anchor = AnchorStyles.Left;
            ParameterTextLabel.AutoSize = true;
            ParameterTextLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ParameterTextLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ParameterTextLabel.Location = new Point(18, 146);
            ParameterTextLabel.Name = "ParameterTextLabel";
            ParameterTextLabel.Size = new Size(101, 16);
            ParameterTextLabel.TabIndex = 1;
            ParameterTextLabel.Text = "ParameterText";
            // 
            // UnitLabel
            // 
            UnitLabel.Anchor = AnchorStyles.Left;
            UnitLabel.AutoSize = true;
            UnitLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            UnitLabel.ForeColor = Color.FromArgb(64, 64, 64);
            UnitLabel.Location = new Point(18, 177);
            UnitLabel.Name = "UnitLabel";
            UnitLabel.Size = new Size(32, 16);
            UnitLabel.TabIndex = 1;
            UnitLabel.Text = "Unit";
            // 
            // UnitTextLabel
            // 
            UnitTextLabel.Anchor = AnchorStyles.Left;
            UnitTextLabel.AutoSize = true;
            UnitTextLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            UnitTextLabel.ForeColor = Color.FromArgb(64, 64, 64);
            UnitTextLabel.Location = new Point(18, 208);
            UnitTextLabel.Name = "UnitTextLabel";
            UnitTextLabel.Size = new Size(59, 16);
            UnitTextLabel.TabIndex = 1;
            UnitTextLabel.Text = "UnitText";
            // 
            // IsActiveLabel
            // 
            IsActiveLabel.Anchor = AnchorStyles.Left;
            IsActiveLabel.AutoSize = true;
            IsActiveLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            IsActiveLabel.ForeColor = Color.FromArgb(64, 64, 64);
            IsActiveLabel.Location = new Point(18, 239);
            IsActiveLabel.Name = "IsActiveLabel";
            IsActiveLabel.Size = new Size(56, 16);
            IsActiveLabel.TabIndex = 1;
            IsActiveLabel.Text = "IsActive";
            // 
            // ChannelMinValueLabel
            // 
            ChannelMinValueLabel.Anchor = AnchorStyles.Left;
            ChannelMinValueLabel.AutoSize = true;
            ChannelMinValueLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ChannelMinValueLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ChannelMinValueLabel.Location = new Point(18, 270);
            ChannelMinValueLabel.Name = "ChannelMinValueLabel";
            ChannelMinValueLabel.Size = new Size(119, 16);
            ChannelMinValueLabel.TabIndex = 1;
            ChannelMinValueLabel.Text = "ChannelMinValue";
            // 
            // ChannelMaxValueLabel
            // 
            ChannelMaxValueLabel.Anchor = AnchorStyles.Left;
            ChannelMaxValueLabel.AutoSize = true;
            ChannelMaxValueLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ChannelMaxValueLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ChannelMaxValueLabel.Location = new Point(18, 301);
            ChannelMaxValueLabel.Name = "ChannelMaxValueLabel";
            ChannelMaxValueLabel.Size = new Size(123, 16);
            ChannelMaxValueLabel.TabIndex = 1;
            ChannelMaxValueLabel.Text = "ChannelMaxValue";
            // 
            // ChannelNumberLabel
            // 
            ChannelNumberLabel.Anchor = AnchorStyles.Left;
            ChannelNumberLabel.AutoSize = true;
            ChannelNumberLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ChannelNumberLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ChannelNumberLabel.Location = new Point(18, 332);
            ChannelNumberLabel.Name = "ChannelNumberLabel";
            ChannelNumberLabel.Size = new Size(110, 16);
            ChannelNumberLabel.TabIndex = 1;
            ChannelNumberLabel.Text = "ChannelNumber";
            // 
            // CalibrationFormulaALabel
            // 
            CalibrationFormulaALabel.Anchor = AnchorStyles.Left;
            CalibrationFormulaALabel.AutoSize = true;
            CalibrationFormulaALabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            CalibrationFormulaALabel.ForeColor = Color.FromArgb(64, 64, 64);
            CalibrationFormulaALabel.Location = new Point(18, 363);
            CalibrationFormulaALabel.Name = "CalibrationFormulaALabel";
            CalibrationFormulaALabel.Size = new Size(139, 16);
            CalibrationFormulaALabel.TabIndex = 1;
            CalibrationFormulaALabel.Text = "CalibrationFormulaA";
            // 
            // CalibrationFormulaBLabel
            // 
            CalibrationFormulaBLabel.Anchor = AnchorStyles.Left;
            CalibrationFormulaBLabel.AutoSize = true;
            CalibrationFormulaBLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            CalibrationFormulaBLabel.ForeColor = Color.FromArgb(64, 64, 64);
            CalibrationFormulaBLabel.Location = new Point(18, 394);
            CalibrationFormulaBLabel.Name = "CalibrationFormulaBLabel";
            CalibrationFormulaBLabel.Size = new Size(139, 16);
            CalibrationFormulaBLabel.TabIndex = 1;
            CalibrationFormulaBLabel.Text = "CalibrationFormulaB";
            // 
            // SerialNumberLabel
            // 
            SerialNumberLabel.Anchor = AnchorStyles.Left;
            SerialNumberLabel.AutoSize = true;
            SerialNumberLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            SerialNumberLabel.ForeColor = Color.FromArgb(64, 64, 64);
            SerialNumberLabel.Location = new Point(18, 425);
            SerialNumberLabel.Name = "SerialNumberLabel";
            SerialNumberLabel.Size = new Size(95, 16);
            SerialNumberLabel.TabIndex = 1;
            SerialNumberLabel.Text = "SerialNumber";
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Anchor = AnchorStyles.Left;
            FullNameTextBox.Location = new Point(234, 81);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(288, 23);
            FullNameTextBox.TabIndex = 2;
            // 
            // BrandTextBox
            // 
            BrandTextBox.Anchor = AnchorStyles.Left;
            BrandTextBox.Location = new Point(234, 19);
            BrandTextBox.Name = "BrandTextBox";
            BrandTextBox.Size = new Size(288, 23);
            BrandTextBox.TabIndex = 2;
            // 
            // BrandModelTextBox
            // 
            BrandModelTextBox.Anchor = AnchorStyles.Left;
            BrandModelTextBox.Location = new Point(234, 50);
            BrandModelTextBox.Name = "BrandModelTextBox";
            BrandModelTextBox.Size = new Size(288, 23);
            BrandModelTextBox.TabIndex = 2;
            // 
            // ParameterTextBox
            // 
            ParameterTextBox.Anchor = AnchorStyles.Left;
            ParameterTextBox.Location = new Point(234, 112);
            ParameterTextBox.Name = "ParameterTextBox";
            ParameterTextBox.Size = new Size(288, 23);
            ParameterTextBox.TabIndex = 2;
            // 
            // ParameterTextTextBox
            // 
            ParameterTextTextBox.Anchor = AnchorStyles.Left;
            ParameterTextTextBox.Location = new Point(234, 143);
            ParameterTextTextBox.Name = "ParameterTextTextBox";
            ParameterTextTextBox.Size = new Size(288, 23);
            ParameterTextTextBox.TabIndex = 2;
            // 
            // UnitTextBox
            // 
            UnitTextBox.Anchor = AnchorStyles.Left;
            UnitTextBox.Location = new Point(234, 174);
            UnitTextBox.Name = "UnitTextBox";
            UnitTextBox.Size = new Size(288, 23);
            UnitTextBox.TabIndex = 2;
            // 
            // UnitTextTextBox
            // 
            UnitTextTextBox.Anchor = AnchorStyles.Left;
            UnitTextTextBox.Location = new Point(234, 205);
            UnitTextTextBox.Name = "UnitTextTextBox";
            UnitTextTextBox.Size = new Size(288, 23);
            UnitTextTextBox.TabIndex = 2;
            // 
            // IsActiveTextBox
            // 
            IsActiveTextBox.Anchor = AnchorStyles.Left;
            IsActiveTextBox.Location = new Point(234, 236);
            IsActiveTextBox.Name = "IsActiveTextBox";
            IsActiveTextBox.Size = new Size(288, 23);
            IsActiveTextBox.TabIndex = 2;
            // 
            // ChannelMinValueTextBox
            // 
            ChannelMinValueTextBox.Anchor = AnchorStyles.Left;
            ChannelMinValueTextBox.Location = new Point(234, 267);
            ChannelMinValueTextBox.Name = "ChannelMinValueTextBox";
            ChannelMinValueTextBox.Size = new Size(288, 23);
            ChannelMinValueTextBox.TabIndex = 2;
            // 
            // ChannelMaxValueTextBox
            // 
            ChannelMaxValueTextBox.Anchor = AnchorStyles.Left;
            ChannelMaxValueTextBox.Location = new Point(234, 298);
            ChannelMaxValueTextBox.Name = "ChannelMaxValueTextBox";
            ChannelMaxValueTextBox.Size = new Size(288, 23);
            ChannelMaxValueTextBox.TabIndex = 2;
            // 
            // ChannelNumberTextBox
            // 
            ChannelNumberTextBox.Anchor = AnchorStyles.Left;
            ChannelNumberTextBox.Location = new Point(234, 329);
            ChannelNumberTextBox.Name = "ChannelNumberTextBox";
            ChannelNumberTextBox.Size = new Size(288, 23);
            ChannelNumberTextBox.TabIndex = 2;
            // 
            // CalibrationFormulaATextBox
            // 
            CalibrationFormulaATextBox.Anchor = AnchorStyles.Left;
            CalibrationFormulaATextBox.Location = new Point(234, 360);
            CalibrationFormulaATextBox.Name = "CalibrationFormulaATextBox";
            CalibrationFormulaATextBox.Size = new Size(288, 23);
            CalibrationFormulaATextBox.TabIndex = 2;
            // 
            // CalibrationFormulaBTextBox
            // 
            CalibrationFormulaBTextBox.Anchor = AnchorStyles.Left;
            CalibrationFormulaBTextBox.Location = new Point(234, 391);
            CalibrationFormulaBTextBox.Name = "CalibrationFormulaBTextBox";
            CalibrationFormulaBTextBox.Size = new Size(288, 23);
            CalibrationFormulaBTextBox.TabIndex = 2;
            // 
            // SerialNumberTextBox
            // 
            SerialNumberTextBox.Anchor = AnchorStyles.Left;
            SerialNumberTextBox.Location = new Point(234, 422);
            SerialNumberTextBox.Name = "SerialNumberTextBox";
            SerialNumberTextBox.Size = new Size(288, 23);
            SerialNumberTextBox.TabIndex = 2;
            // 
            // UpdateChannelContentTableLayoutPanel
            // 
            UpdateChannelContentTableLayoutPanel.BackColor = Color.White;
            UpdateChannelContentTableLayoutPanel.ColumnCount = 2;
            UpdateChannelContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.35294F));
            UpdateChannelContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.6470566F));
            UpdateChannelContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            UpdateChannelContentTableLayoutPanel.Controls.Add(UnitUpdateLabel, 0, 0);
            UpdateChannelContentTableLayoutPanel.Controls.Add(IsActiveUpdateLabel, 0, 1);
            UpdateChannelContentTableLayoutPanel.Controls.Add(ChannelMinValueUpdateLabel, 0, 2);
            UpdateChannelContentTableLayoutPanel.Controls.Add(ChannelMaxValueUpdateLabel, 0, 3);
            UpdateChannelContentTableLayoutPanel.Controls.Add(ChannelNumberUpdateLabel, 0, 4);
            UpdateChannelContentTableLayoutPanel.Controls.Add(CalibrationFormulaAUpdateLabel, 0, 5);
            UpdateChannelContentTableLayoutPanel.Controls.Add(CalibrationFormulaBUpdateLabel, 0, 6);
            UpdateChannelContentTableLayoutPanel.Controls.Add(ChannelMinValueUpdateTextBox, 1, 2);
            UpdateChannelContentTableLayoutPanel.Controls.Add(UnitUpdateTextBox, 1, 0);
            UpdateChannelContentTableLayoutPanel.Controls.Add(IsActiveUpdateTextBox, 1, 1);
            UpdateChannelContentTableLayoutPanel.Controls.Add(ChannelMaxValueUpdateTextBox, 1, 3);
            UpdateChannelContentTableLayoutPanel.Controls.Add(ChannelNumberUpdateTextBox, 1, 4);
            UpdateChannelContentTableLayoutPanel.Controls.Add(CalibrationFormulaAUpdateTextBox, 1, 5);
            UpdateChannelContentTableLayoutPanel.Controls.Add(CalibrationFormulaBUpdateTextBox, 1, 6);
            UpdateChannelContentTableLayoutPanel.Dock = DockStyle.Fill;
            UpdateChannelContentTableLayoutPanel.Location = new Point(1, 1);
            UpdateChannelContentTableLayoutPanel.Margin = new Padding(1);
            UpdateChannelContentTableLayoutPanel.Name = "UpdateChannelContentTableLayoutPanel";
            UpdateChannelContentTableLayoutPanel.Padding = new Padding(15);
            UpdateChannelContentTableLayoutPanel.RowCount = 14;
            UpdateChannelContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            UpdateChannelContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            UpdateChannelContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            UpdateChannelContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            UpdateChannelContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            UpdateChannelContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            UpdateChannelContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            UpdateChannelContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            UpdateChannelContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            UpdateChannelContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            UpdateChannelContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            UpdateChannelContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            UpdateChannelContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            UpdateChannelContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            UpdateChannelContentTableLayoutPanel.Size = new Size(540, 461);
            UpdateChannelContentTableLayoutPanel.TabIndex = 3;
            // 
            // UnitUpdateLabel
            // 
            UnitUpdateLabel.Anchor = AnchorStyles.Left;
            UnitUpdateLabel.AutoSize = true;
            UnitUpdateLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            UnitUpdateLabel.ForeColor = Color.FromArgb(64, 64, 64);
            UnitUpdateLabel.Location = new Point(18, 22);
            UnitUpdateLabel.Name = "UnitUpdateLabel";
            UnitUpdateLabel.Size = new Size(32, 16);
            UnitUpdateLabel.TabIndex = 1;
            UnitUpdateLabel.Text = "Unit";
            // 
            // IsActiveUpdateLabel
            // 
            IsActiveUpdateLabel.Anchor = AnchorStyles.Left;
            IsActiveUpdateLabel.AutoSize = true;
            IsActiveUpdateLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            IsActiveUpdateLabel.ForeColor = Color.FromArgb(64, 64, 64);
            IsActiveUpdateLabel.Location = new Point(18, 53);
            IsActiveUpdateLabel.Name = "IsActiveUpdateLabel";
            IsActiveUpdateLabel.Size = new Size(56, 16);
            IsActiveUpdateLabel.TabIndex = 1;
            IsActiveUpdateLabel.Text = "IsActive";
            // 
            // ChannelMinValueUpdateLabel
            // 
            ChannelMinValueUpdateLabel.Anchor = AnchorStyles.Left;
            ChannelMinValueUpdateLabel.AutoSize = true;
            ChannelMinValueUpdateLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ChannelMinValueUpdateLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ChannelMinValueUpdateLabel.Location = new Point(18, 84);
            ChannelMinValueUpdateLabel.Name = "ChannelMinValueUpdateLabel";
            ChannelMinValueUpdateLabel.Size = new Size(119, 16);
            ChannelMinValueUpdateLabel.TabIndex = 1;
            ChannelMinValueUpdateLabel.Text = "ChannelMinValue";
            // 
            // ChannelMaxValueUpdateLabel
            // 
            ChannelMaxValueUpdateLabel.Anchor = AnchorStyles.Left;
            ChannelMaxValueUpdateLabel.AutoSize = true;
            ChannelMaxValueUpdateLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ChannelMaxValueUpdateLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ChannelMaxValueUpdateLabel.Location = new Point(18, 115);
            ChannelMaxValueUpdateLabel.Name = "ChannelMaxValueUpdateLabel";
            ChannelMaxValueUpdateLabel.Size = new Size(123, 16);
            ChannelMaxValueUpdateLabel.TabIndex = 1;
            ChannelMaxValueUpdateLabel.Text = "ChannelMaxValue";
            // 
            // ChannelNumberUpdateLabel
            // 
            ChannelNumberUpdateLabel.Anchor = AnchorStyles.Left;
            ChannelNumberUpdateLabel.AutoSize = true;
            ChannelNumberUpdateLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ChannelNumberUpdateLabel.ForeColor = Color.FromArgb(64, 64, 64);
            ChannelNumberUpdateLabel.Location = new Point(18, 146);
            ChannelNumberUpdateLabel.Name = "ChannelNumberUpdateLabel";
            ChannelNumberUpdateLabel.Size = new Size(110, 16);
            ChannelNumberUpdateLabel.TabIndex = 1;
            ChannelNumberUpdateLabel.Text = "ChannelNumber";
            // 
            // CalibrationFormulaAUpdateLabel
            // 
            CalibrationFormulaAUpdateLabel.Anchor = AnchorStyles.Left;
            CalibrationFormulaAUpdateLabel.AutoSize = true;
            CalibrationFormulaAUpdateLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            CalibrationFormulaAUpdateLabel.ForeColor = Color.FromArgb(64, 64, 64);
            CalibrationFormulaAUpdateLabel.Location = new Point(18, 177);
            CalibrationFormulaAUpdateLabel.Name = "CalibrationFormulaAUpdateLabel";
            CalibrationFormulaAUpdateLabel.Size = new Size(139, 16);
            CalibrationFormulaAUpdateLabel.TabIndex = 1;
            CalibrationFormulaAUpdateLabel.Text = "CalibrationFormulaA";
            // 
            // CalibrationFormulaBUpdateLabel
            // 
            CalibrationFormulaBUpdateLabel.Anchor = AnchorStyles.Left;
            CalibrationFormulaBUpdateLabel.AutoSize = true;
            CalibrationFormulaBUpdateLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            CalibrationFormulaBUpdateLabel.ForeColor = Color.FromArgb(64, 64, 64);
            CalibrationFormulaBUpdateLabel.Location = new Point(18, 208);
            CalibrationFormulaBUpdateLabel.Name = "CalibrationFormulaBUpdateLabel";
            CalibrationFormulaBUpdateLabel.Size = new Size(139, 16);
            CalibrationFormulaBUpdateLabel.TabIndex = 1;
            CalibrationFormulaBUpdateLabel.Text = "CalibrationFormulaB";
            // 
            // ChannelMinValueUpdateTextBox
            // 
            ChannelMinValueUpdateTextBox.Anchor = AnchorStyles.Left;
            ChannelMinValueUpdateTextBox.Location = new Point(234, 81);
            ChannelMinValueUpdateTextBox.Name = "ChannelMinValueUpdateTextBox";
            ChannelMinValueUpdateTextBox.Size = new Size(288, 23);
            ChannelMinValueUpdateTextBox.TabIndex = 2;
            // 
            // UnitUpdateTextBox
            // 
            UnitUpdateTextBox.Anchor = AnchorStyles.Left;
            UnitUpdateTextBox.Location = new Point(234, 19);
            UnitUpdateTextBox.Name = "UnitUpdateTextBox";
            UnitUpdateTextBox.Size = new Size(288, 23);
            UnitUpdateTextBox.TabIndex = 2;
            // 
            // IsActiveUpdateTextBox
            // 
            IsActiveUpdateTextBox.Anchor = AnchorStyles.Left;
            IsActiveUpdateTextBox.Location = new Point(234, 50);
            IsActiveUpdateTextBox.Name = "IsActiveUpdateTextBox";
            IsActiveUpdateTextBox.Size = new Size(288, 23);
            IsActiveUpdateTextBox.TabIndex = 2;
            // 
            // ChannelMaxValueUpdateTextBox
            // 
            ChannelMaxValueUpdateTextBox.Anchor = AnchorStyles.Left;
            ChannelMaxValueUpdateTextBox.Location = new Point(234, 112);
            ChannelMaxValueUpdateTextBox.Name = "ChannelMaxValueUpdateTextBox";
            ChannelMaxValueUpdateTextBox.Size = new Size(288, 23);
            ChannelMaxValueUpdateTextBox.TabIndex = 2;
            // 
            // ChannelNumberUpdateTextBox
            // 
            ChannelNumberUpdateTextBox.Anchor = AnchorStyles.Left;
            ChannelNumberUpdateTextBox.Location = new Point(234, 143);
            ChannelNumberUpdateTextBox.Name = "ChannelNumberUpdateTextBox";
            ChannelNumberUpdateTextBox.Size = new Size(288, 23);
            ChannelNumberUpdateTextBox.TabIndex = 2;
            // 
            // CalibrationFormulaAUpdateTextBox
            // 
            CalibrationFormulaAUpdateTextBox.Anchor = AnchorStyles.Left;
            CalibrationFormulaAUpdateTextBox.Location = new Point(234, 174);
            CalibrationFormulaAUpdateTextBox.Name = "CalibrationFormulaAUpdateTextBox";
            CalibrationFormulaAUpdateTextBox.Size = new Size(288, 23);
            CalibrationFormulaAUpdateTextBox.TabIndex = 2;
            // 
            // CalibrationFormulaBUpdateTextBox
            // 
            CalibrationFormulaBUpdateTextBox.Anchor = AnchorStyles.Left;
            CalibrationFormulaBUpdateTextBox.Location = new Point(234, 205);
            CalibrationFormulaBUpdateTextBox.Name = "CalibrationFormulaBUpdateTextBox";
            CalibrationFormulaBUpdateTextBox.Size = new Size(288, 23);
            CalibrationFormulaBUpdateTextBox.TabIndex = 2;
            // 
            // UpdateChannelHeaderTableLayoutPanel
            // 
            UpdateChannelHeaderTableLayoutPanel.ColumnCount = 2;
            UpdateChannelHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 264F));
            UpdateChannelHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            UpdateChannelHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            UpdateChannelHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            UpdateChannelHeaderTableLayoutPanel.Controls.Add(UpdateChannelTitleLabel, 0, 0);
            UpdateChannelHeaderTableLayoutPanel.Controls.Add(SaveChannelButton, 1, 0);
            UpdateChannelHeaderTableLayoutPanel.Dock = DockStyle.Fill;
            UpdateChannelHeaderTableLayoutPanel.Location = new Point(547, 0);
            UpdateChannelHeaderTableLayoutPanel.Margin = new Padding(0);
            UpdateChannelHeaderTableLayoutPanel.Name = "UpdateChannelHeaderTableLayoutPanel";
            UpdateChannelHeaderTableLayoutPanel.RowCount = 1;
            UpdateChannelHeaderTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            UpdateChannelHeaderTableLayoutPanel.Size = new Size(547, 40);
            UpdateChannelHeaderTableLayoutPanel.TabIndex = 7;
            // 
            // UpdateChannelTitleLabel
            // 
            UpdateChannelTitleLabel.AutoSize = true;
            UpdateChannelTitleLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            UpdateChannelTitleLabel.ForeColor = Color.FromArgb(64, 64, 64);
            UpdateChannelTitleLabel.Location = new Point(3, 0);
            UpdateChannelTitleLabel.Name = "UpdateChannelTitleLabel";
            UpdateChannelTitleLabel.Size = new Size(242, 22);
            UpdateChannelTitleLabel.TabIndex = 0;
            UpdateChannelTitleLabel.Text = "Kanal Bilgilerini Güncelle";
            // 
            // SaveChannelButton
            // 
            SaveChannelButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SaveChannelButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveChannelButton.Location = new Point(452, 3);
            SaveChannelButton.Name = "SaveChannelButton";
            SaveChannelButton.Size = new Size(92, 32);
            SaveChannelButton.TabIndex = 2;
            SaveChannelButton.Text = "Kaydet";
            SaveChannelButton.UseVisualStyleBackColor = true;
            // 
            // ChannelSettingsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(StationSettingsBgTableLayoutPanel);
            Name = "ChannelSettingsPage";
            Padding = new Padding(0, 15, 0, 15);
            Size = new Size(1094, 533);
            UpdateChannelBgTableLayoutPanel.ResumeLayout(false);
            StationSettingsBgTableLayoutPanel.ResumeLayout(false);
            FetchChannelHeaderTableLayoutPanel.ResumeLayout(false);
            FetchChannelHeaderTableLayoutPanel.PerformLayout();
            StationInfoBgTableLayoutPanel.ResumeLayout(false);
            StationInfoContentTableLayoutPanel.ResumeLayout(false);
            StationInfoContentTableLayoutPanel.PerformLayout();
            UpdateChannelContentTableLayoutPanel.ResumeLayout(false);
            UpdateChannelContentTableLayoutPanel.PerformLayout();
            UpdateChannelHeaderTableLayoutPanel.ResumeLayout(false);
            UpdateChannelHeaderTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel UpdateChannelBgTableLayoutPanel;
        private TableLayoutPanel StationSettingsBgTableLayoutPanel;
        private TableLayoutPanel FetchChannelHeaderTableLayoutPanel;
        private Label FetchChannelTitleLabel;
        private Button FetchChannelButton;
        private TableLayoutPanel StationInfoBgTableLayoutPanel;
        private TableLayoutPanel StationInfoContentTableLayoutPanel;
        private Label BrandLabel;
        private Label BrandModelLabel;
        private Label FullNameLabel;
        private ComboBox ChannelComboBox;
        private Label ChannelLabel;
        private Label ParameterLabel;
        private Label ParameterTextLabel;
        private Label UnitLabel;
        private Label UnitTextLabel;
        private Label IsActiveLabel;
        private Label ChannelMinValueLabel;
        private Label ChannelMaxValueLabel;
        private Label ChannelNumberLabel;
        private Label CalibrationFormulaALabel;
        private Label CalibrationFormulaBLabel;
        private Label SerialNumberLabel;
        private TextBox FullNameTextBox;
        private TextBox BrandTextBox;
        private TextBox BrandModelTextBox;
        private TextBox ParameterTextBox;
        private TextBox ParameterTextTextBox;
        private TextBox UnitTextBox;
        private TextBox UnitTextTextBox;
        private TextBox IsActiveTextBox;
        private TextBox ChannelMinValueTextBox;
        private TextBox ChannelMaxValueTextBox;
        private TextBox ChannelNumberTextBox;
        private TextBox CalibrationFormulaATextBox;
        private TextBox CalibrationFormulaBTextBox;
        private TextBox SerialNumberTextBox;
        private TableLayoutPanel UpdateChannelContentTableLayoutPanel;
        private Label UnitUpdateLabel;
        private Label IsActiveUpdateLabel;
        private Label ChannelMinValueUpdateLabel;
        private Label ChannelMaxValueUpdateLabel;
        private Label ChannelNumberUpdateLabel;
        private Label CalibrationFormulaAUpdateLabel;
        private Label CalibrationFormulaBUpdateLabel;
        private TextBox ChannelMinValueUpdateTextBox;
        private TextBox UnitUpdateTextBox;
        private TextBox IsActiveUpdateTextBox;
        private TextBox ChannelMaxValueUpdateTextBox;
        private TextBox ChannelNumberUpdateTextBox;
        private TextBox CalibrationFormulaAUpdateTextBox;
        private TextBox CalibrationFormulaBUpdateTextBox;
        private TableLayoutPanel UpdateChannelHeaderTableLayoutPanel;
        private Label UpdateChannelTitleLabel;
        private Button SaveChannelButton;
    }
}
