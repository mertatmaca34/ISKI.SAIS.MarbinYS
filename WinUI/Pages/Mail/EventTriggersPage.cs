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
using Domain.Enums;

namespace WinUI.Pages.Mail
{
    public partial class EventTriggersPage: UserControl
    {
        public EventTriggersPage()
        {
            InitializeComponent();
        }

        private void EventTriggers_Load(object sender, EventArgs e)
        {
            List<MailTrigger> mockTriggers = new();
            // 1. Mock veri oluştur
            mockTriggers = new List<MailTrigger>
            {
                new MailTrigger
                {
                    Id = 1,
                    Name = "Yüksek AKM",
                    SensorTag = "AKM",
                    Operator = ComparisonOperator.GreaterThan,
                    Threshold = 50,
                    CooldownMinutes = 30,
                    IsActive = true
                },
                new MailTrigger
                {
                    Id = 2,
                    Name = "Düşük pH",
                    SensorTag = "pH",
                    Operator = ComparisonOperator.LessThan,
                    Threshold = 6.5,
                    CooldownMinutes = 60,
                    IsActive = false
                }
            };

            // 2. DataGridView yapılandırması
            dgvMailTriggers.AutoGenerateColumns = false;
            dgvMailTriggers.Columns.Clear();

            dgvMailTriggers.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Olay Adı",
                DataPropertyName = "Name"
            });

            dgvMailTriggers.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Koşul",
                DataPropertyName = "ConditionText"
            });

            dgvMailTriggers.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Cooldown (dk)",
                DataPropertyName = "CooldownMinutes"
            });

            dgvMailTriggers.Columns.Add(new DataGridViewCheckBoxColumn
            {
                HeaderText = "Aktif",
                DataPropertyName = "IsActive"
            });

            // 3. Verileri formatlayarak bind et
            var displayList = mockTriggers.Select(t => new
            {
                t.Name,
                ConditionText = $"{t.SensorTag} {GetOperatorSymbol(t.Operator)} {t.Threshold}",
                t.CooldownMinutes,
                t.IsActive
            }).ToList();

            dgvMailTriggers.DataSource = displayList;
        }


        string GetOperatorSymbol(ComparisonOperator op) => op switch
        {
            ComparisonOperator.GreaterThan => ">",
            ComparisonOperator.LessThan => "<",
            ComparisonOperator.Equal => "==",
            ComparisonOperator.GreaterOrEqual => ">=",
            ComparisonOperator.LessOrEqual => "<=",
            _ => "?"
        };
    }
}
