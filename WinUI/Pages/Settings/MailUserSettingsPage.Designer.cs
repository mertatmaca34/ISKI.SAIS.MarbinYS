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
            MailUsersDataGridView = new DataGridView();
            MailUsersLabel = new Label();
            RefreshUsersButton = new Button();
            MailUsersHeaderTableLayoutPanel = new TableLayoutPanel();
            EditUserLabel = new Label();
            SaveUserButton = new Button();
            UsernameLabel = new Label();
            UsernameTextBox = new TextBox();
            PasswordLabel = new Label();
            EmailLabel = new Label();
            StationSettingsContentTableLayoutPanel = new TableLayoutPanel();
            EmailTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            EditUserHeaderTableLayoutPanel = new TableLayoutPanel();
            StationSettingsBgTableLayoutPanel = new TableLayoutPanel();
            StationInfoBgTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MailUsersDataGridView).BeginInit();
            MailUsersHeaderTableLayoutPanel.SuspendLayout();
            StationSettingsContentTableLayoutPanel.SuspendLayout();
            EditUserHeaderTableLayoutPanel.SuspendLayout();
            StationSettingsBgTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // StationInfoBgTableLayoutPanel
            // 
            StationInfoBgTableLayoutPanel.BackColor = Color.FromArgb(235, 235, 235);
            StationInfoBgTableLayoutPanel.ColumnCount = 1;
            StationInfoBgTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            StationInfoBgTableLayoutPanel.Controls.Add(MailUsersDataGridView, 0, 0);
            StationInfoBgTableLayoutPanel.Dock = DockStyle.Fill;
            StationInfoBgTableLayoutPanel.Location = new Point(0, 40);
            StationInfoBgTableLayoutPanel.Margin = new Padding(0, 0, 5, 0);
            StationInfoBgTableLayoutPanel.Name = "StationInfoBgTableLayoutPanel";
            StationInfoBgTableLayoutPanel.RowCount = 1;
            StationInfoBgTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            StationInfoBgTableLayoutPanel.Size = new Size(542, 463);
            StationInfoBgTableLayoutPanel.TabIndex = 5;
            // 
            // MailUsersDataGridView
            // 
            MailUsersDataGridView.BackgroundColor = Color.White;
            MailUsersDataGridView.BorderStyle = BorderStyle.None;
            MailUsersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MailUsersDataGridView.Dock = DockStyle.Fill;
            MailUsersDataGridView.Location = new Point(3, 3);
            MailUsersDataGridView.Name = "MailUsersDataGridView";
            MailUsersDataGridView.Size = new Size(536, 457);
            MailUsersDataGridView.TabIndex = 0;
            // 
            // MailUsersLabel
            // 
            MailUsersLabel.AutoSize = true;
            MailUsersLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            MailUsersLabel.ForeColor = Color.FromArgb(64, 64, 64);
            MailUsersLabel.Location = new Point(3, 0);
            MailUsersLabel.Name = "MailUsersLabel";
            MailUsersLabel.Size = new Size(162, 22);
            MailUsersLabel.TabIndex = 0;
            MailUsersLabel.Text = "Mail Kullanıcıları";
            // 
            // RefreshUsersButton
            // 
            RefreshUsersButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RefreshUsersButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RefreshUsersButton.Location = new Point(452, 3);
            RefreshUsersButton.Name = "RefreshUsersButton";
            RefreshUsersButton.Size = new Size(92, 32);
            RefreshUsersButton.TabIndex = 2;
            RefreshUsersButton.Text = "Yenile";
            RefreshUsersButton.TextImageRelation = TextImageRelation.ImageAboveText;
            RefreshUsersButton.UseVisualStyleBackColor = true;
            // 
            // MailUsersHeaderTableLayoutPanel
            // 
            MailUsersHeaderTableLayoutPanel.ColumnCount = 2;
            MailUsersHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            MailUsersHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            MailUsersHeaderTableLayoutPanel.Controls.Add(MailUsersLabel, 0, 0);
            MailUsersHeaderTableLayoutPanel.Controls.Add(RefreshUsersButton, 1, 0);
            MailUsersHeaderTableLayoutPanel.Dock = DockStyle.Fill;
            MailUsersHeaderTableLayoutPanel.Location = new Point(0, 0);
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
            EditUserLabel.Size = new Size(170, 22);
            EditUserLabel.TabIndex = 0;
            EditUserLabel.Text = "Kullanıcı Düzenle";
            // 
            // SaveUserButton
            // 
            SaveUserButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SaveUserButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveUserButton.Location = new Point(452, 3);
            SaveUserButton.Name = "SaveUserButton";
            SaveUserButton.Size = new Size(92, 32);
            SaveUserButton.TabIndex = 2;
            SaveUserButton.Text = "Kaydet";
            SaveUserButton.UseVisualStyleBackColor = true;
            // 
            // UsernameLabel
            // 
            UsernameLabel.Anchor = AnchorStyles.Left;
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            UsernameLabel.ForeColor = Color.FromArgb(64, 64, 64);
            UsernameLabel.Location = new Point(18, 22);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(88, 16);
            UsernameLabel.TabIndex = 1;
            UsernameLabel.Text = "Kullanıcı Adı";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Anchor = AnchorStyles.Left;
            UsernameTextBox.Location = new Point(234, 19);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.PlaceholderText = "kullanıcı adı";
            UsernameTextBox.Size = new Size(288, 23);
            UsernameTextBox.TabIndex = 2;
            // 
            // PasswordLabel
            // 
            PasswordLabel.Anchor = AnchorStyles.Left;
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            PasswordLabel.ForeColor = Color.FromArgb(64, 64, 64);
            PasswordLabel.Location = new Point(18, 84);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(37, 16);
            PasswordLabel.TabIndex = 1;
            PasswordLabel.Text = "Şifre";
            // 
            // EmailLabel
            // 
            EmailLabel.Anchor = AnchorStyles.Left;
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            EmailLabel.ForeColor = Color.FromArgb(64, 64, 64);
            EmailLabel.Location = new Point(18, 53);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(34, 16);
            EmailLabel.TabIndex = 1;
            EmailLabel.Text = "Mail";
            // 
            // StationSettingsContentTableLayoutPanel
            // 
            StationSettingsContentTableLayoutPanel.BackColor = Color.White;
            StationSettingsContentTableLayoutPanel.ColumnCount = 2;
            StationSettingsContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.35294F));
            StationSettingsContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.6470566F));
            StationSettingsContentTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            StationSettingsContentTableLayoutPanel.Controls.Add(UsernameLabel, 0, 0);
            StationSettingsContentTableLayoutPanel.Controls.Add(UsernameTextBox, 1, 0);
            StationSettingsContentTableLayoutPanel.Controls.Add(PasswordLabel, 0, 2);
            StationSettingsContentTableLayoutPanel.Controls.Add(EmailLabel, 0, 1);
            StationSettingsContentTableLayoutPanel.Controls.Add(EmailTextBox, 1, 1);
            StationSettingsContentTableLayoutPanel.Controls.Add(PasswordTextBox, 1, 2);
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
            // EmailTextBox
            // 
            EmailTextBox.Anchor = AnchorStyles.Left;
            EmailTextBox.Location = new Point(234, 50);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.PlaceholderText = "ornek@iski.gov.tr";
            EmailTextBox.Size = new Size(288, 23);
            EmailTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.Left;
            PasswordTextBox.Location = new Point(234, 81);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PlaceholderText = "sifre";
            PasswordTextBox.Size = new Size(288, 23);
            PasswordTextBox.TabIndex = 2;
            // 
            // EditUserHeaderTableLayoutPanel
            // 
            EditUserHeaderTableLayoutPanel.ColumnCount = 2;
            EditUserHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            EditUserHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            EditUserHeaderTableLayoutPanel.Controls.Add(EditUserLabel, 0, 0);
            EditUserHeaderTableLayoutPanel.Controls.Add(SaveUserButton, 1, 0);
            EditUserHeaderTableLayoutPanel.Dock = DockStyle.Fill;
            EditUserHeaderTableLayoutPanel.Location = new Point(547, 0);
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
            ((System.ComponentModel.ISupportInitialize)MailUsersDataGridView).EndInit();
            MailUsersHeaderTableLayoutPanel.ResumeLayout(false);
            MailUsersHeaderTableLayoutPanel.PerformLayout();
            StationSettingsContentTableLayoutPanel.ResumeLayout(false);
            StationSettingsContentTableLayoutPanel.PerformLayout();
            EditUserHeaderTableLayoutPanel.ResumeLayout(false);
            EditUserHeaderTableLayoutPanel.PerformLayout();
            StationSettingsBgTableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel StationInfoBgTableLayoutPanel;
        private Label MailUsersLabel;
        private Button RefreshUsersButton;
        private TableLayoutPanel MailUsersHeaderTableLayoutPanel;
        private Label EditUserLabel;
        private Button SaveUserButton;
        private Label UsernameLabel;
        private TextBox UsernameTextBox;
        private Label PasswordLabel;
        private Label EmailLabel;
        private TableLayoutPanel StationSettingsContentTableLayoutPanel;
        private TableLayoutPanel EditUserHeaderTableLayoutPanel;
        private TableLayoutPanel StationSettingsBgTableLayoutPanel;
        private TextBox EmailTextBox;
        private TextBox PasswordTextBox;
        private DataGridView MailUsersDataGridView;
    }
}
