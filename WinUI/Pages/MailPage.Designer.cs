
namespace WinUI.Pages
{
    partial class MailPage
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
            tableLayoutPanel1 = new TableLayoutPanel();
            titleBarControl1 = new WinUI.Controls.IBKS.TitleBarControl();
            PanelContent = new Panel();
            StationSettingsBgTableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            ApiTestBgTableLayoutPanel = new TableLayoutPanel();
            alarmsDataGridView = new DataGridView();
            usersHeaderTableLayoutPanel = new TableLayoutPanel();
            usersLabel = new Label();
            newUserButton = new Button();
            usersTableLayoutPanel = new TableLayoutPanel();
            usersDataGridView = new DataGridView();
            nameColumn = new DataGridViewTextBoxColumn();
            valueColumn = new DataGridViewTextBoxColumn();
            SaveAlarmsButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            PanelContent.SuspendLayout();
            StationSettingsBgTableLayoutPanel.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ApiTestBgTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)alarmsDataGridView).BeginInit();
            usersHeaderTableLayoutPanel.SuspendLayout();
            usersTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usersDataGridView).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(titleBarControl1, 0, 0);
            tableLayoutPanel1.Controls.Add(PanelContent, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(8);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1170, 677);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // titleBarControl1
            // 
            titleBarControl1.BackColor = Color.FromArgb(235, 235, 235);
            tableLayoutPanel1.SetColumnSpan(titleBarControl1, 2);
            titleBarControl1.Dock = DockStyle.Fill;
            titleBarControl1.Location = new Point(11, 11);
            titleBarControl1.Name = "titleBarControl1";
            titleBarControl1.Padding = new Padding(1);
            titleBarControl1.Size = new Size(1148, 32);
            titleBarControl1.TabIndex = 0;
            titleBarControl1.TitleBarText = "Mail Alarmları";
            // 
            // PanelContent
            // 
            tableLayoutPanel1.SetColumnSpan(PanelContent, 2);
            PanelContent.Controls.Add(StationSettingsBgTableLayoutPanel);
            PanelContent.Dock = DockStyle.Fill;
            PanelContent.Location = new Point(8, 46);
            PanelContent.Margin = new Padding(0);
            PanelContent.Name = "PanelContent";
            PanelContent.Padding = new Padding(60, 30, 0, 60);
            tableLayoutPanel1.SetRowSpan(PanelContent, 2);
            PanelContent.Size = new Size(1154, 623);
            PanelContent.TabIndex = 1;
            // 
            // StationSettingsBgTableLayoutPanel
            // 
            StationSettingsBgTableLayoutPanel.ColumnCount = 2;
            StationSettingsBgTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            StationSettingsBgTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            StationSettingsBgTableLayoutPanel.Controls.Add(tableLayoutPanel2, 1, 0);
            StationSettingsBgTableLayoutPanel.Controls.Add(ApiTestBgTableLayoutPanel, 1, 1);
            StationSettingsBgTableLayoutPanel.Controls.Add(usersHeaderTableLayoutPanel, 0, 0);
            StationSettingsBgTableLayoutPanel.Controls.Add(usersTableLayoutPanel, 0, 1);
            StationSettingsBgTableLayoutPanel.Dock = DockStyle.Fill;
            StationSettingsBgTableLayoutPanel.Location = new Point(60, 30);
            StationSettingsBgTableLayoutPanel.Name = "StationSettingsBgTableLayoutPanel";
            StationSettingsBgTableLayoutPanel.RowCount = 2;
            StationSettingsBgTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            StationSettingsBgTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            StationSettingsBgTableLayoutPanel.Size = new Size(1094, 533);
            StationSettingsBgTableLayoutPanel.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(SaveAlarmsButton, 1, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(547, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(547, 40);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 22);
            label1.TabIndex = 0;
            label1.Text = "Alarmlar";
            // 
            // ApiTestBgTableLayoutPanel
            // 
            ApiTestBgTableLayoutPanel.BackColor = Color.FromArgb(235, 235, 235);
            ApiTestBgTableLayoutPanel.ColumnCount = 1;
            ApiTestBgTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ApiTestBgTableLayoutPanel.Controls.Add(alarmsDataGridView, 0, 0);
            ApiTestBgTableLayoutPanel.Dock = DockStyle.Fill;
            ApiTestBgTableLayoutPanel.Location = new Point(547, 40);
            ApiTestBgTableLayoutPanel.Margin = new Padding(0, 0, 5, 0);
            ApiTestBgTableLayoutPanel.Name = "ApiTestBgTableLayoutPanel";
            ApiTestBgTableLayoutPanel.RowCount = 1;
            ApiTestBgTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ApiTestBgTableLayoutPanel.Size = new Size(542, 493);
            ApiTestBgTableLayoutPanel.TabIndex = 6;
            // 
            // alarmsDataGridView
            // 
            alarmsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            alarmsDataGridView.Dock = DockStyle.Fill;
            alarmsDataGridView.Location = new Point(3, 3);
            alarmsDataGridView.Name = "alarmsDataGridView";
            alarmsDataGridView.Size = new Size(536, 487);
            alarmsDataGridView.TabIndex = 1;
            // 
            // usersHeaderTableLayoutPanel
            // 
            usersHeaderTableLayoutPanel.ColumnCount = 2;
            usersHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            usersHeaderTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            usersHeaderTableLayoutPanel.Controls.Add(usersLabel, 0, 0);
            usersHeaderTableLayoutPanel.Controls.Add(newUserButton, 1, 0);
            usersHeaderTableLayoutPanel.Dock = DockStyle.Fill;
            usersHeaderTableLayoutPanel.Location = new Point(0, 0);
            usersHeaderTableLayoutPanel.Margin = new Padding(0);
            usersHeaderTableLayoutPanel.Name = "usersHeaderTableLayoutPanel";
            usersHeaderTableLayoutPanel.RowCount = 1;
            usersHeaderTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            usersHeaderTableLayoutPanel.Size = new Size(547, 40);
            usersHeaderTableLayoutPanel.TabIndex = 3;
            //
            // usersLabel
            //
            usersLabel.AutoSize = true;
            usersLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            usersLabel.ForeColor = Color.FromArgb(64, 64, 64);
            usersLabel.Location = new Point(3, 0);
            usersLabel.Name = "usersLabel";
            usersLabel.Size = new Size(114, 22);
            usersLabel.TabIndex = 0;
            usersLabel.Text = "Kullanıcılar";
            //
            // newUserButton
            //
            newUserButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            newUserButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newUserButton.Location = new Point(405, 3);
            newUserButton.Name = "newUserButton";
            newUserButton.Size = new Size(139, 32);
            newUserButton.TabIndex = 2;
            newUserButton.Text = "Yeni Kullanıcı";
            newUserButton.UseVisualStyleBackColor = true;
            // 
            // usersTableLayoutPanel
            // 
            usersTableLayoutPanel.BackColor = Color.FromArgb(235, 235, 235);
            usersTableLayoutPanel.ColumnCount = 1;
            usersTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            usersTableLayoutPanel.Controls.Add(usersDataGridView, 0, 0);
            usersTableLayoutPanel.Dock = DockStyle.Fill;
            usersTableLayoutPanel.Location = new Point(0, 40);
            usersTableLayoutPanel.Margin = new Padding(0, 0, 5, 0);
            usersTableLayoutPanel.Name = "usersTableLayoutPanel";
            usersTableLayoutPanel.RowCount = 1;
            usersTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            usersTableLayoutPanel.Size = new Size(542, 493);
            usersTableLayoutPanel.TabIndex = 5;
            //
            // usersDataGridView
            //
            usersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersDataGridView.Dock = DockStyle.Fill;
            usersDataGridView.Location = new Point(3, 3);
            usersDataGridView.Name = "usersDataGridView";
            usersDataGridView.Size = new Size(536, 487);
            usersDataGridView.TabIndex = 0;
            // 
            // nameColumn
            // 
            nameColumn.Name = "nameColumn";
            // 
            // valueColumn
            // 
            valueColumn.Name = "valueColumn";
            // 
            // SaveAlarmsButton
            // 
            SaveAlarmsButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SaveAlarmsButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveAlarmsButton.Location = new Point(452, 3);
            SaveAlarmsButton.Name = "SaveAlarmsButton";
            SaveAlarmsButton.Size = new Size(92, 32);
            SaveAlarmsButton.TabIndex = 3;
            SaveAlarmsButton.Text = "Kaydet";
            SaveAlarmsButton.UseVisualStyleBackColor = true;
            // 
            // MailPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(tableLayoutPanel1);
            Name = "MailPage";
            Size = new Size(1170, 677);
            SizeChanged += MailPage_SizeChanged;
            tableLayoutPanel1.ResumeLayout(false);
            PanelContent.ResumeLayout(false);
            StationSettingsBgTableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ApiTestBgTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)alarmsDataGridView).EndInit();
            usersHeaderTableLayoutPanel.ResumeLayout(false);
            usersHeaderTableLayoutPanel.PerformLayout();
            usersTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)usersDataGridView).EndInit();
            ResumeLayout(false);
        }

        private void MailPage_SizeChanged(object sender, EventArgs e)
        {
        }

        private void ButtonMailStatements_Click(object sender, EventArgs e)
        {
        }

        private void ButtonEditMailStatements_Click(object sender, EventArgs e)
        {
        }

        private void ButtonMailServerSettings_Click(object sender, EventArgs e)
        {
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Controls.IBKS.TitleBarControl titleBarControl1;
        private Panel PanelContent;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn valueColumn;
        private TableLayoutPanel StationSettingsBgTableLayoutPanel;
        private TableLayoutPanel ApiTestBgTableLayoutPanel;
        private TableLayoutPanel usersHeaderTableLayoutPanel;
        private Label usersLabel;
        private Button newUserButton;
        private TableLayoutPanel usersTableLayoutPanel;
        private DataGridView alarmsDataGridView;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private DataGridView usersDataGridView;
        private Button SaveAlarmsButton;
    }
}
