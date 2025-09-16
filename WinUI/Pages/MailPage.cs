using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        private readonly IChannelNameProvider _channelProvider;

        public MailPage(IUserService userService, IMailAlarmService mailAlarmService, IChannelNameProvider channelProvider)
        {
            InitializeComponent();

            _userService = userService;
            _mailAlarmService = mailAlarmService;
            _channelProvider = channelProvider;

            Load += MailPage_Load;
            newUserButton.Click += NewUserButton_Click;
            usersDataGridView.CellContentClick += UsersDataGridView_CellContentClick;
            usersDataGridView.SelectionChanged += UsersDataGridView_SelectionChanged;
            SaveAlarmsButton.Click += SaveAlarmsButton_Click;
            alarmsDataGridView.ReadOnly = true;
            alarmsDataGridView.CellContentClick += AlarmsDataGridView_CellContentClick;
        }

        private async void MailPage_Load(object? sender, EventArgs e)
        {
            ConfigureDataGridView(usersDataGridView);
            ConfigureDataGridView(alarmsDataGridView);

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

            if (usersDataGridView.Columns["Edit"] is DataGridViewImageColumn edit)
            {
                edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                edit.Width = 36;
            }

            if (usersDataGridView.Columns["Delete"] is DataGridViewImageColumn delete)
            {
                delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                delete.Width = 36;
            }

            if (usersDataGridView.Columns["UserName"] is DataGridViewColumn userNameColumn)
            {
                userNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                userNameColumn.FillWeight = 45f;
                userNameColumn.MinimumWidth = 120;
            }

            if (usersDataGridView.Columns["Email"] is DataGridViewColumn emailColumn)
            {
                emailColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                emailColumn.FillWeight = 55f;
                emailColumn.MinimumWidth = 180;
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
                alarmsDataGridView.Columns[nameof(MailAlarmDto.Name)].ReadOnly = true;
                alarmsDataGridView.Columns[nameof(MailAlarmDto.Limit)].ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format(MailAlarmConstants.LoadErrorMessage, ex.Message), UserConstants.ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureAlarmColumns()
        {
            if (alarmsDataGridView.Columns[nameof(MailAlarmDto.Id)] != null)
                alarmsDataGridView.Columns[nameof(MailAlarmDto.Id)].Visible = false;

            if (alarmsDataGridView.Columns[nameof(MailAlarmDto.Name)] != null)
                alarmsDataGridView.Columns[nameof(MailAlarmDto.Name)].HeaderText = MailAlarmConstants.AlarmHeader;

            if (alarmsDataGridView.Columns[nameof(MailAlarmDto.Limit)] != null)
                alarmsDataGridView.Columns[nameof(MailAlarmDto.Limit)].HeaderText = MailAlarmConstants.LimitHeader;

            if (alarmsDataGridView.Columns[nameof(MailAlarmDto.IsActive)] != null)
                alarmsDataGridView.Columns[nameof(MailAlarmDto.IsActive)].HeaderText = MailAlarmConstants.ActiveHeader;

            if (alarmsDataGridView.Columns[nameof(MailAlarmDto.Channel)] != null)
                alarmsDataGridView.Columns[nameof(MailAlarmDto.Channel)].Visible = false;

            if (alarmsDataGridView.Columns[nameof(MailAlarmDto.MailSubject)] != null)
                alarmsDataGridView.Columns[nameof(MailAlarmDto.MailSubject)].Visible = false;

            if (alarmsDataGridView.Columns[nameof(MailAlarmDto.MailBody)] != null)
                alarmsDataGridView.Columns[nameof(MailAlarmDto.MailBody)].Visible = false;

            if (alarmsDataGridView.Columns["Edit"] == null)
            {
                var editColumn2 = new DataGridViewImageColumn
                {
                    Name = "Edit",
                    HeaderText = string.Empty,
                    Image = Properties.Resources.edit_48px,
                    ImageLayout = DataGridViewImageCellLayout.Zoom,
                    Width = 32
                };
                alarmsDataGridView.Columns.Insert(0, editColumn2);
            }

            if (alarmsDataGridView.Columns["Edit"] is DataGridViewImageColumn editColumn)
            {
                editColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                editColumn.Width = 36;
            }

            if (alarmsDataGridView.Columns[nameof(MailAlarmDto.Name)] is DataGridViewColumn nameColumn)
            {
                nameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                nameColumn.FillWeight = 60f;
                nameColumn.MinimumWidth = 180;
            }

            if (alarmsDataGridView.Columns[nameof(MailAlarmDto.Limit)] is DataGridViewColumn limitColumn)
            {
                limitColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                limitColumn.FillWeight = 20f;
                limitColumn.MinimumWidth = 90;
                limitColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (alarmsDataGridView.Columns[nameof(MailAlarmDto.IsActive)] is DataGridViewColumn activeColumn)
            {
                activeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                activeColumn.FillWeight = 20f;
                activeColumn.MinimumWidth = 90;
            }
        }

        private async void AlarmsDataGridView_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var column = alarmsDataGridView.Columns[e.ColumnIndex];
            if (column.Name != "Edit")
                return;

            if (alarmsDataGridView.Rows[e.RowIndex].DataBoundItem is not MailAlarmDto alarm)
                return;

            using var form = new EditMailAlarmForm(alarm, _mailAlarmService, _channelProvider);
            if (form.ShowDialog() == DialogResult.OK &&
                usersDataGridView.CurrentRow?.DataBoundItem is UserDto user)
            {
                await LoadAlarmsAsync(user.Id);
            }
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
                MessageBox.Show(MailAlarmConstants.SaveSuccessMessage, UserConstants.InfoTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format(MailAlarmConstants.SaveErrorMessage, ex.Message), UserConstants.ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
