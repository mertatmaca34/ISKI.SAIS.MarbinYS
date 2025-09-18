using WinUI.Controls.IBKS;
using System.Windows.Forms;

namespace WinUI.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            PasswordTextBox = new TextBox();
            labelTitle = new Label();
            LoginButton = new WinUI.Controls.IBKS.Button();
            EyeButton = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            textBox1 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 4);
            tableLayoutPanel1.Controls.Add(PasswordTextBox, 0, 5);
            tableLayoutPanel1.Controls.Add(labelTitle, 0, 1);
            tableLayoutPanel1.Controls.Add(LoginButton, 0, 6);
            tableLayoutPanel1.Controls.Add(EyeButton, 2, 5);
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(100, 50, 100, 100);
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanel1.Size = new Size(579, 438);
            tableLayoutPanel1.TabIndex = 2;
            //
            // label1
            //
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(130, 158);
            label1.Margin = new Padding(30, 0, 30, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Adı";
            //
            // label2
            //
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(130, 240);
            label2.Margin = new Padding(30, 0, 30, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 3;
            label2.Text = "Şifre";
            //
            // PasswordTextBox
            //
            tableLayoutPanel1.SetColumnSpan(PasswordTextBox, 2);
            PasswordTextBox.Dock = DockStyle.Fill;
            PasswordTextBox.Font = new Font("Segoe UI", 12F);
            PasswordTextBox.Location = new Point(130, 258);
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
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(47, 47, 47);
            labelTitle.Location = new Point(205, 86);
            labelTitle.Margin = new Padding(3);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(167, 32);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Kullanıcı Girişi";
            //
            // LoginButton
            //
            LoginButton.BaseColor = Color.FromArgb(0, 130, 201);
            LoginButton.BorderRadius = 12;
            LoginButton.ButtonText = "Giriş Yap";
            tableLayoutPanel1.SetColumnSpan(LoginButton, 3);
            LoginButton.Dock = DockStyle.Fill;
            LoginButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LoginButton.Location = new Point(130, 319);
            LoginButton.Margin = new Padding(30, 23, 30, 13);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(319, 49);
            LoginButton.TabIndex = 6;
            LoginButton.TextColor = Color.White;
            LoginButton.Click += LoginButton_Click;
            // 
            // EyeButton
            // 
            EyeButton.FlatAppearance.BorderSize = 0;
            EyeButton.FlatStyle = FlatStyle.Flat;
            EyeButton.Image = Properties.Resources.eye_show;
            EyeButton.Location = new Point(421, 258);
            EyeButton.Name = "EyeButton";
            EyeButton.Size = new Size(24, 23);
            EyeButton.TabIndex = 7;
            EyeButton.UseVisualStyleBackColor = true;
            EyeButton.Click += EyeButton_Click;
            // 
            // button1
            // 
            tableLayoutPanel1.SetColumnSpan(button1, 3);
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(103, 53);
            button1.Name = "button1";
            button1.Size = new Size(373, 35);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            // 
            // textBox1
            // 
            tableLayoutPanel1.SetColumnSpan(textBox1, 2);
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(130, 176);
            textBox1.Margin = new Padding(30, 3, 3, 3);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "kullanıcı adı";
            textBox1.Size = new Size(285, 27);
            textBox1.TabIndex = 9;
            //
            // LoginForm
            //
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(579, 438);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 10F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Giriş Yap";
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
        private System.Windows.Forms.Button EyeButton;
        private System.Windows.Forms.Button button1;
        private TextBox textBox1;
    }
}