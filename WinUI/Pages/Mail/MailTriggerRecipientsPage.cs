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
    public partial class MailTriggerRecipientsPage : UserControl
    {
        public MailTriggerRecipientsPage()
        {
            InitializeComponent();
        }

        private void MailTriggerRecipientsPage_Load(object sender, EventArgs e)
        {
            List<MailTriggerRecipient> mock = new()
            {
                new MailTriggerRecipient
                {
                    MailTrigger = new MailTrigger { Name = "Yüksek AKM" },
                    MailUser = new MailUser { FullName = "Ali Veli", Email = "ali@example.com" }
                },
                new MailTriggerRecipient
                {
                    MailTrigger = new MailTrigger { Name = "Düşük pH" },
                    MailUser = new MailUser { FullName = "Ayşe", Email = "ayse@example.com" }
                }
            };

            dgvRecipients.AutoGenerateColumns = false;
            dgvRecipients.Columns.Clear();
            dgvRecipients.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Olay",
                DataPropertyName = "TriggerName"
            });
            dgvRecipients.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Kullanıcı",
                DataPropertyName = "UserName"
            });
            dgvRecipients.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Email",
                DataPropertyName = "Email"
            });
            var display = mock.Select(r => new
            {
                TriggerName = r.MailTrigger.Name,
                UserName = r.MailUser.FullName,
                Email = r.MailUser.Email
            }).ToList();
            dgvRecipients.DataSource = display;
        }
    }
}
