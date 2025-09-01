namespace WinUI.Pages.Settings
{
    partial class StationSettingsPage
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
            StationSettingsBgTableLayoutPanel = new TableLayoutPanel();
            StationSettingsContentTableLayoutPanel = new TableLayoutPanel();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            textBox15 = new TextBox();
            textBox16 = new TextBox();
            textBox17 = new TextBox();
            textBox20 = new TextBox();
            label22 = new Label();
            textBox18 = new TextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            label2 = new Label();
            SaveButton = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            label1 = new Label();
            FetchButton = new Button();
            StationInfoBgTableLayoutPanel = new TableLayoutPanel();
            StationInfoContentTableLayoutPanel = new TableLayoutPanel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            textBox1 = new TextBox();
            textBox5 = new TextBox();
            textBox2 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            textBox13 = new TextBox();
            textBox14 = new TextBox();
            StationSettingsBgTableLayoutPanel.SuspendLayout();
            StationSettingsContentTableLayoutPanel.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            StationInfoBgTableLayoutPanel.SuspendLayout();
            StationInfoContentTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // StationSettingsBgTableLayoutPanel
            // 
            StationSettingsBgTableLayoutPanel.ColumnCount = 2;
            StationSettingsBgTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            StationSettingsBgTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            StationSettingsBgTableLayoutPanel.Controls.Add(StationSettingsContentTableLayoutPanel, 1, 1);
            StationSettingsBgTableLayoutPanel.Controls.Add(tableLayoutPanel5, 1, 0);
            StationSettingsBgTableLayoutPanel.Controls.Add(tableLayoutPanel4, 0, 0);
            StationSettingsBgTableLayoutPanel.Controls.Add(StationInfoBgTableLayoutPanel, 0, 1);
            StationSettingsBgTableLayoutPanel.Dock = DockStyle.Fill;
            StationSettingsBgTableLayoutPanel.Location = new Point(0, 15);
            StationSettingsBgTableLayoutPanel.Name = "StationSettingsBgTableLayoutPanel";
            StationSettingsBgTableLayoutPanel.RowCount = 2;
            StationSettingsBgTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            StationSettingsBgTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            StationSettingsBgTableLayoutPanel.Size = new Size(1094, 503);
            StationSettingsBgTableLayoutPanel.TabIndex = 0;
            // 
            // StationSettingsContentTableLayoutPanel
            // 
            StationSettingsContentTableLayoutPanel.BackColor = Color.White;
            StationSettingsContentTableLayoutPanel.ColumnCount = 2;
            StationSettingsContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.35294F));
            StationSettingsContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.6470566F));
            StationSettingsContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            StationSettingsContentTableLayoutPanel.Controls.Add(label18, 0, 0);
            StationSettingsContentTableLayoutPanel.Controls.Add(label19, 0, 1);
            StationSettingsContentTableLayoutPanel.Controls.Add(label20, 0, 2);
            StationSettingsContentTableLayoutPanel.Controls.Add(label21, 0, 3);
            StationSettingsContentTableLayoutPanel.Controls.Add(textBox15, 1, 0);
            StationSettingsContentTableLayoutPanel.Controls.Add(textBox16, 1, 2);
            StationSettingsContentTableLayoutPanel.Controls.Add(textBox17, 1, 3);
            StationSettingsContentTableLayoutPanel.Controls.Add(textBox20, 1, 1);
            StationSettingsContentTableLayoutPanel.Controls.Add(label22, 0, 4);
            StationSettingsContentTableLayoutPanel.Controls.Add(textBox18, 1, 4);
            StationSettingsContentTableLayoutPanel.Dock = DockStyle.Fill;
            StationSettingsContentTableLayoutPanel.Location = new Point(548, 41);
            StationSettingsContentTableLayoutPanel.Margin = new Padding(1, 1, 5, 1);
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
            StationSettingsContentTableLayoutPanel.Size = new Size(541, 461);
            StationSettingsContentTableLayoutPanel.TabIndex = 6;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Left;
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label18.ForeColor = Color.FromArgb(64, 64, 64);
            label18.Location = new Point(18, 22);
            label18.Name = "label18";
            label18.Size = new Size(64, 16);
            label18.TabIndex = 1;
            label18.Text = "StationId";
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Left;
            label19.AutoSize = true;
            label19.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label19.ForeColor = Color.FromArgb(64, 64, 64);
            label19.Location = new Point(18, 53);
            label19.Name = "label19";
            label19.Size = new Size(107, 16);
            label19.TabIndex = 1;
            label19.Text = "ConnectionUser";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Left;
            label20.AutoSize = true;
            label20.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label20.ForeColor = Color.FromArgb(64, 64, 64);
            label20.Location = new Point(18, 84);
            label20.Name = "label20";
            label20.Size = new Size(140, 16);
            label20.TabIndex = 1;
            label20.Text = "ConnectionPassword";
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Left;
            label21.AutoSize = true;
            label21.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label21.ForeColor = Color.FromArgb(64, 64, 64);
            label21.Location = new Point(18, 115);
            label21.Name = "label21";
            label21.Size = new Size(178, 16);
            label21.TabIndex = 1;
            label21.Text = "ConnectionDomainAddress";
            // 
            // textBox15
            // 
            textBox15.Anchor = AnchorStyles.None;
            textBox15.Location = new Point(234, 19);
            textBox15.Name = "textBox15";
            textBox15.PlaceholderText = "edf10dfd-5fab-460b-b2fd-66b67da7a489";
            textBox15.Size = new Size(288, 23);
            textBox15.TabIndex = 2;
            // 
            // textBox16
            // 
            textBox16.Anchor = AnchorStyles.None;
            textBox16.Location = new Point(234, 81);
            textBox16.Name = "textBox16";
            textBox16.PlaceholderText = "Kabin Yazılımı Kullanıcı Şifresi";
            textBox16.Size = new Size(288, 23);
            textBox16.TabIndex = 2;
            // 
            // textBox17
            // 
            textBox17.Anchor = AnchorStyles.None;
            textBox17.Location = new Point(234, 112);
            textBox17.Name = "textBox17";
            textBox17.PlaceholderText = "Kabin Yazılımı Erişim Host veya IP Numarası";
            textBox17.Size = new Size(288, 23);
            textBox17.TabIndex = 2;
            // 
            // textBox20
            // 
            textBox20.Anchor = AnchorStyles.None;
            textBox20.Location = new Point(234, 50);
            textBox20.Name = "textBox20";
            textBox20.PlaceholderText = "Kabin Yazılımı Kullanıcı Adı";
            textBox20.Size = new Size(288, 23);
            textBox20.TabIndex = 2;
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Left;
            label22.AutoSize = true;
            label22.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label22.ForeColor = Color.FromArgb(64, 64, 64);
            label22.Location = new Point(18, 146);
            label22.Name = "label22";
            label22.Size = new Size(105, 16);
            label22.TabIndex = 1;
            label22.Text = "ConnectionPort";
            // 
            // textBox18
            // 
            textBox18.Anchor = AnchorStyles.None;
            textBox18.Location = new Point(234, 143);
            textBox18.Name = "textBox18";
            textBox18.PlaceholderText = "Kabin Yazılımı Erişim için kullanılan PORT bilgisi";
            textBox18.Size = new Size(288, 23);
            textBox18.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label2, 0, 0);
            tableLayoutPanel5.Controls.Add(SaveButton, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(547, 0);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(547, 40);
            tableLayoutPanel5.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(164, 22);
            label2.TabIndex = 0;
            label2.Text = "İstasyon Ayarları";
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SaveButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveButton.Location = new Point(452, 3);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(92, 32);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Kaydet";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label1, 0, 0);
            tableLayoutPanel4.Controls.Add(FetchButton, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
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
            label1.Size = new Size(164, 22);
            label1.TabIndex = 0;
            label1.Text = "İstasyon Bilgileri";
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
            StationInfoBgTableLayoutPanel.Margin = new Padding(0);
            StationInfoBgTableLayoutPanel.Name = "StationInfoBgTableLayoutPanel";
            StationInfoBgTableLayoutPanel.Padding = new Padding(0, 0, 5, 0);
            StationInfoBgTableLayoutPanel.RowCount = 1;
            StationInfoBgTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            StationInfoBgTableLayoutPanel.Size = new Size(547, 463);
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
            StationInfoContentTableLayoutPanel.Controls.Add(label7, 0, 3);
            StationInfoContentTableLayoutPanel.Controls.Add(label8, 0, 4);
            StationInfoContentTableLayoutPanel.Controls.Add(label9, 0, 5);
            StationInfoContentTableLayoutPanel.Controls.Add(label10, 0, 6);
            StationInfoContentTableLayoutPanel.Controls.Add(label11, 0, 7);
            StationInfoContentTableLayoutPanel.Controls.Add(label12, 0, 8);
            StationInfoContentTableLayoutPanel.Controls.Add(label13, 0, 9);
            StationInfoContentTableLayoutPanel.Controls.Add(label14, 0, 10);
            StationInfoContentTableLayoutPanel.Controls.Add(label15, 0, 11);
            StationInfoContentTableLayoutPanel.Controls.Add(label16, 0, 12);
            StationInfoContentTableLayoutPanel.Controls.Add(label17, 0, 13);
            StationInfoContentTableLayoutPanel.Controls.Add(textBox1, 1, 0);
            StationInfoContentTableLayoutPanel.Controls.Add(textBox5, 1, 2);
            StationInfoContentTableLayoutPanel.Controls.Add(textBox2, 1, 3);
            StationInfoContentTableLayoutPanel.Controls.Add(textBox6, 1, 4);
            StationInfoContentTableLayoutPanel.Controls.Add(textBox7, 1, 5);
            StationInfoContentTableLayoutPanel.Controls.Add(textBox8, 1, 1);
            StationInfoContentTableLayoutPanel.Controls.Add(textBox3, 1, 6);
            StationInfoContentTableLayoutPanel.Controls.Add(textBox4, 1, 7);
            StationInfoContentTableLayoutPanel.Controls.Add(textBox9, 1, 8);
            StationInfoContentTableLayoutPanel.Controls.Add(textBox10, 1, 9);
            StationInfoContentTableLayoutPanel.Controls.Add(textBox11, 1, 10);
            StationInfoContentTableLayoutPanel.Controls.Add(textBox12, 1, 11);
            StationInfoContentTableLayoutPanel.Controls.Add(textBox13, 1, 12);
            StationInfoContentTableLayoutPanel.Controls.Add(textBox14, 1, 13);
            StationInfoContentTableLayoutPanel.Dock = DockStyle.Fill;
            StationInfoContentTableLayoutPanel.Location = new Point(1, 1);
            StationInfoContentTableLayoutPanel.Margin = new Padding(1);
            StationInfoContentTableLayoutPanel.Name = "StationInfoContentTableLayoutPanel";
            StationInfoContentTableLayoutPanel.Padding = new Padding(15);
            StationInfoContentTableLayoutPanel.RowCount = 15;
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
            StationInfoContentTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
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
            label4.Size = new Size(75, 16);
            label4.TabIndex = 1;
            label4.Text = "İstasyon ID";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(18, 53);
            label5.Name = "label5";
            label5.Size = new Size(40, 16);
            label5.TabIndex = 1;
            label5.Text = "Code";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(18, 84);
            label6.Name = "label6";
            label6.Size = new Size(83, 16);
            label6.TabIndex = 1;
            label6.Text = "İstasyon Adı";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(18, 115);
            label7.Name = "label7";
            label7.Size = new Size(97, 16);
            label7.TabIndex = 1;
            label7.Text = "Veri Periyodu ";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(18, 146);
            label8.Name = "label8";
            label8.Size = new Size(101, 16);
            label8.TabIndex = 1;
            label8.Text = "Son Veri Tarihi";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.ForeColor = Color.FromArgb(64, 64, 64);
            label9.Location = new Point(18, 177);
            label9.Name = "label9";
            label9.Size = new Size(199, 16);
            label9.TabIndex = 1;
            label9.Text = "Kabin Yazılımı Bağlantı Adresi";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.ForeColor = Color.FromArgb(64, 64, 64);
            label10.Location = new Point(18, 208);
            label10.Name = "label10";
            label10.Size = new Size(193, 16);
            label10.TabIndex = 1;
            label10.Text = "Kabin Yazılımı Bağlantı Portu";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.ForeColor = Color.FromArgb(64, 64, 64);
            label11.Location = new Point(18, 239);
            label11.Name = "label11";
            label11.Size = new Size(183, 16);
            label11.TabIndex = 1;
            label11.Text = "Kabin Yazılımı Kullanıcı Adı";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label12.ForeColor = Color.FromArgb(64, 64, 64);
            label12.Location = new Point(18, 270);
            label12.Name = "label12";
            label12.Size = new Size(202, 16);
            label12.TabIndex = 1;
            label12.Text = "Kabin Yazılımı Kullanıcı Şifresi";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Left;
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label13.ForeColor = Color.FromArgb(64, 64, 64);
            label13.Location = new Point(18, 301);
            label13.Name = "label13";
            label13.Size = new Size(49, 16);
            label13.TabIndex = 1;
            label13.Text = "Kurum";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Left;
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label14.ForeColor = Color.FromArgb(64, 64, 64);
            label14.Location = new Point(18, 332);
            label14.Name = "label14";
            label14.Size = new Size(156, 16);
            label14.TabIndex = 1;
            label14.Text = "İstasyon Kurulum Tarihi";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Left;
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label15.ForeColor = Color.FromArgb(64, 64, 64);
            label15.Location = new Point(18, 363);
            label15.Name = "label15";
            label15.Size = new Size(151, 16);
            label15.TabIndex = 1;
            label15.Text = "Yazılım Kurulum Tarihi";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Left;
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label16.ForeColor = Color.FromArgb(64, 64, 64);
            label16.Location = new Point(18, 394);
            label16.Name = "label16";
            label16.Size = new Size(102, 16);
            label16.TabIndex = 1;
            label16.Text = "İstasyon Adresi";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Left;
            label17.AutoSize = true;
            label17.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label17.ForeColor = Color.FromArgb(64, 64, 64);
            label17.Location = new Point(18, 425);
            label17.Name = "label17";
            label17.Size = new Size(53, 16);
            label17.TabIndex = 1;
            label17.Text = "Yazılım";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Enabled = false;
            textBox1.Location = new Point(235, 19);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "edf10dfd-5fab-460b-b2fd-66b67da7a489";
            textBox1.Size = new Size(285, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.None;
            textBox5.Enabled = false;
            textBox5.Location = new Point(235, 81);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Test Sais İstasyonu";
            textBox5.Size = new Size(285, 23);
            textBox5.TabIndex = 2;
            textBox5.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Enabled = false;
            textBox2.Location = new Point(235, 112);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "1";
            textBox2.Size = new Size(285, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox1_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.None;
            textBox6.Enabled = false;
            textBox6.Location = new Point(235, 143);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "2019-12-01T00:00:00";
            textBox6.Size = new Size(285, 23);
            textBox6.TabIndex = 2;
            textBox6.TextChanged += textBox1_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.None;
            textBox7.Enabled = false;
            textBox7.Location = new Point(235, 174);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "istanbul.ssl";
            textBox7.Size = new Size(285, 23);
            textBox7.TabIndex = 2;
            textBox7.TextChanged += textBox1_TextChanged;
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.None;
            textBox8.Enabled = false;
            textBox8.Location = new Point(235, 50);
            textBox8.Name = "textBox8";
            textBox8.PlaceholderText = "0337000";
            textBox8.Size = new Size(285, 23);
            textBox8.TabIndex = 2;
            textBox8.TextChanged += textBox1_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Enabled = false;
            textBox3.Location = new Point(235, 205);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "443";
            textBox3.Size = new Size(285, 23);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox1_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Enabled = false;
            textBox4.Location = new Point(235, 236);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "iski";
            textBox4.Size = new Size(285, 23);
            textBox4.TabIndex = 2;
            textBox4.TextChanged += textBox1_TextChanged;
            // 
            // textBox9
            // 
            textBox9.Anchor = AnchorStyles.None;
            textBox9.Enabled = false;
            textBox9.Location = new Point(235, 267);
            textBox9.Name = "textBox9";
            textBox9.PlaceholderText = "iski123";
            textBox9.Size = new Size(285, 23);
            textBox9.TabIndex = 2;
            textBox9.TextChanged += textBox1_TextChanged;
            // 
            // textBox10
            // 
            textBox10.Anchor = AnchorStyles.None;
            textBox10.Enabled = false;
            textBox10.Location = new Point(235, 298);
            textBox10.Name = "textBox10";
            textBox10.PlaceholderText = "Test Tesisi";
            textBox10.Size = new Size(285, 23);
            textBox10.TabIndex = 2;
            textBox10.TextChanged += textBox1_TextChanged;
            // 
            // textBox11
            // 
            textBox11.Anchor = AnchorStyles.None;
            textBox11.Enabled = false;
            textBox11.Location = new Point(235, 329);
            textBox11.Name = "textBox11";
            textBox11.PlaceholderText = "2019-12-01T00:00:00";
            textBox11.Size = new Size(285, 23);
            textBox11.TabIndex = 2;
            textBox11.TextChanged += textBox1_TextChanged;
            // 
            // textBox12
            // 
            textBox12.Anchor = AnchorStyles.None;
            textBox12.Enabled = false;
            textBox12.Location = new Point(235, 360);
            textBox12.Name = "textBox12";
            textBox12.PlaceholderText = "2019-12-01T00:00:00";
            textBox12.Size = new Size(285, 23);
            textBox12.TabIndex = 2;
            textBox12.TextChanged += textBox1_TextChanged;
            // 
            // textBox13
            // 
            textBox13.Anchor = AnchorStyles.None;
            textBox13.Enabled = false;
            textBox13.Location = new Point(235, 391);
            textBox13.Name = "textBox13";
            textBox13.PlaceholderText = "İstanbul";
            textBox13.Size = new Size(285, 23);
            textBox13.TabIndex = 2;
            textBox13.TextChanged += textBox1_TextChanged;
            // 
            // textBox14
            // 
            textBox14.Anchor = AnchorStyles.None;
            textBox14.Enabled = false;
            textBox14.Location = new Point(235, 422);
            textBox14.Name = "textBox14";
            textBox14.PlaceholderText = "IBKS";
            textBox14.Size = new Size(285, 23);
            textBox14.TabIndex = 2;
            textBox14.TextChanged += textBox1_TextChanged;
            // 
            // StationSettingsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(StationSettingsBgTableLayoutPanel);
            Name = "StationSettingsPage";
            Padding = new Padding(0, 15, 0, 15);
            Size = new Size(1094, 533);
            StationSettingsBgTableLayoutPanel.ResumeLayout(false);
            StationSettingsContentTableLayoutPanel.ResumeLayout(false);
            StationSettingsContentTableLayoutPanel.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            StationInfoBgTableLayoutPanel.ResumeLayout(false);
            StationInfoContentTableLayoutPanel.ResumeLayout(false);
            StationInfoContentTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel StationSettingsBgTableLayoutPanel;
        private Label label1;
        private Button FetchButton;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label2;
        private Button SaveButton;
        private TableLayoutPanel StationInfoBgTableLayoutPanel;
        private TableLayoutPanel StationInfoContentTableLayoutPanel;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox14;
        private TableLayoutPanel StationSettingsContentTableLayoutPanel;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private TextBox textBox15;
        private TextBox textBox16;
        private TextBox textBox17;
        private TextBox textBox20;
        private Label label22;
        private TextBox textBox18;
    }
}
