using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using WinUI.Constants;
using WinUI.Forms;
using WinUI.Models;
using WinUI.Services;

namespace WinUI.Pages
{
    public partial class MailPage : UserControl
    {
        private readonly IUserService _userService;
        private readonly IMailAlarmService _mailAlarmService;

        public MailPage()
        {
            InitializeComponent();
            _userService = Program.Services.GetRequiredService<IUserService>();
            _mailAlarmService = Program.Services.GetRequiredService<IMailAlarmService>();
            Load += MailPage_Load;
            newUserButton.Click += NewUserButton_Click;
            ConfigureDataGridView(usersDataGridView);
            ConfigureDataGridView(alarmsDataGridView);
            usersDataGridView.CellContentClick += UsersDataGridView_CellContentClick;
            usersDataGridView.SelectionChanged += UsersDataGridView_SelectionChanged;
            SaveAlarmsButton.Click += SaveAlarmsButton_Click;
            alarmsDataGridView.ReadOnly = true;
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
                ConfigureUserColumns();
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

        private void ConfigureUserColumns()
        {
            if (usersDataGridView.Columns["Id"] != null)
                usersDataGridView.Columns["Id"].Visible = false;

            if (usersDataGridView.Columns["UserName"] != null)
                usersDataGridView.Columns["UserName"].HeaderText = "Kullanıcı Adı";

            if (usersDataGridView.Columns["Email"] != null)
                usersDataGridView.Columns["Email"].HeaderText = "Mail";

            if (usersDataGridView.Columns["Edit"] == null)
            {
                var editColumn = new DataGridViewImageColumn
                {
                    Name = "Edit",
                    HeaderText = string.Empty,
                    Image = Properties.Resources.edit_48px,
                    ImageLayout = DataGridViewImageCellLayout.Zoom,
                    Width = 32
                };
                usersDataGridView.Columns.Insert(0, editColumn);
            }

            if (usersDataGridView.Columns["Delete"] == null)
            {
                var deleteColumn = new DataGridViewImageColumn
                {
                    Name = "Delete",
                    HeaderText = string.Empty,
                    Image = Properties.Resources.delete_48px,
                    ImageLayout = DataGridViewImageCellLayout.Zoom,
                    Width = 32
                };
                usersDataGridView.Columns.Insert(1, deleteColumn);
            }
        }

        private async void UsersDataGridView_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var column = usersDataGridView.Columns[e.ColumnIndex];
            if (column.Name != "Edit" && column.Name != "Delete")
                return;

            if (usersDataGridView.Rows[e.RowIndex].DataBoundItem is not UserDto user)
                return;

            if (column.Name == "Edit")
            {
                using var form = new NewUserForm(user);
                if (form.ShowDialog() == DialogResult.OK)
                    await LoadUsersAsync();
            }
            else if (column.Name == "Delete")
            {
                var result = MessageBox.Show(UserConstants.UserDeleteConfirmMessage, UserConstants.InfoTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        await _userService.DeleteAsync(user.Id);
                        MessageBox.Show(string.Format(UserConstants.UserDeletedMessage, user.UserName), UserConstants.InfoTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadUsersAsync();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Kullanıcı silinirken hata: {ex.Message}", UserConstants.ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void UsersDataGridView_SelectionChanged(object? sender, EventArgs e)
        {
            if (usersDataGridView.CurrentRow?.DataBoundItem is not UserDto user)
            {
                alarmsDataGridView.DataSource = null;
                alarmsDataGridView.ReadOnly = true;
                return;
            }

            await LoadAlarmsAsync(user.Id);
        }

        private async Task LoadAlarmsAsync(int userId)
        {
            try
            {
                var alarms = await _mailAlarmService.GetListAsync(userId) ?? new List<MailAlarmDto>();
                alarmsDataGridView.DataSource = alarms;
                ConfigureAlarmColumns();
                alarmsDataGridView.ReadOnly = false;
                alarmsDataGridView.Columns["Name"].ReadOnly = true;
                alarmsDataGridView.Columns["Limit"].ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Alarmlar yüklenirken hata: {ex.Message}", UserConstants.ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureAlarmColumns()
        {
            if (alarmsDataGridView.Columns["Id"] != null)
                alarmsDataGridView.Columns["Id"].Visible = false;

            if (alarmsDataGridView.Columns["Name"] != null)
                alarmsDataGridView.Columns["Name"].HeaderText = "Alarm";

            if (alarmsDataGridView.Columns["Limit"] != null)
                alarmsDataGridView.Columns["Limit"].HeaderText = "Limit";

            if (alarmsDataGridView.Columns["IsActive"] != null)
                alarmsDataGridView.Columns["IsActive"].HeaderText = "Aktif";
        }

        private async void SaveAlarmsButton_Click(object? sender, EventArgs e)
        {
            if (usersDataGridView.CurrentRow?.DataBoundItem is not UserDto user)
                return;

            if (alarmsDataGridView.DataSource is not List<MailAlarmDto> alarms)
                return;

            var activeIds = alarms.Where(a => a.IsActive).Select(a => a.Id).ToList();

            try
            {
                await _mailAlarmService.UpdateAsync(user.Id, activeIds);
                MessageBox.Show("Alarmlar kaydedildi.", UserConstants.InfoTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Alarmlar kaydedilirken hata: {ex.Message}", UserConstants.ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
