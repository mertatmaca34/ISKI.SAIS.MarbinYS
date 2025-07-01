using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Entities;

namespace WinUI.Pages.Mail
{
    public partial class MailUsersPage : UserControl
    {
        public MailUsersPage()
        {
            InitializeComponent();
        }

        private void MailUsersPage_Load(object sender, EventArgs e)
        {
            List<MailUser> mockUsers = new()
            {
                new MailUser { Id = 1, FullName = "Ali Veli", Email = "ali@example.com", Role = "Admin", IsActive = true },
                new MailUser { Id = 2, FullName = "Ayşe", Email = "ayse@example.com", Role = "Kullanıcı", IsActive = false }
            };

            dgvMailUsers.AutoGenerateColumns = false;
            dgvMailUsers.Columns.Clear();
            dgvMailUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Ad Soyad",
                DataPropertyName = "FullName"
            });
            dgvMailUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Email",
                DataPropertyName = "Email"
            });
            dgvMailUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Rol",
                DataPropertyName = "Role"
            });
            dgvMailUsers.Columns.Add(new DataGridViewCheckBoxColumn
            {
                HeaderText = "Aktif",
                DataPropertyName = "IsActive"
            });
            dgvMailUsers.DataSource = mockUsers;
        }
    }
}
