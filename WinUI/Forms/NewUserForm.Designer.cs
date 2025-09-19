namespace WinUI.Forms
{
    partial class NewUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUserForm));
            mainLayoutPanel = new TableLayoutPanel();
            userNameLabel = new Label();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            titleLabel = new Label();
            saveButton = new WinUI.Controls.IBKS.Button();
            userNameTextBox = new TextBox();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            mainLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            mainLayoutPanel.BackColor = Color.White;
            mainLayoutPanel.ColumnCount = 3;
            mainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.9999962F));
            mainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0000076F));
            mainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            mainLayoutPanel.Controls.Add(userNameLabel, 0, 2);
            mainLayoutPanel.Controls.Add(passwordLabel, 0, 6);
            mainLayoutPanel.Controls.Add(passwordTextBox, 0, 7);
            mainLayoutPanel.Controls.Add(titleLabel, 0, 1);
            mainLayoutPanel.Controls.Add(saveButton, 0, 8);
            mainLayoutPanel.Controls.Add(userNameTextBox, 0, 3);
            mainLayoutPanel.Controls.Add(emailLabel, 0, 4);
            mainLayoutPanel.Controls.Add(emailTextBox, 0, 5);
            mainLayoutPanel.Dock = DockStyle.Fill;
            mainLayoutPanel.Location = new Point(0, 0);
            mainLayoutPanel.Name = "mainLayoutPanel";
            mainLayoutPanel.Padding = new Padding(100, 50, 100, 100);
            mainLayoutPanel.RowCount = 10;
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 13F));
            mainLayoutPanel.Size = new Size(579, 521);
            mainLayoutPanel.TabIndex = 0;
            // 
            // userNameLabel
            // 
            userNameLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            userNameLabel.Location = new Point(130, 158);
            userNameLabel.Margin = new Padding(30, 0, 30, 0);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(72, 15);
            userNameLabel.TabIndex = 0;
            userNameLabel.Text = "Kullanıcı Adı";
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Calibri", 9.75F, FontStyle.Bold);
            passwordLabel.Location = new Point(130, 322);
            passwordLabel.Margin = new Padding(30, 0, 30, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(32, 15);
            passwordLabel.TabIndex = 0;
            passwordLabel.Text = "Şifre";
            // 
            // passwordTextBox
            // 
            mainLayoutPanel.SetColumnSpan(passwordTextBox, 2);
            passwordTextBox.Dock = DockStyle.Fill;
            passwordTextBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            passwordTextBox.Location = new Point(130, 340);
            passwordTextBox.Margin = new Padding(30, 3, 3, 3);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "şifre";
            passwordTextBox.Size = new Size(285, 27);
            passwordTextBox.TabIndex = 2;
            // 
            // titleLabel
            // 
            titleLabel.Anchor = AnchorStyles.None;
            titleLabel.AutoSize = true;
            mainLayoutPanel.SetColumnSpan(titleLabel, 3);
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(47, 47, 47);
            titleLabel.Location = new Point(225, 99);
            titleLabel.Margin = new Padding(3);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(129, 25);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Yeni Kullanıcı";
            // 
            // saveButton
            // 
            saveButton.BaseColor = Color.FromArgb(0, 130, 201);
            saveButton.BorderRadius = 12;
            saveButton.ButtonText = "Kaydet";
            mainLayoutPanel.SetColumnSpan(saveButton, 3);
            saveButton.Dock = DockStyle.Fill;
            saveButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            saveButton.Location = new Point(130, 401);
            saveButton.Margin = new Padding(30, 23, 30, 13);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(319, 36);
            saveButton.TabIndex = 3;
            saveButton.TextColor = Color.White;
            // 
            // userNameTextBox
            // 
            mainLayoutPanel.SetColumnSpan(userNameTextBox, 2);
            userNameTextBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            userNameTextBox.Location = new Point(130, 176);
            userNameTextBox.Margin = new Padding(30, 3, 3, 3);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.PlaceholderText = "kullanıcı adı";
            userNameTextBox.Size = new Size(285, 27);
            userNameTextBox.TabIndex = 0;
            // 
            // emailLabel
            // 
            emailLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            emailLabel.Location = new Point(130, 240);
            emailLabel.Margin = new Padding(30, 0, 30, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(30, 15);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "Mail";
            // 
            // emailTextBox
            // 
            mainLayoutPanel.SetColumnSpan(emailTextBox, 2);
            emailTextBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            emailTextBox.Location = new Point(130, 258);
            emailTextBox.Margin = new Padding(30, 3, 3, 3);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PlaceholderText = "sample@sample.com";
            emailTextBox.Size = new Size(285, 27);
            emailTextBox.TabIndex = 1;
            // 
            // NewUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 521);
            Controls.Add(mainLayoutPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NewUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Yeni Kullanıcı";
            mainLayoutPanel.ResumeLayout(false);
            mainLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainLayoutPanel;
        private Label userNameLabel;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private Label titleLabel;
        private Controls.IBKS.Button saveButton;
        private TextBox userNameTextBox;
        private Label emailLabel;
        private TextBox emailTextBox;
    }
}