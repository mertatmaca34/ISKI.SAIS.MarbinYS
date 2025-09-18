using System;
using System.Drawing;
using System.Windows.Forms;
using WinUI.Helpers;

namespace WinUI.Forms
{
    public partial class LoginForm : Form
    {
        private bool isPasswordVisible = true;
        private readonly Size _baseClientSize;

        public LoginForm()
        {
            InitializeComponent();

            _baseClientSize = ClientSize;
            ControlScalingHelper.CaptureBaseMetrics(this);
            Load += LoginForm_Load;
            Resize += LoginForm_Resize;
        }

        private void LoginForm_Load(object? sender, EventArgs e)
        {
            var scaleFactor = ControlScalingHelper.CalculateScaleFactor(_baseClientSize, ClientSize);
            ControlScalingHelper.ScaleFonts(this, scaleFactor);
        }

        private void LoginForm_Resize(object? sender, EventArgs e)
        {
            var scaleFactor = ControlScalingHelper.CalculateScaleFactor(_baseClientSize, ClientSize);
            ControlScalingHelper.ScaleFonts(this, scaleFactor);
        }

        private void EyeButton_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
                EyeButton.Image = Properties.Resources.eye_hide;
                PasswordTextBox.PlaceholderText = "•••••";
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
                EyeButton.Image = Properties.Resources.eye_show;
                PasswordTextBox.PlaceholderText = "sifre";
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            button1.Visible = true;

            if (isPasswordVisible)
            {
                button1.Text = "Giriş başarılı!";
                button1.BackColor = Color.FromArgb(213, 237, 219);
                return;
            }

            button1.Text = "Lütfen şifreyi gizleyin.";
            button1.BackColor = Color.FromArgb(248, 215, 218);
        }
    }
}
