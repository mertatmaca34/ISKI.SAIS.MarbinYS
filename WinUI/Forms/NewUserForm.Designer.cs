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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            PasswordTextBox = new TextBox();
            labelTitle = new Label();
            LoginButton = new WinUI.Controls.IBKS.Button();
            EyeButton = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.9999962F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0000076F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 6);
            tableLayoutPanel1.Controls.Add(PasswordTextBox, 0, 7);
            tableLayoutPanel1.Controls.Add(labelTitle, 0, 1);
            tableLayoutPanel1.Controls.Add(LoginButton, 0, 8);
            tableLayoutPanel1.Controls.Add(EyeButton, 2, 7);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 4);
            tableLayoutPanel1.Controls.Add(textBox2, 0, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(100, 50, 100, 100);
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 13F));
            tableLayoutPanel1.Size = new Size(579, 521);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(130, 158);
            label1.Margin = new Padding(30, 0, 30, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 9.75F, FontStyle.Bold);
            label2.Location = new Point(130, 322);
            label2.Margin = new Padding(30, 0, 30, 0);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 3;
            label2.Text = "Şifre";
            // 
            // PasswordTextBox
            // 
            tableLayoutPanel1.SetColumnSpan(PasswordTextBox, 2);
            PasswordTextBox.Dock = DockStyle.Fill;
            PasswordTextBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            PasswordTextBox.Location = new Point(130, 340);
            PasswordTextBox.Margin = new Padding(30, 3, 3, 3);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PlaceholderText = "sifre";
            PasswordTextBox.Size = new Size(285, 27);
            PasswordTextBox.TabIndex = 4;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.None;
            labelTitle.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(labelTitle, 3);
            labelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(47, 47, 47);
            labelTitle.Location = new Point(225, 99);
            labelTitle.Margin = new Padding(3);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(129, 25);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Yeni Kullanıcı";
            // 
            // LoginButton
            // 
            LoginButton.BaseColor = Color.FromArgb(0, 130, 201);
            LoginButton.BorderRadius = 12;
            LoginButton.ButtonText = "Kaydet";
            tableLayoutPanel1.SetColumnSpan(LoginButton, 3);
            LoginButton.Dock = DockStyle.Fill;
            LoginButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LoginButton.Location = new Point(130, 401);
            LoginButton.Margin = new Padding(30, 23, 30, 13);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(319, 36);
            LoginButton.TabIndex = 6;
            LoginButton.TextColor = Color.White;
            // 
            // EyeButton
            // 
            EyeButton.FlatAppearance.BorderSize = 0;
            EyeButton.FlatStyle = FlatStyle.Flat;
            EyeButton.Image = Properties.Resources.eye_show;
            EyeButton.Location = new Point(421, 340);
            EyeButton.Name = "EyeButton";
            EyeButton.Size = new Size(24, 23);
            EyeButton.TabIndex = 7;
            EyeButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            tableLayoutPanel1.SetColumnSpan(textBox1, 2);
            textBox1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(130, 176);
            textBox1.Margin = new Padding(30, 3, 3, 3);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "kullanıcı adı";
            textBox1.Size = new Size(285, 27);
            textBox1.TabIndex = 9;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(130, 240);
            label3.Margin = new Padding(30, 0, 30, 0);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 1;
            label3.Text = "Mail";
            // 
            // textBox2
            // 
            tableLayoutPanel1.SetColumnSpan(textBox2, 2);
            textBox2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox2.Location = new Point(130, 258);
            textBox2.Margin = new Padding(30, 3, 3, 3);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "sample@sample.com";
            textBox2.Size = new Size(285, 27);
            textBox2.TabIndex = 9;
            // 
            // NewUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 521);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NewUserForm";
            Text = " Yeni Kullanıcı";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private TextBox PasswordTextBox;
        private Label labelTitle;
        private Controls.IBKS.Button LoginButton;
        private Button EyeButton;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
    }
}