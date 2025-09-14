namespace WinUI.Pages.Settings
{
    partial class MailSettingsPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.MailSettingsMainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MailSettingsHeaderTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MailSettingsHeaderLabel = new System.Windows.Forms.Label();
            this.SaveMailSettingsButton = new System.Windows.Forms.Button();
            this.MailSettingsBgTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MailSettingsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SmtpHostLabel = new System.Windows.Forms.Label();
            this.SmtpHostTextBox = new System.Windows.Forms.TextBox();
            this.SmtpPortLabel = new System.Windows.Forms.Label();
            this.SmtpPortTextBox = new System.Windows.Forms.TextBox();
            this.SmtpUserLabel = new System.Windows.Forms.Label();
            this.SmtpUserTextBox = new System.Windows.Forms.TextBox();
            this.SmtpPasswordLabel = new System.Windows.Forms.Label();
            this.SmtpPasswordTextBox = new System.Windows.Forms.TextBox();
            this.UseSslLabel = new System.Windows.Forms.Label();
            this.UseSslCheckBox = new System.Windows.Forms.CheckBox();
            this.SenderEmailLabel = new System.Windows.Forms.Label();
            this.SenderEmailTextBox = new System.Windows.Forms.TextBox();
            this.SenderNameLabel = new System.Windows.Forms.Label();
            this.SenderNameTextBox = new System.Windows.Forms.TextBox();
            this.UseDefaultCredentialsLabel = new System.Windows.Forms.Label();
            this.UseDefaultCredentialsCheckBox = new System.Windows.Forms.CheckBox();
            this.MailTestHeaderLabel = new System.Windows.Forms.Label();
            this.MailTestBgTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MailTestContentTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TestConnectionButton = new System.Windows.Forms.Button();
            this.TestEmailTextBox = new System.Windows.Forms.TextBox();
            this.SendTestEmailButton = new System.Windows.Forms.Button();
            this.ResponseGroupBox = new System.Windows.Forms.GroupBox();
            this.ResponseTextBox = new System.Windows.Forms.TextBox();
            this.MailSettingsMainTableLayoutPanel.SuspendLayout();
            this.MailSettingsHeaderTableLayoutPanel.SuspendLayout();
            this.MailSettingsBgTableLayoutPanel.SuspendLayout();
            this.MailSettingsTableLayoutPanel.SuspendLayout();
            this.MailTestBgTableLayoutPanel.SuspendLayout();
            this.MailTestContentTableLayoutPanel.SuspendLayout();
            this.ResponseGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MailSettingsMainTableLayoutPanel
            // 
            this.MailSettingsMainTableLayoutPanel.ColumnCount = 2;
            this.MailSettingsMainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MailSettingsMainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MailSettingsMainTableLayoutPanel.Controls.Add(this.MailSettingsHeaderTableLayoutPanel, 0, 0);
            this.MailSettingsMainTableLayoutPanel.Controls.Add(this.MailSettingsBgTableLayoutPanel, 0, 1);
            this.MailSettingsMainTableLayoutPanel.Controls.Add(this.MailTestHeaderLabel, 1, 0);
            this.MailSettingsMainTableLayoutPanel.Controls.Add(this.MailTestBgTableLayoutPanel, 1, 1);
            this.MailSettingsMainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MailSettingsMainTableLayoutPanel.RowCount = 2;
            this.MailSettingsMainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.MailSettingsMainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MailSettingsMainTableLayoutPanel.Location = new System.Drawing.Point(0, 15);
            this.MailSettingsMainTableLayoutPanel.Name = "MailSettingsMainTableLayoutPanel";
            this.MailSettingsMainTableLayoutPanel.Size = new System.Drawing.Size(1094, 503);
            this.MailSettingsMainTableLayoutPanel.TabIndex = 0;
            // 
            // MailSettingsHeaderTableLayoutPanel
            // 
            this.MailSettingsHeaderTableLayoutPanel.ColumnCount = 2;
            this.MailSettingsHeaderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MailSettingsHeaderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MailSettingsHeaderTableLayoutPanel.Controls.Add(this.MailSettingsHeaderLabel, 0, 0);
            this.MailSettingsHeaderTableLayoutPanel.Controls.Add(this.SaveMailSettingsButton, 1, 0);
            this.MailSettingsHeaderTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MailSettingsHeaderTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.MailSettingsHeaderTableLayoutPanel.Name = "MailSettingsHeaderTableLayoutPanel";
            this.MailSettingsHeaderTableLayoutPanel.RowCount = 1;
            this.MailSettingsHeaderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MailSettingsHeaderTableLayoutPanel.Size = new System.Drawing.Size(541, 34);
            this.MailSettingsHeaderTableLayoutPanel.TabIndex = 0;
            // 
            // MailSettingsHeaderLabel
            // 
            this.MailSettingsHeaderLabel.AutoSize = true;
            this.MailSettingsHeaderLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MailSettingsHeaderLabel.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.MailSettingsHeaderLabel.Location = new System.Drawing.Point(3, 0);
            this.MailSettingsHeaderLabel.Name = "MailSettingsHeaderLabel";
            this.MailSettingsHeaderLabel.Size = new System.Drawing.Size(207, 22);
            this.MailSettingsHeaderLabel.TabIndex = 0;
            this.MailSettingsHeaderLabel.Text = "Mail Sunucusu Ayarları";
            // 
            // SaveMailSettingsButton
            // 
            this.SaveMailSettingsButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SaveMailSettingsButton.Location = new System.Drawing.Point(446, 3);
            this.SaveMailSettingsButton.Name = "SaveMailSettingsButton";
            this.SaveMailSettingsButton.Size = new System.Drawing.Size(92, 28);
            this.SaveMailSettingsButton.TabIndex = 1;
            this.SaveMailSettingsButton.Text = "Kaydet";
            this.SaveMailSettingsButton.UseVisualStyleBackColor = true;
            // 
            // MailSettingsBgTableLayoutPanel
            // 
            this.MailSettingsBgTableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            this.MailSettingsBgTableLayoutPanel.ColumnCount = 1;
            this.MailSettingsBgTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MailSettingsBgTableLayoutPanel.Controls.Add(this.MailSettingsTableLayoutPanel, 0, 0);
            this.MailSettingsBgTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MailSettingsBgTableLayoutPanel.Location = new System.Drawing.Point(3, 43);
            this.MailSettingsBgTableLayoutPanel.Name = "MailSettingsBgTableLayoutPanel";
            this.MailSettingsBgTableLayoutPanel.RowCount = 1;
            this.MailSettingsBgTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MailSettingsBgTableLayoutPanel.Size = new System.Drawing.Size(541, 457);
            this.MailSettingsBgTableLayoutPanel.TabIndex = 1;
            // 
            // MailSettingsTableLayoutPanel
            // 
            this.MailSettingsTableLayoutPanel.BackColor = System.Drawing.Color.White;
            this.MailSettingsTableLayoutPanel.ColumnCount = 2;
            this.MailSettingsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.MailSettingsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.MailSettingsTableLayoutPanel.Controls.Add(this.SmtpHostLabel, 0, 0);
            this.MailSettingsTableLayoutPanel.Controls.Add(this.SmtpHostTextBox, 1, 0);
            this.MailSettingsTableLayoutPanel.Controls.Add(this.SmtpPortLabel, 0, 1);
            this.MailSettingsTableLayoutPanel.Controls.Add(this.SmtpPortTextBox, 1, 1);
            this.MailSettingsTableLayoutPanel.Controls.Add(this.SmtpUserLabel, 0, 2);
            this.MailSettingsTableLayoutPanel.Controls.Add(this.SmtpUserTextBox, 1, 2);
            this.MailSettingsTableLayoutPanel.Controls.Add(this.SmtpPasswordLabel, 0, 3);
            this.MailSettingsTableLayoutPanel.Controls.Add(this.SmtpPasswordTextBox, 1, 3);
            this.MailSettingsTableLayoutPanel.Controls.Add(this.UseSslLabel, 0, 4);
            this.MailSettingsTableLayoutPanel.Controls.Add(this.UseSslCheckBox, 1, 4);
            this.MailSettingsTableLayoutPanel.Controls.Add(this.SenderEmailLabel, 0, 5);
            this.MailSettingsTableLayoutPanel.Controls.Add(this.SenderEmailTextBox, 1, 5);
            this.MailSettingsTableLayoutPanel.Controls.Add(this.SenderNameLabel, 0, 6);
            this.MailSettingsTableLayoutPanel.Controls.Add(this.SenderNameTextBox, 1, 6);
            this.MailSettingsTableLayoutPanel.Controls.Add(this.UseDefaultCredentialsLabel, 0, 7);
            this.MailSettingsTableLayoutPanel.Controls.Add(this.UseDefaultCredentialsCheckBox, 1, 7);
            this.MailSettingsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MailSettingsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MailSettingsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MailSettingsTableLayoutPanel.Name = "MailSettingsTableLayoutPanel";
            this.MailSettingsTableLayoutPanel.Padding = new System.Windows.Forms.Padding(15);
            this.MailSettingsTableLayoutPanel.RowCount = 8;
            this.MailSettingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.MailSettingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.MailSettingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.MailSettingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.MailSettingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.MailSettingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.MailSettingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.MailSettingsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.MailSettingsTableLayoutPanel.Size = new System.Drawing.Size(541, 457);
            this.MailSettingsTableLayoutPanel.TabIndex = 0;
            // 
            // SmtpHostLabel
            // 
            this.SmtpHostLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SmtpHostLabel.AutoSize = true;
            this.SmtpHostLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SmtpHostLabel.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.SmtpHostLabel.Location = new System.Drawing.Point(18, 22);
            this.SmtpHostLabel.Name = "SmtpHostLabel";
            this.SmtpHostLabel.Size = new System.Drawing.Size(79, 16);
            this.SmtpHostLabel.TabIndex = 0;
            this.SmtpHostLabel.Text = "SMTP Host";
            // 
            // SmtpHostTextBox
            // 
            this.SmtpHostTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SmtpHostTextBox.Location = new System.Drawing.Point(219, 19);
            this.SmtpHostTextBox.Name = "SmtpHostTextBox";
            this.SmtpHostTextBox.PlaceholderText = "smtp.server.com";
            this.SmtpHostTextBox.Size = new System.Drawing.Size(298, 23);
            this.SmtpHostTextBox.TabIndex = 1;
            // 
            // SmtpPortLabel
            // 
            this.SmtpPortLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SmtpPortLabel.AutoSize = true;
            this.SmtpPortLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SmtpPortLabel.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.SmtpPortLabel.Location = new System.Drawing.Point(18, 53);
            this.SmtpPortLabel.Name = "SmtpPortLabel";
            this.SmtpPortLabel.Size = new System.Drawing.Size(80, 16);
            this.SmtpPortLabel.TabIndex = 2;
            this.SmtpPortLabel.Text = "SMTP Port";
            // 
            // SmtpPortTextBox
            // 
            this.SmtpPortTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SmtpPortTextBox.Location = new System.Drawing.Point(219, 50);
            this.SmtpPortTextBox.Name = "SmtpPortTextBox";
            this.SmtpPortTextBox.PlaceholderText = "587";
            this.SmtpPortTextBox.Size = new System.Drawing.Size(298, 23);
            this.SmtpPortTextBox.TabIndex = 3;
            // 
            // SmtpUserLabel
            // 
            this.SmtpUserLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SmtpUserLabel.AutoSize = true;
            this.SmtpUserLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SmtpUserLabel.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.SmtpUserLabel.Location = new System.Drawing.Point(18, 84);
            this.SmtpUserLabel.Name = "SmtpUserLabel";
            this.SmtpUserLabel.Size = new System.Drawing.Size(131, 16);
            this.SmtpUserLabel.TabIndex = 4;
            this.SmtpUserLabel.Text = "SMTP Kullanıcı Adı";
            // 
            // SmtpUserTextBox
            // 
            this.SmtpUserTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SmtpUserTextBox.Location = new System.Drawing.Point(219, 81);
            this.SmtpUserTextBox.Name = "SmtpUserTextBox";
            this.SmtpUserTextBox.PlaceholderText = "kullanici";
            this.SmtpUserTextBox.Size = new System.Drawing.Size(298, 23);
            this.SmtpUserTextBox.TabIndex = 5;
            // 
            // SmtpPasswordLabel
            // 
            this.SmtpPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SmtpPasswordLabel.AutoSize = true;
            this.SmtpPasswordLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SmtpPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.SmtpPasswordLabel.Location = new System.Drawing.Point(18, 115);
            this.SmtpPasswordLabel.Name = "SmtpPasswordLabel";
            this.SmtpPasswordLabel.Size = new System.Drawing.Size(88, 16);
            this.SmtpPasswordLabel.TabIndex = 6;
            this.SmtpPasswordLabel.Text = "SMTP Şifresi";
            // 
            // SmtpPasswordTextBox
            // 
            this.SmtpPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SmtpPasswordTextBox.Location = new System.Drawing.Point(219, 112);
            this.SmtpPasswordTextBox.Name = "SmtpPasswordTextBox";
            this.SmtpPasswordTextBox.PlaceholderText = "şifre";
            this.SmtpPasswordTextBox.Size = new System.Drawing.Size(298, 23);
            this.SmtpPasswordTextBox.TabIndex = 7;
            this.SmtpPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // UseSslLabel
            // 
            this.UseSslLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UseSslLabel.AutoSize = true;
            this.UseSslLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UseSslLabel.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.UseSslLabel.Location = new System.Drawing.Point(18, 146);
            this.UseSslLabel.Name = "UseSslLabel";
            this.UseSslLabel.Size = new System.Drawing.Size(111, 16);
            this.UseSslLabel.TabIndex = 8;
            this.UseSslLabel.Text = "SSL Kullanılsın?";
            // 
            // UseSslCheckBox
            // 
            this.UseSslCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UseSslCheckBox.AutoSize = true;
            this.UseSslCheckBox.Location = new System.Drawing.Point(219, 146);
            this.UseSslCheckBox.Name = "UseSslCheckBox";
            this.UseSslCheckBox.Size = new System.Drawing.Size(50, 19);
            this.UseSslCheckBox.TabIndex = 9;
            this.UseSslCheckBox.Text = "Evet";
            this.UseSslCheckBox.UseVisualStyleBackColor = true;
            // 
            // SenderEmailLabel
            // 
            this.SenderEmailLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SenderEmailLabel.AutoSize = true;
            this.SenderEmailLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SenderEmailLabel.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.SenderEmailLabel.Location = new System.Drawing.Point(18, 177);
            this.SenderEmailLabel.Name = "SenderEmailLabel";
            this.SenderEmailLabel.Size = new System.Drawing.Size(121, 16);
            this.SenderEmailLabel.TabIndex = 10;
            this.SenderEmailLabel.Text = "Gönderen E-Posta";
            // 
            // SenderEmailTextBox
            // 
            this.SenderEmailTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SenderEmailTextBox.Location = new System.Drawing.Point(219, 174);
            this.SenderEmailTextBox.Name = "SenderEmailTextBox";
            this.SenderEmailTextBox.PlaceholderText = "gonderen@example.com";
            this.SenderEmailTextBox.Size = new System.Drawing.Size(298, 23);
            this.SenderEmailTextBox.TabIndex = 11;
            // 
            // SenderNameLabel
            // 
            this.SenderNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SenderNameLabel.AutoSize = true;
            this.SenderNameLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SenderNameLabel.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.SenderNameLabel.Location = new System.Drawing.Point(18, 208);
            this.SenderNameLabel.Name = "SenderNameLabel";
            this.SenderNameLabel.Size = new System.Drawing.Size(100, 16);
            this.SenderNameLabel.TabIndex = 12;
            this.SenderNameLabel.Text = "Gönderen Adı";
            // 
            // SenderNameTextBox
            // 
            this.SenderNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SenderNameTextBox.Location = new System.Drawing.Point(219, 205);
            this.SenderNameTextBox.Name = "SenderNameTextBox";
            this.SenderNameTextBox.PlaceholderText = "İSKİ";
            this.SenderNameTextBox.Size = new System.Drawing.Size(298, 23);
            this.SenderNameTextBox.TabIndex = 13;
            // 
            // UseDefaultCredentialsLabel
            // 
            this.UseDefaultCredentialsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UseDefaultCredentialsLabel.AutoSize = true;
            this.UseDefaultCredentialsLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UseDefaultCredentialsLabel.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.UseDefaultCredentialsLabel.Location = new System.Drawing.Point(18, 239);
            this.UseDefaultCredentialsLabel.Name = "UseDefaultCredentialsLabel";
            this.UseDefaultCredentialsLabel.Size = new System.Drawing.Size(173, 16);
            this.UseDefaultCredentialsLabel.TabIndex = 14;
            this.UseDefaultCredentialsLabel.Text = "Varsayılan Kimlik Bilgileri";
            // 
            // UseDefaultCredentialsCheckBox
            // 
            this.UseDefaultCredentialsCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UseDefaultCredentialsCheckBox.AutoSize = true;
            this.UseDefaultCredentialsCheckBox.Location = new System.Drawing.Point(219, 239);
            this.UseDefaultCredentialsCheckBox.Name = "UseDefaultCredentialsCheckBox";
            this.UseDefaultCredentialsCheckBox.Size = new System.Drawing.Size(50, 19);
            this.UseDefaultCredentialsCheckBox.TabIndex = 15;
            this.UseDefaultCredentialsCheckBox.Text = "Evet";
            this.UseDefaultCredentialsCheckBox.UseVisualStyleBackColor = true;
            // 
            // MailTestHeaderLabel
            // 
            this.MailTestHeaderLabel.AutoSize = true;
            this.MailTestHeaderLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MailTestHeaderLabel.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.MailTestHeaderLabel.Location = new System.Drawing.Point(550, 0);
            this.MailTestHeaderLabel.Name = "MailTestHeaderLabel";
            this.MailTestHeaderLabel.Size = new System.Drawing.Size(177, 22);
            this.MailTestHeaderLabel.TabIndex = 2;
            this.MailTestHeaderLabel.Text = "Mail Sunucusu Testi";
            // 
            // MailTestBgTableLayoutPanel
            // 
            this.MailTestBgTableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            this.MailTestBgTableLayoutPanel.ColumnCount = 1;
            this.MailTestBgTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MailTestBgTableLayoutPanel.Controls.Add(this.MailTestContentTableLayoutPanel, 0, 0);
            this.MailTestBgTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MailTestBgTableLayoutPanel.Location = new System.Drawing.Point(547, 43);
            this.MailTestBgTableLayoutPanel.Name = "MailTestBgTableLayoutPanel";
            this.MailTestBgTableLayoutPanel.RowCount = 1;
            this.MailTestBgTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MailTestBgTableLayoutPanel.Size = new System.Drawing.Size(544, 457);
            this.MailTestBgTableLayoutPanel.TabIndex = 3;
            // 
            // MailTestContentTableLayoutPanel
            // 
            this.MailTestContentTableLayoutPanel.BackColor = System.Drawing.Color.White;
            this.MailTestContentTableLayoutPanel.ColumnCount = 2;
            this.MailTestContentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.MailTestContentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.MailTestContentTableLayoutPanel.Controls.Add(this.TestConnectionButton, 0, 0);
            this.MailTestContentTableLayoutPanel.Controls.Add(this.ResponseGroupBox, 1, 0);
            this.MailTestContentTableLayoutPanel.Controls.Add(this.TestEmailTextBox, 0, 1);
            this.MailTestContentTableLayoutPanel.Controls.Add(this.SendTestEmailButton, 0, 2);
            this.MailTestContentTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MailTestContentTableLayoutPanel.Location = new System.Drawing.Point(1, 1);
            this.MailTestContentTableLayoutPanel.Margin = new System.Windows.Forms.Padding(1);
            this.MailTestContentTableLayoutPanel.Name = "MailTestContentTableLayoutPanel";
            this.MailTestContentTableLayoutPanel.Padding = new System.Windows.Forms.Padding(15);
            this.MailTestContentTableLayoutPanel.RowCount = 4;
            this.MailTestContentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.MailTestContentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.MailTestContentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.MailTestContentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.MailTestContentTableLayoutPanel.Size = new System.Drawing.Size(542, 455);
            this.MailTestContentTableLayoutPanel.TabIndex = 0;
            // 
            // TestConnectionButton
            // 
            this.TestConnectionButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TestConnectionButton.AutoSize = true;
            this.TestConnectionButton.Location = new System.Drawing.Point(18, 18);
            this.TestConnectionButton.Name = "TestConnectionButton";
            this.TestConnectionButton.Size = new System.Drawing.Size(129, 25);
            this.TestConnectionButton.TabIndex = 0;
            this.TestConnectionButton.Text = "Sunucuya Bağlan";
            this.TestConnectionButton.UseVisualStyleBackColor = true;
            // 
            // TestEmailTextBox
            // 
            this.TestEmailTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TestEmailTextBox.Location = new System.Drawing.Point(18, 49);
            this.TestEmailTextBox.Name = "TestEmailTextBox";
            this.TestEmailTextBox.PlaceholderText = "test@example.com";
            this.TestEmailTextBox.Size = new System.Drawing.Size(179, 23);
            this.TestEmailTextBox.TabIndex = 1;
            // 
            // SendTestEmailButton
            // 
            this.SendTestEmailButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SendTestEmailButton.AutoSize = true;
            this.SendTestEmailButton.Location = new System.Drawing.Point(18, 80);
            this.SendTestEmailButton.Name = "SendTestEmailButton";
            this.SendTestEmailButton.Size = new System.Drawing.Size(176, 25);
            this.SendTestEmailButton.TabIndex = 2;
            this.SendTestEmailButton.Text = "Deneme E-Posta gönder";
            this.SendTestEmailButton.UseVisualStyleBackColor = true;
            // 
            // ResponseGroupBox
            // 
            this.ResponseGroupBox.Controls.Add(this.ResponseTextBox);
            this.ResponseGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResponseGroupBox.Location = new System.Drawing.Point(219, 18);
            this.ResponseGroupBox.Name = "ResponseGroupBox";
            this.ResponseGroupBox.Padding = new System.Windows.Forms.Padding(10);
            this.MailTestContentTableLayoutPanel.SetRowSpan(this.ResponseGroupBox, 4);
            this.ResponseGroupBox.Size = new System.Drawing.Size(305, 422);
            this.ResponseGroupBox.TabIndex = 3;
            this.ResponseGroupBox.TabStop = false;
            this.ResponseGroupBox.Text = "Cevap";
            // 
            // ResponseTextBox
            // 
            this.ResponseTextBox.BackColor = System.Drawing.Color.White;
            this.ResponseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResponseTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResponseTextBox.Location = new System.Drawing.Point(10, 26);
            this.ResponseTextBox.Multiline = true;
            this.ResponseTextBox.Name = "ResponseTextBox";
            this.ResponseTextBox.ReadOnly = true;
            this.ResponseTextBox.Size = new System.Drawing.Size(285, 386);
            this.ResponseTextBox.TabIndex = 0;
            // 
            // MailSettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MailSettingsMainTableLayoutPanel);
            this.Name = "MailSettingsPage";
            this.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.Size = new System.Drawing.Size(1094, 533);
            this.MailSettingsMainTableLayoutPanel.ResumeLayout(false);
            this.MailSettingsMainTableLayoutPanel.PerformLayout();
            this.MailSettingsHeaderTableLayoutPanel.ResumeLayout(false);
            this.MailSettingsHeaderTableLayoutPanel.PerformLayout();
            this.MailSettingsBgTableLayoutPanel.ResumeLayout(false);
            this.MailSettingsTableLayoutPanel.ResumeLayout(false);
            this.MailSettingsTableLayoutPanel.PerformLayout();
            this.MailTestBgTableLayoutPanel.ResumeLayout(false);
            this.MailTestContentTableLayoutPanel.ResumeLayout(false);
            this.MailTestContentTableLayoutPanel.PerformLayout();
            this.ResponseGroupBox.ResumeLayout(false);
            this.ResponseGroupBox.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MailSettingsMainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel MailSettingsHeaderTableLayoutPanel;
        private System.Windows.Forms.Label MailSettingsHeaderLabel;
        private System.Windows.Forms.Button SaveMailSettingsButton;
        private System.Windows.Forms.TableLayoutPanel MailSettingsBgTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel MailSettingsTableLayoutPanel;
        private System.Windows.Forms.Label SmtpHostLabel;
        private System.Windows.Forms.TextBox SmtpHostTextBox;
        private System.Windows.Forms.Label SmtpPortLabel;
        private System.Windows.Forms.TextBox SmtpPortTextBox;
        private System.Windows.Forms.Label SmtpUserLabel;
        private System.Windows.Forms.TextBox SmtpUserTextBox;
        private System.Windows.Forms.Label SmtpPasswordLabel;
        private System.Windows.Forms.TextBox SmtpPasswordTextBox;
        private System.Windows.Forms.Label UseSslLabel;
        private System.Windows.Forms.CheckBox UseSslCheckBox;
        private System.Windows.Forms.Label SenderEmailLabel;
        private System.Windows.Forms.TextBox SenderEmailTextBox;
        private System.Windows.Forms.Label SenderNameLabel;
        private System.Windows.Forms.TextBox SenderNameTextBox;
        private System.Windows.Forms.Label UseDefaultCredentialsLabel;
        private System.Windows.Forms.CheckBox UseDefaultCredentialsCheckBox;
        private System.Windows.Forms.Label MailTestHeaderLabel;
        private System.Windows.Forms.TableLayoutPanel MailTestBgTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel MailTestContentTableLayoutPanel;
        private System.Windows.Forms.Button TestConnectionButton;
        private System.Windows.Forms.TextBox TestEmailTextBox;
        private System.Windows.Forms.Button SendTestEmailButton;
        private System.Windows.Forms.GroupBox ResponseGroupBox;
        private System.Windows.Forms.TextBox ResponseTextBox;
    }
}
