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
            tableLayoutPanel1 = new TableLayoutPanel();
            StationSettingsBgTableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label1 = new Label();
            FetchButton = new Button();
            StationInfoBgTableLayoutPanel = new TableLayoutPanel();
            StationInfoContentTableLayoutPanel = new TableLayoutPanel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            textBox13 = new TextBox();
            textBox14 = new TextBox();
            textBox15 = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            textBox4 = new TextBox();
            textBox16 = new TextBox();
            textBox17 = new TextBox();
            textBox18 = new TextBox();
            textBox19 = new TextBox();
            textBox20 = new TextBox();
            textBox21 = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label32 = new Label();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            StationSettingsBgTableLayoutPanel.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            StationInfoBgTableLayoutPanel.SuspendLayout();
            StationInfoContentTableLayoutPanel.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(235, 235, 235);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(547, 40);
            tableLayoutPanel1.Margin = new Padding(0, 0, 5, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(542, 463);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // StationSettingsBgTableLayoutPanel
            // 
            StationSettingsBgTableLayoutPanel.ColumnCount = 2;
            StationSettingsBgTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            StationSettingsBgTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            StationSettingsBgTableLayoutPanel.Controls.Add(tableLayoutPanel3, 1, 0);
            StationSettingsBgTableLayoutPanel.Controls.Add(tableLayoutPanel1, 1, 1);
            StationSettingsBgTableLayoutPanel.Controls.Add(tableLayoutPanel4, 0, 0);
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
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 141F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(label2, 1, 0);
            tableLayoutPanel4.Controls.Add(label1, 0, 0);
            tableLayoutPanel4.Controls.Add(FetchButton, 3, 0);
            tableLayoutPanel4.Controls.Add(comboBox1, 2, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(547, 40);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(188, 22);
            label1.TabIndex = 0;
            label1.Text = "Kanal Bilgileri Getir";
            // 
            // FetchButton
            // 
            FetchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FetchButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FetchButton.Location = new Point(452, 3);
            FetchButton.Name = "FetchButton";
            FetchButton.Size = new Size(92, 32);
            FetchButton.TabIndex = 2;
            FetchButton.Text = "Getir";
            FetchButton.UseVisualStyleBackColor = true;
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
            StationInfoContentTableLayoutPanel.Controls.Add(label4, 0, 0);
            StationInfoContentTableLayoutPanel.Controls.Add(label5, 0, 1);
            StationInfoContentTableLayoutPanel.Controls.Add(label6, 0, 2);
            StationInfoContentTableLayoutPanel.Controls.Add(label3, 0, 3);
            StationInfoContentTableLayoutPanel.Controls.Add(label7, 0, 4);
            StationInfoContentTableLayoutPanel.Controls.Add(label9, 0, 5);
            StationInfoContentTableLayoutPanel.Controls.Add(label10, 0, 6);
            StationInfoContentTableLayoutPanel.Controls.Add(label11, 0, 7);
            StationInfoContentTableLayoutPanel.Controls.Add(label12, 0, 8);
            StationInfoContentTableLayoutPanel.Controls.Add(label13, 0, 9);
            StationInfoContentTableLayoutPanel.Controls.Add(label14, 0, 10);
            StationInfoContentTableLayoutPanel.Controls.Add(label15, 0, 11);
            StationInfoContentTableLayoutPanel.Controls.Add(label16, 0, 12);
            StationInfoContentTableLayoutPanel.Controls.Add(label17, 0, 13);
            StationInfoContentTableLayoutPanel.Controls.Add(textBox3, 1, 2);
            StationInfoContentTableLayoutPanel.Controls.Add(textBox1, 1, 0);
            StationInfoContentTableLayoutPanel.Controls.Add(textBox2, 1, 1);
            StationInfoContentTableLayoutPanel.Controls.Add(textBox5, 1, 3);
            StationInfoContentTableLayoutPanel.Controls.Add(textBox6, 1, 4);
            StationInfoContentTableLayoutPanel.Controls.Add(textBox7, 1, 5);
            StationInfoContentTableLayoutPanel.Controls.Add(textBox8, 1, 6);
            StationInfoContentTableLayoutPanel.Controls.Add(textBox9, 1, 7);
            StationInfoContentTableLayoutPanel.Controls.Add(textBox10, 1, 8);
            StationInfoContentTableLayoutPanel.Controls.Add(textBox11, 1, 9);
            StationInfoContentTableLayoutPanel.Controls.Add(textBox12, 1, 10);
            StationInfoContentTableLayoutPanel.Controls.Add(textBox13, 1, 11);
            StationInfoContentTableLayoutPanel.Controls.Add(textBox14, 1, 12);
            StationInfoContentTableLayoutPanel.Controls.Add(textBox15, 1, 13);
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
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(18, 22);
            label4.Name = "label4";
            label4.Size = new Size(45, 16);
            label4.TabIndex = 1;
            label4.Text = "Brand";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(18, 53);
            label5.Name = "label5";
            label5.Size = new Size(84, 16);
            label5.TabIndex = 1;
            label5.Text = "BrandModel";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(18, 84);
            label6.Name = "label6";
            label6.Size = new Size(68, 16);
            label6.TabIndex = 1;
            label6.Text = "FullName";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Left;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(263, 8);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(203, 12);
            label2.Name = "label2";
            label2.Size = new Size(48, 16);
            label2.TabIndex = 1;
            label2.Text = "Kanal:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(18, 115);
            label3.Name = "label3";
            label3.Size = new Size(74, 16);
            label3.TabIndex = 1;
            label3.Text = "Parameter";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(18, 146);
            label7.Name = "label7";
            label7.Size = new Size(101, 16);
            label7.TabIndex = 1;
            label7.Text = "ParameterText";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.ForeColor = Color.FromArgb(64, 64, 64);
            label9.Location = new Point(18, 177);
            label9.Name = "label9";
            label9.Size = new Size(32, 16);
            label9.TabIndex = 1;
            label9.Text = "Unit";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.ForeColor = Color.FromArgb(64, 64, 64);
            label10.Location = new Point(18, 208);
            label10.Name = "label10";
            label10.Size = new Size(59, 16);
            label10.TabIndex = 1;
            label10.Text = "UnitText";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.ForeColor = Color.FromArgb(64, 64, 64);
            label11.Location = new Point(18, 239);
            label11.Name = "label11";
            label11.Size = new Size(56, 16);
            label11.TabIndex = 1;
            label11.Text = "IsActive";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label12.ForeColor = Color.FromArgb(64, 64, 64);
            label12.Location = new Point(18, 270);
            label12.Name = "label12";
            label12.Size = new Size(119, 16);
            label12.TabIndex = 1;
            label12.Text = "ChannelMinValue";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Left;
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label13.ForeColor = Color.FromArgb(64, 64, 64);
            label13.Location = new Point(18, 301);
            label13.Name = "label13";
            label13.Size = new Size(123, 16);
            label13.TabIndex = 1;
            label13.Text = "ChannelMaxValue";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Left;
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label14.ForeColor = Color.FromArgb(64, 64, 64);
            label14.Location = new Point(18, 332);
            label14.Name = "label14";
            label14.Size = new Size(110, 16);
            label14.TabIndex = 1;
            label14.Text = "ChannelNumber";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Left;
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label15.ForeColor = Color.FromArgb(64, 64, 64);
            label15.Location = new Point(18, 363);
            label15.Name = "label15";
            label15.Size = new Size(139, 16);
            label15.TabIndex = 1;
            label15.Text = "CalibrationFormulaA";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Left;
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label16.ForeColor = Color.FromArgb(64, 64, 64);
            label16.Location = new Point(18, 394);
            label16.Name = "label16";
            label16.Size = new Size(139, 16);
            label16.TabIndex = 1;
            label16.Text = "CalibrationFormulaB";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Left;
            label17.AutoSize = true;
            label17.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label17.ForeColor = Color.FromArgb(64, 64, 64);
            label17.Location = new Point(18, 425);
            label17.Name = "label17";
            label17.Size = new Size(95, 16);
            label17.TabIndex = 1;
            label17.Text = "SerialNumber";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left;
            textBox3.Location = new Point(234, 81);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(288, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left;
            textBox1.Location = new Point(234, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(288, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left;
            textBox2.Location = new Point(234, 50);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(288, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Left;
            textBox5.Location = new Point(234, 112);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(288, 23);
            textBox5.TabIndex = 2;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Left;
            textBox6.Location = new Point(234, 143);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(288, 23);
            textBox6.TabIndex = 2;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Left;
            textBox7.Location = new Point(234, 174);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(288, 23);
            textBox7.TabIndex = 2;
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.Left;
            textBox8.Location = new Point(234, 205);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(288, 23);
            textBox8.TabIndex = 2;
            // 
            // textBox9
            // 
            textBox9.Anchor = AnchorStyles.Left;
            textBox9.Location = new Point(234, 236);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(288, 23);
            textBox9.TabIndex = 2;
            // 
            // textBox10
            // 
            textBox10.Anchor = AnchorStyles.Left;
            textBox10.Location = new Point(234, 267);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(288, 23);
            textBox10.TabIndex = 2;
            // 
            // textBox11
            // 
            textBox11.Anchor = AnchorStyles.Left;
            textBox11.Location = new Point(234, 298);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(288, 23);
            textBox11.TabIndex = 2;
            // 
            // textBox12
            // 
            textBox12.Anchor = AnchorStyles.Left;
            textBox12.Location = new Point(234, 329);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(288, 23);
            textBox12.TabIndex = 2;
            // 
            // textBox13
            // 
            textBox13.Anchor = AnchorStyles.Left;
            textBox13.Location = new Point(234, 360);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(288, 23);
            textBox13.TabIndex = 2;
            // 
            // textBox14
            // 
            textBox14.Anchor = AnchorStyles.Left;
            textBox14.Location = new Point(234, 391);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(288, 23);
            textBox14.TabIndex = 2;
            // 
            // textBox15
            // 
            textBox15.Anchor = AnchorStyles.Left;
            textBox15.Location = new Point(234, 422);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(288, 23);
            textBox15.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.35294F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.6470566F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(label18, 0, 0);
            tableLayoutPanel2.Controls.Add(label19, 0, 1);
            tableLayoutPanel2.Controls.Add(label20, 0, 2);
            tableLayoutPanel2.Controls.Add(label21, 0, 3);
            tableLayoutPanel2.Controls.Add(label22, 0, 4);
            tableLayoutPanel2.Controls.Add(label23, 0, 5);
            tableLayoutPanel2.Controls.Add(label24, 0, 6);
            tableLayoutPanel2.Controls.Add(textBox4, 1, 2);
            tableLayoutPanel2.Controls.Add(textBox16, 1, 0);
            tableLayoutPanel2.Controls.Add(textBox17, 1, 1);
            tableLayoutPanel2.Controls.Add(textBox18, 1, 3);
            tableLayoutPanel2.Controls.Add(textBox19, 1, 4);
            tableLayoutPanel2.Controls.Add(textBox20, 1, 5);
            tableLayoutPanel2.Controls.Add(textBox21, 1, 6);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(1, 1);
            tableLayoutPanel2.Margin = new Padding(1);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(15);
            tableLayoutPanel2.RowCount = 14;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel2.Size = new Size(540, 461);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Left;
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label18.ForeColor = Color.FromArgb(64, 64, 64);
            label18.Location = new Point(18, 22);
            label18.Name = "label18";
            label18.Size = new Size(32, 16);
            label18.TabIndex = 1;
            label18.Text = "Unit";
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Left;
            label19.AutoSize = true;
            label19.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label19.ForeColor = Color.FromArgb(64, 64, 64);
            label19.Location = new Point(18, 53);
            label19.Name = "label19";
            label19.Size = new Size(56, 16);
            label19.TabIndex = 1;
            label19.Text = "IsActive";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Left;
            label20.AutoSize = true;
            label20.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label20.ForeColor = Color.FromArgb(64, 64, 64);
            label20.Location = new Point(18, 84);
            label20.Name = "label20";
            label20.Size = new Size(119, 16);
            label20.TabIndex = 1;
            label20.Text = "ChannelMinValue";
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Left;
            label21.AutoSize = true;
            label21.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label21.ForeColor = Color.FromArgb(64, 64, 64);
            label21.Location = new Point(18, 115);
            label21.Name = "label21";
            label21.Size = new Size(123, 16);
            label21.TabIndex = 1;
            label21.Text = "ChannelMaxValue";
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Left;
            label22.AutoSize = true;
            label22.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label22.ForeColor = Color.FromArgb(64, 64, 64);
            label22.Location = new Point(18, 146);
            label22.Name = "label22";
            label22.Size = new Size(110, 16);
            label22.TabIndex = 1;
            label22.Text = "ChannelNumber";
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.Left;
            label23.AutoSize = true;
            label23.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label23.ForeColor = Color.FromArgb(64, 64, 64);
            label23.Location = new Point(18, 177);
            label23.Name = "label23";
            label23.Size = new Size(139, 16);
            label23.TabIndex = 1;
            label23.Text = "CalibrationFormulaA";
            // 
            // label24
            // 
            label24.Anchor = AnchorStyles.Left;
            label24.AutoSize = true;
            label24.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label24.ForeColor = Color.FromArgb(64, 64, 64);
            label24.Location = new Point(18, 208);
            label24.Name = "label24";
            label24.Size = new Size(139, 16);
            label24.TabIndex = 1;
            label24.Text = "CalibrationFormulaB";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Left;
            textBox4.Location = new Point(234, 81);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(288, 23);
            textBox4.TabIndex = 2;
            // 
            // textBox16
            // 
            textBox16.Anchor = AnchorStyles.Left;
            textBox16.Location = new Point(234, 19);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(288, 23);
            textBox16.TabIndex = 2;
            // 
            // textBox17
            // 
            textBox17.Anchor = AnchorStyles.Left;
            textBox17.Location = new Point(234, 50);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(288, 23);
            textBox17.TabIndex = 2;
            // 
            // textBox18
            // 
            textBox18.Anchor = AnchorStyles.Left;
            textBox18.Location = new Point(234, 112);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(288, 23);
            textBox18.TabIndex = 2;
            // 
            // textBox19
            // 
            textBox19.Anchor = AnchorStyles.Left;
            textBox19.Location = new Point(234, 143);
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(288, 23);
            textBox19.TabIndex = 2;
            // 
            // textBox20
            // 
            textBox20.Anchor = AnchorStyles.Left;
            textBox20.Location = new Point(234, 174);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(288, 23);
            textBox20.TabIndex = 2;
            // 
            // textBox21
            // 
            textBox21.Anchor = AnchorStyles.Left;
            textBox21.Location = new Point(234, 205);
            textBox21.Name = "textBox21";
            textBox21.Size = new Size(288, 23);
            textBox21.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 264F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(label32, 0, 0);
            tableLayoutPanel3.Controls.Add(button1, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(547, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(547, 40);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label32.ForeColor = Color.FromArgb(64, 64, 64);
            label32.Location = new Point(3, 0);
            label32.Name = "label32";
            label32.Size = new Size(242, 22);
            label32.TabIndex = 0;
            label32.Text = "Kanal Bilgilerini Güncelle";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(452, 3);
            button1.Name = "button1";
            button1.Size = new Size(92, 32);
            button1.TabIndex = 2;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            // 
            // ChannelSettingsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(StationSettingsBgTableLayoutPanel);
            Name = "ChannelSettingsPage";
            Padding = new Padding(0, 15, 0, 15);
            Size = new Size(1094, 533);
            tableLayoutPanel1.ResumeLayout(false);
            StationSettingsBgTableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            StationInfoBgTableLayoutPanel.ResumeLayout(false);
            StationInfoContentTableLayoutPanel.ResumeLayout(false);
            StationInfoContentTableLayoutPanel.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel StationSettingsBgTableLayoutPanel;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
        private Button FetchButton;
        private TableLayoutPanel StationInfoBgTableLayoutPanel;
        private TableLayoutPanel StationInfoContentTableLayoutPanel;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private TextBox textBox3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox14;
        private TextBox textBox15;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private TextBox textBox4;
        private TextBox textBox16;
        private TextBox textBox17;
        private TextBox textBox18;
        private TextBox textBox19;
        private TextBox textBox20;
        private TextBox textBox21;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label32;
        private Button button1;
    }
}
