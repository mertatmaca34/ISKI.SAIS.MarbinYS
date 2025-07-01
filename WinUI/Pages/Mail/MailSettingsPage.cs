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
    public partial class MailSettingsPage : UserControl
    {
        public MailSettingsPage()
        {
            InitializeComponent();
        }

        private void MailSettingsPage_Load(object sender, EventArgs e)
        {
            var settings = new MailSetting
            {
                SmtpHost = "smtp.example.com",
                SmtpPort = 587,
                SmtpUser = "user",
                SmtpPassword = "password",
                UseSsl = true,
                SenderEmail = "noreply@example.com",
                SenderName = "System",
                UseDefaultCredentials = false
            };

            dgvSettings.AutoGenerateColumns = false;
            dgvSettings.Columns.Clear();
            dgvSettings.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Ayar",
                DataPropertyName = "Name"
            });
            dgvSettings.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Değer",
                DataPropertyName = "Value"
            });
            var data = new List<object>
            {
                new { Name = "SMTP Host", Value = settings.SmtpHost },
                new { Name = "SMTP Port", Value = settings.SmtpPort },
                new { Name = "SMTP User", Value = settings.SmtpUser },
                new { Name = "SMTP Password", Value = settings.SmtpPassword },
                new { Name = "Use SSL", Value = settings.UseSsl },
                new { Name = "Sender Email", Value = settings.SenderEmail },
                new { Name = "Sender Name", Value = settings.SenderName },
                new { Name = "Default Credentials", Value = settings.UseDefaultCredentials }
            };
            dgvSettings.DataSource = data;
        }
    }
}
