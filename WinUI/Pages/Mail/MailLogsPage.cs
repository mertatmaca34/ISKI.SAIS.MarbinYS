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
    public partial class MailLogsPage : UserControl
    {
        public MailLogsPage()
        {
            InitializeComponent();
        }

        private void MailLogsPage_Load(object sender, EventArgs e)
        {
            List<MailLog> mock = new()
            {
                new MailLog
                {
                    MailTrigger = new MailTrigger { Name = "Yüksek AKM" },
                    RecipientEmail = "ali@example.com",
                    SentAt = DateTime.Now.AddMinutes(-30),
                    IsSuccess = true
                },
                new MailLog
                {
                    MailTrigger = new MailTrigger { Name = "Düşük pH" },
                    RecipientEmail = "ayse@example.com",
                    SentAt = DateTime.Now.AddMinutes(-10),
                    IsSuccess = false,
                    ErrorMessage = "SMTP hatası"
                }
            };

            dgvMailLogs.AutoGenerateColumns = false;
            dgvMailLogs.Columns.Clear();
            dgvMailLogs.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Olay",
                DataPropertyName = "TriggerName"
            });
            dgvMailLogs.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Alıcı",
                DataPropertyName = "RecipientEmail"
            });
            dgvMailLogs.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Tarih",
                DataPropertyName = "SentAt"
            });
            dgvMailLogs.Columns.Add(new DataGridViewCheckBoxColumn
            {
                HeaderText = "Başarılı",
                DataPropertyName = "IsSuccess"
            });
            var display = mock.Select(l => new
            {
                TriggerName = l.MailTrigger.Name,
                l.RecipientEmail,
                SentAt = l.SentAt.ToString("g"),
                l.IsSuccess
            }).ToList();
            dgvMailLogs.DataSource = display;
        }
    }
}
