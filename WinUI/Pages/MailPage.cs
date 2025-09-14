using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using WinUI.Constants;
using WinUI.Forms;
using WinUI.Services;

namespace WinUI.Pages
{
    public partial class MailPage : UserControl
    {
        private readonly IUserService _userService;

        public MailPage()
        {
            InitializeComponent();
            _userService = Program.Services.GetRequiredService<IUserService>();
            Load += MailPage_Load;
            newUserButton.Click += NewUserButton_Click;
        }

        private async void MailPage_Load(object? sender, EventArgs e)
        {
            await LoadUsersAsync();
        }

        private async Task LoadUsersAsync()
        {
            try
            {
                var users = await _userService.GetListAsync();
                usersDataGridView.DataSource = users;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kullanıcılar yüklenirken hata: {ex.Message}", UserConstants.ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NewUserButton_Click(object? sender, EventArgs e)
        {
            using var form = new NewUserForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _ = LoadUsersAsync();
            }
        }
    }
}
