using System;
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
            var fullName = fullNameTextBox.Text.Trim();
            var email = emailTextBox.Text.Trim();
            var role = roleTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Ad ve e-posta alanları zorunludur.", UserConstants.ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var command = new CreateUserCommand(fullName, email, role, true);
                var user = await _userService.CreateAsync(command);
                if (user != null)
                {
                    MessageBox.Show(string.Format(UserConstants.UserSavedMessage, user.FullName), UserConstants.InfoTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
