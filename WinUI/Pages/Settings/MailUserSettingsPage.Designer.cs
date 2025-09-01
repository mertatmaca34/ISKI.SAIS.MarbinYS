namespace WinUI.Pages.Settings
{
    partial class MailUserSettingsPage
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            FetchButton = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            label2 = new Label();
            SaveButton = new Button();
            label18 = new Label();
            textBox15 = new TextBox();
            label19 = new Label();
            label3 = new Label();
            StationSettingsContentTableLayoutPanel = new TableLayoutPanel();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            StationSettingsBgTableLayoutPanel = new TableLayoutPanel();
            StationInfoBgTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            StationSettingsContentTableLayoutPanel.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            StationSettingsBgTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // StationInfoBgTableLayoutPanel
            // 
            StationInfoBgTableLayoutPanel.BackColor = Color.FromArgb(235, 235, 235);
            StationInfoBgTableLayoutPanel.ColumnCount = 1;
            StationInfoBgTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            StationInfoBgTableLayoutPanel.Controls.Add(dataGridView1, 0, 0);
            StationInfoBgTableLayoutPanel.Dock = DockStyle.Fill;
            StationInfoBgTableLayoutPanel.Location = new Point(0, 40);
            StationInfoBgTableLayoutPanel.Margin = new Padding(0, 0, 5, 0);
            StationInfoBgTableLayoutPanel.Name = "StationInfoBgTableLayoutPanel";
            StationInfoBgTableLayoutPanel.RowCount = 1;
            StationInfoBgTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            StationInfoBgTableLayoutPanel.Size = new Size(542, 463);
            StationInfoBgTableLayoutPanel.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(536, 457);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(162, 22);
            label1.TabIndex = 0;
            label1.Text = "Mail Kullanıcıları";
            // 
            // FetchButton
            // 
            FetchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FetchButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FetchButton.Location = new Point(452, 3);
            FetchButton.Name = "FetchButton";
            FetchButton.Size = new Size(92, 32);
            FetchButton.TabIndex = 2;
            FetchButton.Text = "Yenile";
            FetchButton.TextImageRelation = TextImageRelation.ImageAboveText;
            FetchButton.UseVisualStyleBackColor = true;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(170, 22);
            label2.TabIndex = 0;
            label2.Text = "Kullanıcı Düzenle";
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
            // label18
            // 
            label18.Anchor = AnchorStyles.Left;
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label18.ForeColor = Color.FromArgb(64, 64, 64);
            label18.Location = new Point(18, 22);
            label18.Name = "label18";
            label18.Size = new Size(88, 16);
            label18.TabIndex = 1;
            label18.Text = "Kullanıcı Adı";
            // 
            // textBox15
            // 
            textBox15.Anchor = AnchorStyles.Left;
            textBox15.Location = new Point(234, 19);
            textBox15.Name = "textBox15";
            textBox15.PlaceholderText = "kullanıcı adı";
            textBox15.Size = new Size(288, 23);
            textBox15.TabIndex = 2;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Left;
            label19.AutoSize = true;
            label19.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label19.ForeColor = Color.FromArgb(64, 64, 64);
            label19.Location = new Point(18, 84);
            label19.Name = "label19";
            label19.Size = new Size(37, 16);
            label19.TabIndex = 1;
            label19.Text = "Şifre";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(18, 53);
            label3.Name = "label3";
            label3.Size = new Size(34, 16);
            label3.TabIndex = 1;
            label3.Text = "Mail";
            // 
            // StationSettingsContentTableLayoutPanel
            // 
            StationSettingsContentTableLayoutPanel.BackColor = Color.White;
            StationSettingsContentTableLayoutPanel.ColumnCount = 2;
            StationSettingsContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.35294F));
            StationSettingsContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.6470566F));
            StationSettingsContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            StationSettingsContentTableLayoutPanel.Controls.Add(label18, 0, 0);
            StationSettingsContentTableLayoutPanel.Controls.Add(textBox15, 1, 0);
            StationSettingsContentTableLayoutPanel.Controls.Add(label19, 0, 2);
            StationSettingsContentTableLayoutPanel.Controls.Add(label3, 0, 1);
            StationSettingsContentTableLayoutPanel.Controls.Add(textBox2, 1, 1);
            StationSettingsContentTableLayoutPanel.Controls.Add(textBox3, 1, 2);
            StationSettingsContentTableLayoutPanel.Dock = DockStyle.Fill;
            StationSettingsContentTableLayoutPanel.Location = new Point(547, 40);
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
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left;
            textBox2.Location = new Point(234, 50);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "ornek@iski.gov.tr";
            textBox2.Size = new Size(288, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left;
            textBox3.Location = new Point(234, 81);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "sifre";
            textBox3.Size = new Size(288, 23);
            textBox3.TabIndex = 2;
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
            StationSettingsBgTableLayoutPanel.TabIndex = 2;
            // 
            // MailUserSettingsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(StationSettingsBgTableLayoutPanel);
            Name = "MailUserSettingsPage";
            Padding = new Padding(0, 15, 0, 15);
            Size = new Size(1094, 533);
            StationInfoBgTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            StationSettingsContentTableLayoutPanel.ResumeLayout(false);
            StationSettingsContentTableLayoutPanel.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            StationSettingsBgTableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel StationInfoBgTableLayoutPanel;
        private Label label1;
        private Button FetchButton;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label2;
        private Button SaveButton;
        private Label label18;
        private TextBox textBox15;
        private Label label19;
        private Label label3;
        private TableLayoutPanel StationSettingsContentTableLayoutPanel;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel StationSettingsBgTableLayoutPanel;
        private TextBox textBox2;
        private TextBox textBox3;
        private DataGridView dataGridView1;
    }
}
