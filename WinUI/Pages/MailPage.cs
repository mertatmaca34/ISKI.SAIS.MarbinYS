using System;
using System.Drawing;
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
            ConfigureDataGridView(usersDataGridView);
            ConfigureDataGridView(dataGridView2);
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

        private static void ConfigureDataGridView(DataGridView grid)
        {
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.BackgroundColor = Color.White;
            grid.BorderStyle = BorderStyle.None;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248);
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 220, 220);
            grid.DefaultCellStyle.SelectionForeColor = Color.Black;
            grid.RowHeadersVisible = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeRows = false;
            grid.ReadOnly = true;
        }
    }
}
