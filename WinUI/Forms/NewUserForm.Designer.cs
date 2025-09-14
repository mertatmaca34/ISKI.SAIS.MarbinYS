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
            fullNameLabel = new Label();
            roleLabel = new Label();
            roleTextBox = new TextBox();
            titleLabel = new Label();
            saveButton = new WinUI.Controls.IBKS.Button();
            fullNameTextBox = new TextBox();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            mainLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            mainLayoutPanel.BackColor = Color.White;
            mainLayoutPanel.ColumnCount = 3;
            mainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.9999962F));
            mainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0000076F));
            mainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            mainLayoutPanel.Controls.Add(fullNameLabel, 0, 2);
            mainLayoutPanel.Controls.Add(roleLabel, 0, 6);
            mainLayoutPanel.Controls.Add(roleTextBox, 0, 7);
            mainLayoutPanel.Controls.Add(titleLabel, 0, 1);
            mainLayoutPanel.Controls.Add(saveButton, 0, 8);
            mainLayoutPanel.Controls.Add(fullNameTextBox, 0, 3);
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
            mainLayoutPanel.TabIndex = 3;
            // 
            // label1
            // 
            fullNameLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            fullNameLabel.Location = new Point(130, 158);
            fullNameLabel.Margin = new Padding(30, 0, 30, 0);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(72, 15);
            fullNameLabel.TabIndex = 1;
            fullNameLabel.Text = "Ad Soyad";
            // 
            // label2
            // 
            roleLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Calibri", 9.75F, FontStyle.Bold);
            roleLabel.Location = new Point(130, 322);
            roleLabel.Margin = new Padding(30, 0, 30, 0);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(27, 15);
            roleLabel.TabIndex = 3;
            roleLabel.Text = "Rol";
            // 
            // PasswordTextBox
            // 
            mainLayoutPanel.SetColumnSpan(roleTextBox, 2);
            roleTextBox.Dock = DockStyle.Fill;
            roleTextBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            roleTextBox.Location = new Point(130, 340);
            roleTextBox.Margin = new Padding(30, 3, 3, 3);
            roleTextBox.Name = "roleTextBox";
            roleTextBox.PlaceholderText = "rol";
            roleTextBox.Size = new Size(285, 27);
            roleTextBox.TabIndex = 4;
            // 
            // labelTitle
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
            // LoginButton
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
            saveButton.TabIndex = 6;
            saveButton.TextColor = Color.White;
            // 
            mainLayoutPanel.SetColumnSpan(fullNameTextBox, 2);
            fullNameTextBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            fullNameTextBox.Location = new Point(130, 176);
            fullNameTextBox.Margin = new Padding(30, 3, 3, 3);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.PlaceholderText = "ad soyad";
            fullNameTextBox.Size = new Size(285, 27);
            fullNameTextBox.TabIndex = 9;
            // 
            // label3
            // 
            emailLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            emailLabel.Location = new Point(130, 240);
            emailLabel.Margin = new Padding(30, 0, 30, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(30, 15);
            emailLabel.TabIndex = 1;
            emailLabel.Text = "Mail";
            // 
            // textBox2
            // 
            mainLayoutPanel.SetColumnSpan(emailTextBox, 2);
            emailTextBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            emailTextBox.Location = new Point(130, 258);
            emailTextBox.Margin = new Padding(30, 3, 3, 3);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PlaceholderText = "sample@sample.com";
            emailTextBox.Size = new Size(285, 27);
            emailTextBox.TabIndex = 9;
            // 
            // NewUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 521);
            Controls.Add(mainLayoutPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NewUserForm";
            Text = " Yeni Kullanıcı";
            mainLayoutPanel.ResumeLayout(false);
            mainLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainLayoutPanel;
        private Label fullNameLabel;
        private Label roleLabel;
        private TextBox roleTextBox;
        private Label titleLabel;
        private Controls.IBKS.Button saveButton;
        private TextBox fullNameTextBox;
        private Label emailLabel;
        private TextBox emailTextBox;
    }
}