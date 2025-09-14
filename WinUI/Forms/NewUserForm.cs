using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using WinUI.Constants;
using WinUI.Models;
using WinUI.Services;

namespace WinUI.Forms
{
    public partial class NewUserForm : Form
    {
        private readonly IUserService _userService;
        private readonly int? _userId;

        public NewUserForm(UserDto? user = null)
        {
            InitializeComponent();
            _userService = Program.Services.GetRequiredService<IUserService>();
            saveButton.Click += SaveButton_Click;

            if (user != null)
            {
                _userId = user.Id;
                userNameTextBox.Text = user.UserName;
                emailTextBox.Text = user.Email;
                titleLabel.Text = "Kullanıcı Düzenle";
                Text = "Kullanıcı Düzenle";
            }
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
                if (_userId.HasValue)
                {
                    var updateCommand = new UpdateUserCommand(_userId.Value, userName, email, password);
                    var updated = await _userService.UpdateAsync(updateCommand);
                    if (updated != null)
                    {
                        MessageBox.Show(string.Format(UserConstants.UserUpdatedMessage, updated.UserName), UserConstants.InfoTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
                else
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
            }
            catch (Exception ex)
            {
                var action = _userId.HasValue ? "güncellenirken" : "kaydedilirken";
                MessageBox.Show($"Kullanıcı {action} hata oluştu: {ex.Message}", UserConstants.ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

