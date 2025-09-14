using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using WinUI.Constants;
using WinUI.Services;

namespace WinUI.Forms
{
    public partial class NewUserForm : Form
    {
        private readonly IUserService _userService;

        public NewUserForm()
        {
            InitializeComponent();
            _userService = Program.Services.GetRequiredService<IUserService>();
            saveButton.Click += SaveButton_Click;
        }

        private async void SaveButton_Click(object? sender, EventArgs e)
        {
            var userName = userNameTextBox.Text.Trim();
            var email = emailTextBox.Text.Trim();
            var password = passwordTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Kullanıcı adı, e-posta ve şifre alanları zorunludur.", UserConstants.ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Lütfen geçerli bir e-posta adresi giriniz.", UserConstants.ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var command = new CreateUserCommand(userName, email, password);
                var user = await _userService.CreateAsync(command);
                if (user != null)
                {
                    MessageBox.Show(string.Format(UserConstants.UserSavedMessage, user.UserName), UserConstants.InfoTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kullanıcı kaydedilirken hata oluştu: {ex.Message}", UserConstants.ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
