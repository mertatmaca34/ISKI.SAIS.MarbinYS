
using Domain.Entities;
using Domain.Enums;

namespace WinUI.Pages.Mail
{
    partial class EventTriggersPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            titleBarControl1 = new WinUI.Controls.IBKS.TitleBarControl();
            dgvMailTriggers = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMailTriggers).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.WhiteSmoke;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(titleBarControl1, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvMailTriggers, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(6);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(901, 517);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // titleBarControl1
            // 
            titleBarControl1.BackColor = Color.FromArgb(235, 235, 235);
            titleBarControl1.Dock = DockStyle.Fill;
            titleBarControl1.Location = new Point(9, 9);
            titleBarControl1.Name = "titleBarControl1";
            titleBarControl1.Padding = new Padding(1);
            titleBarControl1.Size = new Size(883, 54);
            titleBarControl1.TabIndex = 0;
            titleBarControl1.TitleBarText = "Olay Tanımları";
            // 
            // dgvMailTriggers
            // 
            dgvMailTriggers.AllowUserToAddRows = false;
            dgvMailTriggers.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(248, 248, 248);
            dgvMailTriggers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvMailTriggers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMailTriggers.BackgroundColor = Color.White;
            dgvMailTriggers.BorderStyle = BorderStyle.None;
            dgvMailTriggers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMailTriggers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(40, 40, 45);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvMailTriggers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvMailTriggers.ColumnHeadersHeight = 44;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvMailTriggers.DefaultCellStyle = dataGridViewCellStyle6;
            dgvMailTriggers.ColumnHeadersDefaultCellStyle.BackColor = Color.DimGray; // Mavi ton
            dgvMailTriggers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvMailTriggers.DefaultCellStyle.BackColor = Color.White;
            dgvMailTriggers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250); // çok açık gri
            dgvMailTriggers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 113, 188); // Mavi (uyumlu)
            dgvMailTriggers.Dock = DockStyle.Top;
            dgvMailTriggers.AdvancedColumnHeadersBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.OutsetDouble;
            dgvMailTriggers.EnableHeadersVisualStyles = false;
            dgvMailTriggers.GridColor = Color.FromArgb(230, 230, 230);
            dgvMailTriggers.Location = new Point(9, 69);
            dgvMailTriggers.MaximumSize = new Size(0, 250);
            dgvMailTriggers.Name = "dgvMailTriggers";
            dgvMailTriggers.RowHeadersVisible = false;
            dgvMailTriggers.RowTemplate.Height = 38;
            dgvMailTriggers.Size = new Size(883, 150);
            dgvMailTriggers.TabIndex = 1;
            // 
            // EventTriggersPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "EventTriggersPage";
            Size = new Size(901, 517);
            Load += EventTriggers_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMailTriggers).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Controls.IBKS.TitleBarControl titleBarControl1;
        private DataGridView dgvMailTriggers;
    }
}
