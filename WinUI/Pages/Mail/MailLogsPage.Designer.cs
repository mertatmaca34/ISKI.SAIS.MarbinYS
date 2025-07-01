using Domain.Entities;

namespace WinUI.Pages.Mail
{
    partial class MailLogsPage
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            titleBarControl1 = new WinUI.Controls.IBKS.TitleBarControl();
            dgvMailLogs = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMailLogs).BeginInit();
            SuspendLayout();
            // tableLayoutPanel1
            tableLayoutPanel1.BackColor = Color.WhiteSmoke;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(titleBarControl1, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvMailLogs, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(6);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(901, 517);
            tableLayoutPanel1.TabIndex = 0;
            // titleBarControl1
            titleBarControl1.BackColor = Color.FromArgb(235, 235, 235);
            titleBarControl1.Dock = DockStyle.Fill;
            titleBarControl1.Location = new Point(9, 9);
            titleBarControl1.Name = "titleBarControl1";
            titleBarControl1.Padding = new Padding(1);
            titleBarControl1.Size = new Size(883, 54);
            titleBarControl1.TabIndex = 0;
            titleBarControl1.TitleBarText = "Mail Logları";
            // dgvMailLogs
            dgvMailLogs.AllowUserToAddRows = false;
            dgvMailLogs.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 248, 248);
            dgvMailLogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvMailLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMailLogs.BackgroundColor = Color.White;
            dgvMailLogs.BorderStyle = BorderStyle.None;
            dgvMailLogs.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMailLogs.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(40, 40, 45);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvMailLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvMailLogs.ColumnHeadersHeight = 44;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvMailLogs.DefaultCellStyle = dataGridViewCellStyle3;
            dgvMailLogs.ColumnHeadersDefaultCellStyle.BackColor = Color.DimGray;
            dgvMailLogs.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvMailLogs.DefaultCellStyle.BackColor = Color.White;
            dgvMailLogs.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250);
            dgvMailLogs.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 113, 188);
            dgvMailLogs.Dock = DockStyle.Top;
            dgvMailLogs.AdvancedColumnHeadersBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.OutsetDouble;
            dgvMailLogs.EnableHeadersVisualStyles = false;
            dgvMailLogs.GridColor = Color.FromArgb(230, 230, 230);
            dgvMailLogs.Location = new Point(9, 69);
            dgvMailLogs.MaximumSize = new Size(0, 250);
            dgvMailLogs.Name = "dgvMailLogs";
            dgvMailLogs.RowHeadersVisible = false;
            dgvMailLogs.RowTemplate.Height = 38;
            dgvMailLogs.Size = new Size(883, 150);
            dgvMailLogs.TabIndex = 1;
            // MailLogsPage
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "MailLogsPage";
            Size = new Size(901, 517);
            Load += MailLogsPage_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMailLogs).EndInit();
            ResumeLayout(false);
        }

        private TableLayoutPanel tableLayoutPanel1;
        private Controls.IBKS.TitleBarControl titleBarControl1;
        private DataGridView dgvMailLogs;
    }
}
